using System;
using System.Windows.Forms;

namespace UpdateActiveDirectory
{
    public partial class frmcreatedatasource : Form
    {
        public frmcreatedatasource()
        {
            InitializeComponent();
        }

        private void frmcreatedatasource_Load(object sender, EventArgs e)
        {           
                rtbCreateTable.Text =
                "CREATE TABLE ADUpdateSource"
                + Environment.NewLine +
                "("
                + Environment.NewLine +
                "ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,"
                + Environment.NewLine +
                "sAMAccountName varchar(200),"
                + Environment.NewLine +
                "Firstname varchar(100),"
                + Environment.NewLine +
                "Initials varchar(100),"
                + Environment.NewLine +
                "LastName varchar(100),"
                + Environment.NewLine +
                "DisplayName varchar(100),"
                + Environment.NewLine +
                "Description varchar(100),"
                + Environment.NewLine +
                "Office varchar(100),"
                + Environment.NewLine +
                "TelephoneNumber varchar(100),"
                + Environment.NewLine +
                "OtherTelephoneNumber varchar(100),"
                + Environment.NewLine +
                "Email varchar(500)"
                + Environment.NewLine +
                ")";

                rtbCreateTable.ReadOnly = true;            
        }
    }
}
