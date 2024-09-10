using System;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class Interfaz : Form
    {
        // Inicialización directa para evitar advertencias de nullables
        private TextBox txtNumber = new TextBox();
        private Button btnCalculate = new Button();
        private Label lblResult = new Label();

        public Interfaz()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtNumber.Text);

                if (number < 0)
                {
                    MessageBox.Show("Por favor, ingresa un número mayor o igual a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamada a la lógica del cálculo del factorial
                long factorial = FactorialCalculator.Calculate(number);
                lblResult.Text = $"El factorial de {number} es {factorial}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // txtNumber
            this.txtNumber.Location = new System.Drawing.Point(30, 30);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 20);
            this.txtNumber.TabIndex = 0;

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(30, 70);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calcular Factorial";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultado";

            // Interfaz
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumber);
            this.Name = "Interfaz";
            this.Text = "Calculadora de Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
