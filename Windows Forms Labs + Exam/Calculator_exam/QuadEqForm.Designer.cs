
namespace SimpleCalculator
{
    partial class QuadEqForm
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxCoefA = new System.Windows.Forms.TextBox();
            this.textBoxCoefB = new System.Windows.Forms.TextBox();
            this.textBoxCoefC = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите коэффициенты уравнения:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(31, 77);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(18, 20);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(31, 128);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(18, 20);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "b";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(31, 182);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(17, 20);
            this.labelC.TabIndex = 3;
            this.labelC.Text = "c";
            // 
            // textBoxCoefA
            // 
            this.textBoxCoefA.Location = new System.Drawing.Point(100, 77);
            this.textBoxCoefA.Name = "textBoxCoefA";
            this.textBoxCoefA.Size = new System.Drawing.Size(100, 26);
            this.textBoxCoefA.TabIndex = 4;
            this.textBoxCoefA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefA_KeyPress);
            // 
            // textBoxCoefB
            // 
            this.textBoxCoefB.Location = new System.Drawing.Point(100, 128);
            this.textBoxCoefB.Name = "textBoxCoefB";
            this.textBoxCoefB.Size = new System.Drawing.Size(100, 26);
            this.textBoxCoefB.TabIndex = 5;
            this.textBoxCoefB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefB_KeyPress);
            // 
            // textBoxCoefC
            // 
            this.textBoxCoefC.Location = new System.Drawing.Point(100, 182);
            this.textBoxCoefC.Name = "textBoxCoefC";
            this.textBoxCoefC.Size = new System.Drawing.Size(100, 26);
            this.textBoxCoefC.TabIndex = 6;
            this.textBoxCoefC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefC_KeyPress);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Thistle;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(81, 245);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(119, 40);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "Ввести";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // QuadEqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(302, 314);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxCoefC);
            this.Controls.Add(this.textBoxCoefB);
            this.Controls.Add(this.textBoxCoefA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QuadEqForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод коэффициентов";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxCoefA;
        private System.Windows.Forms.TextBox textBoxCoefB;
        private System.Windows.Forms.TextBox textBoxCoefC;
        private System.Windows.Forms.Button buttonEnter;
    }
}