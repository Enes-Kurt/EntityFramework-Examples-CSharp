namespace Enes_Kurt_Odev___24._04._2023
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddOrUpdate = new Button();
            cbEmployees = new ComboBox();
            cbShippers = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            txtShipCity = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 135);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Ship City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 181);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Shipper";
            // 
            // btnAddOrUpdate
            // 
            btnAddOrUpdate.Location = new Point(141, 232);
            btnAddOrUpdate.Name = "btnAddOrUpdate";
            btnAddOrUpdate.Size = new Size(145, 32);
            btnAddOrUpdate.TabIndex = 4;
            btnAddOrUpdate.Text = "Add";
            btnAddOrUpdate.UseVisualStyleBackColor = true;
            btnAddOrUpdate.Click += btnAddOrUpdate_Click;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(122, 45);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(183, 23);
            cbEmployees.TabIndex = 6;
            // 
            // cbShippers
            // 
            cbShippers.FormattingEnabled = true;
            cbShippers.Location = new Point(122, 178);
            cbShippers.Name = "cbShippers";
            cbShippers.Size = new Size(183, 23);
            cbShippers.TabIndex = 8;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(122, 85);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(183, 23);
            dtpOrderDate.TabIndex = 9;
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(122, 132);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(183, 23);
            txtShipCity.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 287);
            Controls.Add(dtpOrderDate);
            Controls.Add(cbShippers);
            Controls.Add(cbEmployees);
            Controls.Add(txtShipCity);
            Controls.Add(btnAddOrUpdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddOrUpdate;
        private ComboBox cbEmployees;
        private ComboBox cbShippers;
        private DateTimePicker dtpOrderDate;
        private TextBox txtShipCity;
    }
}