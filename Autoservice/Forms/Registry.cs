using DatabaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoservice.Forms
{
    public partial class Registry : Form
    {
        private Car car;
        private User user;

        //Для закрытия формы вне формы
        public delegate void ShowAncestor();
        private ShowAncestor showAncestor;

        #region Data lists
        private string[] _transportModelList = new string[]
        {
            "Audi",
            "BMW",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Daewoo",
            "Dodge",
            "Ford",
            "Geely",
            "Honda",
            "Hummer",
            "Jeep",
            "Hyundai",
            "Kia",
            "Lada",
            "Lexus",
            "Mazda",
            "Mercedes-Benz",
            "Mitsubishi",
            "Nissan",
            "Opel",
            "Peugeot",
            "Renault",
            "Skoda",
            "Subaru",
            "Suzuki",
            "Toyota",
            "Volkswagen",
            "Volvo"
        };

        private string[] _carBodyList = new string[] 
        {
            "Sedan",
            "Hatchback",
            "Station wagon",
            "Cabriolet",
            "Pickup",
            "Coupe",
            "Minivan"
        };

        private string[] _truckBodyList = new string[] 
        {
            "Euro truck",
            "Jumbo",
            "Auto coupler",
            "Refrigerator",
            "Auto transporter",
            "Tank car"
        };
        private enum _status
        {
            ServiceableСommissioned = 1,
            ServiceableNotСommissioned,
            DefectiveRepaired,
            DefectiveNotRepaired,
            Decommissioned
        }
        #endregion

        #region Data setters
        private string SetManufacturer()
        {
            if (new string[] {
                "Audi",
                "BMW",
                "Volkswagen",
                "Mercedes-Benz",
                "Opel",
            }.Contains<string>(car.Model)) return "Germany";

            if (new string[] {
                "Peugeot",
                "Renault",
                "Skoda",
                "Volvo"
            }.Contains<string>(car.Model)) return "Europe";

            if (new string[] {
                "Subaru",
                "Suzuki",
                "Toyota",
                "Lexus",
                "Mazda",
                "Mitsubishi",
                "Nissan",
                "Honda",
            }.Contains<string>(car.Model)) return "Japan";

            if (new string[] {
                "Hyundai",
                "Daewoo",
                "Kia",
            }.Contains<string>(car.Model)) return "Korea";

            if (new string[] {
                "Geely",
            }.Contains<string>(car.Model)) return "China";

            if (new string[] {
                "Cadillac",
                "Chevrolet",
                "Chrysler",
                "Dodge",
                "Ford",
                "Hummer",
                "Jeep",
            }.Contains<string>(car.Model)) return "USA";

            if (new string[] {
                "Lada (ВАЗ)"
            }.Contains<string>(car.Model)) return "Russia";

            return null;
        }

        private void IsFullfilled()
        {
            if (car.isFullyDescribed())
            {
                initializeCarButton.Enabled = true;
            }
        }

        #endregion
        public Registry(User user, ShowAncestor _delegate)
        {
            car = new Car();
            this.user = user;
            showAncestor = _delegate;
            car.StatusId = (int)_status.DefectiveNotRepaired;
            InitializeComponent();
            transportModelComboBox.Items.AddRange(_transportModelList);
            transportModelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            transportBodyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region RadioButtons events
        private void truckRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            car.IsTruck = true;
            transportBodyComboBox.Items.Clear();
            transportBodyComboBox.Items.AddRange(_truckBodyList);
            IsFullfilled();
        }

        private void carRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            car.IsTruck = false;
            transportBodyComboBox.Items.Clear();
            transportBodyComboBox.Items.AddRange(_carBodyList);
            IsFullfilled();
        }
        #endregion

        #region ComboBoxes events
        private void transportModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transportModelComboBox.SelectedIndex != -1)
            {
                car.Model = transportModelComboBox.SelectedItem.ToString();
                manufacturerTextBox.Text = SetManufacturer();
                manufacturerTextBox.Enabled = false;
                transportModelTextBox.Text = "";
            }
        }

        private void transportBodyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            car.CarType = transportBodyComboBox.SelectedItem.ToString();
            IsFullfilled();
        }

        private void transportModelComboBox_DropDownClosed(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => { transportModelComboBox.Select(0, 0); }));
        }

        private void transportBodyComboBox_DropDownClosed(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => { transportBodyComboBox.Select(0, 0); }));
        }
        #endregion

        #region TextBoxes events
        private void transportModelTextBox_TextChanged(object sender, EventArgs e)
        {
            car.Model = transportModelTextBox.Text.ToString();
            transportModelComboBox.SelectedIndex = -1;
            manufacturerTextBox.Text = "";
            manufacturerTextBox.Enabled = true;
        }

        private void manufacturerTextBox_TextChanged(object sender, EventArgs e)
        {
            car.Manufacturer = manufacturerTextBox.Text.ToString();
            IsFullfilled();
        }

        private void carAssemblyTextBox_TextChanged(object sender, EventArgs e)
        {
            car.CarAssembly = carAssemblyTextBox.Text.ToString();
            IsFullfilled();
        }

        private void transportNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            car.CarNumber = transportNumberTextBox.Text.ToString();
            IsFullfilled();
        }
        #endregion

        #region Form events
        private void Registry_FormClosed(object sender, FormClosedEventArgs e)
        {
            showAncestor.Invoke();
        }
        #endregion
    }
}
