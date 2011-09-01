using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PicassosInventorySystem.Extensions;
using PicassosInventorySystem.Model;
using PicassosInventorySystem.Utility;

namespace PicassosInventorySystem.Views
{
    public partial class ProductsForm : Form
    {
        ProductGraph _productGraph;
        CatalogItem _currentCatalogItem;
        Vendor _currentVendor;
        InventoryItem _currentInventoryItem;
        Location _currentLocation;

        public ProductsForm(ProductGraph productGraph)
        {
            InitializeComponent();

            _productGraph = productGraph;
        }

        void LoadVendors()
        {
            lbxVendors.Items.Clear();
            cbxCatalogVendor.Items.Clear();
           
            foreach(Vendor vendor in _productGraph.Suppliers)
            {
                lbxVendors.Items.Add(vendor);
                cbxCatalogVendor.Items.Add(vendor);
            }

            lbxVendors.SelectedItem = _currentVendor;
            _currentVendor = null;
        }

        void LoadInventory()
        {
            lbxInventory.Items.Clear();
            cbxLocation.Items.Clear();

            lbxInventory.Items.AddRange(_productGraph.Inventory.InventoryItems.ToArray());
            cbxLocation.Items.AddRange(_productGraph.Inventory.Locations.ToArray());

            SetSelectedInventoryItem();
        }

        void SetSelectedInventoryItem()
        {
            if(_currentInventoryItem != null)
            {
                lbxInventory.SelectedItem = _currentInventoryItem;
            }

            if (lbxInventory.Items.Count > 0 && lbxInventory.SelectedIndex < 0)
            {
                lbxInventory.SelectedIndex = 0;
            }

            if (lbxInventory.SelectedIndex > -1)
            {
                InventoryItem inventoryItem = lbxInventory.SelectedItem as InventoryItem;

                SetSelectedLocation(inventoryItem == null ? null : inventoryItem.Location);

                cbxInventoryCatalogItem.SelectedItem = inventoryItem.CatalogItem;
                txtInventoryDescription.Text = inventoryItem.CatalogItem.ToString();
                txtInventoryId.Text = inventoryItem.ToString();

                txtInventoryQtyOnHand.Text = inventoryItem.QtyOnHand.ToString();
                txtInventoryROPoint.Text = inventoryItem.ReOrderPoint.ToString();
                txtInventoryROQty.Text = inventoryItem.ReOrderQuantity.ToString();
                txtInventoryId.Text = inventoryItem.Id;
                txtInventoryComments.Text = inventoryItem.Comments;
            }

            _currentInventoryItem = null;

            SetInventoryDescription();
        }

        void SetSelectedLocation(Location location)
        {
            if(location != null)
            {
                cbxLocation.SelectedItem = location;               
            }

            if(cbxLocation.SelectedIndex < 0 && cbxLocation.Items.Count > 0)
            {
                cbxLocation.SelectedIndex = 0;
            }

            if (cbxLocation.SelectedIndex > -1)
            {
                Location selectedLocation = cbxLocation.SelectedItem as Location;

                if (selectedLocation != null)
                {
                    txtLocationDescription.Text = selectedLocation.Description;
                }
            }
        }

        void SetSelectedVendor()
        {
            HandleVendorClear();

            if(lbxVendors.SelectedIndex < 0 && lbxVendors.Items.Count > 0)
            {
                lbxVendors.SelectedIndex = 0;
            }

            if(lbxVendors.SelectedIndex > -1)
            {
                Vendor selectedVendor = (Vendor)lbxVendors.SelectedItem;
                Address vendorAddress = selectedVendor.Addresses[0];
 
                txtVendorName.Text = selectedVendor.Name;
                txtVendorContactPerson.Text = selectedVendor.PointOfContact;
                txtVendorPhoneNo.Text = selectedVendor.PhoneNumber;
                txtVendorStreet.Text = vendorAddress.Street;
                txtVendorCity.Text = vendorAddress.City;
                txtVendorState.Text = vendorAddress.State;
                txtVendorZip.Text = vendorAddress.Zip;
                txtVendorId.Text = selectedVendor.Id;
                txtVendorComments.Text = selectedVendor.Comments;
            }
        }

        void HandleVendorClear()
        {
            txtVendorName.Text = string.Empty;
            txtVendorContactPerson.Text = string.Empty;
            txtVendorPhoneNo.Text = string.Empty;
            txtVendorStreet.Text = string.Empty;
            txtVendorCity.Text = string.Empty;
            txtVendorState.Text = string.Empty;
            txtVendorZip.Text = string.Empty;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadVendorTab()
        {
            LoadVendors();

            SetSelectedVendor();
        }

        void LoadCatalogTab()
        {
            lbxCatalogItems.Items.Clear();
            cbxInventoryCatalogItem.Items.Clear();

            List<CatalogItem> catalogItems = new List<CatalogItem>();

            catalogItems.AddRange(_productGraph.Catalog.CatalogItems);                

            catalogItems.AddRange(_productGraph.Catalog.BoxedItems.ToArray());

            catalogItems.AddRange(_productGraph.Catalog.VolumeItems.ToArray());               

            catalogItems.Sort();

            lbxCatalogItems.Items.AddRange(catalogItems.ToArray());
            cbxInventoryCatalogItem.Items.AddRange(catalogItems.ToArray());

            SetSelectedCatalogItem();

            SetCorrectCatalogTypeControl();
        }

        void SetSelectedCatalogItem()
        {
            HandleCatalogClear();

            if(_currentCatalogItem != null)
            {
                lbxCatalogItems.SelectedItem = _currentCatalogItem;
            }

            if(lbxCatalogItems.SelectedIndex < 0 && lbxCatalogItems.Items.Count > 0)
            {
                lbxCatalogItems.SelectedIndex = 0;
            }

            if (lbxCatalogItems.SelectedIndex > -1)
            {
                CatalogItem catalogItem = (CatalogItem)lbxCatalogItems.SelectedItem;

                txtCatalogId.Text = catalogItem.Id;
                txtCatalogItemDescription.Text = catalogItem.Description;
                txtCatalogUnitCost.Text = catalogItem.UnitCost.ToString();
                txtCatalogVendorProductId.Text = catalogItem.VendorAssignedProductId;
                txtCatalogComments.Text = catalogItem.Comments;

                cbxCatalogVendor.SelectedItem = catalogItem.Supplier;

                if (catalogItem is BoxedItem)
                {
                    BoxedItem boxedItem = catalogItem as BoxedItem;

                    rdoCatalogBox.Checked = true;
                    boxedItemDetailsControl1.UnitsInBox = boxedItem.UnitsInBox;
                    boxedItemDetailsControl1.BoxCost = boxedItem.BoxCost;
                }
                else if (catalogItem is VolumeItem)
                {
                    VolumeItem volumeItem = catalogItem as VolumeItem;

                    rdoCatalogVolume.Checked = true;

                    lblUnitCost.Visible = true;
                    txtCatalogUnitCost.Visible = true;
                    volumeItemDetailsControl1.Visible = true;
                    volumeItemDetailsControl1.BringToFront();
                    volumeItemDetailsControl1.UnitOfMeasure = volumeItem.UnitOfMeasure;
                    volumeItemDetailsControl1.MinimunVolume = volumeItem.MininumVolume;
                }
                else
                {
                    rdoCatalogSingle.Checked = true;
                    lblUnitCost.Visible = true;
                    txtCatalogUnitCost.Visible = true;
                }
            }
        }

        void HandleInventoryClear()
        {
            txtInventoryId.Text = string.Empty;
            txtInventoryDescription.Text = string.Empty;
            txtInventoryQtyOnHand.Text = "0";
            txtInventoryROPoint.Text = "0";
            txtInventoryROQty.Text = "0";
        }

        void HandleCatalogClear()
        {
            txtCatalogItemDescription.Text = string.Empty;
            txtCatalogUnitCost.Text = "00.00";
            txtCatalogVendorProductId.Text = string.Empty;

            cbxCatalogVendor.SelectedIndex = -1;

            rdoCatalogSingle.Checked = true;
            rdoCatalogVolume.Checked = false;
            rdoCatalogBox.Checked = false;
            volumeItemDetailsControl1.Visible = false;
            boxedItemDetailsControl1.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        bool ReallyIntendsToCancel()
        {
            DialogResult dialogResult = MessageBox.Show("You will lose any changes you have made. Do you really wish continue? Select yes if you would like to discard unsaved data.", "Warning",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            return dialogResult == DialogResult.Yes;
        }

        private void lbxVendors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedVendor();
        }

        private void HandleVendorSave()
        {
            if (VendorDataIsValid())
            {
                SaveVendor();
            }
        }

        private void HandleVendorAddNew()
        {
            txtVendorId.Text = string.Empty;
            HandleVendorSave();
        }

        private void HandleCatalogAddNew()
        {
            txtCatalogId.Text = string.Empty;
            HandleCatalogSave();
        }

        private void HandleInventoryAddNew()
        {
            txtInventoryId.Text = string.Empty;
            HandleInventorySave();
        }

        bool VendorDataIsValid()
        {
            bool isValid = true;

            SetError(txtVendorCity, "");
            SetError(txtVendorContactPerson, "");
            SetError(txtVendorName, "");
            SetError(txtVendorPhoneNo, "");
            SetError(txtVendorState, "");
            SetError(txtVendorStreet, "");
            SetError(txtVendorZip, "");
            SetError(txtVendorComments, "");

            if (string.IsNullOrEmpty( txtVendorCity.Text))
            {
                SetError(txtVendorCity, "Vendor is Required");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtVendorContactPerson.Text))
            {
                SetError(txtVendorContactPerson, "Value Required");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtVendorName.Text))
            {
                SetError(txtVendorName, "Vendor name is required");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtVendorPhoneNo.Text))
            {
                SetError(txtVendorPhoneNo, "Phone number is required");
                isValid = false;
            }
            if(string.IsNullOrEmpty(txtVendorState.Text))
            {
                SetError(txtVendorState, "State is required");
                isValid = false;
            }
            if(string.IsNullOrEmpty(txtVendorStreet.Text))
            {
                SetError(txtVendorStreet, "Street is required");
                isValid = false;
            }
            if(string.IsNullOrEmpty(txtVendorZip.Text))
            {
                SetError(txtVendorZip, "Zipcode is required");
                isValid = false;
            }
            if(txtVendorState.Text != null && txtVendorState.Text.Length != 2)
            {
                SetError(txtVendorState, "State must be exactly two characters in length");
                isValid = false;
            }
            if(!ZipIsValid())
            {
                SetError(txtVendorZip, "Zip code is in invalid format");
                isValid = false;
            }

            IsValidXmlString(ref isValid, txtVendorCity, txtVendorCity.Text);
            IsValidXmlString(ref isValid, txtVendorContactPerson, txtVendorContactPerson.Text);
            IsValidXmlString(ref isValid, txtVendorName, txtVendorName.Text);
            IsValidXmlString(ref isValid, txtVendorPhoneNo, txtVendorPhoneNo.Text);
            IsValidXmlString(ref isValid, txtVendorState, txtVendorState.Text);
            IsValidXmlString(ref isValid, txtVendorStreet, txtVendorStreet.Text);
            IsValidXmlString(ref isValid, txtVendorComments, txtVendorComments.Text);

            return isValid;
        }

        void IsValidXmlString(ref bool isValid, Control control, string value)
        {
            if (isValid && !value.IsValidPicassoXmlString())
            {
                SetError(control, string.Format("Invalid characters. String must be alphanumeric. Special symbols are limited to:{0} and spaces.", Constants.VALID_CHARS_FOR_XML_DATA));
                isValid = false;
            }
        }

        bool ZipIsValid()
        {
            bool isValid = true;
            char[] zipCharacters = txtVendorZip.Text.ToCharArray();
            if(txtVendorZip.Text.Length != 5 && txtVendorZip.Text.Length != 10)
            {
                isValid = false;
            }

            for(int i = 0; i < zipCharacters.Length; i++)
            {
                if(zipCharacters[i] == '-' && i == 5)
                {
                    continue;
                }

                if(!char.IsNumber( zipCharacters[i] ))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        void SaveVendor()
        {
            Vendor vendor = FindVendor(txtVendorId.Text);

            if(vendor == null)
            {
                vendor = CreateVendor();

                AddVendor(vendor);
            }

            _currentVendor = vendor;

            FillVendorFromForm(vendor);

            LoadVendors();
        }

        void SaveInventory()
        {
            SaveLocation();

            InventoryItem inventoryItem = FindInventoryItem(txtInventoryId.Text);

            if (inventoryItem == null)
            {
                inventoryItem = CreateInventoryItem();

                AddInventoryItem(inventoryItem);
            }

            _currentInventoryItem = inventoryItem;
            
            FillInventoryFromForm(inventoryItem);

            _currentInventoryItem.Location = _currentLocation;

            LoadInventory();
        }

        InventoryItem FindInventoryItem(string inventoryId)
        {
            InventoryItem itemFound = null;

            foreach (InventoryItem inventoryItem in lbxInventory.Items)
            {
                if(inventoryItem.Id == inventoryId)
                {
                    itemFound = inventoryItem;    
                }
            }

            return itemFound;
        }

        InventoryItem CreateInventoryItem()
        {
            return new InventoryItem();
        }

        void AddInventoryItem(InventoryItem inventoryItem)
        {
            lbxInventory.Items.Add(inventoryItem);
            _productGraph.Inventory.InventoryItems.Add(inventoryItem);
        }

        void FillInventoryFromForm(InventoryItem inventoryItem)
        {
            inventoryItem.CatalogItem = cbxInventoryCatalogItem.SelectedItem as CatalogItem;
            inventoryItem.Location = cbxLocation.SelectedItem as Location;
            inventoryItem.QtyOnHand = int.Parse(txtInventoryQtyOnHand.Text);
            inventoryItem.ReOrderPoint = int.Parse(txtInventoryROPoint.Text);
            inventoryItem.ReOrderQuantity = int.Parse(txtInventoryROQty.Text);
            inventoryItem.Comments = txtInventoryComments.Text;
        }

        void SaveLocation()
        {
            bool locationWasFound = false;
            _currentLocation = null;

            foreach (Location location in cbxLocation.Items)
            {
                if(location.Name == cbxLocation.Text)
                {
                    locationWasFound = true;
                    _currentLocation = location;
                    location.Description = txtLocationDescription.Text;
                    break;
                }
            }

            if(!locationWasFound)
            {
                _currentLocation = new Location();

                _currentLocation.Name = cbxLocation.Text;
                _currentLocation.Description = txtLocationDescription.Text;
                _productGraph.Inventory.Locations.Add(_currentLocation);
                _productGraph.Inventory.Locations.Sort();
            }
        }

        void FillVendorFromForm(Vendor vendor)
        {
            vendor.Name = txtVendorName.Text;
            vendor.PhoneNumber = txtVendorPhoneNo.Text;
            vendor.PointOfContact = txtVendorContactPerson.Text;
            vendor.Comments = txtVendorComments.Text;

            Address address = vendor.Addresses[0];

            address.Street = txtVendorStreet.Text;
            address.City = txtVendorCity.Text;
            address.State = txtVendorState.Text;
            address.Zip = txtVendorZip.Text;
        }

        Vendor CreateVendor()
        {
            Vendor newVendor = new Vendor();
            Address address = new Address();

            newVendor.Addresses.Add(address);

            return newVendor;
        }

        void AddVendor(Vendor vendor)
        {
            lbxVendors.Items.Add(vendor);
            cbxCatalogVendor.Items.Add(vendor);
            _productGraph.Suppliers.Add(vendor);
        }

        public void ThrowInvalidChangeExceptionIfChangeIsNotValid(CatalogItem catalogItem)
        {
            if (catalogItem != null)
            {
                if (!(catalogItem is VolumeItem) && rdoCatalogVolume.Checked)
                {
                    throw new ApplicationException(
                        "Cannot change this item to volume type.  Please delete the item and re-enter it.");
                }

                if (!(catalogItem is BoxedItem) && rdoCatalogBox.Checked)
                {
                    throw new ApplicationException(
                        "Cannot change this item to boxed type.  Please delete the item and re-enter it.");
                }

                if ((catalogItem is BoxedItem || catalogItem is VolumeItem) && rdoCatalogSingle.Checked)
                {
                    throw new ApplicationException(
                                            "Cannot change this item to single type.  Please delete the item and re-enter it.");
                }
            }
        }

        void SaveCatalogDetails()
        {
            CatalogItem catalogItem = FindCatalogItem(txtCatalogId.Text);
            
            if(catalogItem == null)
            {
                catalogItem = CreateNewCatalogItem();
                AddItemToCatalog(catalogItem);
            }
            else
            {
                ThrowInvalidChangeExceptionIfChangeIsNotValid(catalogItem);
            }

            catalogItem.Description = txtCatalogItemDescription.Text;
            catalogItem.Supplier = cbxCatalogVendor.SelectedItem as Vendor;
            catalogItem.VendorAssignedProductId = txtCatalogVendorProductId.Text;
            catalogItem.Comments = txtCatalogComments.Text;

            SetSpecificItemCatalogAttributes(catalogItem);

            _currentCatalogItem = catalogItem;
        }

        void SetSpecificItemCatalogAttributes(CatalogItem catalogItem)
        {
            decimal unitCost;
            decimal.TryParse(txtCatalogUnitCost.Text, out unitCost);

            if(catalogItem is BoxedItem)
            {
                BoxedItem boxedItem = catalogItem as BoxedItem;

                boxedItem.BoxCost = boxedItemDetailsControl1.BoxCost;
                boxedItem.UnitsInBox = boxedItemDetailsControl1.UnitsInBox;
            }
            else if(catalogItem is VolumeItem)
            {
                VolumeItem volumeItem = catalogItem as VolumeItem;

                volumeItem.MininumVolume = volumeItemDetailsControl1.MinimunVolume;
                volumeItem.UnitOfMeasure = volumeItemDetailsControl1.UnitOfMeasure;
                volumeItem.UnitCost = unitCost;
            }
            else
            {
                catalogItem.UnitCost = unitCost;
            }
        }

        void AddItemToCatalog(CatalogItem catalogItem)
        {
            lbxCatalogItems.Items.Add(catalogItem);
            _productGraph.Catalog.AddItem(catalogItem);
        }

        CatalogItem CreateNewCatalogItem()
        {
            CatalogItem catalogItem = new CatalogItem();

            if (rdoCatalogBox.Checked)
            {
                catalogItem = new BoxedItem();
            }
            else if (rdoCatalogVolume.Checked)
            {
                catalogItem = new VolumeItem();
            }
            else
            {
                catalogItem = new CatalogItem();
            }

            return catalogItem;
        }

        CatalogItem FindCatalogItem(string id)
        {
            CatalogItem returnItem = null;

            foreach (CatalogItem catalogItem in lbxCatalogItems.Items)
            {
                if(catalogItem.Id == id)
                {
                    returnItem = catalogItem;
                    break;
                }
            }
            
            return returnItem;
        }

        Vendor FindVendor(string vendorId)
        {
            foreach(Vendor vendor in lbxVendors.Items)
            {
                if(vendor.Id == vendorId)
                {
                    return vendor;
                }
            }

            return null;
        }

        private void rdoCatalogBox_CheckedChanged(object sender, EventArgs e)
        {
            SetCorrectCatalogTypeControl();
        }

        void SetCorrectCatalogTypeControl()
        {
            boxedItemDetailsControl1.Visible = false;
            volumeItemDetailsControl1.Visible = false;
            
            if(rdoCatalogBox.Checked)
            {
                boxedItemDetailsControl1.Visible = true;
            }
            else if(rdoCatalogVolume.Checked)
            {
                volumeItemDetailsControl1.Visible = true;
            }
            else
            {
                lblUnitCost.Visible = true;
                txtCatalogUnitCost.Visible = true;
            }
        }

        private void lbxCatalogItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedCatalogItem();
        }
        
        private void HandleCatalogSave()
        {
            try
            {
                if (CatalogDataIsValid())
                {
                    SaveCatalogDetails();
                    LoadCatalogTab();
                    _currentCatalogItem = null;
                }
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
        }

        bool CatalogDataIsValid()
        {
            bool isValid = true;
            SetError(txtCatalogItemDescription, "");
            SetError(txtCatalogUnitCost, "");
            SetError(cbxCatalogVendor, "");
            SetError(txtCatalogVendorProductId, "");
            SetError(txtCatalogComments, "");

            if(GetSelectedCatalogVendor() == null)
            {
                SetError(cbxCatalogVendor, "Vendor is Required");
                isValid = false;
            }
            if(string.IsNullOrEmpty( txtCatalogItemDescription.Text))
            {
                SetError(txtCatalogItemDescription, "Description Required");
                isValid = false;
            }
            if(GetCatalogUnitCost() < 0.01M)
            {
                SetError(txtCatalogUnitCost, "Unit cost must be greater than 0");
                isValid = false;
            }
            if(string.IsNullOrEmpty(txtCatalogVendorProductId.Text))
            {
                SetError(txtCatalogVendorProductId, "Vendor product ID is required");
                isValid = false; 
            }
            if(isValid && string.IsNullOrEmpty(txtCatalogId.Text) &&
                _productGraph.Catalog.Contains(cbxCatalogVendor.SelectedItem as Vendor, txtCatalogVendorProductId.Text))
            {
                SetError(txtCatalogVendorProductId, "Product Id/Vendor combination already exists for a different catalog item");
                isValid = false;
            }
            if(isValid && !string.IsNullOrEmpty(txtCatalogId.Text) && !_productGraph.Catalog.IsValidProductId(cbxCatalogVendor.SelectedItem as Vendor, txtCatalogId.Text, txtCatalogVendorProductId.Text))
            {
                string error = "Product Id/Vendor combination already exists for a different catalog item";
                SetError(txtCatalogVendorProductId, error);
                SetError(cbxCatalogVendor, error);
                isValid = false;
            }

            IsValidXmlString(ref isValid, txtCatalogItemDescription, txtCatalogItemDescription.Text);
            IsValidXmlString(ref isValid, txtCatalogComments, txtCatalogComments.Text);
            return isValid;
        }

        Vendor GetSelectedCatalogVendor()
        {
            return cbxCatalogVendor.SelectedItem as Vendor;
        }

        void SetError(Control control, string errorMessage)
        {
            errorProvider1.SetError(control, errorMessage);
        }

        decimal GetCatalogUnitCost()
        {
            decimal unitCost;

            decimal.TryParse(txtCatalogUnitCost.Text, out unitCost);

            return unitCost;
        }

        private void HandleVendorDelete()
        {
            if (lbxVendors.SelectedIndex > -1)
            {
                if (
                    WarningMessageAccepted(
                        "If you delete this vendor all inventory and catalog items will be deleted as well.  Would you like to delete this vendor and all associated data?"))
                {
                    _productGraph.RemoveVendor(lbxVendors.SelectedItem as Vendor);
                    LoadAllData();
                }
            }
         }

        void LoadAllData()
        {
            LoadVendorTab();
            LoadCatalogTab();
            LoadInventory();
        }

        private bool WarningMessageAccepted(string message)
        {
            return DialogResult.Yes == MessageBox.Show(message, "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }

        private void HandleCatalogDelete()
        {
            try
            {
                if (lbxCatalogItems.SelectedIndex > -1)
                {
                    if (
                        WarningMessageAccepted(
                            "This will delete the catalog item and all inventory items that use this catalog item.  Would you like proceed anyway?"))
                    {
                        _productGraph.RemoveCatalogItem(lbxCatalogItems.SelectedItem as CatalogItem);
                        LoadAllData();
                    }
                }
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
        }

        private void HandleInventoryDelete()
        {
            try
            {
                if (lbxInventory.SelectedIndex > -1)
                {
                    if (
                        WarningMessageAccepted(
                            "You are about to delete this inventory item. Would you like to continue?"))
                    {
                        _productGraph.RemoveInventoryItem(lbxInventory.SelectedItem as InventoryItem);
                        LoadAllData();
                    }
                }
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
        }

        void HandleException(Exception exception)
        {
            MessageBox.Show(exception.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtCatalogUnitCost_TextChanged(object sender, EventArgs e)
        {
            txtCatalogUnitCost.RemoveNonNumericCharacters(true);
            txtCatalogUnitCost.NormalizedToDecimalPoint(2);
        }

        private void HandleInventorySave()
        {
            if (InventoryDataIsValid())
            {
                SaveInventory();
            }
        }

        bool InventoryDataIsValid()
        {
            bool isValid = true;

            SetError(cbxLocation, "");
            SetError(txtLocationDescription, "");
            SetError(cbxInventoryCatalogItem, "");
            SetError(txtInventoryComments, "");

            if(string.IsNullOrEmpty( cbxLocation.Text ))
            {
                SetError(cbxLocation, "Location is required");
                isValid = false;
            }

            if(string.IsNullOrEmpty(txtLocationDescription.Text))
            {
                SetError(txtLocationDescription, "Location description is required");
                isValid = false;
            }

            if(cbxInventoryCatalogItem.SelectedIndex < 0)
            {
                SetError(cbxInventoryCatalogItem, "Catalog Item is required");
                isValid = false;
            }

            if(isValid && string.IsNullOrEmpty(txtInventoryId.Text) && 
                _productGraph.Inventory.Contains(cbxLocation.SelectedItem as Location, cbxInventoryCatalogItem.SelectedItem as CatalogItem))
            {
                SetError(cbxInventoryCatalogItem, "This inventory item already exists");
                isValid = false;
            }

            IsValidXmlString(ref isValid, cbxLocation, cbxLocation.Text);
            IsValidXmlString(ref isValid, txtLocationDescription, txtLocationDescription.Text);
            IsValidXmlString(ref isValid, txtInventoryComments, txtInventoryComments.Text);
            return isValid;
        }

        private void txtInventoryQtyOnHand_TextChanged(object sender, EventArgs e)
        {
            txtInventoryQtyOnHand.RemoveNonNumericCharacters(false);
        }

        private void txtInventoryROPoint_TextChanged(object sender, EventArgs e)
        {
            txtInventoryROPoint.RemoveNonNumericCharacters(false);
        }

        private void txtInventoryROQty_TextChanged(object sender, EventArgs e)
        {
            txtInventoryROQty.RemoveNonNumericCharacters(false);
        }

        private void lbxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedInventoryItem();
        }

        private void cbxInventoryCatalogItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInventoryDescription();
        }

        void SetInventoryDescription()
        {
            CatalogItem catalogItem = cbxInventoryCatalogItem.SelectedItem as CatalogItem;

            if(catalogItem != null)
            {
                txtInventoryDescription.Text = string.Format("{0} from {1}", catalogItem.Description, catalogItem.Supplier.Name);
            }
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedLocation(cbxLocation.SelectedIndex > -1 ? cbxLocation.SelectedItem as Location : null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteAction(tabSystem.SelectedIndex,
                    HandleVendorDelete,
                    HandleCatalogDelete,
                    HandleInventoryDelete);

            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteAction(tabSystem.SelectedIndex, 
                    HandleVendorClear, 
                    HandleCatalogClear, 
                    HandleInventoryClear);
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
         }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteAction(tabSystem.SelectedIndex, 
                    HandleVendorSave, 
                    HandleCatalogSave, 
                    HandleInventorySave);
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
        }

        private void ExecuteAction(int index, params Action[] actions)
        {
            actions[index].Invoke();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ExecuteAction(tabSystem.SelectedIndex,
                HandleVendorAddNew,
                HandleCatalogAddNew,
                HandleInventoryAddNew);
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                if(ReallyIntendsToCancel())
                {
                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
