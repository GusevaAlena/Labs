
namespace ITMO.ADO.NET.DBCommand
{
    partial class Form1
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.button1_query = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.button2_BQuery = new System.Windows.Forms.Button();
            this.button3_StProc = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.button4_CreateTable = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.button5_QueryWithParam = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.button6_StProcParam = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=" +
    "True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT CustomerID, CompanyName\r\nFROM   Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // button1_query
            // 
            this.button1_query.Location = new System.Drawing.Point(12, 25);
            this.button1_query.Name = "button1_query";
            this.button1_query.Size = new System.Drawing.Size(167, 49);
            this.button1_query.TabIndex = 0;
            this.button1_query.Text = "Запрос данных";
            this.button1_query.UseVisualStyleBackColor = true;
            this.button1_query.Click += new System.EventHandler(this.button1_query_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 177);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(730, 250);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // button2_BQuery
            // 
            this.button2_BQuery.Location = new System.Drawing.Point(196, 25);
            this.button2_BQuery.Name = "button2_BQuery";
            this.button2_BQuery.Size = new System.Drawing.Size(201, 49);
            this.button2_BQuery.TabIndex = 2;
            this.button2_BQuery.Text = "Пакетный запрос";
            this.button2_BQuery.UseVisualStyleBackColor = true;
            this.button2_BQuery.Click += new System.EventHandler(this.button2_BQuery_Click);
            // 
            // button3_StProc
            // 
            this.button3_StProc.Location = new System.Drawing.Point(12, 96);
            this.button3_StProc.Name = "button3_StProc";
            this.button3_StProc.Size = new System.Drawing.Size(164, 49);
            this.button3_StProc.TabIndex = 3;
            this.button3_StProc.Text = "Вызов процедуры";
            this.button3_StProc.UseVisualStyleBackColor = true;
            this.button3_StProc.Click += new System.EventHandler(this.button3_StProc_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "Ten Most Expensive Products";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // button4_CreateTable
            // 
            this.button4_CreateTable.Location = new System.Drawing.Point(196, 96);
            this.button4_CreateTable.Name = "button4_CreateTable";
            this.button4_CreateTable.Size = new System.Drawing.Size(201, 49);
            this.button4_CreateTable.TabIndex = 4;
            this.button4_CreateTable.Text = "Создание таблицы";
            this.button4_CreateTable.UseVisualStyleBackColor = true;
            this.button4_CreateTable.Click += new System.EventHandler(this.button4_CreateTable_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // button5_QueryWithParam
            // 
            this.button5_QueryWithParam.Location = new System.Drawing.Point(428, 26);
            this.button5_QueryWithParam.Name = "button5_QueryWithParam";
            this.button5_QueryWithParam.Size = new System.Drawing.Size(181, 53);
            this.button5_QueryWithParam.TabIndex = 5;
            this.button5_QueryWithParam.Text = "Запрос с параметром";
            this.button5_QueryWithParam.UseVisualStyleBackColor = true;
            this.button5_QueryWithParam.Click += new System.EventHandler(this.button5_QueryWithParam_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(642, 26);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 26);
            this.CityTextBox.TabIndex = 6;
            this.CityTextBox.Text = "London";
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT CustomerID, CompanyName, City\r\nFROM   Customers\r\nWHERE (City = @City)";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar)});
            // 
            // button6_StProcParam
            // 
            this.button6_StProcParam.Location = new System.Drawing.Point(428, 91);
            this.button6_StProcParam.Name = "button6_StProcParam";
            this.button6_StProcParam.Size = new System.Drawing.Size(181, 59);
            this.button6_StProcParam.TabIndex = 7;
            this.button6_StProcParam.Text = "Процедура с параметром";
            this.button6_StProcParam.UseVisualStyleBackColor = true;
            this.button6_StProcParam.Click += new System.EventHandler(this.button6_StProcParam_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(642, 91);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.CategoryNameTextBox.TabIndex = 8;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(642, 124);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(100, 26);
            this.OrdYearTextBox.TabIndex = 9;
            this.OrdYearTextBox.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.button6_StProcParam);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.button5_QueryWithParam);
            this.Controls.Add(this.button4_CreateTable);
            this.Controls.Add(this.button3_StProc);
            this.Controls.Add(this.button2_BQuery);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.button1_query);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button button1_query;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button button2_BQuery;
        private System.Windows.Forms.Button button3_StProc;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button button4_CreateTable;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Button button5_QueryWithParam;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button button6_StProcParam;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox OrdYearTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}

