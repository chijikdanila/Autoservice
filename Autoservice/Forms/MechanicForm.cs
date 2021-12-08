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
    public partial class MechanicForm : Form
    {
        private User user;
        public delegate void ShowAncestor();
        private ShowAncestor showAncestor;
        public MechanicForm(User user, ShowAncestor _delegate)
        {
            this.user = user;
            showAncestor = _delegate;
            InitializeComponent();

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

            UpdateGridView(DefaultOperations.GetMechanicCars(user));
        }

        public void UpdateGridView(List<Car> carList)
        {
            dataGridViewForCars.Rows.Clear();

            foreach (var car in carList)
            {
                dataGridViewForCars.Rows.Add(car.IsTruck ? "Truck" : "Car", car.Model, car.CarType, car.Manufacturer,
                    car.CarAssembly, car.CarNumber, DefaultOperations.GetCarStatus(car.StatusId));
            }
        }

        private void MechanicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            showAncestor.Invoke();
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
            MechanicId = user.id
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
            Car car = ParseCarFromRow(row);
            if (car.StatusId == 3)
            {
                CarStatus carStatus = new CarStatus(this, ParseCarFromRow(row), user);
                carStatus.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Car can not change status.", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
