using Autoservice.Forms;
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
            DataGridViewUpdate();
        }

        public void DataGridViewUpdate()
        {
            var carList = DefaultOperations.GetCars();
            //DataTable table = new DataTable("Cars");
            dataGridViewForCars.Rows.Clear();
            dataGridViewForCars.Columns.Clear();
            dataGridViewForCars.Columns.Add("IsTruck", "IsTruck");
            dataGridViewForCars.Columns.Add("Model", "Model");
            dataGridViewForCars.Columns.Add("CarType", "CarType");
            dataGridViewForCars.Columns.Add("Manufacturer", "Manufacturer");
            dataGridViewForCars.Columns.Add("CarAssembly", "CarAssembly");
            dataGridViewForCars.Columns.Add("CarNumber", "CarNumber");
            dataGridViewForCars.Columns.Add("Status", "Status");
            dataGridViewForCars.Columns[0].Width = 50;
            dataGridViewForCars.Columns[4].Width = 195;
            dataGridViewForCars.Columns[6].Width = 200;
            foreach (var car in carList)
            {
                dataGridViewForCars.Rows.Add( car.IsTruck ? "Truck" : "Car", car.Model, car.CarType, car.Manufacturer, 
                    car.CarAssembly, car.CarNumber, DefaultOperations.GetCarStatus(car.StatusId));
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
                StatusId = carStatusComboBox.SelectedIndex + 1
            };

            List<Car> searchedCarList = DefaultOperations.SearchCars(findCar);
            dataGridViewForCars.Rows.Clear();
            foreach (var car in searchedCarList)
            {
                dataGridViewForCars.Rows.Add(car.IsTruck ? "Truck" : "Car", car.Model, car.CarType, car.Manufacturer,
                    car.CarAssembly, car.CarNumber, DefaultOperations.GetCarStatus(car.StatusId));
            }

            isTruckComboBox.SelectedItem = -1;
            modelTextBox.Text = string.Empty;
            carTypeTextBox.Text = string.Empty;
            manufacturerTextBox.Text = string.Empty;
            carAssemblyTextBox.Text = string.Empty;
            carNumberTextBox.Text = string.Empty;
            carStatusComboBox.SelectedItem = -1;
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            Registry registryForm = new Registry(this);
            registryForm.Show();
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            Car deleteCar = new Car() {
                IsTruck = (string) dataGridViewForCars.SelectedRows[0].Cells[0].Value == "Truck",
                Model = (string) dataGridViewForCars.SelectedRows[0].Cells[1].Value,
                CarType = (string) dataGridViewForCars.SelectedRows[0].Cells[2].Value,
                Manufacturer = (string) dataGridViewForCars.SelectedRows[0].Cells[3].Value,
                CarAssembly = (string) dataGridViewForCars.SelectedRows[0].Cells[4].Value,
                CarNumber = (string) dataGridViewForCars.SelectedRows[0].Cells[5].Value,
            };

            DefaultOperations.DeleteCar(deleteCar);

            dataGridViewForCars.Rows.Clear();
            var carList = DefaultOperations.GetCars();
            foreach (var car in carList)
            {
                dataGridViewForCars.Rows.Add(car.IsTruck ? "Truck" : "Car", car.Model, car.CarType, car.Manufacturer,
                    car.CarAssembly, car.CarNumber, DefaultOperations.GetCarStatus(car.StatusId));
            }
        }
    }
}
