
namespace Farm_Management_System
{
    partial class Salesman_milk
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
            this.Milk_saleDGV = new System.Windows.Forms.DataGridView();
            this.txbx_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.brn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lvl_cus_id = new System.Windows.Forms.Label();
            this.salling_date = new System.Windows.Forms.DateTimePicker();
            this.lvl_sl_mi_list = new System.Windows.Forms.Label();
            this.txbx_Total_price = new System.Windows.Forms.TextBox();
            this.lvl_tp = new System.Windows.Forms.Label();
            this.txbx_Buyer_Name = new System.Windows.Forms.TextBox();
            this.lvl_cname = new System.Windows.Forms.Label();
            this.txbx_Buyer_ID = new System.Windows.Forms.TextBox();
            this.lvl_ci = new System.Windows.Forms.Label();
            this.txbx_Quantity = new System.Windows.Forms.TextBox();
            this.lvl_quan = new System.Windows.Forms.Label();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.lvl_pr = new System.Windows.Forms.Label();
            this.lvl_sd = new System.Windows.Forms.Label();
            this.txbx_SalerID = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_Milk_S_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Milk_saleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Milk_saleDGV
            // 
            this.Milk_saleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Milk_saleDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Milk_saleDGV.Location = new System.Drawing.Point(0, 299);
            this.Milk_saleDGV.Name = "Milk_saleDGV";
            this.Milk_saleDGV.Size = new System.Drawing.Size(700, 221);
            this.Milk_saleDGV.TabIndex = 135;
            this.Milk_saleDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Milk_saleDGV_RowHeaderMouseClick_1);
            // 
            // txbx_search
            // 
            this.txbx_search.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_search.Location = new System.Drawing.Point(271, 218);
            this.txbx_search.Margin = new System.Windows.Forms.Padding(2);
            this.txbx_search.Name = "txbx_search";
            this.txbx_search.Size = new System.Drawing.Size(179, 30);
            this.txbx_search.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Salesman Id :";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.Font = new System.Drawing.Font("Century", 12F);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(82, 171);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 32);
            this.btn_clear.TabIndex = 132;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_show.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_show.FlatAppearance.BorderSize = 0;
            this.btn_show.Font = new System.Drawing.Font("Century", 12F);
            this.btn_show.ForeColor = System.Drawing.Color.Black;
            this.btn_show.Location = new System.Drawing.Point(293, 171);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(114, 32);
            this.btn_show.TabIndex = 131;
            this.btn_show.Text = "SHOW ALL";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // brn_update
            // 
            this.brn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brn_update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.brn_update.FlatAppearance.BorderSize = 0;
            this.brn_update.Font = new System.Drawing.Font("Century", 12F);
            this.brn_update.ForeColor = System.Drawing.Color.Black;
            this.brn_update.Location = new System.Drawing.Point(411, 171);
            this.brn_update.Name = "brn_update";
            this.brn_update.Size = new System.Drawing.Size(100, 32);
            this.brn_update.TabIndex = 130;
            this.brn_update.Text = "UPDATE";
            this.brn_update.UseVisualStyleBackColor = false;
            this.brn_update.Click += new System.EventHandler(this.brn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.Font = new System.Drawing.Font("Century", 12F);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(514, 171);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 32);
            this.btn_add.TabIndex = 129;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // lvl_cus_id
            // 
            this.lvl_cus_id.AutoSize = true;
            this.lvl_cus_id.BackColor = System.Drawing.Color.Transparent;
            this.lvl_cus_id.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_cus_id.Location = new System.Drawing.Point(9, 59);
            this.lvl_cus_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl_cus_id.Name = "lvl_cus_id";
            this.lvl_cus_id.Size = new System.Drawing.Size(109, 20);
            this.lvl_cus_id.TabIndex = 128;
            this.lvl_cus_id.Text = "Customer Id :";
            // 
            // salling_date
            // 
            this.salling_date.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salling_date.Location = new System.Drawing.Point(295, 19);
            this.salling_date.Margin = new System.Windows.Forms.Padding(2);
            this.salling_date.Name = "salling_date";
            this.salling_date.Size = new System.Drawing.Size(118, 23);
            this.salling_date.TabIndex = 127;
            // 
            // lvl_sl_mi_list
            // 
            this.lvl_sl_mi_list.AutoSize = true;
            this.lvl_sl_mi_list.BackColor = System.Drawing.Color.Transparent;
            this.lvl_sl_mi_list.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_sl_mi_list.Location = new System.Drawing.Point(266, 260);
            this.lvl_sl_mi_list.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl_sl_mi_list.Name = "lvl_sl_mi_list";
            this.lvl_sl_mi_list.Size = new System.Drawing.Size(166, 27);
            this.lvl_sl_mi_list.TabIndex = 126;
            this.lvl_sl_mi_list.Text = "Sell Milk List";
            // 
            // txbx_Total_price
            // 
            this.txbx_Total_price.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Total_price.Location = new System.Drawing.Point(623, 59);
            this.txbx_Total_price.Margin = new System.Windows.Forms.Padding(2);
            this.txbx_Total_price.Name = "txbx_Total_price";
            this.txbx_Total_price.Size = new System.Drawing.Size(73, 26);
            this.txbx_Total_price.TabIndex = 125;
            // 
            // lvl_tp
            // 
            this.lvl_tp.AutoSize = true;
            this.lvl_tp.BackColor = System.Drawing.Color.Transparent;
            this.lvl_tp.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_tp.Location = new System.Drawing.Point(524, 63);
            this.lvl_tp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl_tp.Name = "lvl_tp";
            this.lvl_tp.Size = new System.Drawing.Size(96, 20);
            this.lvl_tp.TabIndex = 124;
            this.lvl_tp.Text = "Total price :";
            // 
            // txbx_Buyer_Name
            // 
            this.txbx_Buyer_Name.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Buyer_Name.Location = new System.Drawing.Point(341, 57);
            this.txbx_Buyer_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txbx_Buyer_Name.Name = "txbx_Buyer_Name";
            this.txbx_Buyer_Name.Size = new System.Drawing.Size(179, 26);
            this.txbx_Buyer_Name.TabIndex = 123;
            // 
            // lvl_cname
            // 
            this.lvl_cname.AutoSize = true;
            this.lvl_cname.BackColor = System.Drawing.Color.Transparent;
            this.lvl_cname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_cname.Location = new System.Drawing.Point(204, 59);
            this.lvl_cname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl_cname.Name = "lvl_cname";
            this.lvl_cname.Size = new System.Drawing.Size(137, 20);
            this.lvl_cname.TabIndex = 122;
            this.lvl_cname.Text = "Customer Name :";
            // 
            // txbx_Buyer_ID
            // 
            this.txbx_Buyer_ID.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Buyer_ID.Location = new System.Drawing.Point(119, 57);
            this.txbx_Buyer_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txbx_Buyer_ID.Name = "txbx_Buyer_ID";
            this.txbx_Buyer_ID.Size = new System.Drawing.Size(81, 26);
            this.txbx_Buyer_ID.TabIndex = 121;
            // 
            // lvl_ci
            // 
            this.lvl_ci.AutoSize = true;
            this.lvl_ci.BackColor = System.Drawing.Color.Transparent;
            this.lvl_ci.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_ci.Location = new System.Drawing.Point(457, 334);
            this.lvl_ci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl_ci.Name = "lvl_ci";
            this.lvl_ci.Size = new System.Drawing.Size(0, 20);
            this.lvl_ci.TabIndex = 120;
            // 
            // txbx_Quantity
            // 
            this.txbx_Quantity.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Quantity.Location = new System.Drawing.Point(610, 19);
            this.txbx_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.txbx_Quantity.Name = "txbx_Quantity";
            this.txbx_Quantity.Size = new System.Drawing.Size(86, 26);
            this.txbx_Quantity.TabIndex = 119;
            // 
            // lvl_quan
            // 
            this.lvl_quan.AutoSize = true;
            this.lvl_quan.BackColor = System.Drawing.Color.Transparent;
            this.lvl_quan.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_quan.Location = new System.Drawing.Point(529, 22);
            this.lvl_quan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl_quan.Name = "lvl_quan";
            this.lvl_quan.Size = new System.Drawing.Size(84, 20);
            this.lvl_quan.TabIndex = 118;
            this.lvl_quan.Text = "Quantity :";
            // 
            // txbx_price
            // 
            this.txbx_price.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_price.Location = new System.Drawing.Point(474, 19);
            this.txbx_price.Margin = new System.Windows.Forms.Padding(2);
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(53, 26);
            this.txbx_price.TabIndex = 117;
            // 
            // lvl_pr
            // 
            this.lvl_pr.AutoSize = true;
            this.lvl_pr.BackColor = System.Drawing.Color.Transparent;
            this.lvl_pr.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_pr.Location = new System.Drawing.Point(418, 22);
            this.lvl_pr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl_pr.Name = "lvl_pr";
            this.lvl_pr.Size = new System.Drawing.Size(55, 20);
            this.lvl_pr.TabIndex = 116;
            this.lvl_pr.Text = "Price :";
            // 
            // lvl_sd
            // 
            this.lvl_sd.AutoSize = true;
            this.lvl_sd.BackColor = System.Drawing.Color.Transparent;
            this.lvl_sd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_sd.Location = new System.Drawing.Point(209, 20);
            this.lvl_sd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl_sd.Name = "lvl_sd";
            this.lvl_sd.Size = new System.Drawing.Size(84, 20);
            this.lvl_sd.TabIndex = 115;
            this.lvl_sd.Text = "Sell Date :";
            // 
            // txbx_SalerID
            // 
            this.txbx_SalerID.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_SalerID.Location = new System.Drawing.Point(117, 17);
            this.txbx_SalerID.Margin = new System.Windows.Forms.Padding(2);
            this.txbx_SalerID.Name = "txbx_SalerID";
            this.txbx_SalerID.Size = new System.Drawing.Size(88, 26);
            this.txbx_SalerID.TabIndex = 114;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_remove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.Font = new System.Drawing.Font("Century", 12F);
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(187, 171);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 32);
            this.btn_remove.TabIndex = 136;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 138;
            this.label2.Text = "Milk Sale ID :";
            // 
            // txbx_Milk_S_ID
            // 
            this.txbx_Milk_S_ID.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Milk_S_ID.Location = new System.Drawing.Point(122, 100);
            this.txbx_Milk_S_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txbx_Milk_S_ID.Name = "txbx_Milk_S_ID";
            this.txbx_Milk_S_ID.ReadOnly = true;
            this.txbx_Milk_S_ID.Size = new System.Drawing.Size(115, 27);
            this.txbx_Milk_S_ID.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 139;
            this.label3.Text = "Search";
            // 
            // Salesman_milk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.Screenshot_2023_12_03_030323;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_Milk_S_ID);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.Milk_saleDGV);
            this.Controls.Add(this.txbx_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.brn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lvl_cus_id);
            this.Controls.Add(this.salling_date);
            this.Controls.Add(this.lvl_sl_mi_list);
            this.Controls.Add(this.txbx_Total_price);
            this.Controls.Add(this.lvl_tp);
            this.Controls.Add(this.txbx_Buyer_Name);
            this.Controls.Add(this.lvl_cname);
            this.Controls.Add(this.txbx_Buyer_ID);
            this.Controls.Add(this.lvl_ci);
            this.Controls.Add(this.txbx_Quantity);
            this.Controls.Add(this.lvl_quan);
            this.Controls.Add(this.txbx_price);
            this.Controls.Add(this.lvl_pr);
            this.Controls.Add(this.lvl_sd);
            this.Controls.Add(this.txbx_SalerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salesman_milk";
            this.Text = "Salesman_milk";
            ((System.ComponentModel.ISupportInitialize)(this.Milk_saleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Milk_saleDGV;
        private System.Windows.Forms.TextBox txbx_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button brn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lvl_cus_id;
        private System.Windows.Forms.DateTimePicker salling_date;
        private System.Windows.Forms.Label lvl_sl_mi_list;
        private System.Windows.Forms.TextBox txbx_Total_price;
        private System.Windows.Forms.Label lvl_tp;
        private System.Windows.Forms.TextBox txbx_Buyer_Name;
        private System.Windows.Forms.Label lvl_cname;
        private System.Windows.Forms.TextBox txbx_Buyer_ID;
        private System.Windows.Forms.Label lvl_ci;
        private System.Windows.Forms.TextBox txbx_Quantity;
        private System.Windows.Forms.Label lvl_quan;
        private System.Windows.Forms.TextBox txbx_price;
        private System.Windows.Forms.Label lvl_pr;
        private System.Windows.Forms.Label lvl_sd;
        private System.Windows.Forms.TextBox txbx_SalerID;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_Milk_S_ID;
        private System.Windows.Forms.Label label3;
    }
}