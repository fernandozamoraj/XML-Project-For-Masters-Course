using System.Windows.Forms;
using PicassosInventorySystem.Extensions;

namespace PicassosInventorySystem.Views
{
    public partial class BoxedItemDetailsControl : UserControl
    {
        public BoxedItemDetailsControl()
        {
            InitializeComponent();
        }

        public decimal BoxCost
        {
            get
            {
                decimal result;
                decimal.TryParse(txtBoxCost.Text, out result);

                return result;
            }
            set
            {
                txtBoxCost.Text = value.ToString();
            }

        }

        public int UnitsInBox
        {
            get
            {
                int result;

                int.TryParse(txtUnitsInBox.Text, out result);

                return result;
            }
            set
            {
                txtUnitsInBox.Text = value.ToString();
            }
        }

        private void txtUnitsInBox_TextChanged(object sender, System.EventArgs e)
        {
            txtUnitsInBox.RemoveNonNumericCharacters(false);
        }

        private void txtBoxCost_TextChanged(object sender, System.EventArgs e)
        {
            txtBoxCost.RemoveNonNumericCharacters(true);
            txtBoxCost.NormalizedToDecimalPoint(2);
        }
    }
}
