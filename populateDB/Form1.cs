using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Data.SqlClient;
using System.Security;


namespace populateDB
{
    public partial class Form1 : Form
    {
        String username = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Replace("7-11\\", "").ToUpper().Trim();
        static String logPath = @"\\vmdevdsm5.711dev.pvt\c$\Documents and Settings\vprabh01\Desktop\TestFoodRecInsert.txt";
        StreamWriter reportLog;
        public static List<string> authenticatedUsers = new List<string>();
        SqlConnection conn;
        public Form1()
        {
            try
            {
                InitializeComponent();
                label1.Select();
                reportLog = new StreamWriter(logPath, true);
                reportLog.AutoFlush = true;
                ToolTip inputPrompt = new ToolTip();
                inputPrompt.ShowAlways = true;
                inputPrompt.SetToolTip(productInput, "Enter food name for DB insert");
                ToolTip submitPrompt = new ToolTip();
                inputPrompt.ShowAlways = true;
                submitPrompt.SetToolTip(submitButton, "Click submit to add your product ratings entry to the database.");
                runStoredProcedure("getAdmins");
            }
            catch (Exception ex)
            {
                reportLog.WriteLine(DateTime.Now.ToString() + ":\nApplication experienced the following error: " + ex.ToString() + "\nStack Trace:\n" + ex.StackTrace);
                MessageBox.Show("Error: " + ex.Message.ToString() + " - Please contact support at Varun.Prabhakar@Cognizant.com.");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (authenticatedUsers.Contains(username))
                {
                    bool valid = true;
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox textBox = c as TextBox;
                            if (textBox.Text == string.Empty && valid)
                            {
                                valid = false;
                                MessageBox.Show("Please complete all fields before clicking Submit.");
                                break;
                            }
                        }
                    }
                    if (valid)
                        runStoredProcedure("prodInsert");
                }
                else
                {
                    reportLog.WriteLine(DateTime.Now.ToString() + ": Unauthorized user " + username + " attempted to insert into table.");
                    MessageBox.Show("Could not authenticate " + username + " as an authorized user.");
                }
            }
            catch (Exception ex)
            {
                reportLog.WriteLine(DateTime.Now.ToString() + ":\nApplication experienced the following error: " + ex.ToString() + "\nStack Trace:\n" + ex.StackTrace);
                MessageBox.Show("Error: " + ex.Message.ToString() + " - Please contact support at Varun.Prabhakar@Cognizant.com.");
            }
        }

        private void runStoredProcedure(string spName)
        {
            try
            {
                conn = new SqlConnection("server=localhost;database=FoodRec;integrated security=SSPI;");
                String query = spName;
                conn.Open();
                SqlCommand ds = new SqlCommand(query, conn);
                ds.CommandType = CommandType.StoredProcedure;
                if (spName.Equals("getAdmins"))
                {
                    SqlDataReader Reader;
                    Reader = ds.ExecuteReader();
                    while (Reader.Read())
                        authenticatedUsers.Add(Reader[0].ToString().Trim());
                    Reader.Close();
                }
                else if (spName.Equals("prodInsert"))
                {
                    ds.Parameters.Add("@Brand", SqlDbType.VarChar).Value = "7-11";
                    ds.Parameters.Add("@Name", SqlDbType.VarChar).Value = productInput.Text;
                    ds.Parameters.Add("@NumRatings", SqlDbType.Int).Value = 1;
                    ds.Parameters.Add("@numSweets", SqlDbType.Int).Value = sweetBox.Text;
                    ds.Parameters.Add("@numSalty", SqlDbType.Int).Value = saltBox.Text;
                    ds.Parameters.Add("@numCrunchy", SqlDbType.Int).Value = crunchBox.Text;
                    ds.Parameters.Add("@numSour", SqlDbType.Int).Value = sourBox.Text;
                    ds.Parameters.Add("@numHot", SqlDbType.Int).Value = hotbox.Text;
                    ds.Parameters.Add("@numChicken", SqlDbType.Int).Value = chickenBox.Text;
                    ds.Parameters.Add("@numBeef", SqlDbType.Int).Value = beefBox.Text;
                    ds.Parameters.Add("@numPork", SqlDbType.Int).Value = porkBox.Text;
                    ds.Parameters.Add("@numCheesy", SqlDbType.Int).Value = cheesyBox.Text;
                    ds.Parameters.Add("@numSize", SqlDbType.Int).Value = sizeBox.Text;
                    ds.Parameters.Add("@numBaked", SqlDbType.Int).Value = bakedBox.Text;
                    ds.Parameters.Add("@numFrozen", SqlDbType.Int).Value = frozenBox.Text;
                    ds.Parameters.Add("@numCold", SqlDbType.Int).Value = coldBox.Text;
                    ds.Parameters.Add("@numSpicy", SqlDbType.Int).Value = spiceBox.Text;
                    ds.Parameters.Add("@numSugary", SqlDbType.Int).Value = sugaryBox.Text;
                    ds.Parameters.Add("@numChewy", SqlDbType.Int).Value = chewBox.Text;
                    ds.Parameters.Add("@numVeg", SqlDbType.Int).Value = vegBox.Text;
                    ds.Parameters.Add("@numBreakfast", SqlDbType.Int).Value = breakfastBox.Text;
                    ds.Parameters.Add("@numLunch", SqlDbType.Int).Value = lunchBox.Text;
                    ds.Parameters.Add("@numDinner", SqlDbType.Int).Value = dinnerBox.Text;
                    ds.Parameters.Add("@numSnack", SqlDbType.Int).Value = snackBox.Text;
                    ds.Parameters.Add("@numSoft", SqlDbType.Int).Value = softBox.Text;
                    ds.Parameters.Add("@numBitter", SqlDbType.Int).Value = bitterBox.Text;
                    ds.Parameters.Add("@numHotBev", SqlDbType.Int).Value = hotDrink.Text;
                    ds.Parameters.Add("@numColdBev", SqlDbType.Int).Value = coldDrink.Text;
                    ds.Parameters.Add("@numMeaty", SqlDbType.Int).Value = meatBox.Text;
                    ds.Parameters.Add("@numFruity", SqlDbType.Int).Value = fruitBox.Text;
                    ds.Parameters.Add("@under2bucks", SqlDbType.Int).Value = priceBox.Text;
                    ds.ExecuteNonQuery();
                    MessageBox.Show(productInput.Text + " insert complete.");
                    ClearAllText(this);
                }
                    
                
                //foreach (String user in authenticatedUsers)
                //    MessageBox.Show("Listed user: " + user);
            }
            catch (Exception ex)
            {
                reportLog.WriteLine(DateTime.Now.ToString() + ": Application experienced the following error: " + ex.ToString());
                MessageBox.Show("Error: " + ex.Message.ToString() + " - Please contact support at Varun.Prabhakar@Cognizant.com.");

            }
            finally
            {
                conn.Close();
            }
        }
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is ComboBox)
                    c.Text = "0";
                else
                    ClearAllText(c);
            }
        }

        private void productInput_Click(object sender, EventArgs e)
        {
            if (productInput.Text.ToString() == "Enter Product Name")
                productInput.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
