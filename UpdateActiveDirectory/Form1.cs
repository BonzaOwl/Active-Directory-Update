using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.DirectoryServices;

namespace UpdateActiveDirectory
{
    public partial class Form1 : Form
    {

        public string FileName = "C:\\AD_Update.log";

        public static int UpdateCnt = 0;
        public static int ErrorCnt = 0;

        SqlConnection Con = new SqlConnection("Data Source=localhost;Initial Catalog=test;User ID=;Password=");

        DateTime now = new DateTime();

        public Form1()
        {
            InitializeComponent();        
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            GetResults();

        }

        public void GetResults()
        {           
            try
            {
                Con.Open();

                SqlCommand GetDetails = new SqlCommand("Select * from " + txtTablename.Text, Con);                    

                SqlDataReader reader = GetDetails.ExecuteReader();                

                DataTable t1 = new DataTable();

                t1.Load(reader);

                if (t1.Rows.Count > 0)
                {
                    DataColumn usr = t1.Columns["username"];
                    DataColumn tel = t1.Columns["telephone"];

                    foreach (DataRow dr in t1.Rows)
                    {
                        var username = dr[usr].ToString();
                        var telephone = dr[tel].ToString();

                        UpdateActiveDirectory(username, telephone);
                    }                    

                }

                Con.Close();

                lblUpdateCnt.Text = UpdateCnt.ToString();
                lblErrorCnt.Text = ErrorCnt.ToString();

            }
            catch (Exception ex)
            {
                string error = ex.ToString();

            }            
        }

        public void RecordLog(string username, string telephone, string result)
        {
            if (File.Exists(FileName))

            {
                now = DateTime.Now;
                File.AppendAllText(FileName, now + " " + username + " " + telephone + " " + result + Environment.NewLine);
            }
            else
            {
                now = DateTime.Now;
                File.Create(FileName);
                File.AppendAllText(FileName, now + " " + username + " " + telephone + " " + result + Environment.NewLine);
            }
        }

        public bool UpdateActiveDirectory(string username, string telephone)
        {

            //try
            //{
            //    DirectoryEntry rootEntry = new DirectoryEntry("LDAP://" + LdapServerName, "usrename", "password", AuthenticationTypes.Secure);

            //    DirectorySearcher searcher = new DirectorySearcher(rootEntry);
            //    searcher.Filter = "(sAMAccountName=" + username + ")";

            //    SearchResult result = searcher.FindOne();

            //    if (result != null)
            //    {
            //        // create new object from search result    
            //        DirectoryEntry entryToUpdate = result.GetDirectoryEntry();

            //        entryToUpdate.Properties["telephoneNumber"].Value = telephone;

            //        entryToUpdate.CommitChanges();

            //        RecordLog(username, telephone, "User Updated");
            //        UpdateCnt = UpdateCnt + 1;
            //    }
            //    else
            //    {
            //        RecordLog(username, telephone, "User Not Updated");

            //        ErrorCnt = ErrorCnt + 1;
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception caught:\n\n" + e.ToString());
            //}

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
