
namespace Farm_Management_System
{
    partial class Expend
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
            this.txbx_UID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exp_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpList_DGV = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.brn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExpList_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txbx_purpose
            // 
            this.txbx_purpose.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_purpose.Location = new System.Drawing.Point(456, 74);
            this.txbx_purpose.Name = "txbx_purpose";
            this.txbx_purpose.Size = new System.Drawing.Size(156, 27);
            this.txbx_purpose.TabIndex = 75;
            // 
            // txbx_amount
            // 
            this.txbx_amount.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_amount.Location = new System.Drawing.Point(198, 77);
            this.txbx_amount.Name = "txbx_amount";
            this.txbx_amount.Size = new System.Drawing.Size(100, 27);
            this.txbx_amount.TabIndex = 74;
            // 
            // txbx_UID
            // 
            this.txbx_UID.Font = new System.Drawing.Font("Century", 12F);
            this.txbx_UID.Location = new System.Drawing.Point(198, 29);
            this.txbx_UID.Name = "txbx_UID";
            this.txbx_UID.ReadOnly = true;
            this.txbx_UID.Size = new System.Drawing.Size(100, 27);
            this.txbx_UID.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Expend Purpose :";
            // 
            // Exp_date
            // 
            this.Exp_date.Font = new System.Drawing.Font("Century", 12F);
            this.Exp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Exp_date.Location = new System.Drawing.Point(456, 30);
            this.Exp_date.Name = "Exp_date";
            this.Exp_date.Size = new System.Drawing.Size(156, 27);
            this.Exp_date.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 12F);
            this.label7.Location = new System.Drawing.Point(343, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Expend Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "User ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 27);
            this.label4.TabIndex = 76;
            this.label4.Text = "Expenditure List";
            // 
            // ExpList_DGV
            // 
            this.ExpList_DGV.BackgroundColor = System.Drawing.Color.Gray;
            this.ExpList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpList_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExpList_DGV.Location = new System.Drawing.Point(0, 250);
            this.ExpList_DGV.Name = "ExpList_DGV";
            this.ExpList_DGV.Size = new System.Drawing.Size(700, 270);
            this.ExpList_DGV.TabIndex = 86;
            this.ExpList_DGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.incList_DGV_RowHeaderMouseClick);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.Font = new System.Drawing.Font("Century", 12F);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(126, 143);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 32);
            this.btn_clear.TabIndex = 114;
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
            this.btn_show.Location = new System.Drawing.Point(232, 143);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(114, 32);
            this.btn_show.TabIndex = 113;
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
            this.brn_update.Location = new System.Drawing.Point(356, 143);
            this.brn_update.Name = "brn_update";
            this.brn_update.Size = new System.Drawing.Size(100, 32);
            this.brn_update.TabIndex = 112;
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
            this.btn_add.Location = new System.Drawing.Point(462, 143);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 32);
            this.btn_add.TabIndex = 111;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(674, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 115;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Expend
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
            this.Controls.Add(this.ExpList_DGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_purpose);
            this.Controls.Add(this.txbx_amount);
            this.Controls.Add(this.txbx_UID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exp_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expend";
            this.Text = "Expend";
            this.Load += new System.EventHandler(this.Expend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpList_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_purpose;
        private System.Windows.Forms.TextBox txbx_amount;
        private System.Windows.Forms.TextBox txbx_UID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Exp_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ExpList_DGV;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button brn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
    }
}