namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.NomeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HorasInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalarioOutput = new System.Windows.Forms.TextBox();
            this.SalarioLabel = new System.Windows.Forms.Label();
            this.CpfInput = new System.Windows.Forms.MaskedTextBox();
            this.ValorInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(40, 200);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(252, 35);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular salário";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // NomeInput
            // 
            this.NomeInput.Location = new System.Drawing.Point(89, 56);
            this.NomeInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeInput.Name = "NomeInput";
            this.NomeInput.Size = new System.Drawing.Size(203, 26);
            this.NomeInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor por hora";
            // 
            // HorasInput
            // 
            this.HorasInput.Location = new System.Drawing.Point(160, 128);
            this.HorasInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HorasInput.Name = "HorasInput";
            this.HorasInput.Size = new System.Drawing.Size(132, 26);
            this.HorasInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Horas trabalhadas";
            // 
            // SalarioOutput
            // 
            this.SalarioOutput.Location = new System.Drawing.Point(89, 164);
            this.SalarioOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalarioOutput.Name = "SalarioOutput";
            this.SalarioOutput.ReadOnly = true;
            this.SalarioOutput.Size = new System.Drawing.Size(203, 26);
            this.SalarioOutput.TabIndex = 10;
            // 
            // SalarioLabel
            // 
            this.SalarioLabel.AutoSize = true;
            this.SalarioLabel.Location = new System.Drawing.Point(36, 167);
            this.SalarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalarioLabel.Name = "SalarioLabel";
            this.SalarioLabel.Size = new System.Drawing.Size(50, 20);
            this.SalarioLabel.TabIndex = 9;
            this.SalarioLabel.Text = "Salário";
            // 
            // CpfInput
            // 
            this.CpfInput.Location = new System.Drawing.Point(89, 20);
            this.CpfInput.Mask = "000\\.000\\.000\\-00";
            this.CpfInput.Name = "CpfInput";
            this.CpfInput.Size = new System.Drawing.Size(203, 26);
            this.CpfInput.TabIndex = 11;
            // 
            // ValorInput
            // 
            this.ValorInput.Location = new System.Drawing.Point(138, 92);
            this.ValorInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ValorInput.Name = "ValorInput";
            this.ValorInput.Size = new System.Drawing.Size(154, 26);
            this.ValorInput.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 258);
            this.Controls.Add(this.ValorInput);
            this.Controls.Add(this.CpfInput);
            this.Controls.Add(this.SalarioOutput);
            this.Controls.Add(this.SalarioLabel);
            this.Controls.Add(this.HorasInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox NomeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HorasInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SalarioOutput;
        private System.Windows.Forms.Label SalarioLabel;
        private System.Windows.Forms.MaskedTextBox CpfInput;
        private System.Windows.Forms.TextBox ValorInput;
    }
}

