using Enes_Kurt_Odev___24._04._2023.Context;
using Enes_Kurt_Odev___24._04._2023.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enes_Kurt_Odev___24._04._2023
{
    public partial class Form2 : Form
    {
        NorthwindContext db = new NorthwindContext();
        int orderID;
        string eName;
        string sName;
        public Form2()
        {
            InitializeComponent();

        }
        public Form2(int orderId, string employeeName, string shippersName)
        {
            InitializeComponent();
            orderID = orderId;
            eName = employeeName;
            sName = shippersName;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cbEmployees.DisplayMember = "FirstName";
            cbEmployees.ValueMember = "EmployeeId";
            cbEmployees.DataSource = db.Employees.ToList();
            cbShippers.DisplayMember = "CompanyName";
            cbShippers.ValueMember = "ShipperId";
            cbShippers.DataSource = db.Shippers.ToList();
            if (orderID > 0)
            {
                var order = db.Orders.Find(orderID);
                dtpOrderDate.Value = (DateTime)order.OrderDate;
                txtShipCity.Text = order.ShipCity;
                cbEmployees.Text = eName;
                cbShippers.Text = sName;
                btnAddOrUpdate.Text = "Update";
            }
        }


        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (orderID != null)
            {
                var order = db.Orders.Find(orderID);
                order.EmployeeId = (int)cbEmployees.SelectedValue;
                order.OrderDate = dtpOrderDate.Value;
                order.ShipCity = txtShipCity.Text;
                order.ShipVia = (int)cbShippers.SelectedValue;
                db.Orders.Update(order);
                db.SaveChanges();
            }
            else
            {
                Order order = new Order();
                order.EmployeeId = (int)cbEmployees.SelectedValue;
                order.OrderDate = dtpOrderDate.Value;
                order.ShipCity = txtShipCity.Text;
                order.ShipVia = (int)cbShippers.SelectedValue;
                db.Orders.Add(order);
                db.SaveChanges();
            }

        }
    }
}
