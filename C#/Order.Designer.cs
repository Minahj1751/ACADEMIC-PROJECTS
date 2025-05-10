
namespace Farm_Management_System
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.order_form = new System.Windows.Forms.Label();
            this.btn_Exit_OrderFrom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.milkp = new System.Windows.Forms.Label();
            this.eggp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EggPrice = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.txbx_phone = new System.Windows.Forms.TextBox();
            this.txbx_address = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_Egg = new System.Windows.Forms.TextBox();
            this.txbx_Milk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.order_date = new System.Windows.Forms.DateTimePicker();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.order_form);
            this.panel1.Controls.Add(this.btn_Exit_OrderFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 44);
            this.panel1.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Silver;
            this.btn_home.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_home.Location = new System.Drawing.Point(43, 5);
            this.btn_home.Margin = new System.Windows.Forms.Padding(5);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(91, 34);
            this.btn_home.TabIndex = 18;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // order_form
            // 
            this.order_form.AutoSize = true;
            this.order_form.BackColor = System.Drawing.Color.Transparent;
            this.order_form.Font = new System.Drawing.Font("Century", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_form.Location = new System.Drawing.Point(379, 7);
            this.order_form.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.order_form.Name = "order_form";
            this.order_form.Size = new System.Drawing.Size(150, 29);
            this.order_form.TabIndex = 1;
            this.order_form.Text = "Order Form";
            // 
            // btn_Exit_OrderFrom
            // 
            this.btn_Exit_OrderFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit_OrderFrom.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit_OrderFrom.Location = new System.Drawing.Point(796, 0);
            this.btn_Exit_OrderFrom.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Exit_OrderFrom.Name = "btn_Exit_OrderFrom";
            this.btn_Exit_OrderFrom.Size = new System.Drawing.Size(40, 36);
            this.btn_Exit_OrderFrom.TabIndex = 3;
            this.btn_Exit_OrderFrom.Text = "X";
            this.btn_Exit_OrderFrom.UseVisualStyleBackColor = true;
            this.btn_Exit_OrderFrom.Click += new System.EventHandler(this.btn_Exit_OrderFrom_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.milkp);
            this.panel2.Controls.Add(this.eggp);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.EggPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 547);
            this.panel2.TabIndex = 1;
            // 
            // milkp
            // 
            this.milkp.AutoSize = true;
            this.milkp.BackColor = System.Drawing.Color.Transparent;
            this.milkp.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.milkp.Location = new System.Drawing.Point(114, 155);
            this.milkp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.milkp.Name = "milkp";
            this.milkp.Size = new System.Drawing.Size(0, 23);
            this.milkp.TabIndex = 28;
            // 
            // eggp
            // 
            this.eggp.AutoSize = true;
            this.eggp.BackColor = System.Drawing.Color.Transparent;
            this.eggp.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.eggp.Location = new System.Drawing.Point(112, 117);
            this.eggp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.eggp.Name = "eggp";
            this.eggp.Size = new System.Drawing.Size(0, 23);
            this.eggp.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(4, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Milk Price";
            // 
            // EggPrice
            // 
            this.EggPrice.AutoSize = true;
            this.EggPrice.BackColor = System.Drawing.Color.Transparent;
            this.EggPrice.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EggPrice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.EggPrice.Location = new System.Drawing.Point(10, 116);
            this.EggPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EggPrice.Name = "EggPrice";
            this.EggPrice.Size = new System.Drawing.Size(94, 23);
            this.EggPrice.TabIndex = 26;
            this.EggPrice.Text = "Egg Price";
            // 
            // txbx_email
            // 
            this.txbx_email.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbx_email.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_email.Location = new System.Drawing.Point(405, 118);
            this.txbx_email.Margin = new System.Windows.Forms.Padding(5);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(263, 27);
            this.txbx_email.TabIndex = 9;
            // 
            // txbx_name
            // 
            this.txbx_name.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbx_name.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_name.Location = new System.Drawing.Point(405, 75);
            this.txbx_name.Margin = new System.Windows.Forms.Padding(5);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(263, 27);
            this.txbx_name.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(296, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(297, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(272, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Location :";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Phone.Location = new System.Drawing.Point(292, 159);
            this.Phone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(77, 23);
            this.Phone.TabIndex = 12;
            this.Phone.Text = "Phone :";
            // 
            // txbx_phone
            // 
            this.txbx_phone.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbx_phone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_phone.Location = new System.Drawing.Point(405, 161);
            this.txbx_phone.Margin = new System.Windows.Forms.Padding(5);
            this.txbx_phone.Name = "txbx_phone";
            this.txbx_phone.Size = new System.Drawing.Size(263, 27);
            this.txbx_phone.TabIndex = 14;
            // 
            // txbx_address
            // 
            this.txbx_address.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbx_address.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_address.Location = new System.Drawing.Point(405, 336);
            this.txbx_address.Margin = new System.Windows.Forms.Padding(5);
            this.txbx_address.Multiline = true;
            this.txbx_address.Name = "txbx_address";
            this.txbx_address.Size = new System.Drawing.Size(263, 57);
            this.txbx_address.TabIndex = 15;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Silver;
            this.btn_send.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_send.Location = new System.Drawing.Point(579, 402);
            this.btn_send.Margin = new System.Windows.Forms.Padding(5);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(91, 34);
            this.btn_send.TabIndex = 16;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_clear.Location = new System.Drawing.Point(405, 402);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(113, 34);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.Silver;
            this.btn_payment.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_payment.Location = new System.Drawing.Point(692, 540);
            this.btn_payment.Margin = new System.Windows.Forms.Padding(5);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(127, 34);
            this.btn_payment.TabIndex = 18;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(311, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Egg Quantity";
            // 
            // txbx_Egg
            // 
            this.txbx_Egg.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbx_Egg.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Egg.Location = new System.Drawing.Point(293, 233);
            this.txbx_Egg.Margin = new System.Windows.Forms.Padding(5);
            this.txbx_Egg.Name = "txbx_Egg";
            this.txbx_Egg.Size = new System.Drawing.Size(169, 27);
            this.txbx_Egg.TabIndex = 20;
            // 
            // txbx_Milk
            // 
            this.txbx_Milk.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbx_Milk.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Milk.Location = new System.Drawing.Point(499, 233);
            this.txbx_Milk.Margin = new System.Windows.Forms.Padding(5);
            this.txbx_Milk.Name = "txbx_Milk";
            this.txbx_Milk.Size = new System.Drawing.Size(169, 27);
            this.txbx_Milk.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(516, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Milk Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(305, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date :";
            // 
            // order_date
            // 
            this.order_date.Enabled = false;
            this.order_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_date.Location = new System.Drawing.Point(405, 282);
            this.order_date.Margin = new System.Windows.Forms.Padding(4);
            this.order_date.Name = "order_date";
            this.order_date.Size = new System.Drawing.Size(263, 26);
            this.order_date.TabIndex = 24;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Silver;
            this.btn_print.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_print.Location = new System.Drawing.Point(204, 543);
            this.btn_print.Margin = new System.Windows.Forms.Padding(5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(91, 34);
            this.btn_print.TabIndex = 25;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 591);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.order_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbx_Milk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbx_Egg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txbx_address);
            this.Controls.Add(this.txbx_phone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_email);
            this.Controls.Add(this.txbx_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label order_form;
        private System.Windows.Forms.Button btn_Exit_OrderFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox txbx_phone;
        private System.Windows.Forms.TextBox txbx_address;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_Egg;
        private System.Windows.Forms.TextBox txbx_Milk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker order_date;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label milkp;
        private System.Windows.Forms.Label eggp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EggPrice;
    }
}