
namespace Farm_Management_System
{
    partial class Farmer_Egg
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
            this.btn_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.txbx_search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EggList_DGV = new System.Windows.Forms.DataGridView();
            this.txbx_EC_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_P_egg = new System.Windows.Forms.TextBox();
            this.txbx_N_egg = new System.Windows.Forms.TextBox();
            this.txbx_A_egg = new System.Windows.Forms.TextBox();
            this.txbx_group_ID = new System.Windows.Forms.TextBox();
            this.txbx_FID = new System.Windows.Forms.TextBox();
            this.collection_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EggList_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.Font = new System.Drawing.Font("Century", 12F);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(468, 113);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 32);
            this.btn_add.TabIndex = 76;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 27);
            this.label5.TabIndex = 83;
            this.label5.Text = "Egg Collection List";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.Font = new System.Drawing.Font("Century", 12F);
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(362, 113);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 32);
            this.btn_update.TabIndex = 84;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.Font = new System.Drawing.Font("Century", 12F);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(256, 113);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 32);
            this.btn_clear.TabIndex = 85;
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
            this.btn_show.Location = new System.Drawing.Point(139, 113);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(111, 32);
            this.btn_show.TabIndex = 86;
            this.btn_show.Text = "SHOW ALL";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // txbx_search
            // 
            this.txbx_search.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_search.Location = new System.Drawing.Point(288, 180);
            this.txbx_search.Name = "txbx_search";
            this.txbx_search.Size = new System.Drawing.Size(247, 27);
            this.txbx_search.TabIndex = 87;
            this.txbx_search.TextChanged += new System.EventHandler(this.txbx_search_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(193, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 28);
            this.label10.TabIndex = 101;
            this.label10.Text = "Search";
            // 
            // EggList_DGV
            // 
            this.EggList_DGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.EggList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EggList_DGV.Location = new System.Drawing.Point(11, 271);
            this.EggList_DGV.Name = "EggList_DGV";
            this.EggList_DGV.Size = new System.Drawing.Size(677, 237);
            this.EggList_DGV.TabIndex = 102;
            this.EggList_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EggList_DGV_CellContentClick);
            this.EggList_DGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EggList_DGV_RowHeaderMouseClick);
            // 
            // txbx_EC_ID
            // 
            this.txbx_EC_ID.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_EC_ID.Location = new System.Drawing.Point(154, 13);
            this.txbx_EC_ID.Name = "txbx_EC_ID";
            this.txbx_EC_ID.ReadOnly = true;
            this.txbx_EC_ID.Size = new System.Drawing.Size(100, 27);
            this.txbx_EC_ID.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 115;
            this.label8.Text = "Egg Collection ID :";
            // 
            // txbx_P_egg
            // 
            this.txbx_P_egg.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_P_egg.Location = new System.Drawing.Point(616, 62);
            this.txbx_P_egg.Name = "txbx_P_egg";
            this.txbx_P_egg.Size = new System.Drawing.Size(68, 27);
            this.txbx_P_egg.TabIndex = 114;
            // 
            // txbx_N_egg
            // 
            this.txbx_N_egg.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_N_egg.Location = new System.Drawing.Point(459, 62);
            this.txbx_N_egg.Name = "txbx_N_egg";
            this.txbx_N_egg.Size = new System.Drawing.Size(67, 27);
            this.txbx_N_egg.TabIndex = 113;
            // 
            // txbx_A_egg
            // 
            this.txbx_A_egg.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_A_egg.Location = new System.Drawing.Point(289, 62);
            this.txbx_A_egg.Name = "txbx_A_egg";
            this.txbx_A_egg.Size = new System.Drawing.Size(68, 27);
            this.txbx_A_egg.TabIndex = 112;
            // 
            // txbx_group_ID
            // 
            this.txbx_group_ID.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_group_ID.Location = new System.Drawing.Point(349, 14);
            this.txbx_group_ID.Name = "txbx_group_ID";
            this.txbx_group_ID.Size = new System.Drawing.Size(89, 27);
            this.txbx_group_ID.TabIndex = 111;
            // 
            // txbx_FID
            // 
            this.txbx_FID.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_FID.Location = new System.Drawing.Point(99, 61);
            this.txbx_FID.Name = "txbx_FID";
            this.txbx_FID.ReadOnly = true;
            this.txbx_FID.Size = new System.Drawing.Size(100, 27);
            this.txbx_FID.TabIndex = 110;
            // 
            // collection_date
            // 
            this.collection_date.Font = new System.Drawing.Font("Century", 12F);
            this.collection_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.collection_date.Location = new System.Drawing.Point(576, 14);
            this.collection_date.Name = "collection_date";
            this.collection_date.Size = new System.Drawing.Size(108, 27);
            this.collection_date.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 108;
            this.label6.Text = "Farmer ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "Group ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Collection Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "AM Egg :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "Noon Egg :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 103;
            this.label7.Text = "PM Egg :";
            // 
            // Farmer_Egg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.txbx_EC_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbx_P_egg);
            this.Controls.Add(this.txbx_N_egg);
            this.Controls.Add(this.txbx_A_egg);
            this.Controls.Add(this.txbx_group_ID);
            this.Controls.Add(this.txbx_FID);
            this.Controls.Add(this.collection_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EggList_DGV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbx_search);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Farmer_Egg";
            this.Text = "Farmer_Egg";
            this.Load += new System.EventHandler(this.Farmer_Egg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EggList_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txbx_search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView EggList_DGV;
        private System.Windows.Forms.TextBox txbx_EC_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbx_P_egg;
        private System.Windows.Forms.TextBox txbx_N_egg;
        private System.Windows.Forms.TextBox txbx_A_egg;
        private System.Windows.Forms.TextBox txbx_group_ID;
        private System.Windows.Forms.TextBox txbx_FID;
        private System.Windows.Forms.DateTimePicker collection_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}