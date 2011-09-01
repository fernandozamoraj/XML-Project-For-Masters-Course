using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PicassosInventorySystem.Model;
using PicassosInventorySystem.Views;

namespace PicassosInventorySystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFile("C:\\Temp\\PicassoProducts.xml");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        //Creates a dummy file
        private void WriteFile(string filePath)
        {
            Model.Location tempLocation = new Location {Description = "Shop", Name = "Shop"};
            Model.Location warehouseLocation = new Location{Description = "Storage Room", Name = "Storage"};
            Vendor gracoVendor = new Vendor
                                     {
                                         Addresses = new List<Address>
                                         {
                                             new Address{City = "Temple", State = "TX", Street = "4001 North Point Blvd", Zip = "76502"}
                                         },
                                         Id = "Graco",
                                         Name = "Graco",
                                         PhoneNumber = "254 555-1234",
                                         PointOfContact = "Jimmy Walker"

                                     };

            ProductGraph productGraph = new ProductGraph();

            productGraph.Inventory = new Inventory();
            productGraph.Catalog = new Catalog();

            productGraph.Inventory.Locations.Add(tempLocation);
            productGraph.Inventory.Locations.Add(warehouseLocation);

            productGraph.Inventory.InventoryItems.Add(
                new InventoryItem{Id = "0000001", Location = tempLocation, ReOrderPoint = 10, ReOrderQuantity = 10, QtyOnHand = 21}
                );

            productGraph.Inventory.InventoryItems.Add(
    new InventoryItem { Id = "0000002", Location = warehouseLocation, ReOrderPoint = 10, ReOrderQuantity = 10, QtyOnHand = 21 }
    );
            productGraph.Catalog.CatalogItems.Add( new CatalogItem()
                                                      {
                                                  Description        = "Mat 32x40, Chinese Red, White Core", Supplier = gracoVendor, UnitCost = 10m, VendorAssignedProductId = "132343"
                                                      });
            productGraph.Catalog.CatalogItems.Add(new CatalogItem
            {
                Description = "Mat 32x40, Sky Blue, White Core",
                Supplier = gracoVendor,
                UnitCost = 10m,
                VendorAssignedProductId = "132343"
            });

            productGraph.Catalog.BoxedItems.Add(new BoxedItem
            {
                Description = "Glass Clear, 16in x 20in",
                Supplier = gracoVendor,
                UnitCost = 10m,
                VendorAssignedProductId = "000000224324",
                BoxCost = 40,
                UnitsInBox = 8

            });

            productGraph.Catalog.BoxedItems.Add(new BoxedItem
            {
                Description = "Glass Clear, 32in x 40in",
                Supplier = gracoVendor,
                VendorAssignedProductId = "00000003",
                BoxCost = 80,
                UnitsInBox = 4

            });

            productGraph.Catalog.BoxedItems.Add(new BoxedItem
            {
                Description = "Framing Nails 1/8in",
                Supplier = gracoVendor,
                VendorAssignedProductId = "00000003",
                BoxCost = 25,
                UnitsInBox = 12
            });

            productGraph.Catalog.VolumeItems.Add(new VolumeItem
            {
                Description = "Gold Decor Molding 4in Wide",
                Supplier = gracoVendor,
                UnitCost = 10m,
                VendorAssignedProductId = "00000005",
                MininumVolume = 4,
                UnitOfMeasure = "Ft"
            });


            productGraph.Catalog.VolumeItems.Add(new VolumeItem
            {
                Description = "Gold Decor Molding 2in Wide",
                Supplier = gracoVendor,
                UnitCost = 5m,
                VendorAssignedProductId = "00000007",
                MininumVolume = 4,
                UnitOfMeasure = "Ft"
            });


            productGraph.Suppliers = new List<Vendor>{gracoVendor};

            List<string> xml = productGraph.ProduceXml("", true);

            using(StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in xml)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
               ProductGraph.FromFile("C:\\Temp\\PicassoProducts.xml");
            }
            catch (Exception exception)
            {
                
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnCreateNewFile_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGraph productGraph = new ProductGraph();

                OpenProductsForm(productGraph, string.Empty);

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }
        }

        private void btnOpenExistingFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    ProductGraph productGraph = ProductGraph.FromFile(openFileDialog.FileName);

                    OpenProductsForm(productGraph, openFileDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void OpenProductsForm(ProductGraph productGraph, string fileName)
        {
            using(ProductsForm productsForm = new ProductsForm(productGraph))
            {
                if (DialogResult.OK == productsForm.ShowDialog(this))
                {
                    string newFileName = GetFileName(fileName);

                    if (!string.IsNullOrEmpty(newFileName))
                    {
                        productGraph.SaveToFile(newFileName);
                    }
                }
            }
        }

        private string GetFileName(string fileName)
        {
            string newFileName = string.Empty;

            if(!string.IsNullOrEmpty(fileName))
            {
                newFileName = fileName;
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "PicassoProductsNew";
                saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

                if(DialogResult.OK == saveFileDialog.ShowDialog(this))
                {
                    newFileName = saveFileDialog.FileName;
                }
            }

            return newFileName;
        }

        bool _mouseIsDown = false;
        Point _mouseLocation;

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseIsDown = true;
            _mouseLocation = new Point(e.X, e.Y);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseIsDown = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(_mouseIsDown)
            {
                if(e.Delta > 10)
                {
                    this.Location = new Point(this.Location.X + (_mouseLocation.X + e.X), this.Location.Y +(_mouseLocation.Y + e.Y));
                }
            }
        }
    }
}
