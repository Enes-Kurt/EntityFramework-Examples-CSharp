namespace Enes_Kurt_Odev___24._04._2023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetOrderList = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lvDetails = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lvEmployees = new ListView();
            lvShippers = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnGetOrderList
            // 
            btnGetOrderList.Location = new Point(36, 22);
            btnGetOrderList.Name = "btnGetOrderList";
            btnGetOrderList.Size = new Size(176, 31);
            btnGetOrderList.TabIndex = 0;
            btnGetOrderList.Text = "Get Order List";
            btnGetOrderList.UseVisualStyleBackColor = true;
            btnGetOrderList.Click += btnGetOrderList_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(256, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(428, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 31);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(608, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvDetails
            // 
            lvDetails.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvDetails.FullRowSelect = true;
            lvDetails.GridLines = true;
            lvDetails.Location = new Point(256, 79);
            lvDetails.Name = "lvDetails";
            lvDetails.Size = new Size(493, 359);
            lvDetails.TabIndex = 4;
            lvDetails.UseCompatibleStateImageBehavior = false;
            lvDetails.View = View.Details;
            lvDetails.SelectedIndexChanged += lvDetails_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Order ID";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order Date";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ship City";
            columnHeader3.Width = 200;
            // 
            // lvEmployees
            // 
            lvEmployees.Location = new Point(34, 78);
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(174, 205);
            lvEmployees.TabIndex = 5;
            lvEmployees.UseCompatibleStateImageBehavior = false;
            lvEmployees.View = View.List;
            // 
            // lvShippers
            // 
            lvShippers.Location = new Point(34, 318);
            lvShippers.Name = "lvShippers";
            lvShippers.Size = new Size(174, 120);
            lvShippers.TabIndex = 6;
            lvShippers.UseCompatibleStateImageBehavior = false;
            lvShippers.View = View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 300);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 7;
            label1.Text = "Shippers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 60);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 60);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvShippers);
            Controls.Add(lvEmployees);
            Controls.Add(lvDetails);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnGetOrderList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetOrderList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListView lvDetails;
        private ListView lvEmployees;
        private ListView lvShippers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}