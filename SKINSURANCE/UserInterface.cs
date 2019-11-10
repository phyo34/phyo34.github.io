using skinsurance;
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

namespace SKINSURANCE
{
    /// <summary>
    /// Describes the user interface.
    /// </summary>
    public partial class UserInterface : Form
    {

        Dictionary<string, string[]> productList = new Dictionary<string, string[]>();

        /// <summary>
        /// Initializes the user interface.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads in the necessary information on startup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInterface_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader inFile = new StreamReader(@"dumpbox\skinproducts.txt"))
                {
                    while (!inFile.EndOfStream)
                    {
                        string prodName = inFile.ReadLine(); // read in product name
                        string content = inFile.ReadLine(); // read in ingredients list
                        string[] items = new string[0];
                        if(content != null)
                            items = content.Split(','); // tokenize each ingredient

                        for (int i = 0; i < items.Length; i++)
                            items[i] = items[i].Trim().ToLower(); // make each entry nice

                        uxProductOne.Items.Add(prodName); // adding name to the drop down lists
                        uxProductTwo.Items.Add(prodName);
                        productList.Add(prodName, items); // add product and ingredients to dictionary
                    }
                }
            }
            catch
            {
                MessageBox.Show("Product list was not able to be read.");
            }
        }

        /// <summary>
        /// Initiates the comparision between the ingredients of the two chosen products.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCompare_Click(object sender, EventArgs e)
        {
            Cleanser();
            string prodNameUno = uxProductOne.Text; // getting product names from user
            string prodNameDos = uxProductTwo.Text;
            string[] ingredientsOne = new string[0]; // declaring the ingredient arrays
            string[] ingredientsTwo = new string[0];

            // if product one is on our list
            if (productList.ContainsKey(prodNameUno))
            {
                bool getValue = productList.TryGetValue(prodNameUno, out string[] value);
                if (getValue) // if the key got got,
                    ingredientsOne = value; // store value array
                else
                    MessageBox.Show("Product One is not in our collection. Please try another.");
            }

            // if product two is on our list
            if (productList.ContainsKey(prodNameDos))
            {
                bool getValue = productList.TryGetValue(prodNameDos, out string[] value);
                if (getValue) // if got the key,
                    ingredientsTwo = value; // store 2nd ingredients
                else
                    MessageBox.Show("Product Two is not in our collection. Please try another.");
            }

            CompareProducts.CompareIngredients(ingredientsOne, ingredientsTwo);


            foreach (string item in ingredientsOne)
            {
                uxIngredientsOne.Items.Add(item);
            }
            foreach (string item in ingredientsTwo)
            {
                uxIngredientsTwo.Items.Add(item);
            }


            bool good = CompareProducts.AllGood(out bool harmfulConflict, out bool lessEffective);
            if (good == true)
            {
                uxGreen.BackColor = Color.Green;
            }
            //else
            //{
                if (harmfulConflict == true)
                {
                    uxRed.BackColor = Color.Red;
                }
                if (lessEffective == true)
                {
                    uxOrange.BackColor = Color.Orange;
                }
            //}


        }

        public void Cleanser()
        {
            uxGreen.BackColor = default;
            uxRed.BackColor = default;
            uxOrange.BackColor = default;
            uxIngredientsOne.Items.Clear();
            uxIngredientsTwo.Items.Clear();
        }
    }
}
