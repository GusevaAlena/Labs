namespace ITMO.Lab03.Ex4
{
    partial class FormRegistration
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
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.richTextBoxUserInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataUserControl1 = new ITMO.Lab03.Ex4.DataUserControl();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(109, 361);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(238, 48);
            this.buttonRegistration.TabIndex = 1;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // richTextBoxUserInfo
            // 
            this.richTextBoxUserInfo.Location = new System.Drawing.Point(465, 46);
            this.richTextBoxUserInfo.Name = "richTextBoxUserInfo";
            this.richTextBoxUserInfo.Size = new System.Drawing.Size(396, 363);
            this.richTextBoxUserInfo.TabIndex = 2;
            this.richTextBoxUserInfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Информация о пользователе:";
            // 
            // dataUserControl1
            // 
            this.dataUserControl1.BirthDay = new System.DateTime(2020, 12, 6, 2, 22, 35, 638);
            this.dataUserControl1.Email = "";
            this.dataUserControl1.FirstName = "";
            this.dataUserControl1.LastName = "";
            this.dataUserControl1.Location = new System.Drawing.Point(12, 12);
            this.dataUserControl1.Name = "dataUserControl1";
            this.dataUserControl1.Size = new System.Drawing.Size(408, 324);
            this.dataUserControl1.TabIndex = 4;
            this.dataUserControl1.TelNumber = "";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 451);
            this.Controls.Add(this.dataUserControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxUserInfo);
            this.Controls.Add(this.buttonRegistration);
            this.Name = "FormRegistration";
            this.Text = "Регистрация пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.RichTextBox richTextBoxUserInfo;
        private System.Windows.Forms.Label label1;
        private DataUserControl dataUserControl1;
    }
}

