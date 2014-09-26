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
using CSVLib;

namespace DailyExpenseApplication
{
    public partial class DailyExpenseUI : Form
    {
        public DailyExpenseUI()
        {
            InitializeComponent();
        }

        private string fileLocation = @"entrynote.csv";

        private void saveButton_Click(object sender, EventArgs e)
        {
        
            FileStream aStream = new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aStream);
            List<string> dailyEntry = new List<string>();
            dailyEntry.Add(amountTextBox.Text);
            dailyEntry.Add(categoryComboBox.Text);
            dailyEntry.Add(particularTextBox.Text);
            aWriter.WriteRow(dailyEntry);



            if (amountTextBox.Text == String.Empty || categoryComboBox.Text == string.Empty || particularTextBox.Text == string.Empty )
            {
                MessageBox.Show("Please enter all fileds");
            }
            else
            {
                MessageBox.Show("Data save successfully");
            }
                   
            amountTextBox.Text = "";
            categoryComboBox.Text = "";
            particularTextBox.Text = "";

            aStream.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.OpenOrCreate);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> expense = new List<string>();
            List<string> maxexpense = new List<string>();

            double totalExpense = 0;
            double maximumExpense = 0;

            if (new FileInfo(fileLocation).Length != 0) ;

            while (aReader.ReadRow(expense))
            {
                double categoryWiseExpense = Convert.ToDouble(expense[0]);

                totalExpense = totalExpense + categoryWiseExpense;
                totalExpenseTextBox.Text = totalExpense.ToString();

              

                maximumExpense = totalExpense + categoryWiseExpense;
                maximumExpenseTextBox.Text = totalExpense.ToString();
            }
            aStream.Close();

            

        }

        private void viewCategoryWiseShowButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
           

        }
        }
    }

