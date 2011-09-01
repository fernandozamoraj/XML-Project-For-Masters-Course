using System;
using System.Windows.Forms;
using PicassosInventorySystem.Extensions;

namespace PicassosInventorySystem.Views
{
    public partial class VolumeItemDetailsControl : UserControl
    {
        public VolumeItemDetailsControl()
        {
            InitializeComponent();
        }

        private void VolumeItemDetailsControl_Load(object sender, EventArgs e)
        {
            LoadDefaultUnitsOfMeasure();
        }

        void LoadDefaultUnitsOfMeasure()
        {
            cbxUnitOfMeasure.Items.Clear();
            cbxUnitOfMeasure.Items.Add("Foot");
            cbxUnitOfMeasure.Items.Add("Inch");
            cbxUnitOfMeasure.Items.Add("Meter");
            cbxUnitOfMeasure.Items.Add("Sq Foot");
            cbxUnitOfMeasure.Items.Add("Sq Yard");
            cbxUnitOfMeasure.Items.Add("Dozen");
            cbxUnitOfMeasure.Items.Add("Gallon");
            cbxUnitOfMeasure.Items.Add("Pint");
            cbxUnitOfMeasure.Items.Add("Quart");
        }

        public decimal MinimunVolume
        {
            get
            {
                decimal result;
                decimal.TryParse(txtMinimum.Text, out result);

                return result;
            }
            set
            {
                txtMinimum.Text = value.ToString();
            }

        }

        public string UnitOfMeasure
        {
            get
            {
                return cbxUnitOfMeasure.Text;
            }
            set
            {
                cbxUnitOfMeasure.Text = value;
            }
        }

        private void txtMinimum_TextChanged(object sender, EventArgs e)
        {
            txtMinimum.RemoveNonNumericCharacters(false);
        }
    }
}
