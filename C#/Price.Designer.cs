
namespace Farm_Management_System
{
    partial class Price
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
            this.price_DGV = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.txbx_egg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_milk = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.price_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // price_DGV
            // 
            this.price_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.price_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.price_DGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.price_DGV.Location = new System.Drawing.Point(175, 246);
            this.price_DGV.Name = "price_DGV";
            this.price_DGV.Size = new System.Drawing.Size(307, 95);
            this.price_DGV.TabIndex = 0;
            this.price_DGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.price_DGV_RowHeaderMouseClick);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(341, 185);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 31);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txbx_egg
            // 
            this.txbx_egg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_egg.Location = new System.Drawing.Point(325, 74);
            this.txbx_egg.Name = "txbx_egg";
            this.txbx_egg.Size = new System.Drawing.Size(100, 29);
            this.txbx_egg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "EGG :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "MILK :";
            // 
            // txbx_milk
            // 
            this.txbx_milk.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_milk.Location = new System.Drawing.Point(325, 121);
            this.txbx_milk.Name = "txbx_milk";
            this.txbx_milk.Size = new System.Drawing.Size(100, 29);
            this.txbx_milk.TabIndex = 4;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(227, 185);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(70, 31);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(653, 12);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(35, 31);
            this.clear.TabIndex = 7;
            this.clear.Text = "X";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_milk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_egg);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.price_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Price";
            this.Text = "Price";
            ((System.ComponentModel.ISupportInitialize)(this.price_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView price_DGV;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txbx_egg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_milk;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button clear;
    }
}