
namespace Employee_Management_System
{
    partial class EmpLeave
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtreason = new System.Windows.Forms.RichTextBox();
            this.btnleave = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Work Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Approved Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Work Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Reason for the Leave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Work Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Leave Requesting Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Work Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee ID";
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Work Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(440, 275);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(317, 27);
            this.txtdate.TabIndex = 15;
            // 
            // txtreason
            // 
            this.txtreason.Font = new System.Drawing.Font("Work Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreason.Location = new System.Drawing.Point(440, 332);
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(317, 96);
            this.txtreason.TabIndex = 14;
            this.txtreason.Text = "";
            // 
            // btnleave
            // 
            this.btnleave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(145)))));
            this.btnleave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnleave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnleave.FlatAppearance.BorderSize = 0;
            this.btnleave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(92)))), ((int)(((byte)(67)))));
            this.btnleave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnleave.Font = new System.Drawing.Font("Work Sans Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleave.ForeColor = System.Drawing.Color.Black;
            this.btnleave.Location = new System.Drawing.Point(463, 547);
            this.btnleave.Name = "btnleave";
            this.btnleave.Size = new System.Drawing.Size(131, 53);
            this.btnleave.TabIndex = 13;
            this.btnleave.Text = "Apply";
            this.btnleave.UseVisualStyleBackColor = false;
            this.btnleave.Click += new System.EventHandler(this.btnleave_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Font = new System.Drawing.Font("Work Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.Location = new System.Drawing.Point(440, 457);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.Size = new System.Drawing.Size(317, 27);
            this.txtstatus.TabIndex = 12;
            this.txtstatus.Text = "Pending";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Work Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(440, 209);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(317, 27);
            this.txtid.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Work Sans", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(145)))));
            this.label13.Location = new System.Drawing.Point(59, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 54);
            this.label13.TabIndex = 81;
            this.label13.Text = "Leave Request";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Work Sans Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(600, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 82;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(982, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtreason);
            this.Controls.Add(this.btnleave);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtid);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EmpLeave";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.RichTextBox txtreason;
        private System.Windows.Forms.Button btnleave;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}