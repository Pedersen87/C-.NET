using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace OrdProgrammet
{
    public partial class Form1 : Form
    {
        private string fileName = string.Empty;
        bool textChangeCheck = false;

        public Form1()
        {
            InitializeComponent();
            this.Text = "dok1.txt";
        }

        public void newFunction() //Metod som nollställer allt
        {
           this.fileName = string.Empty;
           textBox.Text = "";
           textChangeCheck = false;
           this.Text = "dok1.txt"; 
            
        }

        /*https://stackoverflow.com/questions/35911194/trying-to-save-file-without-using-savefiledialog*/
        public void saveFunction() //Sparar över befintlig fil
        {
            //textChangeCheck = false; 
            if (string.IsNullOrEmpty(fileName)) //Om fil ej finns för överskrivning så körs saveAsFunction
            {
                saveAsFunction();
            }
            else
            {   
                /*sparar med nytt filnamn, skriver innehållet i textbox till fil, "nollställer" textChangecheck*/
                this.Text = string.Format(Path.GetFileNameWithoutExtension(fileName), Encoding.Default); //Sparar befintliga filen samt tolkar text med åäö
                StreamWriter writer = new StreamWriter(fileName);
                writer.Write(textBox.Text);
                textChangeCheck = true;
                writer.Close();
            }         

        }

        public void saveAsFunction()
        {
            SaveFileDialog wordFileSave = new SaveFileDialog();
            wordFileSave.Filter = "Text Files: (*.txt)|*.txt"; //Filter för vilken sorts filtyp som ska sparas
            //textChangeCheck = false; 

            if (wordFileSave.ShowDialog() == DialogResult.OK) 
            {
                this.fileName = wordFileSave.FileName; //Sparar ny fil till nytt namn
                this.Text = string.Format("{0}", Path.GetFileNameWithoutExtension(wordFileSave.FileName), Encoding.Default); 
                StreamWriter writing = new StreamWriter(wordFileSave.FileName);
                writing.Write(textBox.Text);
                textChangeCheck = true;
                writing.Close();
              
            }
        }

        public void openFunction() // Funktion för att öppna fil
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            open.FileName = ""; 
            textChangeCheck = false; //Sätts till false annars tror programmet att texten är ändrad direkt

            if (open.ShowDialog() == DialogResult.OK)
            {
                this.fileName = open.FileName;
                this.Text = string.Format("{0}", Path.GetFileNameWithoutExtension(open.FileName), Encoding.Default);
                StreamReader reader = new StreamReader(open.FileName);
                textBox.Text = reader.ReadToEnd();
                textChangeCheck = true; 
                reader.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            if (!this.Text.Contains("*"))
            {
                Application.Exit();
            }
           
            else
            {
                DialogResult exitFile = MessageBox.Show("Vill du spara ändringarna i ditt dokument?", "Ordbehandlar'n", MessageBoxButtons.YesNoCancel);
                if (exitFile == DialogResult.Yes)
                {
                    saveFunction();
                    Application.Exit(); 
                }
                
                if(exitFile == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            saveAsFunction();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            saveFunction();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (!this.Text.Contains("*"))
            {
                openFunction();
            }
            
            else
            { 
                DialogResult openFile = MessageBox.Show("Vill du spara ändringarna i ditt dokument?", "Ordbehandlar'n", MessageBoxButtons.YesNoCancel);
                if (openFile == DialogResult.Yes)
                {
                    saveFunction();
                    openFunction();
                } 
                
                if(openFile == DialogResult.No)
                {
                    openFunction();
                }
            }
        }

        private void newFile_Click(object sender, EventArgs e)
        {

            if (!this.Text.Contains("*"))
            {
                newFunction();
            }
            
            else
            {
                DialogResult newFile = MessageBox.Show("Vill du spara ändringarna i ditt dokument?", "Ordbehandlar'n", MessageBoxButtons.YesNoCancel);
                if (newFile == DialogResult.Yes)
                {
                    saveFunction();
                    newFunction();
                }
                
                if(newFile == DialogResult.No)
                {
                    newFunction();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
            
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textChangeCheck == true) //Om en ändring i texten sker så får this.Text en * bakom filnamnet
            {
                this.Text = string.Format(Path.GetFileNameWithoutExtension(fileName) + "*"); //Aktuell              
            }

            else if (this.Text == "dok1.txt") //Finns det ej ett sparat filnamn så får defaultnamnet en *
            {
                this.Text = "dok1.txt*";
            }
        }
    }
}
