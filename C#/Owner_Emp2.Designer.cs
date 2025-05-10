
namespace Farm_Management_System
{
    partial class Owner_Emp2
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
            this.com_bx_status = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.txbx_salary = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.DOB_dt_pic = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.join_dt_pic = new System.Windows.Forms.DateTimePicker();
            this.lvl_UserName = new System.Windows.Forms.Label();
            this.txbx_UName = new System.Windows.Forms.TextBox();
            this.lvl_userID = new System.Windows.Forms.Label();
            this.txbx_UID = new System.Windows.Forms.TextBox();
            this.Salesman_List_DGV = new System.Windows.Forms.DataGridView();
            this.txbx_S_ID = new System.Windows.Forms.TextBox();
            this.Salesman = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.Search_txbx1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Salesman_List_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // com_bx_status
            // 
            this.com_bx_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_bx_status.FormattingEnabled = true;
            this.com_bx_status.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.com_bx_status.Location = new System.Drawing.Point(580, 107);
            this.com_bx_status.Name = "com_bx_status";
            this.com_bx_status.Size = new System.Drawing.Size(111, 26);
            this.com_bx_status.TabIndex = 41;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(512, 110);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(65, 20);
            this.status.TabIndex = 40;
            this.status.Text = "Status :";
            // 
            // txbx_salary
            // 
            this.txbx_salary.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_salary.Location = new System.Drawing.Point(592, 61);
            this.txbx_salary.Name = "txbx_salary";
            this.txbx_salary.Size = new System.Drawing.Size(99, 27);
            this.txbx_salary.TabIndex = 39;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.BackColor = System.Drawing.Color.Transparent;
            this.Salary.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(519, 64);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(70, 20);
            this.Salary.TabIndex = 38;
            this.Salary.Text = "Salary  :";
            // 
            // DOB_dt_pic
            // 
            this.DOB_dt_pic.CalendarFont = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_dt_pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_dt_pic.Location = new System.Drawing.Point(232, 108);
            this.DOB_dt_pic.Name = "DOB_dt_pic";
            this.DOB_dt_pic.Size = new System.Drawing.Size(70, 24);
            this.DOB_dt_pic.TabIndex = 37;
            this.DOB_dt_pic.Value = new System.DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "DOB :";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(110, 168);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 27);
            this.btn_clear.TabIndex = 35;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(486, 168);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(88, 27);
            this.btn_show.TabIndex = 34;
            this.btn_show.Text = "Show All";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(580, 168);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 27);
            this.btn_add.TabIndex = 33;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Salesman  List";
            // 
            // txbx_email
            // 
            this.txbx_email.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_email.Location = new System.Drawing.Point(374, 108);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(129, 27);
            this.txbx_email.TabIndex = 31;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(306, 111);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(66, 20);
            this.email.TabIndex = 30;
            this.email.Text = "Email  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Join Date :";
            // 
            // join_dt_pic
            // 
            this.join_dt_pic.CalendarFont = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.join_dt_pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.join_dt_pic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.join_dt_pic.Location = new System.Drawing.Point(100, 109);
            this.join_dt_pic.Name = "join_dt_pic";
            this.join_dt_pic.Size = new System.Drawing.Size(74, 24);
            this.join_dt_pic.TabIndex = 28;
            this.join_dt_pic.Value = new System.DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // lvl_UserName
            // 
            this.lvl_UserName.AutoSize = true;
            this.lvl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lvl_UserName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_UserName.Location = new System.Drawing.Point(200, 64);
            this.lvl_UserName.Name = "lvl_UserName";
            this.lvl_UserName.Size = new System.Drawing.Size(137, 20);
            this.lvl_UserName.TabIndex = 27;
            this.lvl_UserName.Text = "Salesman Name :";
            // 
            // txbx_UName
            // 
            this.txbx_UName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_UName.Location = new System.Drawing.Point(340, 61);
            this.txbx_UName.Name = "txbx_UName";
            this.txbx_UName.Size = new System.Drawing.Size(160, 27);
            this.txbx_UName.TabIndex = 26;
            // 
            // lvl_userID
            // 
            this.lvl_userID.AutoSize = true;
            this.lvl_userID.BackColor = System.Drawing.Color.Transparent;
            this.lvl_userID.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_userID.Location = new System.Drawing.Point(15, 64);
            this.lvl_userID.Name = "lvl_userID";
            this.lvl_userID.Size = new System.Drawing.Size(75, 20);
            this.lvl_userID.TabIndex = 25;
            this.lvl_userID.Text = "User ID :";
            // 
            // txbx_UID
            // 
            this.txbx_UID.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_UID.Location = new System.Drawing.Point(96, 61);
            this.txbx_UID.Name = "txbx_UID";
            this.txbx_UID.Size = new System.Drawing.Size(98, 27);
            this.txbx_UID.TabIndex = 24;
            // 
            // Salesman_List_DGV
            // 
            this.Salesman_List_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Salesman_List_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Salesman_List_DGV.Location = new System.Drawing.Point(0, 277);
            this.Salesman_List_DGV.Name = "Salesman_List_DGV";
            this.Salesman_List_DGV.Size = new System.Drawing.Size(700, 243);
            this.Salesman_List_DGV.TabIndex = 42;
            this.Salesman_List_DGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Salesman_List_DGV_RowHeaderMouseClick);
            // 
            // txbx_S_ID
            // 
            this.txbx_S_ID.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_S_ID.Location = new System.Drawing.Point(129, 12);
            this.txbx_S_ID.Name = "txbx_S_ID";
            this.txbx_S_ID.ReadOnly = true;
            this.txbx_S_ID.Size = new System.Drawing.Size(169, 27);
            this.txbx_S_ID.TabIndex = 44;
            // 
            // Salesman
            // 
            this.Salesman.AutoSize = true;
            this.Salesman.BackColor = System.Drawing.Color.Transparent;
            this.Salesman.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salesman.Location = new System.Drawing.Point(18, 15);
            this.Salesman.Name = "Salesman";
            this.Salesman.Size = new System.Drawing.Size(112, 20);
            this.Salesman.TabIndex = 43;
            this.Salesman.Text = "Salesman ID :";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(204, 168);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 27);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(328, 168);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(94, 27);
            this.btn_remove.TabIndex = 46;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Search_txbx1
            // 
            this.Search_txbx1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txbx1.Location = new System.Drawing.Point(302, 210);
            this.Search_txbx1.Name = "Search_txbx1";
            this.Search_txbx1.Size = new System.Drawing.Size(246, 27);
            this.Search_txbx1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Seach";
            // 
            // Owner_Emp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_txbx1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txbx_S_ID);
            this.Controls.Add(this.Salesman);
            this.Controls.Add(this.Salesman_List_DGV);
            this.Controls.Add(this.com_bx_status);
            this.Controls.Add(this.status);
            this.Controls.Add(this.txbx_salary);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.DOB_dt_pic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_email);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.join_dt_pic);
            this.Controls.Add(this.lvl_UserName);
            this.Controls.Add(this.txbx_UName);
            this.Controls.Add(this.lvl_userID);
            this.Controls.Add(this.txbx_UID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Owner_Emp2";
            this.Text = "Owner_Emp2";
            ((System.ComponentModel.ISupportInitialize)(this.Salesman_List_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_bx_status;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox txbx_salary;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.DateTimePicker DOB_dt_pic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker join_dt_pic;
        private System.Windows.Forms.Label lvl_UserName;
        private System.Windows.Forms.TextBox txbx_UName;
        private System.Windows.Forms.Label lvl_userID;
        private System.Windows.Forms.TextBox txbx_UID;
        private System.Windows.Forms.DataGridView Salesman_List_DGV;
        private System.Windows.Forms.TextBox txbx_S_ID;
        private System.Windows.Forms.Label Salesman;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox Search_txbx1;
        private System.Windows.Forms.Label label1;
    }
}