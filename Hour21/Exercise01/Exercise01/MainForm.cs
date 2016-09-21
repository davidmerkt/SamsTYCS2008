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

namespace Exercise01
{
    public partial class MainForm : Form
    {
        OleDbConnection m_cnADONetConnection = new OleDbConnection();
        OleDbDataAdapter m_daDataAdapter;
        DataTable m_dtContacts = new DataTable();

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

            ShowRecords();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_cnADONetConnection.Close();
            m_cnADONetConnection.Dispose();
        }

        private void ShowRecords()
        {
            if (m_dtContacts.Rows.Count == 0)
            {
                lstContacts.Items.Add("No contacts in data store");
            }
            else
            {
                for (int i = 0; i < m_dtContacts.Rows.Count; i++)
                {
                    lstContacts.Items.Add(m_dtContacts.Rows[i]["ContactName"].ToString() + "\t" + m_dtContacts.Rows[i]["State"].ToString().ToUpper());
                }
            }
        }
    }
}
