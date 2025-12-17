using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // an argument.

        // The GetCountries method accpets a filename as an
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.
        

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName; // To hold the file name

            GetFileName(out fileName);
            GetCountries(fileName);
        }

        private void GetFileName(out string fileName)
        {
            // Show the Open File dialog box.
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name.
                fileName = openFile.FileName;
            }
            else
            {
                // User canceled, so set fileName to an empty string.
                fileName = string.Empty;
            }
        }

        private void GetCountries(string fileName)
        {
            string country; // To hold a country name
            // Clear the list box.
            countriesListBox.Items.Clear();
            // Check if a file name was provided.
            if (fileName == string.Empty)
            {
                StreamReader inputFile = File.OpenText(fileName);

                while (!inputFile.EndOfStream)
                {
                    // Read a country name.
                    country = inputFile.ReadLine();
                    // Add the country name to the list box.
                    countriesListBox.Items.Add(country);
                }
            }
            else
            {
                // Display a message indicating that no file was selected.
                MessageBox.Show("未選取城市","錯誤");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}
