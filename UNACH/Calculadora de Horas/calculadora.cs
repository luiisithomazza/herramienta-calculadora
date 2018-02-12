using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Horas
{
    public partial class calculadora : Form
    {
        
             this.timer1.Start();
            bool sigue = true, punto = true;
            string operacion, point;
            double resultado1, resultado2, resultado;
            public calculadora()

            {
                InitializeComponent();
            }

            private void num1_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("1");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("1");
                }
            }

            private void num2_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("2");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("2");
                }
            }

            private void num3_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("3");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("3");
                }
            }

            private void num4_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("4");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("4");
                }
            }

            private void num5_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("5");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("5");
                }
            }

            private void num6_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("6");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("6");
                }
            }

            private void num7_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("7");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("7");
                }
            }

            private void num8_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("8");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("8");
                }
            }

            private void num9_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("9");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("9");
                }
            }

            private void num0_Click(object sender, EventArgs e)
            {
                if (sigue)
                {
                    pantalla.Text = ("");
                    pantalla.Text = ("0");
                    sigue = false;
                }
                else
                {
                    pantalla.Text = pantalla.Text + ("0");
                }
            }

            private void num_Click(object sender, EventArgs e)
            {
                if (punto == true)
                {
                    pantalla.Text = (".");
                    punto = false;
                }
                else
                {
                    return;
                }

            }

            private void numentre_Click(object sender, EventArgs e)
            {
                operacion = "/";
                sigue = true;
                resultado1 = double.Parse(pantalla.Text);
            }

            private void numpor_Click(object sender, EventArgs e)
            {
                operacion = "*";
                sigue = true;
                resultado1 = double.Parse(pantalla.Text);
            }

            private void nummenos_Click(object sender, EventArgs e)
            {
                operacion = "-";
                sigue = true;
                resultado1 = double.Parse(pantalla.Text);
            }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void num7_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Start();
            label3.Text = DateTime.Now.ToString("dd MMMM yyyy");
            label4.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void nummas_Click(object sender, EventArgs e)
            {
                operacion = "+";
                sigue = true;
                resultado1 = double.Parse(pantalla.Text);
            }

            private void numigual_Click(object sender, EventArgs e)
            {

            }

            private void CE_Click(object sender, EventArgs e)
            {
                pantalla.Clear();
            }

            private void numigual_Click_1(object sender, EventArgs e)
            {
                resultado2 = double.Parse(pantalla.Text);
                sigue = true;

                switch (operacion)
                {
                    case "+":
                        resultado = resultado1 + resultado2;
                        pantalla.Text = resultado.ToString();
                        break;
                    case "-":
                        resultado = resultado1 - resultado2;
                        pantalla.Text = resultado.ToString();
                        break;
                    case "*":
                        resultado = resultado1 * resultado2;
                        pantalla.Text = resultado.ToString();
                        break;
                    case "/":
                        resultado = resultado1 / resultado2;
                        pantalla.Text = resultado.ToString();
                        break;
                }
            }
        }
    }