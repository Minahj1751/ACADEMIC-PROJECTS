
namespace Farm_Management_System
{
    partial class Notification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_sender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_subject = new System.Windows.Forms.TextBox();
            this.btn_notification = new System.Windows.Forms.Label();
            this.NotificationDGV = new System.Windows.Forms.DataGridView();
            this.ShowMgs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sender :";
            // 
            // txbx_sender
            // 
            this.txbx_sender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbx_sender.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_sender.Location = new System.Drawing.Point(167, 14);
            this.txbx_sender.Multiline = true;
            this.txbx_sender.Name = "txbx_sender";
            this.txbx_sender.ReadOnly = true;
            this.txbx_sender.Size = new System.Drawing.Size(416, 26);
            this.txbx_sender.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Subject :";
            // 
            // txbx_subject
            // 
            this.txbx_subject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbx_subject.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_subject.Location = new System.Drawing.Point(167, 46);
            this.txbx_subject.Multiline = true;
            this.txbx_subject.Name = "txbx_subject";
            this.txbx_subject.ReadOnly = true;
            this.txbx_subject.Size = new System.Drawing.Size(416, 26);
            this.txbx_subject.TabIndex = 10;
            // 
            // btn_notification
            // 
            this.btn_notification.AutoSize = true;
            this.btn_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notification.Location = new System.Drawing.Point(278, 312);
            this.btn_notification.Name = "btn_notification";
            this.btn_notification.Size = new System.Drawing.Size(150, 31);
            this.btn_notification.TabIndex = 9;
            this.btn_notification.Text = "Notification";
            this.btn_notification.Click += new System.EventHandler(this.btn_notification_Click);
            // 
            // NotificationDGV
            // 
            this.NotificationDGV.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.NotificationDGV.ColumnHeadersHeight = 10;
            this.NotificationDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NotificationDGV.GridColor = System.Drawing.Color.Gray;
            this.NotificationDGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NotificationDGV.Location = new System.Drawing.Point(0, 363);
            this.NotificationDGV.Name = "NotificationDGV";
            this.NotificationDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotificationDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NotificationDGV.Size = new System.Drawing.Size(700, 157);
            this.NotificationDGV.TabIndex = 8;
            this.NotificationDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.NotificationDGV_RowHeaderMouseClick);
            // 
            // ShowMgs
            // 
            this.ShowMgs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowMgs.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMgs.Location = new System.Drawing.Point(167, 80);
            this.ShowMgs.Multiline = true;
            this.ShowMgs.Name = "ShowMgs";
            this.ShowMgs.ReadOnly = true;
            this.ShowMgs.Size = new System.Drawing.Size(416, 218);
            this.ShowMgs.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Message :";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_sender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_subject);
            this.Controls.Add(this.btn_notification);
            this.Controls.Add(this.NotificationDGV);
            this.Controls.Add(this.ShowMgs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Text = "Notification";
            ((System.ComponentModel.ISupportInitialize)(this.NotificationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_sender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_subject;
        private System.Windows.Forms.Label btn_notification;
        private System.Windows.Forms.DataGridView NotificationDGV;
        private System.Windows.Forms.TextBox ShowMgs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}