
namespace Farm_Management_System
{
    partial class Profile
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Farmer_picBx = new System.Windows.Forms.PictureBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.lvlDOB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Farmer_picBx)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(25, 329);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(158, 25);
            this.label.TabIndex = 14;
            this.label.Text = "Date Of Birth :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email :";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.BackColor = System.Drawing.Color.Transparent;
            this.Id.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(137, 238);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(49, 25);
            this.Id.TabIndex = 12;
            this.Id.Text = "ID :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(100, 271);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(83, 25);
            this.name.TabIndex = 11;
            this.name.Text = "Name :";
            // 
            // Farmer_picBx
            // 
            this.Farmer_picBx.BackColor = System.Drawing.Color.Transparent;
            this.Farmer_picBx.Image = global::Farm_Management_System.Properties.Resources.emp;
            this.Farmer_picBx.Location = new System.Drawing.Point(268, 12);
            this.Farmer_picBx.Name = "Farmer_picBx";
            this.Farmer_picBx.Size = new System.Drawing.Size(158, 161);
            this.Farmer_picBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Farmer_picBx.TabIndex = 10;
            this.Farmer_picBx.TabStop = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(197, 238);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 25);
            this.labelID.TabIndex = 15;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(199, 271);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 23);
            this.labelName.TabIndex = 16;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(199, 300);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 25);
            this.labelEmail.TabIndex = 18;
            // 
            // lvlDOB
            // 
            this.lvlDOB.AutoSize = true;
            this.lvlDOB.BackColor = System.Drawing.Color.Transparent;
            this.lvlDOB.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDOB.Location = new System.Drawing.Point(184, 327);
            this.lvlDOB.Name = "lvlDOB";
            this.lvlDOB.Size = new System.Drawing.Size(0, 25);
            this.lvlDOB.TabIndex = 19;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.lvlDOB);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Farmer_picBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Farmer_picBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox Farmer_picBx;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label lvlDOB;
    }
}