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

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {  
        public FormLogin()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=DESKTOP-FF26GO5\\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True";

        private void buttonCO_Click(object sender, EventArgs e)
        {

            SqlConnection sqlco = new SqlConnection(connectionString);
            string query = "SELECT * FROM Login where Login='"+ textBoxID.Text + "' and MDP='"+textBoxMDP.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlco);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Application objFr1 = new Application();
                this.Hide();
                objFr1.Show();
            }
            else
                MessageBox.Show("Mauvais identifiant ou mot de passe");       
                               
           
        }
    }
}
