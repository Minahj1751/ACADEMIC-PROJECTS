
namespace Farm_Management_System
{
    partial class Incom
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
            this.txbx_purpose = new System.Windows.Forms.TextBox();
            this.txbx_amount = new System.Windows.Forms.TextBox();
            this.txbx_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inc_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.incList_DGV = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.brn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incList_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txbx_purpose
            // 
            this.txbx_purpose.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_purpose.Location = new System.Drawing.Point(421, 64);
            this.txbx_purpose.Name = "txbx_purpose";
            this.txbx_purpose.Size = new System.Drawing.Size(138, 27);
            this.txbx_purpose.TabIndex = 83;
            // 
            // txbx_amount
            // 
            this.txbx_amount.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_amount.Location = new System.Drawing.Point(170, 62);
            this.txbx_amount.Name = "txbx_amount";
            this.txbx_amount.Size = new System.Drawing.Size(95, 27);
            this.txbx_amount.TabIndex = 82;
            // 
            // txbx_ID
            // 
            this.txbx_ID.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_ID.Location = new System.Drawing.Point(170, 22);
            this.txbx_ID.Name = "txbx_ID";
            this.txbx_ID.ReadOnly = true;
            this.txbx_ID.Size = new System.Drawing.Size(95, 27);
            this.txbx_ID.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Income Purpose :";
            // 
            // inc_date
            // 
            this.inc_date.Font = new System.Drawing.Font("Century", 12F);
            this.inc_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inc_date.Location = new System.Drawing.Point(421, 24);
            this.inc_date.Name = "inc_date";
            this.inc_date.Size = new System.Drawing.Size(138, 27);
            this.inc_date.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 12F);
            this.label7.Location = new System.Drawing.Point(303, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 77;
            this.label7.Text = "Income Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "User ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 27);
            this.label4.TabIndex = 84;
            this.label4.Text = "Income List";
            // 
            // incList_DGV
            // 
            this.incList_DGV.BackgroundColor = System.Drawing.Color.Gray;
            this.incList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incList_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.incList_DGV.Location = new System.Drawing.Point(0, 250);
            this.incList_DGV.Name = "incList_DGV";
            this.incList_DGV.Size = new System.Drawing.Size(700, 270);
            this.incList_DGV.TabIndex = 85;
            this.incList_DGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.incList_DGV_RowHeaderMouseClick);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.Font = new System.Drawing.Font("Century", 12F);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(122, 124);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 32);
            this.btn_clear.TabIndex = 110;
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
            this.btn_show.Location = new System.Drawing.Point(228, 124);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(114, 32);
            this.btn_show.TabIndex = 109;
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
            this.brn_update.Location = new System.Drawing.Point(352, 124);
            this.brn_update.Name = "brn_update";
            this.brn_update.Size = new System.Drawing.Size(100, 32);
            this.brn_update.TabIndex = 108;
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
            this.btn_add.Location = new System.Drawing.Point(458, 124);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 32);
            this.btn_add.TabIndex = 107;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(674, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 111;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Incom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.brn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.incList_DGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_purpose);
            this.Controls.Add(this.txbx_amount);
            this.Controls.Add(this.txbx_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inc_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Incom";
            this.Text = "Incom";
            this.Load += new System.EventHandler(this.Incom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incList_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_purpose;
        private System.Windows.Forms.TextBox txbx_amount;
        private System.Windows.Forms.TextBox txbx_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inc_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView incList_DGV;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button brn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
    }
}