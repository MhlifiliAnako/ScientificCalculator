using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        double enterfirstValue, entersecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //this.Width = 365; // 668;
            //txtResult.Width = 309;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            String f, s;

            f = Convert.ToString(enterfirstValue);
            s = Convert.ToString(entersecondValue);

            f = "";
            s = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            entersecondValue = Convert.ToDouble(txtResult.Text);

            switch (op)
            {
                case "+":
                    txtResult.Text = (enterfirstValue + entersecondValue).ToString();
                break;

                case "-":
                    txtResult.Text = (enterfirstValue - entersecondValue).ToString();
                    break;

                case "*":
                    txtResult.Text = (enterfirstValue * entersecondValue).ToString();
                    break;

                case "/":
                    txtResult.Text = (enterfirstValue / entersecondValue).ToString();
                    break;

                case "Mod":
                    txtResult.Text = (enterfirstValue % entersecondValue).ToString();
                    break;

                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j;
                    j = entersecondValue;

                    txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                default:
                break;
            }
        }

        private void numberOperators(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterfirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void fireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 365; // 668;
            txtResult.Width = 309;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 690; // 668;
            txtResult.Width = 630;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;

            exitCal = MessageBox.Show("Confirm if you want to exit", " Scientific Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589793238462643383279502884197";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            sh = Math.Sinh(sh);
            txtResult.Text = Convert.ToString(sh);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            double x,q,p,m;

            q = Convert.ToDouble(txtResult.Text);
            p = Convert.ToDouble(txtResult.Text);
            m = Convert.ToDouble(txtResult.Text);

            x = (q * p * m);
            txtResult.Text = Convert.ToString(x);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(txtResult.Text);
            cosh = Math.Cosh(cosh);
            txtResult.Text = Convert.ToString(cosh);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txtResult.Text);
            tanh = Math.Tanh(tanh);
            txtResult.Text = Convert.ToString(tanh);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);

            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double Inx = Convert.ToDouble(txtResult.Text);
            Inx = Math.Log(Inx);
            txtResult.Text = Convert.ToString(Inx);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            double a;
            
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));

            txtResult.Text = Convert.ToString(a);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(a);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text ==".")
                {
                    if (!txtResult.Text.Contains("."))

                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }
    }
}
