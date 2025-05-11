
namespace Farm_Management_System
{
    partial class Farmer
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.picbx_Farmer_profile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Livestock_panel = new System.Windows.Forms.Panel();
            this.gbtn_Chicken = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_Livestock = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_Cows = new Guna.UI2.WinForms.Guna2Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.transaction_panel = new System.Windows.Forms.Panel();
            this.gbtn_Expend = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_Transaction = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_Income = new Guna.UI2.WinForms.Guna2Button();
            this.production_panel = new System.Windows.Forms.Panel();
            this.gbtn_Egg = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_Production = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_Milk = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_CPassword = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_notification = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_health_report = new Guna.UI2.WinForms.Guna2Button();
            this.Livestocktimer = new System.Windows.Forms.Timer(this.components);
            this.Transactiontimer = new System.Windows.Forms.Timer(this.components);
            this.Productiontimer = new System.Windows.Forms.Timer(this.components);
            this.F_mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Farmer_profile)).BeginInit();
            this.panel2.SuspendLayout();
            this.Livestock_panel.SuspendLayout();
            this.transaction_panel.SuspendLayout();
            this.production_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.picbx_Farmer_profile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 37);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(855, 1);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(48, 31);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // picbx_Farmer_profile
            // 
            this.picbx_Farmer_profile.Image = global::Farm_Management_System.Properties.Resources.Owner;
            this.picbx_Farmer_profile.Location = new System.Drawing.Point(4, 2);
            this.picbx_Farmer_profile.Name = "picbx_Farmer_profile";
            this.picbx_Farmer_profile.Size = new System.Drawing.Size(39, 31);
            this.picbx_Farmer_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_Farmer_profile.TabIndex = 2;
            this.picbx_Farmer_profile.TabStop = false;
            this.picbx_Farmer_profile.Click += new System.EventHandler(this.picbx_Farmer_profile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Farmer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.Livestock_panel);
            this.panel2.Controls.Add(this.mainpanel);
            this.panel2.Controls.Add(this.transaction_panel);
            this.panel2.Controls.Add(this.production_panel);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.gbtn_logout);
            this.panel2.Controls.Add(this.gbtn_CPassword);
            this.panel2.Controls.Add(this.gbtn_notification);
            this.panel2.Controls.Add(this.gbtn_health_report);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 524);
            this.panel2.TabIndex = 2;
            // 
            // Livestock_panel
            // 
            this.Livestock_panel.BackColor = System.Drawing.Color.Transparent;
            this.Livestock_panel.Controls.Add(this.gbtn_Chicken);
            this.Livestock_panel.Controls.Add(this.gbtn_Livestock);
            this.Livestock_panel.Controls.Add(this.gbtn_Cows);
            this.Livestock_panel.Location = new System.Drawing.Point(12, 16);
            this.Livestock_panel.MaximumSize = new System.Drawing.Size(183, 138);
            this.Livestock_panel.MinimumSize = new System.Drawing.Size(183, 51);
            this.Livestock_panel.Name = "Livestock_panel";
            this.Livestock_panel.Size = new System.Drawing.Size(183, 51);
            this.Livestock_panel.TabIndex = 18;
            // 
            // gbtn_Chicken
            // 
            this.gbtn_Chicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_Chicken.BorderColor = System.Drawing.Color.Gray;
            this.gbtn_Chicken.BorderRadius = 20;
            this.gbtn_Chicken.BorderThickness = 2;
            this.gbtn_Chicken.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Chicken.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Chicken.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Chicken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Chicken.FillColor = System.Drawing.Color.DarkOrange;
            this.gbtn_Chicken.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_Chicken.ForeColor = System.Drawing.Color.White;
            this.gbtn_Chicken.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_Chicken.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_Chicken.Location = new System.Drawing.Point(0, 94);
            this.gbtn_Chicken.Name = "gbtn_Chicken";
            this.gbtn_Chicken.Size = new System.Drawing.Size(183, 44);
            this.gbtn_Chicken.TabIndex = 5;
            this.gbtn_Chicken.Text = "Chicken";
            this.gbtn_Chicken.Click += new System.EventHandler(this.gbtn_Chicken_Click);
            // 
            // gbtn_Livestock
            // 
            this.gbtn_Livestock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_Livestock.BorderColor = System.Drawing.Color.DimGray;
            this.gbtn_Livestock.BorderRadius = 23;
            this.gbtn_Livestock.BorderThickness = 2;
            this.gbtn_Livestock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Livestock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Livestock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Livestock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Livestock.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbtn_Livestock.FillColor = System.Drawing.Color.White;
            this.gbtn_Livestock.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_Livestock.ForeColor = System.Drawing.Color.Black;
            this.gbtn_Livestock.Image = global::Farm_Management_System.Properties.Resources.rsz_dropdown___copy;
            this.gbtn_Livestock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gbtn_Livestock.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_Livestock.Location = new System.Drawing.Point(0, 0);
            this.gbtn_Livestock.Name = "gbtn_Livestock";
            this.gbtn_Livestock.Size = new System.Drawing.Size(183, 51);
            this.gbtn_Livestock.TabIndex = 2;
            this.gbtn_Livestock.Text = "Livestock";
            this.gbtn_Livestock.Click += new System.EventHandler(this.gbtn_Livestock_Click_1);
            // 
            // gbtn_Cows
            // 
            this.gbtn_Cows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_Cows.BorderColor = System.Drawing.Color.Gray;
            this.gbtn_Cows.BorderRadius = 20;
            this.gbtn_Cows.BorderThickness = 2;
            this.gbtn_Cows.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Cows.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Cows.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Cows.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Cows.FillColor = System.Drawing.Color.DarkOrange;
            this.gbtn_Cows.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_Cows.ForeColor = System.Drawing.Color.White;
            this.gbtn_Cows.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_Cows.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_Cows.Location = new System.Drawing.Point(0, 51);
            this.gbtn_Cows.Name = "gbtn_Cows";
            this.gbtn_Cows.Size = new System.Drawing.Size(183, 44);
            this.gbtn_Cows.TabIndex = 6;
            this.gbtn_Cows.Text = "Cows";
            this.gbtn_Cows.Click += new System.EventHandler(this.gbtn_Cows_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel.Location = new System.Drawing.Point(203, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(700, 520);
            this.mainpanel.TabIndex = 3;
            // 
            // transaction_panel
            // 
            this.transaction_panel.BackColor = System.Drawing.Color.Transparent;
            this.transaction_panel.Controls.Add(this.gbtn_Expend);
            this.transaction_panel.Controls.Add(this.gbtn_Transaction);
            this.transaction_panel.Controls.Add(this.gbtn_Income);
            this.transaction_panel.Location = new System.Drawing.Point(12, 73);
            this.transaction_panel.MaximumSize = new System.Drawing.Size(183, 138);
            this.transaction_panel.MinimumSize = new System.Drawing.Size(183, 51);
            this.transaction_panel.Name = "transaction_panel";
            this.transaction_panel.Size = new System.Drawing.Size(183, 51);
            this.transaction_panel.TabIndex = 16;
            // 
            // gbtn_Expend
            // 
            this.gbtn_Expend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_Expend.BorderColor = System.Drawing.Color.Gray;
            this.gbtn_Expend.BorderRadius = 20;
            this.gbtn_Expend.BorderThickness = 2;
            this.gbtn_Expend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Expend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Expend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Expend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Expend.FillColor = System.Drawing.Color.DarkOrange;
            this.gbtn_Expend.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_Expend.ForeColor = System.Drawing.Color.White;
            this.gbtn_Expend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_Expend.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_Expend.Location = new System.Drawing.Point(0, 94);
            this.gbtn_Expend.Name = "gbtn_Expend";
            this.gbtn_Expend.Size = new System.Drawing.Size(183, 44);
            this.gbtn_Expend.TabIndex = 5;
            this.gbtn_Expend.Text = "Expend";
            this.gbtn_Expend.Click += new System.EventHandler(this.gbtn_Expend_Click);
            // 
            // gbtn_Transaction
            // 
            this.gbtn_Transaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_Transaction.BorderColor = System.Drawing.Color.DimGray;
            this.gbtn_Transaction.BorderRadius = 23;
            this.gbtn_Transaction.BorderThickness = 2;
            this.gbtn_Transaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Transaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Transaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Transaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Transaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbtn_Transaction.FillColor = System.Drawing.Color.White;
            this.gbtn_Transaction.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_Transaction.ForeColor = System.Drawing.Color.Black;
            this.gbtn_Transaction.Image = global::Farm_Management_System.Properties.Resources.rsz_dropdown___copy;
            this.gbtn_Transaction.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gbtn_Transaction.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_Transaction.Location = new System.Drawing.Point(0, 0);
            this.gbtn_Transaction.Name = "gbtn_Transaction";
            this.gbtn_Transaction.Size = new System.Drawing.Size(183, 51);
            this.gbtn_Transaction.TabIndex = 2;
            this.gbtn_Transaction.Text = "Transaction";
            this.gbtn_Transaction.Click += new System.EventHandler(this.gbtn_Transaction_Click);
            // 
            // gbtn_Income
            // 
            this.gbtn_Income.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_Income.BorderColor = System.Drawing.Color.Gray;
            this.gbtn_Income.BorderRadius = 20;
            this.gbtn_Income.BorderThickness = 2;
            this.gbtn_Income.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Income.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Income.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Income.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Income.FillColor = System.Drawing.Color.DarkOrange;
            this.gbtn_Income.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_Income.ForeColor = System.Drawing.Color.White;
            this.gbtn_Income.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_Income.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_Income.Location = new System.Drawing.Point(0, 49);
            this.gbtn_Income.Name = "gbtn_Income";
            this.gbtn_Income.Size = new System.Drawing.Size(183, 44);
            this.gbtn_Income.TabIndex = 6;
            this.gbtn_Income.Text = "Income";
            this.gbtn_Income.Click += new System.EventHandler(this.gbtn_Income_Click);
            // 
            // production_panel
            // 
            this.production_panel.BackColor = System.Drawing.Color.Transparent;
            this.production_panel.Controls.Add(this.gbtn_Egg);
            this.production_panel.Controls.Add(this.gbtn_Production);
            this.production_panel.Controls.Add(this.gbtn_Milk);
            this.production_panel.Location = new System.Drawing.Point(12, 126);
            this.production_panel.MaximumSize = new System.Drawing.Size(183, 138);
            this.production_panel.MinimumSize = new System.Drawing.Size(183, 51);
            this.production_panel.Name = "production_panel";
            this.production_panel.Size = new System.Drawing.Size(183, 51);
            this.production_panel.TabIndex = 15;
            // 
            // gbtn_Egg
            // 
            this.gbtn_Egg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_Egg.BorderColor = System.Drawing.Color.Gray;
            this.gbtn_Egg.BorderRadius = 20;
            this.gbtn_Egg.BorderThickness = 2;
            this.gbtn_Egg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Egg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Egg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Egg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Egg.FillColor = System.Drawing.Color.DarkOrange;
            this.gbtn_Egg.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_Egg.ForeColor = System.Drawing.Color.White;
            this.gbtn_Egg.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_Egg.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_Egg.Location = new System.Drawing.Point(0, 94);
            this.gbtn_Egg.Name = "gbtn_Egg";
            this.gbtn_Egg.Size = new System.Drawing.Size(183, 44);
            this.gbtn_Egg.TabIndex = 5;
            this.gbtn_Egg.Text = "Egg";
            this.gbtn_Egg.Click += new System.EventHandler(this.gbtn_Egg_Click);
            // 
            // gbtn_Production
            // 
            this.gbtn_Production.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_Production.BorderColor = System.Drawing.Color.DimGray;
            this.gbtn_Production.BorderRadius = 23;
            this.gbtn_Production.BorderThickness = 2;
            this.gbtn_Production.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Production.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Production.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Production.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Production.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbtn_Production.FillColor = System.Drawing.Color.White;
            this.gbtn_Production.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_Production.ForeColor = System.Drawing.Color.Black;
            this.gbtn_Production.Image = global::Farm_Management_System.Properties.Resources.rsz_dropdown___copy;
            this.gbtn_Production.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gbtn_Production.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_Production.Location = new System.Drawing.Point(0, 0);
            this.gbtn_Production.Name = "gbtn_Production";
            this.gbtn_Production.Size = new System.Drawing.Size(183, 51);
            this.gbtn_Production.TabIndex = 2;
            this.gbtn_Production.Text = "Production";
            this.gbtn_Production.Click += new System.EventHandler(this.gbtn_Production_Click);
            // 
            // gbtn_Milk
            // 
            this.gbtn_Milk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_Milk.BorderColor = System.Drawing.Color.Gray;
            this.gbtn_Milk.BorderRadius = 20;
            this.gbtn_Milk.BorderThickness = 2;
            this.gbtn_Milk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Milk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Milk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Milk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Milk.FillColor = System.Drawing.Color.DarkOrange;
            this.gbtn_Milk.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_Milk.ForeColor = System.Drawing.Color.White;
            this.gbtn_Milk.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_Milk.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_Milk.Location = new System.Drawing.Point(0, 49);
            this.gbtn_Milk.Name = "gbtn_Milk";
            this.gbtn_Milk.Size = new System.Drawing.Size(183, 44);
            this.gbtn_Milk.TabIndex = 6;
            this.gbtn_Milk.Text = "Milk";
            this.gbtn_Milk.Click += new System.EventHandler(this.gbtn_Milk_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button1.BorderRadius = 23;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Century", 14.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::Farm_Management_System.Properties.Resources.Notification;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(12, 285);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Size = new System.Drawing.Size(180, 48);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Mail";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // gbtn_logout
            // 
            this.gbtn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_logout.BorderColor = System.Drawing.Color.DimGray;
            this.gbtn_logout.BorderRadius = 23;
            this.gbtn_logout.BorderThickness = 2;
            this.gbtn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_logout.FillColor = System.Drawing.Color.White;
            this.gbtn_logout.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_logout.ForeColor = System.Drawing.Color.Black;
            this.gbtn_logout.Image = global::Farm_Management_System.Properties.Resources.Logout;
            this.gbtn_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_logout.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtn_logout.Location = new System.Drawing.Point(12, 388);
            this.gbtn_logout.Name = "gbtn_logout";
            this.gbtn_logout.Size = new System.Drawing.Size(180, 48);
            this.gbtn_logout.TabIndex = 8;
            this.gbtn_logout.Text = "Logout";
            this.gbtn_logout.Click += new System.EventHandler(this.gbtn_logout_Click);
            // 
            // gbtn_CPassword
            // 
            this.gbtn_CPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_CPassword.BorderColor = System.Drawing.Color.DimGray;
            this.gbtn_CPassword.BorderRadius = 23;
            this.gbtn_CPassword.BorderThickness = 2;
            this.gbtn_CPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_CPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_CPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_CPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_CPassword.FillColor = System.Drawing.Color.White;
            this.gbtn_CPassword.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_CPassword.ForeColor = System.Drawing.Color.Black;
            this.gbtn_CPassword.Image = global::Farm_Management_System.Properties.Resources.password;
            this.gbtn_CPassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_CPassword.ImageSize = new System.Drawing.Size(25, 25);
            this.gbtn_CPassword.Location = new System.Drawing.Point(12, 334);
            this.gbtn_CPassword.Name = "gbtn_CPassword";
            this.gbtn_CPassword.Size = new System.Drawing.Size(180, 52);
            this.gbtn_CPassword.TabIndex = 7;
            this.gbtn_CPassword.Text = "Change Password";
            this.gbtn_CPassword.Click += new System.EventHandler(this.gbtn_CPassword_Click);
            // 
            // gbtn_notification
            // 
            this.gbtn_notification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbtn_notification.BorderColor = System.Drawing.Color.DimGray;
            this.gbtn_notification.BorderRadius = 23;
            this.gbtn_notification.BorderThickness = 2;
            this.gbtn_notification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_notification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_notification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_notification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_notification.FillColor = System.Drawing.Color.White;
            this.gbtn_notification.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_notification.ForeColor = System.Drawing.Color.Black;
            this.gbtn_notification.Image = global::Farm_Management_System.Properties.Resources.Notification;
            this.gbtn_notification.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_notification.ImageSize = new System.Drawing.Size(23, 23);
            this.gbtn_notification.IndicateFocus = true;
            this.gbtn_notification.Location = new System.Drawing.Point(12, 235);
            this.gbtn_notification.Name = "gbtn_notification";
            this.gbtn_notification.PressedColor = System.Drawing.Color.DimGray;
            this.gbtn_notification.Size = new System.Drawing.Size(180, 48);
            this.gbtn_notification.TabIndex = 5;
            this.gbtn_notification.Text = "Notification";
            this.gbtn_notification.Click += new System.EventHandler(this.gbtn_notification_Click);
            // 
            // gbtn_health_report
            // 
            this.gbtn_health_report.BorderColor = System.Drawing.Color.DimGray;
            this.gbtn_health_report.BorderRadius = 23;
            this.gbtn_health_report.BorderThickness = 2;
            this.gbtn_health_report.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_health_report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_health_report.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_health_report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_health_report.FillColor = System.Drawing.Color.White;
            this.gbtn_health_report.Font = new System.Drawing.Font("Century", 14.25F);
            this.gbtn_health_report.ForeColor = System.Drawing.Color.Black;
            this.gbtn_health_report.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbtn_health_report.Location = new System.Drawing.Point(12, 183);
            this.gbtn_health_report.Name = "gbtn_health_report";
            this.gbtn_health_report.Size = new System.Drawing.Size(180, 51);
            this.gbtn_health_report.TabIndex = 3;
            this.gbtn_health_report.Text = "Health Report";
            this.gbtn_health_report.Click += new System.EventHandler(this.gbtn_health_report_Click);
            // 
            // Livestocktimer
            // 
            this.Livestocktimer.Interval = 1;
            this.Livestocktimer.Tick += new System.EventHandler(this.Livestocktimer_Tick);
            // 
            // Transactiontimer
            // 
            this.Transactiontimer.Interval = 1;
            this.Transactiontimer.Tick += new System.EventHandler(this.Transactiontimer_Tick);
            // 
            // Productiontimer
            // 
            this.Productiontimer.Interval = 1;
            this.Productiontimer.Tick += new System.EventHandler(this.Productiontimer_Tick);
            // 
            // F_mainpanel
            // 
            this.F_mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.F_mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F_mainpanel.Location = new System.Drawing.Point(204, 37);
            this.F_mainpanel.Name = "F_mainpanel";
            this.F_mainpanel.Size = new System.Drawing.Size(700, 520);
            this.F_mainpanel.TabIndex = 3;
            // 
            // Farmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Management_System.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 561);
            this.Controls.Add(this.F_mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Farmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmer";
            this.Load += new System.EventHandler(this.Farmer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Farmer_profile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.Livestock_panel.ResumeLayout(false);
            this.transaction_panel.ResumeLayout(false);
            this.production_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picbx_Farmer_profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button gbtn_logout;
        private Guna.UI2.WinForms.Guna2Button gbtn_CPassword;
        private Guna.UI2.WinForms.Guna2Button gbtn_notification;
        private System.Windows.Forms.Button btn_Exit;
        private Guna.UI2.WinForms.Guna2Button gbtn_health_report;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel transaction_panel;
        private Guna.UI2.WinForms.Guna2Button gbtn_Expend;
        private Guna.UI2.WinForms.Guna2Button gbtn_Transaction;
        private Guna.UI2.WinForms.Guna2Button gbtn_Income;
        private System.Windows.Forms.Panel production_panel;
        private Guna.UI2.WinForms.Guna2Button gbtn_Egg;
        private Guna.UI2.WinForms.Guna2Button gbtn_Production;
        private Guna.UI2.WinForms.Guna2Button gbtn_Milk;
        private System.Windows.Forms.Panel Livestock_panel;
        private Guna.UI2.WinForms.Guna2Button gbtn_Chicken;
        private Guna.UI2.WinForms.Guna2Button gbtn_Livestock;
        private Guna.UI2.WinForms.Guna2Button gbtn_Cows;
        private System.Windows.Forms.Timer Livestocktimer;
        private System.Windows.Forms.Timer Transactiontimer;
        private System.Windows.Forms.Timer Productiontimer;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel F_mainpanel;
        private System.Windows.Forms.Label label2;
    }
}