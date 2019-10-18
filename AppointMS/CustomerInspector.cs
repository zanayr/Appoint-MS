using System;
using System.Windows.Forms;

namespace c969_Fickenscher
{
    public partial class CustomerInspector : Form
    {
        private bool _isUpdate;
        private Customer _customer;
        private int _originalAddressID;
        
        //  New customer constructor.
        public CustomerInspector()
        {
            InitializeComponent();
            _isUpdate = false;
            _customer = new Customer(0); // Dummy customer.
        }

        //  Existing customer constructor.
        public CustomerInspector(int id)
        {
            InitializeComponent();
            _isUpdate = true;
            _customer = Customers.GetCustomerBy(c => c.ID == id);
        }
        
        private bool CheckInspectorFields()
        {
            if (CustomerNameField.Text.Length > 0 && Address1Field.Text.Length > 0 && CityField.Text.Length > 0 && PostalCodeField.Text.Length > 0 && CountryField.Text.Length > 0 && PhoneField.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        //  Prevent the entry of empty fields into the database
        private void ToggleOkButton()
        {
            if (CheckInspectorFields())
            {
                OkButton.Enabled = true;
            }
            else
            {
                OkButton.Enabled = false;
            }
        }

        private Country BuildCountry(DateTime timestamp)
        {
            Country country = new Country(Countries.GetNextID());
            country.Name = CountryField.Text;
            country.CreateDate = timestamp;
            country.CreateBy = Users.CurrentUser;
            country.UpdateTimestamp = timestamp;
            country.UpdateBy = Users.CurrentUser;
            return country;
        }

        private City BuildCity(DateTime timestamp)
        {
            City city = new City(Cities.GetNextID());
            city.Name = CityField.Text;
            city.CreateDate = timestamp;
            city.CreateBy = Users.CurrentUser;
            city.UpdateTimestamp = timestamp;
            city.UpdateBy = Users.CurrentUser;
            return city;
        }

        private Address BuildAddress(DateTime timestamp)
        {
            Address address = new Address(Addresses.GetNextID());
            address.Address1 = Address1Field.Text;
            address.Address2 = Address2Field.Text;
            address.PostalCode = PostalCodeField.Text;
            address.Phone = PhoneField.Text;
            address.CreateDate = timestamp;
            address.CreateBy = Users.CurrentUser;
            address.UpdateTimestamp = timestamp;
            address.UpdateBy = Users.CurrentUser;
            return address;
        }

        private void CustomerInspector_Load(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                CustomerIDField.Text = Convert.ToString(_customer.ID);
                CustomerNameField.Text = _customer.Name;
                ResponseLabel.Text = "Customer " + _customer.Name + "'s information.";
                ActiveBox.Checked = _customer.Active;
                DateCreatedField.Text = _customer.CreateDate.ToString("MM/dd/yyyy");
                CreatedByField.Text = _customer.CreateBy.Name;
                DateUpdatedField.Text = _customer.UpdateTimestamp.ToString("MM/dd/yyyy HH:mm:ss");
                UpdatedByField.Text = _customer.UpdateBy.Name;
                _originalAddressID = _customer.Address.ID;
                Address1Field.Text = _customer.Address.Address1;
                Address2Field.Text = _customer.Address.Address2;
                PostalCodeField.Text = _customer.Address.PostalCode;
                PhoneField.Text = _customer.Address.Phone;
                CityField.Text = _customer.Address.City.Name;
                CountryField.Text = _customer.Address.City.Country.Name;
            }
            else
            {
                ResponseLabel.Text = "Enter new user's infromation.";
                DateCreatedLabel.Visible = false;
                DateCreatedField.Visible = false;
                CreatedByLabel.Visible = false;
                CreatedByField.Visible = false;
                DateUpdatedLabel.Visible = false;
                DateUpdatedField.Visible = false;
                UpdatedByLabel.Visible = false;
                UpdatedByField.Visible = false;
            }
            ToggleOkButton();
        }
        
        private void EditableFields_TextChanged(object sender, EventArgs e)
        {
            ToggleOkButton();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime timestamp = DateTime.Now;
            if (Countries.SearchBy(c => c.Name == CountryField.Text))
            {
                Country country = Countries.GetCountryBy(c => c.Name == CountryField.Text);
                if (Cities.SearchBy(c => c.Name == CityField.Text && c.Country.ID == country.ID))
                {
                    City city = Cities.GetCityBy(c => c.Name == CityField.Text && c.Country.ID == country.ID); ;
                    if (Addresses.SearchBy(a => a.Address1 == Address1Field.Text && a.Address2 == Address2Field.Text && a.PostalCode == PostalCodeField.Text && a.Phone == PhoneField.Text && a.City.ID == city.ID))
                    {
                        _customer.Address = Addresses.GetAddressBy(a => a.Address1 == Address1Field.Text && a.Address2 == Address2Field.Text && a.PostalCode == PostalCodeField.Text && a.Phone == PhoneField.Text && a.City.ID == city.ID);
                    }
                    else
                    {
                        Address address = BuildAddress(timestamp);
                        address.City = city;
                        address.City.Country = country;

                        Addresses.Insert(address);

                        _customer.Address = address;
                    }
                    _customer.CityName = city.Name;
                    _customer.CountryName = country.Name;
                }
                else
                {
                    Address address = BuildAddress(timestamp);
                    address.City = BuildCity(timestamp);
                    address.City.Country = country;
                    
                    Cities.Insert(address.City);
                    Addresses.Insert(address);

                    _customer.Address = address;
                    _customer.CityName = address.City.Name;
                }
                _customer.CountryName = country.Name;
            }
            else
            {
                Address address = BuildAddress(timestamp);
                address.City = BuildCity(timestamp);
                address.City.Country = BuildCountry(timestamp);

                Countries.Insert(address.City.Country);
                Cities.Insert(address.City);
                Addresses.Insert(address);

                _customer.Address = address;
                _customer.CityName = address.City.Name;
                _customer.CountryName = address.City.Country.Name;
            }

            if (_isUpdate)
            {
                _customer.Name = CustomerNameField.Text;
                _customer.Active = ActiveBox.Checked;
                _customer.UpdateTimestamp = timestamp;
                _customer.UpdateBy = Users.CurrentUser;

                Customers.Update(_customer);
            }
            else
            {
                Customer newCustomer = new Customer(Countries.GetNextID());
                newCustomer.Name = CustomerNameField.Text;
                newCustomer.Address = _customer.Address;
                newCustomer.Active = ActiveBox.Checked;
                newCustomer.CreateDate = timestamp;
                newCustomer.CreateBy = Users.CurrentUser;
                newCustomer.UpdateTimestamp = timestamp;
                newCustomer.UpdateBy = Users.CurrentUser;

                Customers.Insert(newCustomer);

                newCustomer.CityName = _customer.Address.City.Name;
                newCustomer.CountryName = _customer.Address.City.Country.Name;
            }
            Close();
        }

        private void CustomerInspectorCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}