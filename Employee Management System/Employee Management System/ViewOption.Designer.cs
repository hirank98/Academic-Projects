
namespace Employee_Management_System
{
    partial class ViewOption
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
            this.btnmanager = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmanager
            // 
            this.btnmanager.Location = new System.Drawing.Point(438, 168);
            this.btnmanager.Name = "btnmanager";
            this.btnmanager.Size = new System.Drawing.Size(180, 115);
            this.btnmanager.TabIndex = 3;
            this.btnmanager.Text = "Manager";
            this.btnmanager.UseVisualStyleBackColor = true;
            this.btnmanager.Click += new System.EventHandler(this.btnmanager_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(182, 168);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(180, 115);
            this.btnEmp.TabIndex = 2;
            this.btnEmp.Text = "Employee";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // ViewOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmanager);
            this.Controls.Add(this.btnEmp);
            this.Name = "ViewOption";
            this.Text = "ViewOption";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmanager;
        private System.Windows.Forms.Button btnEmp;
    }
}