using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace groupProject
{
    public partial class Form1 : Form
    {
         public Form1()
        {
            InitializeComponent();
            textBoxPackageId.Text = ("test");
            //  string queryString = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkdDesc, PkgBasePrice, PkgAgencyCommission, Products  FROM travelexperts2.packages";
            //  MessageBox.Show(queryString);
            // string queryString = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkdDesc, PkgBasePrice, PkgAgencyCommission, Products  FROM travelexperts2.packages";
            // listbox.Show(queryString);
            if (tabProducts.Enabled.Equals(true))
            {
                var product = new Products();
                txtBoxProductId.Text = product.test();
            }
            GetPackages();
        }
      //  tabProducts.Selecting += new TabControlCancelEventHandler(tabProducts_Selecting);

      

        void tabProducts_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;

            // Validate the current page. To cancel the select, use:
            e.Cancel = true;


            //  var product = new Products();
            //  txtBoxProductId.Text = product.test();
            
        }

        public package GetPackages()
        {
            SqlConnection connection = travelexpertsDB.GetConnection();
            string selectStatement = "SELECT *" + "FROM packages";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader PackageReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                    if (PackageReader.Read())
                    {
                    package Package = new package();
                  //  Package.PackageId =(string)PackageReader["PackageId"];
                   // listBox1.Items.Add(Package.PackageId);
                    return Package;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
           

    }



    private void Form1_Load(object sender, EventArgs e)
        {
            //displaypackages();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPackageId_TextChanged(object sender, EventArgs e)
        {
            textBoxPackageId.Text = ("test");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string queryString = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkdDesc, PkgBasePrice, PkgAgencyCommission, Products  FROM travelexperts2.packages";
            listBox1.DataSource = queryString;

        }
        private void displaypackages()
        {
            string queryString = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkdDesc, PkgBasePrice, PkgAgencyCommission, Products  FROM travelexperts2.packages";
            listBox1.Items.Add(queryString);


        }

        private void txtBoxPackageId_TextChanged(object sender, EventArgs e)
        {
            //string txtBoxPackageId;
        //    txtBoxPackageId.Text = "test";
           // tBox1.Text += "a";
        }

        private void tabPackages_Click(object sender, EventArgs e)
        {

        }



        //string queryString = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkdDesc, PkgBasePrice, PkgAgencyCommission, Products  FROM travelexperts2.packages;";


    }
}
