
namespace Farm_Management_System
{
    partial class OrderList
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
            this.btn_shaw = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.OrderList_DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_orderid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_B_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_milk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_egg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_e_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbx_m_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_S_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.confirmDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txbx_order_confirm_id = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalEggs = new System.Windows.Forms.Label();
            this.lblTotalMilks = new System.Windows.Forms.Label();
            this.qShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_shaw
            // 
            this.btn_shaw.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shaw.Location = new System.Drawing.Point(600, 172);
            this.btn_shaw.Name = "btn_shaw";
            this.btn_shaw.Size = new System.Drawing.Size(88, 31);
            this.btn_shaw.TabIndex = 0;
            this.btn_shaw.Text = "Refresh";
            this.btn_shaw.UseVisualStyleBackColor = true;
            this.btn_shaw.Click += new System.EventHandler(this.btn_shaw_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(491, 172);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 31);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // OrderList_DGV
            // 
            this.OrderList_DGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.OrderList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderList_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderList_DGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OrderList_DGV.Location = new System.Drawing.Point(0, 277);
            this.OrderList_DGV.Name = "OrderList_DGV";
            this.OrderList_DGV.Size = new System.Drawing.Size(700, 243);
            this.OrderList_DGV.TabIndex = 2;
            this.OrderList_DGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrderList_DGV_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "See Order List";
            // 
            // txbx_orderid
            // 
            this.txbx_orderid.Location = new System.Drawing.Point(93, 16);
            this.txbx_orderid.Name = "txbx_orderid";
            this.txbx_orderid.ReadOnly = true;
            this.txbx_orderid.Size = new System.Drawing.Size(84, 22);
            this.txbx_orderid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buyer Name";
            // 
            // txbx_B_name
            // 
            this.txbx_B_name.Location = new System.Drawing.Point(286, 16);
            this.txbx_B_name.Name = "txbx_B_name";
            this.txbx_B_name.ReadOnly = true;
            this.txbx_B_name.Size = new System.Drawing.Size(132, 22);
            this.txbx_B_name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Milk";
            // 
            // txbx_milk
            // 
            this.txbx_milk.Location = new System.Drawing.Point(472, 15);
            this.txbx_milk.Name = "txbx_milk";
            this.txbx_milk.ReadOnly = true;
            this.txbx_milk.Size = new System.Drawing.Size(73, 22);
            this.txbx_milk.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(555, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Egg";
            // 
            // txbx_egg
            // 
            this.txbx_egg.Location = new System.Drawing.Point(598, 16);
            this.txbx_egg.Name = "txbx_egg";
            this.txbx_egg.ReadOnly = true;
            this.txbx_egg.Size = new System.Drawing.Size(71, 22);
            this.txbx_egg.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Egg Price";
            // 
            // txbx_e_price
            // 
            this.txbx_e_price.Location = new System.Drawing.Point(93, 60);
            this.txbx_e_price.Name = "txbx_e_price";
            this.txbx_e_price.Size = new System.Drawing.Size(62, 22);
            this.txbx_e_price.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Milk Price";
            // 
            // txbx_m_price
            // 
            this.txbx_m_price.Location = new System.Drawing.Point(249, 60);
            this.txbx_m_price.Name = "txbx_m_price";
            this.txbx_m_price.Size = new System.Drawing.Size(62, 22);
            this.txbx_m_price.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "SalesMan ID";
            // 
            // txbx_S_ID
            // 
            this.txbx_S_ID.Location = new System.Drawing.Point(423, 60);
            this.txbx_S_ID.Name = "txbx_S_ID";
            this.txbx_S_ID.Size = new System.Drawing.Size(79, 22);
            this.txbx_S_ID.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Confirm Date";
            // 
            // confirmDate
            // 
            this.confirmDate.CalendarFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmDate.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.confirmDate.Location = new System.Drawing.Point(618, 59);
            this.confirmDate.Name = "confirmDate";
            this.confirmDate.Size = new System.Drawing.Size(77, 26);
            this.confirmDate.TabIndex = 20;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(599, 103);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(88, 31);
            this.btn_Confirm.TabIndex = 21;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Order Confirm ID";
            // 
            // txbx_order_confirm_id
            // 
            this.txbx_order_confirm_id.Location = new System.Drawing.Point(151, 104);
            this.txbx_order_confirm_id.Name = "txbx_order_confirm_id";
            this.txbx_order_confirm_id.ReadOnly = true;
            this.txbx_order_confirm_id.Size = new System.Drawing.Size(84, 22);
            this.txbx_order_confirm_id.TabIndex = 22;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(491, 103);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(88, 31);
            this.btn_Clear.TabIndex = 24;
            this.btn_Clear.Text = "Clean";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(674, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 112;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTotalEggs
            // 
            this.lblTotalEggs.AutoSize = true;
            this.lblTotalEggs.Location = new System.Drawing.Point(13, 142);
            this.lblTotalEggs.Name = "lblTotalEggs";
            this.lblTotalEggs.Size = new System.Drawing.Size(0, 16);
            this.lblTotalEggs.TabIndex = 113;
            // 
            // lblTotalMilks
            // 
            this.lblTotalMilks.AutoSize = true;
            this.lblTotalMilks.Location = new System.Drawing.Point(13, 172);
            this.lblTotalMilks.Name = "lblTotalMilks";
            this.lblTotalMilks.Size = new System.Drawing.Size(0, 16);
            this.lblTotalMilks.TabIndex = 114;
            // 
            // qShow
            // 
            this.qShow.Location = new System.Drawing.Point(12, 142);
            this.qShow.Name = "qShow";
            this.qShow.Size = new System.Drawing.Size(127, 42);
            this.qShow.TabIndex = 115;
            this.qShow.Text = "Show Quantity";
            this.qShow.UseVisualStyleBackColor = true;
            this.qShow.Click += new System.EventHandler(this.qShow_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.qShow);
            this.Controls.Add(this.lblTotalMilks);
            this.Controls.Add(this.lblTotalEggs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbx_order_confirm_id);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.confirmDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbx_S_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbx_m_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbx_e_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbx_egg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_milk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_B_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_orderid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderList_DGV);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_shaw);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderList";
            this.Text = "OrderList";
            ((System.ComponentModel.ISupportInitialize)(this.OrderList_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_shaw;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView OrderList_DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_orderid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_B_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_milk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_egg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_e_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbx_m_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbx_S_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker confirmDate;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbx_order_confirm_id;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalEggs;
        private System.Windows.Forms.Label lblTotalMilks;
        private System.Windows.Forms.Button qShow;
    }
}