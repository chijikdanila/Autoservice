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
            DataGridViewUpdate();
        }

        private void DataGridViewUpdate()
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
            dataGridViewForCars.Columns[6].Width = 150;
            foreach (var car in carList)
            {
                dataGridViewForCars.Rows.Add(car.IsTruck, car.Model, car.CarType, car.Manufacturer, 
                    car.CarAssembly, car.CarNumber, DefaultOperations.GetCarStatus(car.StatusId));
            }
        }

        #region Form events
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            showAncestor.Invoke();
        }
        #endregion
    }
}
