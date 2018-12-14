using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;

namespace UpdateActiveDirectory
{
    public partial class Form1 : Form
    {

        public string FileName = "C:\\AD_Update.log";

        public static string FirstName;
        public static string Initials;
        public static string LastName;
        public static string DisplayName;
        public static string Description;
        public static string Office;
        public static string TelephoneNumber;
        public static string OtherTelephoneNumber;
        public static string Email;

        public static string AuthUsrName;
        public static string AuthUsrPassword;

        public static int UpdateCnt = 0;
        public static int ErrorCnt = 0;

        public static string DBServer;
        public static string DBDatabase;
        public static string DBUsr;
        public static string DBUsrPassword;

        SqlConnection Con = new SqlConnection("Data Source=" + DBServer + ";Initial Catalog=" + DBDatabase + ";User ID=" + DBUsr + ";Password=" + DBUsrPassword + "");

        DateTime now = new DateTime();

        public Form1()
        {
            InitializeComponent();        
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }        

        public void GetResults()
        {
            GetDBAuthDetails();

            try
            {
                Con.Open();

                SqlCommand GetDetails = new SqlCommand("Select * from " + txtTablename.Text + "", Con);

                SqlDataReader reader = GetDetails.ExecuteReader();

                DataTable t1 = new DataTable();

                t1.Load(reader);

                if (t1.Rows.Count > 0)
                {
                    DataColumn sAMAccountNameCol = t1.Columns["sAMAccountName"];
                    DataColumn FirstNameCol = t1.Columns["Firstname"];
                    DataColumn InitialsCol = t1.Columns["Initials"];
                    DataColumn LastNameCol = t1.Columns["LastName"];
                    DataColumn DisplayNameCol = t1.Columns["DisplayName"];
                    DataColumn DescriptionCol = t1.Columns["Description"];
                    DataColumn OfficeCol = t1.Columns["Office"];
                    DataColumn TelephoneNumberCol = t1.Columns["TelephoneNumber"];
                    DataColumn OtherTelephoneNumberCol = t1.Columns["OtherTelephoneNumber"];
                    DataColumn EmailCol = t1.Columns["Email"];

                    foreach (DataRow dr in t1.Rows)
                    {
                        var UserName = dr[sAMAccountNameCol].ToString();

                        if (chkFirstName.Checked == true)
                        {
                            FirstName = dr[FirstNameCol].ToString();
                        }
                        else
                        {
                            FirstName = string.Empty;
                        }

                        if (chkInitials.Checked == true)
                        {
                            Initials = dr[InitialsCol].ToString();
                        }
                        else
                        {
                            Initials = string.Empty;
                        }

                        if (chkLastname.Checked == true)
                        {
                            LastName = dr[LastNameCol].ToString();
                        }
                        else
                        {
                            LastName = string.Empty;
                        }

                        if (chkDisplayName.Checked == true)
                        {
                            DisplayName = dr[DisplayNameCol].ToString();
                        }
                        else
                        {
                            DisplayName = string.Empty;
                        }

                        if (chkDescription.Checked == true)
                        {
                            Description = dr[DescriptionCol].ToString();
                        }
                        else
                        {
                            Description = string.Empty;
                        }

                        if (chkOffice.Checked == true)
                        {
                            Office = dr[OfficeCol].ToString();
                        }
                        else
                        {
                            Office = string.Empty;
                        }
                        if (ChkAdTelephone.Checked == true)
                        {
                            TelephoneNumber = dr[TelephoneNumberCol].ToString();
                        }
                        else
                        {
                            TelephoneNumber = string.Empty;
                        }

                        if (chkOtherTelephone.Checked == true)
                        {
                            OtherTelephoneNumber = dr[OtherTelephoneNumberCol].ToString();
                        }
                        else
                        {
                            OtherTelephoneNumber = string.Empty;

                        }
                        if (chkEmail.Checked == true)
                        {
                            Email = dr[EmailCol].ToString();
                        }
                        else
                        {
                            Email = string.Empty;
                        }

                        String adPath = GetDomainController.GetDC();

                        UpdateActiveDirectory(UserName, FirstName, Initials, LastName, DisplayName, Description, Office, TelephoneNumber, OtherTelephoneNumber, Email, adPath);
                    }

                }

                Con.Close();                

            }
            catch (Exception ex)
            {
                string error = ex.ToString();

            }
        }

        public void GetAuthUser()
        {
            AuthUsrName = txtDomain.Text + '\\' + txtUsrName.Text;
            AuthUsrPassword = txtPassword.Text;

        }

        public void GetDBAuthDetails()
        {
            DBServer = txtDBServerName.Text;
            DBDatabase = txtDBDatabase.Text;
            DBUsr = txtDBUsrName.Text;
            DBUsrPassword = txtDBPassword.Text;
        }

        public bool UpdateActiveDirectory(string username, string FirstName, string Initials, string LastName, string DisplayName, string Description, string Office, string TelephoneNumber, string OtherTelephoneNumber, string Email, string DomainController)
        {

            try
            {
                //Had to append the domain to the username when authenticating, no domain was causing the commit to not take effect.
                DirectoryEntry rootEntry = new DirectoryEntry("LDAP://" + DomainController, AuthUsrName, AuthUsrPassword, AuthenticationTypes.Secure);

                using (DirectorySearcher searcher = new DirectorySearcher(rootEntry))
                {
                    //Search on the following
                    //People
                    //Users 
                    //Where the sAMAccountName matches the username from the dataser
                    //User is not in a disabled state 
                    searcher.Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + username + ")(!userAccountControl:1.2.840.113556.1.4.803:=2))";

                    if (chkFirstName.Checked == true)
                    {
                        searcher.PropertiesToLoad.Add("givenName");
                    }
                    if (chkInitials.Checked == true)
                    {
                        searcher.PropertiesToLoad.Add("initials");
                    }
                    if (chkLastname.Checked == true)
                    {
                        searcher.PropertiesToLoad.Add("sn");
                    }
                    if (chkDisplayName.Checked == true)
                    {
                        searcher.PropertiesToLoad.Add("displayName");
                    }
                    if (chkDescription.Checked == true)
                    {
                        searcher.PropertiesToLoad.Add("description");
                    }
                    if (chkOffice.Checked == true)
                    {
                        searcher.PropertiesToLoad.Add("physicalDeliveryOfficeName");
                    }
                    if (ChkAdTelephone.Checked == true)
                    {
                        searcher.PropertiesToLoad.Add("telephoneNumber");
                    }
                    if (chkOtherTelephone.Checked == true)
                    {
                        searcher.PropertiesToLoad.Add("otherTelephone");
                    }
                    if (chkEmail.Checked == true)
                    {
                        searcher.PropertiesToLoad.Add("mail");
                    }

                    //Find the user based on the above
                    SearchResult result = searcher.FindOne();

                    //If no user is returned Record that the user was not updated, else update
                    if (result != null)
                    {
                        using (DirectoryEntry entryToUpdate = result.GetDirectoryEntry())
                        {

                            //DirectoryEntry entryToUpdate = result.GetDirectoryEntry();

                            if (chkFirstName.Checked == true)
                            {
                                entryToUpdate.Properties["givenName"].Value = FirstName;
                            }
                            if (chkInitials.Checked == true)
                            {
                                entryToUpdate.Properties["initials"].Value = Initials;
                            }
                            if (chkLastname.Checked == true)
                            {
                                entryToUpdate.Properties["sn"].Value = LastName;
                            }
                            if (chkDisplayName.Checked == true)
                            {
                                entryToUpdate.Properties["displayName"].Value = DisplayName;
                            }
                            if (chkDescription.Checked == true)
                            {
                                entryToUpdate.Properties["description"].Value = Description;
                            }
                            if (chkOffice.Checked == true)
                            {
                                entryToUpdate.Properties["physicalDeliveryOfficeName"].Value = Office;
                            }
                            if (ChkAdTelephone.Checked == true)
                            {
                                entryToUpdate.Properties["telephoneNumber"].Value = TelephoneNumber;
                            }
                            if (chkOtherTelephone.Checked == true)
                            {
                                entryToUpdate.Properties["otherTelephone"].Value = OtherTelephoneNumber;
                            }
                            if (chkEmail.Checked == true)
                            {
                                entryToUpdate.Properties["mail"].Value = Email;
                            }

                            //If we don't commit the changes they will remain in the cache 
                            entryToUpdate.CommitChanges();                            

                            //Update the counter 
                            UpdateCnt = UpdateCnt + 1;

                            lblUpdateCnt.Text = UpdateCnt.ToString();

                            //Write the action to the log 
                            RecordLog(username, FirstName, Initials, LastName, DisplayName, Description, Office, TelephoneNumber, OtherTelephoneNumber, Email, "User Updated");

                        }
                    }
                    else
                    {
                        ErrorCnt = ErrorCnt + 1;

                        lblErrorCnt.Text = ErrorCnt.ToString();

                        RecordLog(username, FirstName, Initials, LastName, DisplayName, Description, Office, TelephoneNumber, OtherTelephoneNumber, Email, "User Not Updated");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught:\n\n" + e.ToString());
            }

            return true;
        }

        public void RecordLog(string username, string FirstName, string Initials, string LastName, string DisplayName, string Description, string Office, string TelephoneNumber, string OtherTelephoneNumber, string Email, string result)
        {
            if (File.Exists(FileName))
            {
                now = DateTime.Now;

                File.AppendAllText(FileName, now + " " + username + " " + FirstName + " " + Initials + " " + LastName + " " + DisplayName + " " + Description + " " + Office + " " + TelephoneNumber + " " + OtherTelephoneNumber + " " + Email + " " + result + Environment.NewLine);
            }
            else
            {
                now = DateTime.Now;
                File.Create(FileName);
                File.AppendAllText(FileName, now + " " + username + " " + FirstName + " " + Initials + " " + LastName + " " + DisplayName + " " + Description + " " + Office + " " + TelephoneNumber + " " + OtherTelephoneNumber + " " + Email + " " + result + Environment.NewLine);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ResetCounters();

            bool Auth = AuthValidation();
            bool ValidDataSource = DataSourceValidation();

            if (Auth == false)
            {
                lblAuthError.Visible = true;
                lblAuthError.Text = "You must provide valid authentication";
                return;
            }
            else if (ValidDataSource == false)
            {
                lblDataSourceError.Visible = true;
                lblDataSourceError.Text = "You must provide valid data source";
                return;

            }
            else
            {
                GetAuthUser();

                GetResults();
            }
        }

        public bool AuthValidation()
        {

            if (txtDomain.Text.Length == 0 || txtUsrName.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool DataSourceValidation()
        {

            if (txtDBServerName.Text.Length == 0 || txtDBDatabase.Text.Length == 0 || txtTablename.Text.Length == 0 || txtDBUsrName.Text.Length == 0 || txtDBPassword.Text.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void ResetCounters()
        {
            UpdateCnt = 0;
            ErrorCnt = 0;
            lblErrorCnt.Text = "0";
            lblUpdateCnt.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Authentication
            txtDomain.Text = string.Empty;
            txtUsrName.Text = string.Empty;
            txtPassword.Text = string.Empty;

            //Datasource
            txtDBServerName.Text = string.Empty;
            txtDBDatabase.Text = string.Empty;
            txtTablename.Text = string.Empty;
            txtDBUsrName.Text = string.Empty;
            txtDBPassword.Text = string.Empty;

            //Active Directory
            chkFirstName.Checked = false;
            chkInitials.Checked = false;
            chkLastname.Checked = false;
            chkDisplayName.Checked = false;
            chkDescription.Checked = false;
            chkOffice.Checked = false;
            ChkAdTelephone.Checked = false;
            chkOtherTelephone.Checked = false;
            chkEmail.Checked = false;
        }

        private void txtDomain_TextChanged(object sender, EventArgs e)
        {
            lblAuthError.Visible = false;
        }

        private void txtUsrName_TextChanged(object sender, EventArgs e)
        {
            lblAuthError.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblAuthError.Visible = false;
        }

        private void txtDBServerName_TextChanged(object sender, EventArgs e)
        {
            lblDataSourceError.Visible = false;
        }

        private void txtDBDatabase_TextChanged(object sender, EventArgs e)
        {
            lblDataSourceError.Visible = false;
        }

        private void txtTablename_TextChanged(object sender, EventArgs e)
        {
            lblDataSourceError.Visible = false;
        }

        private void txtDBUsrName_TextChanged(object sender, EventArgs e)
        {
            lblDataSourceError.Visible = false;
        }

        private void txtDBPassword_TextChanged(object sender, EventArgs e)
        {
            lblDataSourceError.Visible = false;
        }

        private void createDatasourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcreatedatasource datasource = new frmcreatedatasource();
            datasource.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmabout about = new frmabout();
            about.Show();
        }
    }
}
