using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Screen_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
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
            lbl_Screen.Text += "0";

        }


        char _islem;
        double _ilkSayi;
        bool _ekranTemizlenecekMi;
      

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
            _islem = '+';
            while (_islem == '+')
            {
                _ilkSayi += Convert.ToInt32(lbl_Screen.Text);
                break;   
            }
           
            _ekranTemizlenecekMi = true;            
        }
        double sonuc;
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double _sonSayi = Convert.ToDouble(lbl_Screen.Text);
            sender = _sonSayi;
            

            
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + _sonSayi;
                    break;


                case '-':
                    sonuc = (-1 * _ilkSayi) - _sonSayi;
                    break;


                case 'x':
                    sonuc =  _ilkSayi * _sonSayi;
                    break;


                case '/':
                    sonuc =   _ilkSayi / _sonSayi;
                    break;

                default:
                    sonuc = 0;
                    break;

            }
            lbl_Screen.Text = Convert.ToString(sonuc);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbl_Screen.Text = "0";
            _ilkSayi = 0;
            sender = 0;
            //sonuc -= sonuc;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _islem = '-';
            while (_islem == '-')
            {
                _ilkSayi -= Convert.ToInt32(lbl_Screen.Text);
                break;
            }           
            _ekranTemizlenecekMi = true;
        }

        private void btnMultipliedBy_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            while (_islem == 'x')
            {
                _ilkSayi = Convert.ToInt32(lbl_Screen.Text);
                break;
            }        
            _ekranTemizlenecekMi = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            _islem = '/';
            while (_islem == '/')
            {
                _ilkSayi = Convert.ToInt32(lbl_Screen.Text);
                break;
            }    
            _ekranTemizlenecekMi = true;
        }
    }
}
