
namespace ITMO.ADO.NET.Ex04
{
    partial class Library
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
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumbtextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BooksradioButton = new System.Windows.Forms.RadioButton();
            this.ReadersradioButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.Showbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.Location = new System.Drawing.Point(193, 21);
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(200, 26);
            this.LastNametextBox.TabIndex = 0;
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(193, 53);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(200, 26);
            this.FirstNametextBox.TabIndex = 1;
            // 
            // PhoneNumbtextBox
            // 
            this.PhoneNumbtextBox.Location = new System.Drawing.Point(193, 117);
            this.PhoneNumbtextBox.Name = "PhoneNumbtextBox";
            this.PhoneNumbtextBox.Size = new System.Drawing.Size(200, 26);
            this.PhoneNumbtextBox.TabIndex = 3;
            // 
            // dateOfBirthTimePicker
            // 
            this.dateOfBirthTimePicker.Location = new System.Drawing.Point(193, 85);
            this.dateOfBirthTimePicker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthTimePicker.Name = "dateOfBirthTimePicker";
            this.dateOfBirthTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateOfBirthTimePicker.TabIndex = 4;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(193, 149);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(200, 26);
            this.EmailtextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Контактный телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "e-mail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BooksradioButton);
            this.groupBox1.Controls.Add(this.ReadersradioButton);
            this.groupBox1.Location = new System.Drawing.Point(411, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 57);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            // 
            // BooksradioButton
            // 
            this.BooksradioButton.AutoSize = true;
            this.BooksradioButton.Location = new System.Drawing.Point(278, 26);
            this.BooksradioButton.Name = "BooksradioButton";
            this.BooksradioButton.Size = new System.Drawing.Size(78, 24);
            this.BooksradioButton.TabIndex = 1;
            this.BooksradioButton.TabStop = true;
            this.BooksradioButton.Text = "Книги";
            this.BooksradioButton.UseVisualStyleBackColor = true;
            // 
            // ReadersradioButton
            // 
            this.ReadersradioButton.AutoSize = true;
            this.ReadersradioButton.Location = new System.Drawing.Point(13, 25);
            this.ReadersradioButton.Name = "ReadersradioButton";
            this.ReadersradioButton.Size = new System.Drawing.Size(110, 24);
            this.ReadersradioButton.TabIndex = 0;
            this.ReadersradioButton.TabStop = true;
            this.ReadersradioButton.Text = "Читатели";
            this.ReadersradioButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(424, 24);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(169, 61);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить данные";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(608, 24);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(183, 61);
            this.Showbutton.TabIndex = 13;
            this.Showbutton.Text = "Показать данные";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 274);
            this.dataGridView1.TabIndex = 14;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.dateOfBirthTimePicker);
            this.Controls.Add(this.PhoneNumbtextBox);
            this.Controls.Add(this.FirstNametextBox);
            this.Controls.Add(this.LastNametextBox);
            this.Name = "Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastNametextBox;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.TextBox PhoneNumbtextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthTimePicker;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BooksradioButton;
        private System.Windows.Forms.RadioButton ReadersradioButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

