using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MCDApp
{
    public partial class Interfaz : Form
    {
        private TextBox txtNumber1 = new TextBox();
        private TextBox txtNumber2 = new TextBox();
        private Button btnCalculate = new Button();
        private Label lblResult = new Label();

        public Interfaz()
        {
            IniciarComponente();
        }
        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            try
            {
                int numero1 = int.Parse(txtNumber1.Text);
                int numero2 = int.Parse(txtNumber2.Text);

                int mcd = MCDCalculador.Calcular(numero1, numero2);
                lblResult.Text = $"El MCD de {numero1} y {numero2} es {mcd}";
            }
            catch(FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void IniciarComponente()
        {
            this.SuspendLayout();

            this.txtNumber1.Location = new System.Drawing.Point(30, 30);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 0;

            // txtNumber2
            this.txtNumber2.Location = new System.Drawing.Point(150, 30);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 1;

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(30, 70);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(220, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calcular MCD";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado";

            // Interfaz
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Name = "Interfaz";
            this.Text = "Calculadora de MCD";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}