using DatabaseLayer.Entities;
using System;
using DatabaseLayer.Entities.Enums;
using DatabaseLayer;
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
    public partial class CarInfo : Form
    {
        private Menu menuForm;
        private Car selectedCar;
        private Status engineStatus;
        private Status chassisStatus;
        private Status carcassStatus;

        public CarInfo(Menu menuForm, Car selectedCar)
        {
            this.menuForm = menuForm;
            this.selectedCar = selectedCar;

            this.menuForm.Hide();

            InitializeComponent();

            carLabel.Text = $"to work on car {this.selectedCar}";
            engineRadioButton1.Checked = true;
            chassisRadioButton1.Checked = true;
            carcassRadioButton1.Checked = true;

            FillMechanicsComboBox();
        }

        private void FillMechanicsComboBox()
        {
            var mechanics = DefaultOperations.GetUsers().Where(user => user.User_Type == false);
            mechanicsComboBox.Items.AddRange(mechanics.ToArray());
        }

        private void CarInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.menuForm.Show();
        }

        private void EngineRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (engineRadioButton1.Checked)
            {
                engineStatus = Status.UnBroken;
            }
            else if (engineRadioButton2.Checked)
            {
                engineStatus = Status.Broken;
                 
            }
            else if (engineRadioButton3.Checked)
            {
                engineStatus = Status.CannotBeRepaired;
            }
        }

        private void ChassisRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (chassisRadioButton1.Checked)
            {
                chassisStatus = Status.UnBroken;
            }
            else if (chassisRadioButton2.Checked)
            {
                chassisStatus = Status.Broken;
            }
            else if (chassisRadioButton3.Checked)
            {
                chassisStatus = Status.CannotBeRepaired;
            }
        }

        private void CarcassRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (carcassRadioButton1.Checked)
            {
                carcassStatus = Status.Broken;
            }
            else if (carcassRadioButton2.Checked)
            {
                carcassStatus = Status.UnBroken;
            }
            else if(carcassRadioButton3.Checked)
            {
                carcassStatus = Status.CannotBeRepaired;
            }
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (mechanicsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You should choose mechanic.", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(mileageTextBox.Text, out int mileage))
            {
                MessageBox.Show("You should enter mileage.", "Warning", MessageBoxButtons.OK);
                return;
            }

            int carId;
            try
            {
                carId = DefaultOperations.GetCars().Where(car => car.Model == selectedCar.Model
                    && car.Manufacturer == selectedCar.Manufacturer
                    && car.CarNumber == selectedCar.CarNumber
                    && car.CarAssembly == selectedCar.CarAssembly).First().id;
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK);
                return;
            }

            Accounting accounting = new Accounting
            {
                CarId = carId,
                Milleage = mileage,
                CarcassStatus = carcassStatus,
                ChassisStatus = chassisStatus,
                EngineStatus = engineStatus,
            };

            DefaultOperations.AddAccounting(accounting);
            DefaultOperations.ChangeCarStatus(carId, (int)RepairStatus.FaultyBeingRepaired);

            MessageBox.Show("Successfully added !", "Success", MessageBoxButtons.OK);

            

            this.Close();
        }
    }
}
