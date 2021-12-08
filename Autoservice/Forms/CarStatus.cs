using DatabaseLayer;
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
    public partial class CarStatus : Form
    {
        MechanicForm mechanicForm;
        Car selectedCar;
        User user;
        public CarStatus(MechanicForm mechanicForm, Car selectedCar, User user)
        {
            this.mechanicForm = mechanicForm;
            this.selectedCar = selectedCar;
            this.user = user;
            InitializeComponent();

            repairedRadioButton.Checked = true;
            carLabel.Text = $"Car: {this.selectedCar}";
            currentStatusLabel.Text = $"Status: Faulty being repaired";
        }

        private void StatusRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (repairedRadioButton.Checked)
            {
                selectedCar.StatusId = 2;
            }
            else if (decommissionedRadioButton.Checked)
            {
                selectedCar.StatusId = 5;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
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

            DefaultOperations.ChangeCarStatus(carId, selectedCar.StatusId);

            this.mechanicForm.UpdateGridView(DefaultOperations.GetMechanicCars(user));

            MessageBox.Show("Successfully added!", "Success", MessageBoxButtons.OK);

            this.Close();
            this.mechanicForm.Show();
        }
    }
}
