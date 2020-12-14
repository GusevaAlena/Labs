namespace ITMO.Lab03.Ex4
{
    partial class DataUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelTelNumb = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxFirtsName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxTelNumb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(193, 26);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(181, 26);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastName_Validating);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(60, 86);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(40, 20);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "Имя";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(60, 32);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(81, 20);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelTelNumb
            // 
            this.labelTelNumb.AutoSize = true;
            this.labelTelNumb.Location = new System.Drawing.Point(60, 217);
            this.labelTelNumb.Name = "labelTelNumb";
            this.labelTelNumb.Size = new System.Drawing.Size(79, 20);
            this.labelTelNumb.TabIndex = 5;
            this.labelTelNumb.Text = "Телефон";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(193, 271);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(181, 26);
            this.textBoxMail.TabIndex = 6;
            this.textBoxMail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMail_Validating);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(60, 277);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(53, 20);
            this.labelMail.TabIndex = 7;
            this.labelMail.Text = "E-mail";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(60, 154);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(128, 20);
            this.labelBirthDay.TabIndex = 11;
            this.labelBirthDay.Text = "Дата рождения";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxFirtsName
            // 
            this.textBoxFirtsName.Location = new System.Drawing.Point(193, 80);
            this.textBoxFirtsName.Name = "textBoxFirtsName";
            this.textBoxFirtsName.Size = new System.Drawing.Size(181, 26);
            this.textBoxFirtsName.TabIndex = 12;
            this.textBoxFirtsName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFirtsName_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 147);
            this.dateTimePicker1.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 26);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // textBoxTelNumb
            // 
            this.textBoxTelNumb.Location = new System.Drawing.Point(193, 212);
            this.textBoxTelNumb.Name = "textBoxTelNumb";
            this.textBoxTelNumb.Size = new System.Drawing.Size(182, 26);
            this.textBoxTelNumb.TabIndex = 17;
            this.textBoxTelNumb.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelNumb_Validating);
            // 
            // DataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTelNumb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxFirtsName);
            this.Controls.Add(this.labelBirthDay);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelTelNumb);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Name = "DataUserControl";
            this.Size = new System.Drawing.Size(408, 324);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelTelNumb;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxFirtsName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxTelNumb;
    }
}
