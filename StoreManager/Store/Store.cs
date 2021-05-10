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
using Microsoft.VisualBasic;

namespace Store
{
    public partial class Store : Form
    {

        public Store()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Store_Close);
        }


        int r, row;
        Product prod = new Product();

        public void Form1_Load(object sender, EventArgs e)
        {
            OpenProductStorage(); //När programmet startas så kommer programmet hämta lagerfilen
            OpenProductCheckout();
        }

        public void Store_Close(object sender, FormClosingEventArgs e)
        {        
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult close = MessageBox.Show("Du kommer nu att stänga ner programmet! Köp som ej är genomförda kommer att gå förlorade, vill du fortsätta?", "Varning!", MessageBoxButtons.YesNo);

                if (close == DialogResult.Yes)
                {
                    Application.Exit();
                }
                if (close == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        public void Lager_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Lager"); Visar meddelande när man klickar på själva formen
        }

        public void Kassa_Click(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
        }
        public void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void removeButton_Click(object sender, EventArgs e)
        {                      
            removeProduct();
        }
        
        public void addButton_Click(object sender, EventArgs e)
        {
            addProduct();
            
            //Nedanstående rensar all textboxar efter man klickat på addButton
            textArtNr.Clear();
            textProduct.Clear();
            textPrice.Clear();
            textQuantity.Clear();
            textMediaType.Clear();
        }
        
        public void addToCart_Click(object sender, EventArgs e)
        {
            moveToCart();
        }

        private void removeCart_Click(object sender, EventArgs e)
        {
            removeFromCart();
        }
 
        private void buyButton_Click(object sender, EventArgs e)
        {
            buyMethod();                     
        }

        public void quantityButton_Click_1(object sender, EventArgs e)
        {
            addQuantity();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exitMethod();
        }

         /* addProduct:
         * Metoden addProduct innehåller felhantering för inmatning av produktinformation.
         * Går allt igenom så kommer information i textBoxarna att läggas in på respektive plats i datagridview och därefter körs
         * funktionen saveProducts();
         */
        public void addProduct()
        {
            int checkInt;
            double checkDouble;
            
            try
            {                              
                for(int i=0; i<dataGridView1.Rows.Count; i++)
                {
                    if(dataGridView1.Rows[i].Cells[0].Value.ToString() == textArtNr.Text)
                    {
                        MessageBox.Show("Artikelnummer upptaget! Skapa ett nytt artikelnummer för att gå vidare!");
                        return;
                    }
                }
                
                if (textArtNr.Text == "" || textProduct.Text == "" || textPrice.Text == "" ||
                  textQuantity.Text == "" || textMediaType.Text == "")
                {
                    MessageBox.Show("Alla rutor måste fyllas i!");
                }
                
                else if (!int.TryParse(textArtNr.Text, out checkInt) || int.Parse(textArtNr.Text) <= 0)
                {
                    MessageBox.Show("Artikelnummer kan bara bestå av positiva nummer!");                   
                }
                                
                else if (!int.TryParse(textQuantity.Text, out checkInt) || int.Parse(textQuantity.Text) < 0)
                {
                    MessageBox.Show("Antal kan bara bestå av positiva nummer!");
                }

                else if (!double.TryParse(textPrice.Text, out checkDouble) || double.Parse(textPrice.Text) < 0)
                {
                    MessageBox.Show("Pris kan bara bestå av positiva nummer!");
                }

             

                else
                {
                    r = dataGridView1.Rows.Add();

                    prod.artNr = int.Parse(textArtNr.Text);
                    dataGridView1.Rows[r].Cells[0].Value = prod.artNr;
                
                    prod.productName = textProduct.Text;
                    dataGridView1.Rows[r].Cells[1].Value = prod.productName;

                    prod.Price = double.Parse(textPrice.Text);  
                    dataGridView1.Rows[r].Cells[2].Value = prod.Price;


                    prod.Quantity = int.Parse(textQuantity.Text);
                    dataGridView1.Rows[r].Cells[3].Value = prod.Quantity;

                    prod.Media = textMediaType.Text;
                    dataGridView1.Rows[r].Cells[4].Value = prod.Media;

                    SaveProducts();
                }

            }

            catch (Exception)
            {
            }
                
        }
        /* addQuantity:
        * Metoden addQuantity innehåller felhantering för inmatning av antal varor i lager. Får inte vara negativt, innehålla bokstäver
        * och textruta kan inte vara tom. 
        * Går allt igenom så kommer information i textBox att läggas in på cell[3] i datagridview och därefter körs
        * funktionen saveProducts(); och textruta för antal töms.
        */
        public void addQuantity() 
        {
            try
            {
                if (int.Parse(textQuantity.Text) > 0)
                {
                    prod.Quantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) + int.Parse(textQuantity.Text);
                    dataGridView1.CurrentRow.Cells[3].Value = prod.Quantity;
                    SaveProducts();
                    textQuantity.Text = null;
                }

                else
                {
                    MessageBox.Show("Antal kan inte vara negativt!");
                }
            }
                catch(Exception)
                {
                    MessageBox.Show("Quantity får inte vara tomt eller innehålla bokstäver!");
                }
        }

        /* removeProduct:
        * Metoden removeProduct innehåller felhantering om man vill ta bort varor från lager.
        * Markerad rad i datagridview läggs i row
        * En if-sats kollar sedan så rad i datagridview existerar. Gör den det så kan man ta bort markerad rad
        * Ett meddelande dyker först upp där användaren kan ändra sig. Klickar användare Yes så raderas data på markerad rad 
        * från datagridview i Lager samt lagerlista som visas i kassavy.
        * Raderar man sista produkten i lager så kommer även lagerfilen på datorn raderas. Dock skapas en ny så fort en 
        * ny produkt läggs till eller att programmet startas om.
        */
        public void removeProduct()
        {
            try
            {
                row = dataGridView1.CurrentCell.RowIndex;

                if (dataGridView1.CurrentCell.ColumnIndex >= 0)
                {
                    DialogResult options = MessageBox.Show("Artikel kommer att raderas från lager!", "Varning", MessageBoxButtons.YesNo);
                    if(options == DialogResult.Yes) { 
                        dataGridView1.Rows.RemoveAt(row);
                        showStorageView.Rows.RemoveAt(row);
                        SaveProducts();
                    }
                }
             
            }
            catch (Exception)
            {
                MessageBox.Show("Finns ingen vara att ta bort!");
                File.Delete("Productlist.txt");
            }
        }
        /*SaveProducts:
        * Se kommentarer i metoden för metodens funktion.
        */
        public void SaveProducts()
        {
           
            string Filename = "Productlist.txt";
            // Tar bort header/ om inte detta görs så blir det en extra cell/starttab i textfilen 
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            // Väljer alla celler
            dataGridView1.SelectAll();
            // Kopierar innehållet i datagridview
            Clipboard.SetDataObject(dataGridView1.GetClipboardContent());
            // Klistrar in det kopierade innehållet i en textfil. (TextDataFormat.Text) används för tab mellan celler
            //File.WriteAllText(Filename, Clipboard.GetText(TextDataFormat.Text));
            File.WriteAllText(Filename, Clipboard.GetText(TextDataFormat.CommaSeparatedValue));


            showStorageView.Rows.Clear(); //Direkt metoden SaveProducts(); körs så kommer lagerlista i kassa att tömmas
            OpenProductCheckout(); // Efter lagerlistan i kassa blivit tömd så kommer en ny lista laddas upp med nya produkter

            
        }


        public void textArtNr_TextChanged(object sender, EventArgs e)
        {

        }
        /*OpenProductStorage:
       * Se kommentarer i metoden för metodens funktion.
       */
        public void OpenProductStorage()
        {
            try
            {
                using (var streamReader = new StreamReader(@"Productlist.txt"))
                {
                    while (!streamReader.EndOfStream)//Kör streamReader tills loopen når sista raden
                    {
                        var line = streamReader.ReadLine(); //Läser en rad åt gången och lägger den i line
                        var values = line.Split(','); //Splittar en sträng vid , och lägger varje del i en array
                        var rowIndex = dataGridView1.Rows.Add(); // Lägger varje rads index i rowIndex
                        for (int i = 0; i < values.Length; i++) //Varje del från den splittade strängen kommer läggas in på respektive plats i datagridview med for-loopen
                        {
                            dataGridView1.Rows[rowIndex].Cells[i].Value = values[i];
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Det finns för närvarande ingen lagerlista. Ny lagerlista kommer skapas när du lägger till första produkten i programmet!");
            }
          

        }

        /*OpenProductCheckout:
       * Innehåller samma funktion som metoden OpenProductStorage().
       */
        public void OpenProductCheckout()
        {
            try
            {
                using (var streamReader = new StreamReader(@"Productlist.txt"))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();
                        var values = line.Split(',');
                        var rowIndex = showStorageView.Rows.Add();
                        for (int i = 0; i < values.Length; i++)
                        {
                            showStorageView.Rows[rowIndex].Cells[i].Value = values[i];
                        }
                    }
                }
            }
            catch (Exception)
            {
               // MessageBox.Show("Det finns för närvarande ingen lagerlista. Ny lagerlista kommer skapas när du lägger till första produkten i programmet!");
            }
        }
        /*moveToCart:
       * Metoden moveToCart innehåller funktion för att föra över en vara från lagerlistan till kundvagnen.
       * Innehåller även felhantering. Användare skriver in antal varor denne vill föra över.
       * Är antalet mindre än noll eller påverkar lagerstatus negativt så kommer ett felmeddelande visas och användaren får försöka på nytt
       * If-sats används för att kolla om input är större/mindre än antal i lista. Vid ok, så går en foreach-loop igenom vald rad och lägger index på vald rad i row
       * i foreach-loopen så läggs rätt rad i variabel n. n motsvarar vald rad och cell[3] motsvarar antal.
       */
        public void moveToCart()
        {           
            try
            {
                string quantityInput = Interaction.InputBox("Skriv in antalet varor du vill lägga i kundvagnen!", "Varning", "1");
                int quantityInt = int.Parse(quantityInput);
                int totalAmount = Convert.ToInt32(showStorageView.CurrentRow.Cells[3].Value) - quantityInt;
               
                if (quantityInt > 0 && totalAmount >= 0)
                {
                    foreach (DataGridViewRow row in showStorageView.SelectedRows)
                    {
                        int n = customerCart.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
                        customerCart.Rows[n].Cells[3].Value = quantityInt;

                    }

                    showStorageView.CurrentRow.Cells[3].Value = Convert.ToInt32(showStorageView.CurrentRow.Cells[3].Value) - quantityInt;
                    dataGridView1.CurrentRow.Cells[3].Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) - quantityInt;
            
                }
                else if(totalAmount < 0)
                {
                    MessageBox.Show("Obs! Du kan inte föra över fler varor än vad som finns på lager!");
                }

                else
                {
                    MessageBox.Show("Antal måste vara större än noll!");
                }


            }
            catch (Exception)
            {

            }

            
        }

        /*removeFromCart:
        * Metoden removeFromCart jämför artikelnummer från vara i kundvagn med vara i lagerlista.
        * Stämmer artikelnumren så kan vara föras tillbaka från kundvagnen till lagerlista.
        * Vald rad läggs i variebel row med hjälp av en foreach-loop. värdet för vald rad cell[3] (antal), läggs i variabel quantityCart.
        * lagerlistans valda rad med värde från cell[3] (antal) läggs i variabel quantityStorage.
        * Dessa två värden adderas och läggs i variebeln totalQuantity som sedan skriver över nuvarande värde i lagerlistans valda rad, cell[3].
        * Slutligen raderas vald rad i kundvagn.
        */
        public void removeFromCart() 
        {
            try
            {
                    if (Convert.ToInt32(customerCart.CurrentRow.Cells[0].Value) == Convert.ToInt32(showStorageView.CurrentRow.Cells[0].Value))
                    {
                        Console.WriteLine("Artikelnummer kundvagn: " + customerCart.CurrentRow.Cells[0].Value);
                        Console.WriteLine("Artikelnummer Lagervy: " + showStorageView.CurrentRow.Cells[0].Value);
                        foreach (DataGridViewRow row in customerCart.SelectedRows)
                        {
                            var quantityCart = row.Cells[3].Value;
                            var quantityStorage = showStorageView.CurrentRow.Cells[3].Value;
                            var totalQuantity = Convert.ToInt32(quantityCart) + Convert.ToInt32(quantityStorage);
                            showStorageView.CurrentRow.Cells[3].Value = totalQuantity;
                            customerCart.Rows.RemoveAt(row.Index);
                        }
                    }
            }
            catch (Exception) {
                MessageBox.Show("Obs! artikelnumret på varan i kundvagnen matchar inte artikelnumret för lagervara!");
            }
        }


        /*buyMethod:
        * Om kundvagnen innehåller minst en vara så kan ett köp genomföras.
        * lagerlista i lagervy töms när köpet gjorts och blir uppdaterad då den nya sparade listan direkt öppnas.
        * Även kundvagnen töms och ett meddelande att köp genomförts dyker upp.
        */
        public void buyMethod()
        {
            try
            {
                if(customerCart.Rows.Count > 0)
                {
                    string Filename = "Productlist.txt"; 
                    showStorageView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
                    showStorageView.SelectAll();
                    Clipboard.SetDataObject(showStorageView.GetClipboardContent());
                    File.WriteAllText(Filename, Clipboard.GetText(TextDataFormat.CommaSeparatedValue));

                    dataGridView1.Rows.Clear();
                    OpenProductStorage();
                    customerCart.Rows.Clear();
                    
                    MessageBox.Show("Köp genomfört!");
                }
            }
            catch (Exception)
            {
            }
        }
        
        /*exitMethod:
        * Ger användaren ett val om denne vill stänga ner programmet.  
        */
        
        public void exitMethod()
        {
            DialogResult close = MessageBox.Show("Du kommer nu att stänga ner programmet! Köp som ej är genomförda kommer att gå förlorade, vill du fortsätta?", "Varning!", MessageBoxButtons.YesNo);

            if(close == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            if(close == DialogResult.No)
            {
               //e.Cancel = true;
               

            }

        }
    }
}

      
