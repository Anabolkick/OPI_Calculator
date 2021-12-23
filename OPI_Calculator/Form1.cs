using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal memory;

        private void btn1_Click(object sender, EventArgs e)
        {
            main_tb.Text += 1;
            curr_num += 1;
            emt.Select();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            main_tb.Text += 2;
            curr_num += 2;
            emt.Select();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            main_tb.Text += 3;
            curr_num += 3;
            emt.Select();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            main_tb.Text += 4;
            curr_num += 4;
            emt.Select();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            main_tb.Text += 5;
            curr_num += 5;
            emt.Select();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            main_tb.Text += 6;
            curr_num += 6;
            emt.Select();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            main_tb.Text += 7;
            curr_num += 7;
            emt.Select();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            main_tb.Text += 8;
            curr_num += 8;
            emt.Select();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            main_tb.Text += 9;
            curr_num += 9;
            emt.Select();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            main_tb.Text += '.';
            curr_num += '.';
            emt.Select();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            main_tb.Text += 0;
            curr_num += 0;
            emt.Select();
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            CheckPrev();
            main_tb.Text += '-';
            curr_num = "";
            emt.Select();
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            CheckPrev();
            main_tb.Text += '+';
            curr_num = "";
            emt.Select();
        }

        private void mult_btn_Click(object sender, EventArgs e)
        {
            Mult();
        }

        void Mult()
        {
            CheckPrev();
            if (main_tb.Text.Length > 1)
            {
                main_tb.Text += '*';
                curr_num = "";
            }
            emt.Select();
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            Div();
        }
        void Div()
        {
            CheckPrev();
            if (main_tb.Text.Length >= 1)
            {
                main_tb.Text += '/';
                curr_num = "";
            }
            emt.Select();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (main_tb.Text.Length > 0)
            {
                main_tb.Text = main_tb.Text.Remove(main_tb.Text.Length - 1, 1);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            main_tb.Text = "";
            curr_num = "";
            result_tb.Clear();
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            Calculate();

            // string calc = main_tb.Text;
            // var nums = calc.Split('+', '/', '*', '-');
            // var oper = calc.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
        }

        void Calculate()
        {
            if (main_tb.Text.Contains("/0"))
            {
                result_tb.Text = "Неможливо порахувати";
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    var v = dt.Compute(main_tb.Text, "");
                    // var v = dt.Compute("3+(-5)", "");
                    decimal result;
                    decimal.TryParse(v.ToString(), out result);
                    result_tb.Text = "" + result.ToString(new CultureInfo("en-US"));
                }
                catch(Exception ex)
                {
                   MessageBox.Show($"{ex.Message}",$"Виникло виключеня!");
                }

            }
        }

        private string curr_num = "";
        decimal GetCurrentNum()
        {
            decimal result;
            decimal.TryParse(curr_num, out result);
            return result;
        }

        void CheckPrev()
        {
            if (main_tb.Text.Length > 0 && (main_tb.Text[main_tb.Text.Length - 1] == '*' || main_tb.Text[main_tb.Text.Length - 1] == '-' ||
                                            main_tb.Text[main_tb.Text.Length - 1] == '+' || main_tb.Text[main_tb.Text.Length - 1] == '/'))
            {
                main_tb.Text = main_tb.Text.Remove(main_tb.Text.Length - 1, 1);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    main_tb.Text += 0;
                    curr_num += 0;
                    break;

                case Keys.NumPad1:
                case Keys.D1:
                    main_tb.Text += 1;
                    curr_num += 1;
                    break;

                case Keys.NumPad2:
                case Keys.D2:
                    main_tb.Text += 2;
                    curr_num += 2;
                    break;

                case Keys.NumPad3:
                case Keys.D3:
                    main_tb.Text += 3;
                    curr_num += 3;
                    break;

                case Keys.NumPad4:
                case Keys.D4:
                    main_tb.Text += 4;
                    curr_num += 4;
                    break;

                case Keys.NumPad5:
                case Keys.D5:
                    main_tb.Text += 5;
                    curr_num += 5;
                    break;

                case Keys.NumPad6:
                case Keys.D6:
                    main_tb.Text += 6;
                    curr_num += 6;
                    break;

                case Keys.NumPad7:
                case Keys.D7:
                    main_tb.Text += 7;
                    curr_num += 7;
                    break;

                case Keys.NumPad8:
                case Keys.D8:
                    main_tb.Text += 8;
                    curr_num += 8;
                    break;

                case Keys.NumPad9:
                case Keys.D9:
                    main_tb.Text += 9;
                    curr_num += 9;
                    break;

                case Keys.Enter:
                    Calculate();
                    break;

                case Keys.Back:
                    if (main_tb.Text.Length > 0)
                    {
                        main_tb.Text = main_tb.Text.Remove(main_tb.Text.Length - 1, 1);
                    }
                    break;

                case Keys.Delete:
                    main_tb.Text = "";
                    curr_num = "";
                    result_tb.Clear();
                    break;

                case Keys.Subtract:
                    CheckPrev();
                    main_tb.Text += '-';
                    curr_num = "";
                    break;

                case Keys.Add:
                    CheckPrev();
                    main_tb.Text += '+';
                    curr_num = "";
                    break;

                case Keys.Divide:
                    Div();
                    break;

                case Keys.Multiply:
                    Mult();
                    break;

                case Keys.Decimal:
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                    main_tb.Text += '.';
                    curr_num += '.';
                    break;

            }

        }

        private void mc_Click(object sender, EventArgs e)
        {
            memory_tb.Clear();
            memory = 0;
        }

        private void mr_Click(object sender, EventArgs e)
        {
            if (memory != 0)
            {
                main_tb.Text = $"{memory}";
            }
        }

        private void ms_Click(object sender, EventArgs e)
        {
            decimal.TryParse(result_tb.Text, out memory);
            if (memory != 0)
            {
                memory_tb.Text = $"{memory}";
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            main_tb.Text = main_tb.Text.Substring(0, main_tb.Text.Length - curr_num.Length);
            main_tb.Text += "("+ (Math.Cos(Convert.ToDouble(GetCurrentNum()))).ToString(new CultureInfo("en-US")) + ")";
            curr_num = "";
        }

        private void sin_Click(object sender, EventArgs e)
        {
            main_tb.Text = main_tb.Text.Substring(0,main_tb.Text.Length - curr_num.Length);
            main_tb.Text += "("+ (Math.Sin(Convert.ToDouble(GetCurrentNum()))).ToString(new CultureInfo("en-US")) + ")";
            curr_num = "";
        }

        private void tg_Click(object sender, EventArgs e)
        {
            main_tb.Text = main_tb.Text.Substring(0, main_tb.Text.Length - curr_num.Length);
            main_tb.Text += "(" + (Math.Tan(Convert.ToDouble(GetCurrentNum()))).ToString(new CultureInfo("en-US")) + ")";
            curr_num = "";
        }

        private void ctg_Click(object sender, EventArgs e)
        {
            main_tb.Text = main_tb.Text.Substring(0, main_tb.Text.Length - curr_num.Length);
            main_tb.Text += "(" + (1 / (Math.Tan(Convert.ToDouble(GetCurrentNum())))).ToString(new CultureInfo("en-US")) + ")";
            curr_num = "";
        }

        private void exp_Click(object sender, EventArgs e)
        {
            main_tb.Text = main_tb.Text.Substring(0, main_tb.Text.Length - curr_num.Length);
            main_tb.Text += "(" + (Math.Exp(Convert.ToDouble(GetCurrentNum()))).ToString(new CultureInfo("en-US")) + ")";
            curr_num = "";
        }

        private void x2_Click(object sender, EventArgs e)
        {
            main_tb.Text = main_tb.Text.Substring(0, main_tb.Text.Length - curr_num.Length);
            main_tb.Text += "(" + (Math.Pow(Convert.ToDouble(GetCurrentNum()),2)).ToString(new CultureInfo("en-US")) + ")";
            curr_num = "";
        }

        private void x3_Click(object sender, EventArgs e)
        {
            main_tb.Text = main_tb.Text.Substring(0, main_tb.Text.Length - curr_num.Length);
            main_tb.Text += "(" + (Math.Pow(Convert.ToDouble(GetCurrentNum()),3)).ToString(new CultureInfo("en-US")) + ")";
            curr_num = "";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            main_tb.Text = main_tb.Text.Substring(0, main_tb.Text.Length - curr_num.Length);
            main_tb.Text += "(" + (Math.Sqrt(Convert.ToDouble(GetCurrentNum()))).ToString(new CultureInfo("en-US")) + ")";
            curr_num = "";
        }

        private void binary_r_Click(object sender, EventArgs e)
        {
          Calculate();
          long res;
          long.TryParse(result_tb.Text, out res);
          res = res >> 1;
          result_tb.Text =""+res;
        }

        private void binary_l_Click(object sender, EventArgs e)
        {
            Calculate();
            long res;
            long.TryParse(result_tb.Text, out res);
            res = res << 1;
            result_tb.Text = "" + res;
        }

        private void binary_inv_Click(object sender, EventArgs e)
        {
            Calculate();
            long res;
            long.TryParse(result_tb.Text, out res);
            result_tb.Text = "" + ~res;
        }

        private void btn_change_mode_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = !groupBox2.Visible;
            groupBox3.Visible = !groupBox3.Visible;
        }
    }
}
