namespace Vehicle_and_Emaployee_Management_System
{
    partial class Admin_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Interface));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vehicleManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDeailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleManagementToolStripMenuItem,
            this.employeeManagementToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vehicleManagementToolStripMenuItem
            // 
            this.vehicleManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterDetailsToolStripMenuItem,
            this.manageDeailsToolStripMenuItem});
            this.vehicleManagementToolStripMenuItem.Name = "vehicleManagementToolStripMenuItem";
            this.vehicleManagementToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.vehicleManagementToolStripMenuItem.Text = "Vehicle Management ";
            this.vehicleManagementToolStripMenuItem.Click += new System.EventHandler(this.vehicleManagementToolStripMenuItem_Click);
            // 
            // enterDetailsToolStripMenuItem
            // 
            this.enterDetailsToolStripMenuItem.Name = "enterDetailsToolStripMenuItem";
            this.enterDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enterDetailsToolStripMenuItem.Text = "Enter Details";
            this.enterDetailsToolStripMenuItem.Click += new System.EventHandler(this.enterDetailsToolStripMenuItem_Click);
            // 
            // manageDeailsToolStripMenuItem
            // 
            this.manageDeailsToolStripMenuItem.Name = "manageDeailsToolStripMenuItem";
            this.manageDeailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageDeailsToolStripMenuItem.Text = "Manage Deails";
            this.manageDeailsToolStripMenuItem.Click += new System.EventHandler(this.manageDeailsToolStripMenuItem_Click);
            // 
            // employeeManagementToolStripMenuItem
            // 
            this.employeeManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterDetailsToolStripMenuItem1,
            this.manageDetailsToolStripMenuItem,
            this.salaryCalculatorToolStripMenuItem});
            this.employeeManagementToolStripMenuItem.Name = "employeeManagementToolStripMenuItem";
            this.employeeManagementToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.employeeManagementToolStripMenuItem.Text = "Employee Management";
            this.employeeManagementToolStripMenuItem.Click += new System.EventHandler(this.employeeManagementToolStripMenuItem_Click);
            // 
            // enterDetailsToolStripMenuItem1
            // 
            this.enterDetailsToolStripMenuItem1.Name = "enterDetailsToolStripMenuItem1";
            this.enterDetailsToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.enterDetailsToolStripMenuItem1.Text = "Enter Details ";
            this.enterDetailsToolStripMenuItem1.Click += new System.EventHandler(this.enterDetailsToolStripMenuItem1_Click);
            // 
            // manageDetailsToolStripMenuItem
            // 
            this.manageDetailsToolStripMenuItem.Name = "manageDetailsToolStripMenuItem";
            this.manageDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.manageDetailsToolStripMenuItem.Text = "Manage Details";
            this.manageDetailsToolStripMenuItem.Click += new System.EventHandler(this.manageDetailsToolStripMenuItem_Click);
            // 
            // salaryCalculatorToolStripMenuItem
            // 
            this.salaryCalculatorToolStripMenuItem.Name = "salaryCalculatorToolStripMenuItem";
            this.salaryCalculatorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.salaryCalculatorToolStripMenuItem.Text = "Salary Calculator";
            this.salaryCalculatorToolStripMenuItem.Click += new System.EventHandler(this.salaryCalculatorToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Admin_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 517);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_Interface";
            this.Text = "Admin_Interface";
            this.Load += new System.EventHandler(this.Admin_Interface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vehicleManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDeailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}