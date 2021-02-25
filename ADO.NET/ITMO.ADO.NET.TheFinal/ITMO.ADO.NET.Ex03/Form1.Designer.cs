
namespace ITMO.ADO.NET.Ex03
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clientbutton = new System.Windows.Forms.Button();
            this.Employeebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clientbutton
            // 
            this.Clientbutton.Location = new System.Drawing.Point(36, 120);
            this.Clientbutton.Name = "Clientbutton";
            this.Clientbutton.Size = new System.Drawing.Size(128, 40);
            this.Clientbutton.TabIndex = 0;
            this.Clientbutton.Text = "Client";
            this.Clientbutton.UseVisualStyleBackColor = true;
            this.Clientbutton.Click += new System.EventHandler(this.Clientbutton_Click);
            // 
            // Employeebutton
            // 
            this.Employeebutton.Location = new System.Drawing.Point(289, 120);
            this.Employeebutton.Name = "Employeebutton";
            this.Employeebutton.Size = new System.Drawing.Size(114, 40);
            this.Employeebutton.TabIndex = 1;
            this.Employeebutton.Text = "Employee";
            this.Employeebutton.UseVisualStyleBackColor = true;
            this.Employeebutton.Click += new System.EventHandler(this.Employeebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Who are you?";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employeebutton);
            this.Controls.Add(this.Clientbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clientbutton;
        private System.Windows.Forms.Button Employeebutton;
        private System.Windows.Forms.Label label1;
    }
}

