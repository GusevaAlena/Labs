
namespace ITMO.ADO.NET.Ex02
{
    partial class ClientForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getproductsButton = new System.Windows.Forms.Button();
            this.ProductslistBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(528, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // getproductsButton
            // 
            this.getproductsButton.Location = new System.Drawing.Point(588, 63);
            this.getproductsButton.Name = "getproductsButton";
            this.getproductsButton.Size = new System.Drawing.Size(174, 44);
            this.getproductsButton.TabIndex = 1;
            this.getproductsButton.Text = "Get Products";
            this.getproductsButton.UseVisualStyleBackColor = true;
            this.getproductsButton.Click += new System.EventHandler(this.getproductsButton_Click);
            // 
            // ProductslistBox
            // 
            this.ProductslistBox.FormattingEnabled = true;
            this.ProductslistBox.ItemHeight = 20;
            this.ProductslistBox.Location = new System.Drawing.Point(12, 13);
            this.ProductslistBox.Name = "ProductslistBox";
            this.ProductslistBox.Size = new System.Drawing.Size(539, 464);
            this.ProductslistBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.ProductslistBox);
            this.Controls.Add(this.getproductsButton);
            this.Name = "ClientForm";
            this.Text = "Products for clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getproductsButton;
        private System.Windows.Forms.ListBox ProductslistBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

