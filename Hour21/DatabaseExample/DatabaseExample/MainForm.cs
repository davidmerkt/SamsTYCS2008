using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseExample
{
    public partial class MainForm : Form
    {
        OleDbConnection m_cnADONetConnection = new OleDbConnection();
        OleDbDataAdapter m_daDataAdapter;
        OleDbCommandBuilder m_cbCommandBuilder;
        DataTable m_dtContacts = new DataTable();
        int m_rowPosition = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_cnADONetConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\temp\contacts.mdb";
            m_cnADONetConnection.Open();

            m_daDataAdapter = new OleDbDataAdapter("SELECT * FROM Contacts", m_cnADONetConnection);
            OleDbCommandBuilder m_cbCommandBuilder = new OleDbCommandBuilder(m_daDataAdapter);

            m_daDataAdapter.Fill(m_dtContacts);

            this.ShowCurrentRecord();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_cnADONetConnection.Close();
            m_cnADONetConnection.Dispose();
        }

        private void ShowCurrentRecord()
        {
            if (m_dtContacts.Rows.Count == 0)
            {
                txtContactName.Text = "";
                txtState.Text = "";
                return;
            }
            txtContactName.Text = m_dtContacts.Rows[m_rowPosition]["ContactName"].ToString();
            txtState.Text = m_dtContacts.Rows[m_rowPosition]["State"].ToString();
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            m_rowPosition = 0;
            this.ShowCurrentRecord();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            if (m_rowPosition != 0)
            {
                m_rowPosition--;
                this.ShowCurrentRecord();
            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (m_rowPosition < m_dtContacts.Rows.Count - 1)
            {
                m_rowPosition++;
                this.ShowCurrentRecord();
            }
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            if (m_dtContacts.Rows.Count != 0)
            {
                m_rowPosition = m_dtContacts.Rows.Count - 1;
                this.ShowCurrentRecord();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_dtContacts.Rows.Count != 0)
            {
                if (txtContactName.Text != "")
                {
                    m_dtContacts.Rows[m_rowPosition]["ContactName"] = txtContactName.Text;
                    m_dtContacts.Rows[m_rowPosition]["State"] = txtState.Text.ToUpper();
                    m_daDataAdapter.Update(m_dtContacts);
                }
                else
                {
                    MessageBox.Show("A user name must be present", "No name provided");
                    this.ShowCurrentRecord();
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtNewContactName.Text != "")
            {
                DataRow drNewRow = m_dtContacts.NewRow();
                drNewRow["ContactName"] = txtNewContactName.Text;
                drNewRow["State"] = txtNewState.Text.ToUpper();
                m_dtContacts.Rows.Add(drNewRow);
                m_daDataAdapter.Update(m_dtContacts);
                m_rowPosition = m_dtContacts.Rows.Count - 1;
                this.ShowCurrentRecord();
            }
            else
                MessageBox.Show("A user name must be present", "No name provided");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (m_dtContacts.Rows.Count != 0)
            {
                m_dtContacts.Rows[m_rowPosition].Delete();
                m_daDataAdapter.Update(m_dtContacts);
                m_rowPosition = 0;
                this.ShowCurrentRecord();
            }
        }
    }
}
