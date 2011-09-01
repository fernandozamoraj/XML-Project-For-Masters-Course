using System.Windows.Forms;

namespace PicassosInventorySystem.Extensions
{
    //I got tired of toying around with the MaskedEditBox 
    //as a result I decided to just write my own function
    //for masking out the number
    public static class TextBoxExtensions
    {
        public static void RemoveNonNumericCharacters(this TextBox textBox, bool allowDecimals)
        {
            string newText = RemoveAnythingExceptDigitsAndDecimals(textBox.Text, allowDecimals);

            //To avoid recursion check values they may be ok already
            if (newText != textBox.Text)
            {
                textBox.Text = newText;
            }
        }

        public static void NormalizedToDecimalPoint(this TextBox textBox, int digitsAfterDecimalPoint)
        {
            int index = textBox.Text.IndexOf('.');
            string newTextValue = textBox.Text;

            if(index > -1)
            {
                int actualDigitsAfterDecimal = (textBox.Text.Length - index) - 1;

                if(actualDigitsAfterDecimal > digitsAfterDecimalPoint )
                {
                    newTextValue = textBox.Text.Substring(0, index + digitsAfterDecimalPoint + 1);
                }
            }

            if(newTextValue != textBox.Text)
            {
                textBox.Text = newTextValue;
            }
        }

        static string RemoveAnythingExceptDigitsAndDecimals(string text, bool allowDecimals)
        {
            char[] rawCharacters = text.ToCharArray();
            string newTextString = string.Empty;

            for (int i = 0; i < rawCharacters.Length; i++)
            {
                bool isNumber = char.IsNumber(rawCharacters[i]);
                bool isDecimalPoint = rawCharacters[i] == '.';
                bool decimalPointIsAllowed = (newTextString.IndexOf(".") < 0 && allowDecimals);

                if (isNumber || (isDecimalPoint && decimalPointIsAllowed))
                {
                    newTextString += rawCharacters[i];
                }
            }

            return newTextString;
        }
    }
}
