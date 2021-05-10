using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylatorn
{
    public partial class Form1 : Form
    {
        double result = 0.0;  
        string numOne, numTwo, input;
        char operation;
         
        public Form1()
        {
            InitializeComponent();
        }

        /*Har kollat på https://medium.com/@thecodeghost/build-a-simple-calculator-with-c-4962828ef5f7 för att 
         få lite hjälp med switch*/
        public void resultFunction()
        {
            numTwo = input;
                try
                { 
                    switch (operation)
                    {
                                case '-':
                                    result = double.Parse(numOne) - double.Parse(numTwo);
                            numOne = result.ToString(); //När lika med trycks fler gånger så körs numOne och vald operation för varje klick
                            break;
                                case '+':                   
                                    result = double.Parse(numOne) + double.Parse(numTwo);
                            numOne = result.ToString();
                            break;
                                case '/':
                                    if (numTwo == "0")
                            {
                                MessageBox.Show("Fel");
                                textBox1.Text = "";
                            }
                            else
                            {
                                result = double.Parse(numOne) / double.Parse(numTwo);
                                numOne = result.ToString();
                            }
                            break;
                                case '*':
                                    result = double.Parse(numOne) * double.Parse(numTwo);
                            numOne = result.ToString();
                            break;
                    }
                }
                catch (Exception)
                    {
                        MessageBox.Show("Error");
                    }
                    
        }
        /*Se divide, One, Equal och clear för respektive funktioner och olika operationer*/
        private void button1_Click(object sender, EventArgs e)//One
        {
            /*Om första siffran är noll och en nolla matas in igen, så kommer det bli ett kommatecken mellan dessa.
             Om inte så matas värdet för tryckt knapp in och läggs i input samt visas i textBox*/
            if (textBox1.Text == "0")  
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "1";
            textBox1.Text += "1"; 
        }

        private void button2_Click(object sender, EventArgs e)//Two
        {                                         
            if (textBox1.Text == "0")  
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "2";
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)//Three
        {
            if (textBox1.Text == "0") 
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "3";
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)//Divide
        {
            numOne = input; //Sätter in input på numOne
            operation = '/'; //Sätter vilken operation som gäller
            input = string.Empty;//Tömmer input för att man ska kunna mata in numTwo
            textBox1.Clear(); //Rensar textBox efter operation är tryckt
        }

        private void button5_Click(object sender, EventArgs e)//Four
        {
            if (textBox1.Text == "0") 
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "4";
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)//Five
        {
            if (textBox1.Text == "0") 
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "5";
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)//Six
        {
            if (textBox1.Text == "0") 
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "6";
            textBox1.Text += "6";
        } 

        private void button8_Click(object sender, EventArgs e)//Multiply
        {
            numOne = input;
            operation = '*';
            input = string.Empty;
            textBox1.Clear(); 
        }

        private void button9_Click(object sender, EventArgs e)//Seven
        {
            if (textBox1.Text == "0") 
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "7";
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)//Eight
        {
            if (textBox1.Text == "0") 
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "8";
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)//Nine
        {
            if (textBox1.Text == "0")
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "9";
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)//Minus
        {
            numOne = input;
            operation = '-';
            input = string.Empty;
            textBox1.Clear(); 
        }

        private void button13_Click(object sender, EventArgs e)//Comma
        {           
            if (!textBox1.Text.Contains(","))//Kollar så att endast ett kommatecken kan matas in
            {
                input += ",";
                textBox1.Text += ",";
            }
        }

        private void button14_Click(object sender, EventArgs e)//Zero
        { 
            if(textBox1.Text == "0") 
            {
                input = "0" + ",";
                textBox1.Text = input;
            }
            input += "0";
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)//Equal
        {
            resultFunction(); //Kör resultFunction när knapp trycks
            textBox1.Text = result.ToString(); //Visar resultat i textBox
            
            /*Har använt mig av nedanstående länk för att lära mig hur man kan loopa igenom alla knappar.
            Med hjälp av detta så gör jag så alla knappar blir disabled efter man tryckt equal, för att återställa trycks clear.
            https://stackoverflow.com/questions/14537218/winforms-simple-form-how-to-iterate-all-the-buttons-in-it-visual-sudito-2010*/
            foreach (Control buttons in this.Controls)
            {
                if(buttons is Button)
                {
                    buttons.Enabled = false;
                    button17.Enabled = true; 
                    button15.Enabled = true;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)//Plus
        { 
            numOne = input;
            operation = '+';
            input = string.Empty;
            textBox1.Clear(); 
            
        }

        private void button17_Click(object sender, EventArgs e) //Clear
        { 
            textBox1.Clear(); //Reset the textbox
            input = string.Empty; 
            numOne = string.Empty;
            numTwo = string.Empty;
            //Nedanstående återställer alla knappar till true när knappen clear trycks.
            foreach (Control buttons in this.Controls)
            {
                if (buttons is Button)
                {
                    buttons.Enabled = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
