using CsvHelper;
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
using System.Xml.Linq;



namespace MediaIntegrator
{
    public partial class Form1 : Form
    {
        string store;  
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
        }
        
        //Väljer frånkatalog samt kör metoden fileWatcherFrom när frånmapp valts
        private void fButton_Click(object sender, EventArgs e) 
        {           
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxF.Text = fbd.SelectedPath;             
                fileWatcherFrom();
            }
        } 
        //Väljer tillkatalog där XMLfil ska sparas
        private void tButton_Click(object sender, EventArgs e) 
        {
           
            FolderBrowserDialog fbd2 = new FolderBrowserDialog(); 
            DialogResult result = fbd2.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxT.Text = fbd2.SelectedPath;
            }
        }

        // Vald katalog sparas i store, ändras sedan ett dokument av typ .txt i katalogen så kommer En fileSystemWatcher snappa upp detta
        // när en ändring skett så anropas fwF_Changed som i sin tur kör metoden textToXml();
        //txtWF = textfil+Watcher+Från
        public void fileWatcherFrom() 
        {
            store = textBoxF.Text;
            FileSystemWatcher txtWF = new FileSystemWatcher(store, "*.txt"); //Kollar sökväg samt att filtyp är txt
            txtWF.EnableRaisingEvents = true;
            txtWF.Changed += fwF_Changed;
            txtWF.Created += fwF_Created;
            txtWF.Deleted += fwF_Deleted;
        }

        private void fwF_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Fil borttagen...");
            textToXml();
        }

        private void fwF_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Fil skapad...");
            textToXml();
        }

        //Kollar om fil i frånkatalog har ändrats. Är fallet så, så körs metoden textToXml
        private void fwF_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Fil ändrad...");
            textToXml();
        }

        //Konverterar textfil till xml.
        public void textToXml() 
        {
            string xmlTo = textBoxT.Text;
            string filename = "simplemedia.xml";
            string txtname = "Productlist.txt";
            try
            {
                //string[] files = Directory.GetFiles(store, "*.txt"); //Läser in textfil i vald mapp in i array

                //Fungerar endast om filen på något annat ställe än skrivbord
                //string[] storeTxt = File.ReadAllLines(files[0]); //Läser in data som ligger i "första" filen i vald mapp
                string[] storeTxt = File.ReadAllLines(store + @"\" + txtname);
                             
                //for (int i = 0; i<files.Length; i++) { //TEST
                
                    //string[] storeTxt = File.ReadAllLines(files[i]); //TEST

                // Läser in varje rad i string storeTxt och delar data när ett , dyker upp
                // Lägger därefter in data i den rad/XElement det ska vara i
                //Sparar ner(över fil i katalog(xmlTo/product.xml)
                XElement xE = new XElement("Inventory", from str in storeTxt let fields = str.Split(',') select
                new XElement("Item",
                new XElement("Name", ""),
                new XElement("Count", fields[3]),
                new XElement("Price", fields[2]),
                new XElement("Comment", ""),
                new XElement("Artist", fields[1]),
                new XElement("Publisher", ""),
                new XElement("Genre", fields[4]),
                new XElement("Year", 0),
                new XElement("ProductID", fields[0])
                ));
                xE.Save(xmlTo + "/" + filename);
                   // } //Test
            }
            catch (IOException) { }
            catch (UnauthorizedAccessException) { }
        } 
    }
}
