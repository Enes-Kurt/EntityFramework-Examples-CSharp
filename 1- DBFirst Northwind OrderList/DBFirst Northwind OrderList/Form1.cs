using Enes_Kurt_Odev___24._04._2023.Context;
using Enes_Kurt_Odev___24._04._2023.Models;
using Microsoft.EntityFrameworkCore;

namespace Enes_Kurt_Odev___24._04._2023
{
    public partial class Form1 : Form
    {
        NorthwindContext db = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            var employeeNames = db.Employees.Select(a => a.FirstName).ToList();
            lvEmployees.Items.AddRange(employeeNames.Select(en => new ListViewItem(en)).ToArray());
            var companyNames = db.Shippers.Select(a => a.CompanyName).ToList();
            lvShippers.Items.AddRange(companyNames.Select(cn => new ListViewItem(cn)).ToArray());
        }

        private void btnGetOrderList_Click(object sender, EventArgs e)
        {
            lvDetails.Items.Clear();
            db = new NorthwindContext();


            if (lvEmployees.SelectedItems.Count > 0 && lvShippers.SelectedItems.Count > 0)
            {
                string selectedEmployeeName = lvEmployees.SelectedItems[0].Text;
                string selectedShipperCompanyName = lvShippers.SelectedItems[0].Text;
                var employee = db.Employees.FirstOrDefault(e => e.FirstName == selectedEmployeeName);
                var shipper = db.Shippers.FirstOrDefault(e => e.CompanyName == selectedShipperCompanyName);
                var selectedOrders = db.Orders.Where(o => o.EmployeeId == employee.EmployeeId && o.ShipVia == shipper.ShipperId).ToList();
                foreach (var selectedOrder in selectedOrders)
                {
                    ListViewItem item = new ListViewItem(selectedOrder.OrderId.ToString());
                    item.SubItems.Add(selectedOrder.OrderDate.ToString());
                    item.SubItems.Add(selectedOrder.ShipCity);
                    lvDetails.Items.Add(item);
                }
            }
            else if (lvEmployees.SelectedItems.Count > 0)
            {
                string selectedEmployeeName = lvEmployees.SelectedItems[0].Text;
                var employee = db.Employees.FirstOrDefault(e => e.FirstName == selectedEmployeeName);
                var selectedOrders = db.Orders.Where(o => o.EmployeeId == employee.EmployeeId).ToList();
                foreach (var selectedOrder in selectedOrders)
                {
                    ListViewItem item = new ListViewItem(selectedOrder.OrderId.ToString());
                    item.SubItems.Add(selectedOrder.OrderDate.ToString());
                    item.SubItems.Add(selectedOrder.ShipCity);
                    lvDetails.Items.Add(item);
                }
            }
            else if (lvShippers.SelectedItems.Count > 0)
            {
                string selectedShipperCompanyName = lvShippers.SelectedItems[0].Text;
                var shipper = db.Shippers.FirstOrDefault(e => e.CompanyName == selectedShipperCompanyName);
                var selectedOrders = db.Orders.Where(o => o.ShipVia == shipper.ShipperId).ToList();
                foreach (var selectedOrder in selectedOrders)
                {
                    ListViewItem item = new ListViewItem(selectedOrder.OrderId.ToString());
                    item.SubItems.Add(selectedOrder.OrderDate.ToString());
                    item.SubItems.Add(selectedOrder.ShipCity);
                    lvDetails.Items.Add(item);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db = new NorthwindContext();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db = new NorthwindContext();
            string epmloyeeName = lvEmployees.SelectedItems[0].Text;
            string shipperName = lvShippers.SelectedItems[0].Text;
            int orderID = Convert.ToInt32(lvDetails.SelectedItems[0].Text);
            Form2 form2 = new Form2(orderID, epmloyeeName, shipperName);
            form2.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db = new NorthwindContext();
            var control = MessageBox.Show("Silmek istiyor musnuz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (control == DialogResult.Yes)
            {
                int selectedOrderId = Convert.ToInt32(lvDetails.SelectedItems[0].Text);
                var order = db.Orders.Find(selectedOrderId);
                db.Orders.Remove(order);
                db.SaveChanges();
            }
        }

        private void lvDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}