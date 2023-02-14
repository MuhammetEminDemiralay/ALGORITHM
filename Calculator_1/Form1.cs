using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_1
{
    public partial class CALCULATOR : Form
    {
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void CALCULATOR_Load(object sender, EventArgs e)
        {

        }




        private void btn1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";
            lbl_Screen.Text += "1";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";
            lbl_Screen.Text += "2";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";
            lbl_Screen.Text += "3";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";
            lbl_Screen.Text += "4";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";
            lbl_Screen.Text += "5";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";
            lbl_Screen.Text += "6";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";
            lbl_Screen.Text += "7";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";
            lbl_Screen.Text += "8";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";
            lbl_Screen.Text += "9";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lbl_Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lbl_Screen.Text == "0")
                lbl_Screen.Text = "";

            //label1.Text += "0";

            lbl_Screen.Text += "0";
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "0";
        }



        char _islem;
        bool _ekranTemizlenecekMi;
        double _ilkSayi;
        double _sonuc;
        string islem;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _islem = '+';
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "+";
            _ilkSayi += Convert.ToInt32(lbl_Screen.Text);
            _ekranTemizlenecekMi = true;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double sonSayi = Convert.ToInt32(lbl_Screen.Text);



            switch (_islem)
            {

                case '+':
                    _sonuc = _ilkSayi + sonSayi;
                    break;

                case '-':
                    _sonuc = _ilkSayi - sonSayi;
                    break;

                case 'x':
                    _sonuc = _ilkSayi * sonSayi;
                    break;

                case '/':
                    _sonuc = _ilkSayi / sonSayi;
                    break;



                default:
                    _sonuc = Convert.ToDouble(lbl_Screen.Text);
                    break;
            }

            lbl_Screen.Text = Convert.ToString(_sonuc);
            label1.Text = Convert.ToString(_sonuc);

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi -= Convert.ToInt32(lbl_Screen.Text);
            label1.Text += "-";
        }

        private void btnMultipliedBy_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekranTemizlenecekMi = true;
            _ilkSayi *= Convert.ToInt32(lbl_Screen.Text);
            label1.Text += "x";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi /= Convert.ToInt32(lbl_Screen.Text);
            label1.Text += "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbl_Screen.Text = "0";
            label1.Text = "0";
            _sonuc *= 0;
            _ilkSayi *= 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
