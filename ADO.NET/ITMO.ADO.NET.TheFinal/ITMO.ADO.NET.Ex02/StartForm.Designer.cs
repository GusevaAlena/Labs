
namespace ITMO.ADO.NET.Ex02
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClientFormbutton = new System.Windows.Forms.Button();
            this.EmployeeFormbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Who are you?";
            // 
            // ClientFormbutton
            // 
            this.ClientFormbutton.Location = new System.Drawing.Point(36, 108);
            this.ClientFormbutton.Name = "ClientFormbutton";
            this.ClientFormbutton.Size = new System.Drawing.Size(95, 40);
            this.ClientFormbutton.TabIndex = 1;
            this.ClientFormbutton.Text = "Client";
            this.ClientFormbutton.UseVisualStyleBackColor = true;
            this.ClientFormbutton.Click += new System.EventHandler(this.ClientFormbutton_Click);
            // 
            // EmployeeFormbutton
            // 
            this.EmployeeFormbutton.Location = new System.Drawing.Point(252, 108);
            this.EmployeeFormbutton.Name = "EmployeeFormbutton";
            this.EmployeeFormbutton.Size = new System.Drawing.Size(95, 40);
            this.EmployeeFormbutton.TabIndex = 2;
            this.EmployeeFormbutton.Text = "Employee";
            this.EmployeeFormbutton.UseVisualStyleBackColor = true;
            this.EmployeeFormbutton.Click += new System.EventHandler(this.EmployeeFormbutton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 197);
            this.Controls.Add(this.EmployeeFormbutton);
            this.Controls.Add(this.ClientFormbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClientFormbutton;
        private System.Windows.Forms.Button EmployeeFormbutton;
    }
}