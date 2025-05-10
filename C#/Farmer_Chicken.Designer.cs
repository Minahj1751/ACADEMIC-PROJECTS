
namespace Farm_Management_System
{
    partial class Farmer_Chicken
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
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adding_date = new System.Windows.Forms.DateTimePicker();
            this.txbx_quantity = new System.Windows.Forms.TextBox();
            this.txbx_caste = new System.Windows.Forms.TextBox();
            this.txbx_FID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChickenList_DGV = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.brn_update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_G_ID = new System.Windows.Forms.TextBox();
            this.txbx_search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenList_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 90;
            this.label3.Text = "Chiken List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 12F);
            this.label7.Location = new System.Drawing.Point(158, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Quantity :";
            // 
            // adding_date
            // 
            this.adding_date.Font = new System.Drawing.Font("Century", 12F);
            this.adding_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adding_date.Location = new System.Drawing.Point(467, 56);
            this.adding_date.Name = "adding_date";
            this.adding_date.Size = new System.Drawing.Size(114, 27);
            this.adding_date.TabIndex = 85;
            // 
            // txbx_quantity
            // 
            this.txbx_quantity.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_quantity.Location = new System.Drawing.Point(244, 56);
            this.txbx_quantity.Name = "txbx_quantity";
            this.txbx_quantity.Size = new System.Drawing.Size(105, 27);
            this.txbx_quantity.TabIndex = 84;
            // 
            // txbx_caste
            // 
            this.txbx_caste.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_caste.Location = new System.Drawing.Point(533, 13);
            this.txbx_caste.Name = "txbx_caste";
            this.txbx_caste.Size = new System.Drawing.Size(122, 27);
            this.txbx_caste.TabIndex = 83;
            // 
            // txbx_FID
            // 
            this.txbx_FID.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_FID.Location = new System.Drawing.Point(300, 13);
            this.txbx_FID.Name = "txbx_FID";
            this.txbx_FID.ReadOnly = true;
            this.txbx_FID.Size = new System.Drawing.Size(100, 27);
            this.txbx_FID.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 12F);
            this.label5.Location = new System.Drawing.Point(355, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Adding Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F);
            this.label2.Location = new System.Drawing.Point(406, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Chicken Caste :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Farmer ID :";
            // 
            // ChickenList_DGV
            // 
            this.ChickenList_DGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ChickenList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChickenList_DGV.Location = new System.Drawing.Point(11, 314);
            this.ChickenList_DGV.Name = "ChickenList_DGV";
            this.ChickenList_DGV.Size = new System.Drawing.Size(677, 203);
            this.ChickenList_DGV.TabIndex = 91;
            this.ChickenList_DGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ChickenList_DGV_RowHeaderMouseClick);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.Font = new System.Drawing.Font("Century", 12F);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(89, 111);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 32);
            this.btn_clear.TabIndex = 96;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_show.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_show.FlatAppearance.BorderSize = 0;
            this.btn_show.Font = new System.Drawing.Font("Century", 12F);
            this.btn_show.ForeColor = System.Drawing.Color.Black;
            this.btn_show.Location = new System.Drawing.Point(196, 111);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(114, 32);
            this.btn_show.TabIndex = 95;
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
            this.brn_update.Location = new System.Drawing.Point(422, 111);
            this.brn_update.Name = "brn_update";
            this.brn_update.Size = new System.Drawing.Size(100, 32);
            this.brn_update.TabIndex = 94;
            this.brn_update.Text = "UPDATE";
            this.brn_update.UseVisualStyleBackColor = false;
            this.brn_update.Click += new System.EventHandler(this.brn_update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.Font = new System.Drawing.Font("Century", 12F);
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(316, 111);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 32);
            this.btn_remove.TabIndex = 93;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.Font = new System.Drawing.Font("Century", 12F);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(528, 111);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 32);
            this.btn_add.TabIndex = 92;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F);
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Group ID:";
            // 
            // txbx_G_ID
            // 
            this.txbx_G_ID.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_G_ID.Location = new System.Drawing.Point(96, 13);
            this.txbx_G_ID.Name = "txbx_G_ID";
            this.txbx_G_ID.ReadOnly = true;
            this.txbx_G_ID.Size = new System.Drawing.Size(105, 27);
            this.txbx_G_ID.TabIndex = 98;
            // 
            // txbx_search
            // 
            this.txbx_search.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_search.Location = new System.Drawing.Point(294, 198);
            this.txbx_search.Name = "txbx_search";
            this.txbx_search.Size = new System.Drawing.Size(236, 27);
            this.txbx_search.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 28);
            this.label10.TabIndex = 100;
            this.label10.Text = "Search";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(671, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 112;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Farmer_Chicken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbx_search);
            this.Controls.Add(this.txbx_G_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.brn_update);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.ChickenList_DGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adding_date);
            this.Controls.Add(this.txbx_quantity);
            this.Controls.Add(this.txbx_caste);
            this.Controls.Add(this.txbx_FID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Farmer_Chicken";
            this.Text = "Farmer_Chicken";
            this.Load += new System.EventHandler(this.Farmer_Chicken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChickenList_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker adding_date;
        private System.Windows.Forms.TextBox txbx_quantity;
        private System.Windows.Forms.TextBox txbx_caste;
        private System.Windows.Forms.TextBox txbx_FID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ChickenList_DGV;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button brn_update;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_G_ID;
        private System.Windows.Forms.TextBox txbx_search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}