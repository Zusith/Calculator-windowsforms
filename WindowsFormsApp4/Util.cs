using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class Util
    {

        double a, b; //переменные для проведения расчетов
        string sign; //выбранный знак *,-,=,/
        bool znak; //переменная для проверки положительное или отрицательное значение
        bool chksign; //переменная для проверки первого определения знака
        bool chkask; //переменная для проверки на провелись ли расчеты
        bool chknum; //переменная для проверки введения 1-ого числа
        bool chknum2; //переменная для проверки введения 2-ого числа

        public void formload(TextBox textBoxAsk, Label labe) //метод установки параметров при запуске и отчистке калькулятора
        {
            znak = true; //число положительное по стандарту
            chksign = false; //знак не был выбран
            chkask = false; //вычисления не проводились
            chknum = false; //1-ое число не вводилось
            chknum2 = false; //2-ое число не вводилось
            textBoxAsk.Text = "0"; //при запуске и отчистке в поле появляется 0
            labe.Text = ""; //показатель положительность или отрицательности числа, по стандарту +
        }

        public void Sign(string sign2, TextBox textBoxAsk, Label labe) //метод выбора знака
        {
            if (!chknum2) 
            {
                sign = sign2;
            }
            if (!chkask) 
            {
                a = Num(textBoxAsk);               
                if (!znak) 
                {
                    a *= -1;
                }
                chknum = true;
                znak = true;
                chksign = true;
                chkask = true;
            }
            if (chknum2) 
            {
                Ask(textBoxAsk, labe);
                a = Num(textBoxAsk);
                if (!znak)
                {
                    a *= -1;
                }
                znak = true;
                sign = sign2;
                chknum = true;
                chksign = true;
                chkask = true;
            }           
        }

        public void Number(string number, TextBox textBoxAsk, Label plusminus) //метод ввода цифр в поле (не более 9)
        {
            if (chknum)
            {
                chknum2 = true;
                chknum = false;
            }
            if (textBoxAsk.Text == "0")
            {
                textBoxAsk.Text = "";
            }
            if (textBoxAsk.TextLength < 9 || chksign)
            {
                if (chksign)
                {
                    textBoxAsk.Clear();
                    plusminus.Text = "";
                    chksign = false;
                }
                textBoxAsk.Text += number;
            }           
        }

        public void Ask(TextBox textBoxAsk, Label labe) //метод для вызова вычислений
        {
            if (chkask && chknum2)
            {
                Calculate(textBoxAsk, labe); 
            }           
        }

        private double Num(TextBox textBoxAsk) //метод конвертации string в double
        {
            return Convert.ToDouble(textBoxAsk.Text);
        }
        private void Askmet(TextBox textBoxAsk) => textBoxAsk.Text = Math.Round(b, 1).ToString(); //метод для вывода результата вычислений 

        private void Calculate(TextBox textBoxAsk, Label plusminus) //метод самого вычислений
        {
            double num = Num(textBoxAsk);
            if (!znak)
            {
                num *= -1;
            }
            znak = true;
            switch (sign)
            {
                case "+":
                    b = a + num;
                    Askmet(textBoxAsk);
                    break;
                case "-":
                    b = a - num;
                    Askmet(textBoxAsk);
                    break;
                case "*":
                    b = a * num;
                    Askmet(textBoxAsk);
                    break;
                case "/":
                    b = a / num;
                    Askmet(textBoxAsk);
                    if (num == 0)
                    {
                        textBoxAsk.Text = "not / 0"; //нельзя делить на 0
                    }
                    break;
                default:
                    break;
            }
            b = Math.Round(b, 1);
            if (b <= 0)
            {
                plusminus.Text = "-";
                znak = false;
            }
            if (b >= 0 || textBoxAsk.Text == "0")
            {
                plusminus.Text = "";
            }
            string btest = b.ToString();
            if (btest.Length > 9)
            {
                textBoxAsk.Text = "EXCEEDED"; //нарушение максимальной разрядности числа (9 разрядов) 
            }
            textBoxAsk.Text = textBoxAsk.Text.Replace("-", "");
            chkask = false;
            chknum2 = false;
            chksign = true;
        }

        public void PlusMinus(Label labelplusminus, TextBox textBoxAsk) //Метод для установки отрицательности, положительности числа
        {
            if (znak)
            {
                labelplusminus.Text = "-";
                znak = false;
            }
            else if (!znak)
            {
                labelplusminus.Text = "";
                znak = true;
            }           
        }
    }
}
