
namespace SimpleCalculator
{
    partial class EngiCalc
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
            this.components = new System.ComponentModel.Container();
            this.stepen_btn = new System.Windows.Forms.Button();
            this.sqrt_btn = new System.Windows.Forms.Button();
            this.sqrt3_btn = new System.Windows.Forms.Button();
            this.reverse_btn = new System.Windows.Forms.Button();
            this.factorial_btn = new System.Windows.Forms.Button();
            this.quadeq_btn = new System.Windows.Forms.Button();
            this.sqr_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OutputFact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // stepen_btn
            // 
            this.stepen_btn.BackColor = System.Drawing.Color.Ivory;
            this.stepen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepen_btn.ForeColor = System.Drawing.Color.DeepPink;
            this.stepen_btn.Location = new System.Drawing.Point(504, 127);
            this.stepen_btn.Name = "stepen_btn";
            this.stepen_btn.Size = new System.Drawing.Size(78, 59);
            this.stepen_btn.TabIndex = 24;
            this.stepen_btn.TabStop = false;
            this.stepen_btn.Text = "x^y";
            this.toolTip1.SetToolTip(this.stepen_btn, "Возведение в степень");
            this.stepen_btn.UseVisualStyleBackColor = false;
            this.stepen_btn.Click += new System.EventHandler(this.stepen_btn_Click);
            // 
            // sqrt_btn
            // 
            this.sqrt_btn.BackColor = System.Drawing.Color.Ivory;
            this.sqrt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt_btn.ForeColor = System.Drawing.Color.DeepPink;
            this.sqrt_btn.Location = new System.Drawing.Point(425, 201);
            this.sqrt_btn.Name = "sqrt_btn";
            this.sqrt_btn.Size = new System.Drawing.Size(78, 59);
            this.sqrt_btn.TabIndex = 25;
            this.sqrt_btn.TabStop = false;
            this.sqrt_btn.Text = "x^(1/2)";
            this.toolTip1.SetToolTip(this.sqrt_btn, "Взятие квадратного корня");
            this.sqrt_btn.UseVisualStyleBackColor = false;
            this.sqrt_btn.Click += new System.EventHandler(this.sqrt_btn_Click);
            // 
            // sqrt3_btn
            // 
            this.sqrt3_btn.BackColor = System.Drawing.Color.Ivory;
            this.sqrt3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt3_btn.ForeColor = System.Drawing.Color.DeepPink;
            this.sqrt3_btn.Location = new System.Drawing.Point(504, 201);
            this.sqrt3_btn.Name = "sqrt3_btn";
            this.sqrt3_btn.Size = new System.Drawing.Size(78, 59);
            this.sqrt3_btn.TabIndex = 26;
            this.sqrt3_btn.TabStop = false;
            this.sqrt3_btn.Text = "x^(1/3)";
            this.toolTip1.SetToolTip(this.sqrt3_btn, "Взятие кубического корня");
            this.sqrt3_btn.UseVisualStyleBackColor = false;
            this.sqrt3_btn.Click += new System.EventHandler(this.sqrt3_btn_Click);
            // 
            // reverse_btn
            // 
            this.reverse_btn.BackColor = System.Drawing.Color.Ivory;
            this.reverse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reverse_btn.ForeColor = System.Drawing.Color.DeepPink;
            this.reverse_btn.Location = new System.Drawing.Point(425, 273);
            this.reverse_btn.Name = "reverse_btn";
            this.reverse_btn.Size = new System.Drawing.Size(76, 59);
            this.reverse_btn.TabIndex = 27;
            this.reverse_btn.TabStop = false;
            this.reverse_btn.Text = "1/x";
            this.toolTip1.SetToolTip(this.reverse_btn, "Вычисление обратного числа");
            this.reverse_btn.UseVisualStyleBackColor = false;
            this.reverse_btn.Click += new System.EventHandler(this.reverse_btn_Click);
            // 
            // factorial_btn
            // 
            this.factorial_btn.BackColor = System.Drawing.Color.Ivory;
            this.factorial_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorial_btn.ForeColor = System.Drawing.Color.DeepPink;
            this.factorial_btn.Location = new System.Drawing.Point(504, 273);
            this.factorial_btn.Name = "factorial_btn";
            this.factorial_btn.Size = new System.Drawing.Size(78, 59);
            this.factorial_btn.TabIndex = 28;
            this.factorial_btn.TabStop = false;
            this.factorial_btn.Text = "x!";
            this.toolTip1.SetToolTip(this.factorial_btn, "Вычисление факториала числа");
            this.factorial_btn.UseVisualStyleBackColor = false;
            this.factorial_btn.Click += new System.EventHandler(this.factorial_btn_Click);
            // 
            // quadeq_btn
            // 
            this.quadeq_btn.BackColor = System.Drawing.Color.Ivory;
            this.quadeq_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quadeq_btn.ForeColor = System.Drawing.Color.DeepPink;
            this.quadeq_btn.Location = new System.Drawing.Point(425, 343);
            this.quadeq_btn.Name = "quadeq_btn";
            this.quadeq_btn.Size = new System.Drawing.Size(157, 59);
            this.quadeq_btn.TabIndex = 29;
            this.quadeq_btn.TabStop = false;
            this.quadeq_btn.Text = "ax^2+bx+c=0";
            this.toolTip1.SetToolTip(this.quadeq_btn, "Вычисление корней квадратного уравнения");
            this.quadeq_btn.UseVisualStyleBackColor = false;
            this.quadeq_btn.Click += new System.EventHandler(this.quadeq_btn_Click);
            // 
            // sqr_btn
            // 
            this.sqr_btn.BackColor = System.Drawing.Color.Ivory;
            this.sqr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqr_btn.ForeColor = System.Drawing.Color.DeepPink;
            this.sqr_btn.Location = new System.Drawing.Point(425, 127);
            this.sqr_btn.Name = "sqr_btn";
            this.sqr_btn.Size = new System.Drawing.Size(78, 59);
            this.sqr_btn.TabIndex = 30;
            this.sqr_btn.TabStop = false;
            this.sqr_btn.Text = "x^2";
            this.toolTip1.SetToolTip(this.sqr_btn, "Квадрат числа");
            this.sqr_btn.UseVisualStyleBackColor = false;
            this.sqr_btn.Click += new System.EventHandler(this.sqr_btn_Click);
            // 
            // OutputFact
            // 
            this.OutputFact.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputFact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputFact.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputFact.Location = new System.Drawing.Point(425, 67);
            this.OutputFact.Name = "OutputFact";
            this.OutputFact.ReadOnly = true;
            this.OutputFact.Size = new System.Drawing.Size(157, 35);
            this.OutputFact.TabIndex = 31;
            this.OutputFact.TabStop = false;
            this.OutputFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(415, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Факториал числа:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // EngiCalc
            // 
            this.ClientSize = new System.Drawing.Size(594, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputFact);
            this.Controls.Add(this.sqr_btn);
            this.Controls.Add(this.quadeq_btn);
            this.Controls.Add(this.factorial_btn);
            this.Controls.Add(this.reverse_btn);
            this.Controls.Add(this.sqrt3_btn);
            this.Controls.Add(this.sqrt_btn);
            this.Controls.Add(this.stepen_btn);
            this.Name = "EngiCalc";
            this.Text = "Инженерный калькулятор";
            this.Controls.SetChildIndex(this.OutputDisplay, 0);
            this.Controls.SetChildIndex(this.stepen_btn, 0);
            this.Controls.SetChildIndex(this.sqrt_btn, 0);
            this.Controls.SetChildIndex(this.sqrt3_btn, 0);
            this.Controls.SetChildIndex(this.reverse_btn, 0);
            this.Controls.SetChildIndex(this.factorial_btn, 0);
            this.Controls.SetChildIndex(this.quadeq_btn, 0);
            this.Controls.SetChildIndex(this.sqr_btn, 0);
            this.Controls.SetChildIndex(this.OutputFact, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stepen_btn;
        private System.Windows.Forms.Button sqrt_btn;
        private System.Windows.Forms.Button sqrt3_btn;
        private System.Windows.Forms.Button reverse_btn;
        private System.Windows.Forms.Button factorial_btn;
        private System.Windows.Forms.Button quadeq_btn;
        private System.Windows.Forms.Button sqr_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox OutputFact;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
