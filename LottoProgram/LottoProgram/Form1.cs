using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace LottoProgram
{
    public partial class Form1 : Form
    {
        List<int> UserNumbers = new List<int>(); //Lista för användarens inmatning av nummer se metod AddNumbers()
        List<int> RandomList = new List<int>(); //Lista som används för randommetoden se RandomDraws()
        Random rand = new Random(); //Skapa en randominstans
        int r = 0;       
        int counter = 0; //counter för räkning av antal rätt
        int five, six, seven = 0; //Räknare för antal rätt startar på noll
        int[] AddNumberArray = new int[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        public Boolean AddNumbers() //Metod för validering, diskuterat och fått hjälp med Simon Petersohn så det kan förekomma några likheter.
        {
            string[] containsDuplicates = {LottoRow1.Text, LottoRow2.Text, LottoRow3.Text, LottoRow4.Text, LottoRow5.Text, LottoRow6.Text, LottoRow7.Text };
            try
            {
                //Har använt https://www.techiedelight.com/convert-string-array-to-int-array-csharp/ för att se hur man konverterar arrayer
                AddNumberArray = Array.ConvertAll(containsDuplicates, int.Parse);//Konverterar stringarray till intarray
                for (int x = 0; x < AddNumberArray.Count(); x++)
                {
                    if (AddNumberArray[x] <= 0 || AddNumberArray[x] > 35)
                    {
                        MessageBox.Show("Du kan endast välja ett nummer mellan 1-35!");
                        return false;
                    }
                }

                //https://stackoverflow.com/questions/5080538/c-sharp-determine-duplicate-in-list
                //Tittar om textBoxerna är lika med varandra"dubbletter"
                if (containsDuplicates.Distinct().Count() != containsDuplicates.Count())
                {
                     MessageBox.Show("Din lottorad får ej innehålla dubletter!");
                     return false;            
                }

                else
                {
                     return true;
                }
            }
               
                catch (Exception)
                {
                    MessageBox.Show("Du kan endast använda heltal!!");
                    return false;
                }
        }
            
        public void CheckTextBox()//Metod som kollar om alla textfält är ifyllda
        {
            string[] numberBox = { LottoRow1.Text, LottoRow2.Text, LottoRow3.Text, LottoRow4.Text, LottoRow5.Text, LottoRow6.Text, LottoRow7.Text, draws.Text };
 
            foreach(string item in numberBox)
            {
                if (numberBox.Contains(""))
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
            }
        }

        public void RandomDraws() //Metod som kollar om dragningar består av heltal, om fallet är så, så körs randommetod
        {
         int LottoDraws = 0;

            try
            {
               LottoDraws = int.Parse(draws.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Antal dragningar skall skriva med ett heltal");
            }

            //LottoDraws = int.Parse(draws.Text); // Antal  dragningar som matas in i programmet, för nedanstående for-loop
            for (int i = 0; i < LottoDraws; i++)
        {
            while (RandomList.Count() < 7)//RandomList.Count() Räknar upp hur många element som läggs i listan tills det blivit 7
            {
                r = rand.Next(1, 35);
                if (!RandomList.Contains(r)) // Kollar om Lista innehåller flera av samma tal, om inte så läggs tal i lista 
                {
                    RandomList.Add(r);
                }
            }
            CompareList();
        }
                                                                      } 
        public void CompareList() //Metod för att jämföra listors värde Klar!!
        {            
            foreach (int item in RandomList) 
            {               
                if (AddNumberArray.Contains(item)) //ÄNDRA TILLBAKA TILL USERNUMBERS!!!!!!!!!!!!!!!!
                {
                    counter++; //Räknar nummer i en dragning om ex. 5 rätta uppnås, nollställs sedan för nästa dragning
                }
            }                         
                if (counter == 5) //If-sats för att se om räknaren för 5 rätt har hittat 5 rätt
                {
                    five++; //Räknare för antal rätt 
                    amount1.Text = five.ToString();  //Skriver ut antal rätt i textbox
                }
                if (counter == 6)
                {
                    six++;
                    amount2.Text = six.ToString();                  
                }
                if (counter == 7)
                {
                    seven++;
                    amount3.Text = seven.ToString();                     
                }                                               
            RandomList.Clear();
            counter = 0;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if(AddNumbers() == true) //Om Addnumbers går igenom validering så körs nedanstående metoder efter knapptryck
            {
                AddNumbers();
                RandomDraws();         
            }
            UserNumbers.Clear();
        }

        //Nedanstående är textboxarna, metoden CheckTextBox körs för att se så inte dessa är tomma. 
        //Är de tomma så kommer inte knappen i programmet att aktiveras
        private void LottoRow4_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void LottoRow5_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void LottoRow6_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void LottoRow7_TextChanged_1(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void LottoRow2_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void draws_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void LottoRow1_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void LottoRow3_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }
    }
}
