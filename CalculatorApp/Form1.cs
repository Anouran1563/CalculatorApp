using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private Rectangle btn0OriginalRectangle;
        private Rectangle btn1OriginalRectangle;
        private Rectangle btn2OriginalRectangle;
        private Rectangle btn3OriginalRectangle;
        private Rectangle btn4OriginalRectangle;
        private Rectangle btn5OriginalRectangle;
        private Rectangle btn6OriginalRectangle;
        private Rectangle btn7OriginalRectangle;
        private Rectangle btn8OriginalRectangle;
        private Rectangle btn9OriginalRectangle;
        private Rectangle btnRootOriginalRectangle;
        private Rectangle btnClearOriginalRectangle;
        private Rectangle btnBackOriginalRectangle;
        private Rectangle btnMultOriginalRectangle;
        private Rectangle btnDvdOriginalRectangle;
        private Rectangle btnMinusOriginalRectangle;
        private Rectangle btnPlusOriginalRectangle;
        private Rectangle btnPointOriginalRectangle;
        private Rectangle btnNegOriginalRectangle;
        private Rectangle btnEqualOriginalRectangle;
        private Rectangle lblDpyOriginalRectangle;
        private Size originalformsize;


        public Form1()
        {
            InitializeComponent();
        }

        float num1,num2, result;
        char operation;
        bool dec = false;

        private void changelbl(int numPrssed)
        {
            if (dec == true )
            {
                int decCount = 0;
                foreach (char c in lblDpy.Text)
                {
                    if (c == '.')
                    {
                        decCount++;
                    }
                    if (decCount < 1)
                    {
                        lblDpy.Text = lblDpy.Text + '.';
                    }
                    dec = false;
                }
            }
            else
            {
                if (lblDpy.Text.Equals("0") == true && lblDpy.Text != null)
                {
                    lblDpy.Text = numPrssed.ToString();
                }
                else if (lblDpy.Text.Equals("-0") == true)
                {
                    lblDpy.Text = "-" + numPrssed.ToString();
                }
                else
                {
                    lblDpy.Text = lblDpy.Text + numPrssed.ToString();
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            changelbl(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            changelbl(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            changelbl(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            changelbl(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            changelbl(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            changelbl(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            changelbl(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            changelbl(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            changelbl(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            changelbl(9);
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            dec = true;
            changelbl(0);
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            lblDpy.Text = "-" + lblDpy.Text;
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(lblDpy.Text);
            if (num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                lblDpy.Text = sqrt.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDpy.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            dec = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int stringlength = lblDpy.Text.Length;
            if (stringlength > 1)
            {
                lblDpy.Text  = lblDpy.Text.Substring(0, stringlength -1);
            }
            else
            {
                lblDpy.Text = "0";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(lblDpy.Text);
            operation = '*';
            lblDpy.Text = "";
        }

        private void btnDvd_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(lblDpy.Text);
            operation = '/';
            lblDpy.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(lblDpy.Text);
            operation = '-';
            lblDpy.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(lblDpy.Text);
            operation = '+';
            result = result + num1;
            lblDpy.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            result = 0; 
            if (lblDpy.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(lblDpy.Text);
                        result = num1 + num2;
                        break;
                }
                switch (operation)
                {
                    case '-':
                        num2 = float.Parse(lblDpy.Text);
                        result = num1 - num2;
                        break;
                }
                switch (operation)
                {
                    case '*':
                        num2 = float.Parse(lblDpy.Text);
                        result = num1 * num2;
                        break;
                }
                switch (operation)
                {
                    case '/':
                        num2 = float.Parse(lblDpy.Text);
                        result = num1 / num2;
                        break;
                }
            }
            lblDpy.Text = result.ToString();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            originalformsize = this.Size;
            btn0OriginalRectangle = new Rectangle(btn0.Location.X, btn0.Location.Y, btn0.Width, btn0.Height);
            btn1OriginalRectangle = new Rectangle(btn1.Location.X, btn1.Location.Y, btn1.Width, btn1.Height);
            btn2OriginalRectangle = new Rectangle(btn2.Location.X, btn2.Location.Y, btn2.Width, btn2.Height);
            btn3OriginalRectangle = new Rectangle(btn3.Location.X, btn3.Location.Y, btn3.Width, btn3.Height);
            btn4OriginalRectangle = new Rectangle(btn4.Location.X, btn4.Location.Y, btn4.Width, btn4.Height);
            btn5OriginalRectangle = new Rectangle(btn5.Location.X, btn5.Location.Y, btn5.Width, btn5.Height);
            btn6OriginalRectangle = new Rectangle(btn6.Location.X, btn6.Location.Y, btn6.Width, btn6.Height);
            btn7OriginalRectangle = new Rectangle(btn7.Location.X, btn7.Location.Y, btn7.Width, btn7.Height);
            btn8OriginalRectangle = new Rectangle(btn8.Location.X, btn8.Location.Y, btn8.Width, btn8.Height);
            btn9OriginalRectangle = new Rectangle(btn9.Location.X, btn9.Location.Y, btn9.Width, btn9.Height);
            btnRootOriginalRectangle = new Rectangle(btnRoot.Location.X, btnRoot.Location.Y, btnRoot.Width, btnRoot.Height);
            btnClearOriginalRectangle = new Rectangle(btnClear.Location.X, btnClear.Location.Y, btnClear.Width, btnClear.Height);
            btnBackOriginalRectangle = new Rectangle(btnBack.Location.X, btnBack.Location.Y, btnBack.Width, btnBack.Height);
            btnMultOriginalRectangle = new Rectangle(btnMult.Location.X, btnMult.Location.Y, btnMult.Width, btnMult.Height);
            btnDvdOriginalRectangle = new Rectangle(btnDvd.Location.X, btnDvd.Location.Y, btnDvd.Width, btnDvd.Height);
            btnMinusOriginalRectangle = new Rectangle(btnMinus.Location.X, btnMinus.Location.Y, btnMinus.Width, btnMinus.Height);
            btnPlusOriginalRectangle = new Rectangle(btnPlus.Location.X, btnPlus.Location.Y, btnPlus.Width, btnPlus.Height);
            btnPointOriginalRectangle = new Rectangle(btnPoint.Location.X, btnPoint.Location.Y, btnPoint.Width, btnPoint.Height);
            btnNegOriginalRectangle = new Rectangle(btnNeg.Location.X, btnNeg.Location.Y, btnNeg.Width, btnNeg.Height);
            btnEqualOriginalRectangle = new Rectangle(btnEqual.Location.X, btnEqual.Location.Y, btnEqual.Width, btnEqual.Height);
            lblDpyOriginalRectangle = new Rectangle(lblDpy.Location.X, lblDpy.Location.Y, lblDpy.Width, lblDpy.Height);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeCtrl(btn0OriginalRectangle, btn0);
            ResizeCtrl(btn1OriginalRectangle, btn1);
            ResizeCtrl(btn2OriginalRectangle, btn2);
            ResizeCtrl(btn3OriginalRectangle, btn3);
            ResizeCtrl(btn4OriginalRectangle, btn4);
            ResizeCtrl(btn5OriginalRectangle, btn5);
            ResizeCtrl(btn6OriginalRectangle, btn6);
            ResizeCtrl(btn7OriginalRectangle, btn7);
            ResizeCtrl(btn8OriginalRectangle, btn8);
            ResizeCtrl(btn9OriginalRectangle, btn9);
            ResizeCtrl(btnRootOriginalRectangle, btnRoot);
            ResizeCtrl(btnClearOriginalRectangle, btnClear);
            ResizeCtrl(btnBackOriginalRectangle, btnBack);
            ResizeCtrl(btnMultOriginalRectangle, btnMult);
            ResizeCtrl(btnDvdOriginalRectangle, btnDvd);
            ResizeCtrl(btnMinusOriginalRectangle, btnMinus);
            ResizeCtrl(btnPlusOriginalRectangle, btnPlus);
            ResizeCtrl(btnPointOriginalRectangle, btnPoint);
            ResizeCtrl(btnNegOriginalRectangle, btnNeg);
            ResizeCtrl(btnEqualOriginalRectangle, btnEqual);
            ResizeCtrl(lblDpyOriginalRectangle, lblDpy);

        }
        private void ResizeCtrl(Rectangle OriginalControlRect, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalformsize.Width);
            float yAxis = (float)(this.Height) / (float)(originalformsize.Height);

            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);

            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHight = (int)(OriginalControlRect.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHight);
        }


    }
}
