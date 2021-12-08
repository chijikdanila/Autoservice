using Autoservice.Forms;
using DatabaseLayer;
using DatabaseLayer.Entities;
using DatabaseLayer.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoservice
{
    public partial class Menu : Form
    {
        private User user;
        //Для закрытия формы вне формы
        public delegate void ShowAncestor();
        private ShowAncestor showAncestor;

        public Menu(User user, ShowAncestor _delegate)
        {
            this.user = user;
            showAncestor = _delegate;
            InitializeComponent();
            isTruckComboBox.SelectedIndex = 0;

            dataGridViewForCars.Rows.Clear();
            dataGridViewForCars.Columns.Clear();
            dataGridViewForCars.Columns.Add("IsTruck", "IsTruck");
            dataGridViewForCars.Columns.Add("Model", "Model");
            dataGridViewForCars.Columns.Add("CarType", "CarType");
            dataGridViewForCars.Columns.Add("Manufacturer", "Manufacturer");
            dataGridViewForCars.Columns.Add("CarAssembly", "CarAssembly");
            dataGridViewForCars.Columns.Add("CarNumber", "CarNumber");
            dataGridViewForCars.Columns.Add("Status", "Status");
            dataGridViewForCars.Columns.Add("Mechanic", "Mechanic");
            dataGridViewForCars.Columns[0].Width = 50;
            dataGridViewForCars.Columns[6].Width = 200;
            dataGridViewForCars.Columns[7].Width = 95;

            UpdateGridView(DefaultOperations.GetCars());
        }

        public void UpdateGridView(List<Car> carList)
        {
            dataGridViewForCars.Rows.Clear();
            
            foreach (var car in carList)
            {
                dataGridViewForCars.Rows.Add( car.IsTruck ? "Truck" : "Car", car.Model, car.CarType, car.Manufacturer, 
                    car.CarAssembly, car.CarNumber, DefaultOperations.GetCarStatus(car.StatusId), car.MechanicId);
            }
        }

        #region Form events
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            showAncestor.Invoke();
        }
        #endregion

        private void searchCarButton_Click(object sender, EventArgs e)
        {
            Car findCar = new Car() {
                IsTruck = isTruckComboBox.Text == "Truck" ? true : false,
                Model = modelTextBox.Text,
                CarType = carTypeTextBox.Text,
                Manufacturer = manufacturerTextBox.Text,
                CarAssembly = carAssemblyTextBox.Text,
                CarNumber = carNumberTextBox.Text,
                StatusId = carStatusComboBox.SelectedIndex + 1,
                MechanicId = mechanicTextBox.Text != string.Empty ? Convert.ToInt32(mechanicTextBox.Text) : 0
            };

            UpdateGridView(DefaultOperations.SearchCars(findCar));

            isTruckComboBox.SelectedItem = -1;
            modelTextBox.Text = string.Empty;
            carTypeTextBox.Text = string.Empty;
            manufacturerTextBox.Text = string.Empty;
            carAssemblyTextBox.Text = string.Empty;
            carNumberTextBox.Text = string.Empty;
            carStatusComboBox.SelectedItem = -1;
            mechanicTextBox.Text = string.Empty;
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            Registry registryForm = new Registry(this);
            registryForm.Show();
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;

            try
            {
                row = dataGridViewForCars.SelectedRows[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please, choose car to delete.", "Warning", MessageBoxButtons.OK);
                return;
            }

            Car deleteCar = ParseCarFromRow(row);

            DefaultOperations.DeleteCar(deleteCar);

            UpdateGridView(DefaultOperations.GetCars());
        }

        private Car ParseCarFromRow(DataGridViewRow row) => new Car()
        {
            IsTruck = (string)row.Cells[0].Value == "Truck",
            Model = (string)row.Cells[1].Value,
            CarType = (string)row.Cells[2].Value,
            Manufacturer = (string)row.Cells[3].Value,
            CarAssembly = (string)row.Cells[4].Value,
            CarNumber = (string)row.Cells[5].Value,
            StatusId = DefaultOperations.GetStatusId((string)row.Cells[6].Value),
            MechanicId = (int)row.Cells[7].Value
        };

        private void dataGridViewForCars_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow row;

            try
            {
                row = dataGridViewForCars.SelectedRows[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select car to see more information.", "Warning", MessageBoxButtons.OK);
                return;
            }

            CarInfo carInfoForm = new CarInfo(this, ParseCarFromRow(row));
            carInfoForm.Show();
        }

        private void putButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;

            try
            {
                row = dataGridViewForCars.SelectedRows[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please, choose car to delete.", "Warning", MessageBoxButtons.OK);
                return;
            }

            Car selectedCar = ParseCarFromRow(row);

            try
            {
                int carId = DefaultOperations.GetCars().Where(car => car.Model == selectedCar.Model
                    && car.Manufacturer == selectedCar.Manufacturer
                    && car.CarNumber == selectedCar.CarNumber
                    && car.CarAssembly == selectedCar.CarAssembly).First().id;

                if (selectedCar.StatusId == (int)RepairStatus.ServiceableNotExploit)
                {
                    DefaultOperations.ChangeCarStatus(carId, (int)RepairStatus.ServiceableOperated);
                }
                else
                {
                    MessageBox.Show("Can not put into operation. Car is broken or being repaired.", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK);
                return;
            }


            MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK);

            UpdateGridView(DefaultOperations.GetCars());
        }
    }
}