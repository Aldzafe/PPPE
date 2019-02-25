using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=DESKTOP-FF26GO5\\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Security=True";
       

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void buttonAjouter_Click_1(object sender, EventArgs e)
        {
            
        }

        private void RemplissageDGV_Client()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Client", sqlConnection1);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv_client.DataSource = dtbl;
            }
        }

        private void RemplissageDGV_Inter()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Intervention", sqlConnection1);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv_inter.DataSource = dtbl;
            }
        }

        private void RemplissageDGV_Site()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Site", sqlConnection1);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv_site.DataSource = dtbl;
            }
        }
        private void RemplissageDGV_Mat()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Materiel", sqlConnection1);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv_mat.DataSource = dtbl;
            }
        }
        private void RemplissageDGV_TM()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Type_Materiel", sqlConnection1);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv_TM.DataSource = dtbl;
            }
        }
        private void RemplissageDGV_Marque()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Marque", sqlConnection1);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv_marque.DataSource = dtbl;
            }
        }

        private void buttonAfficher_Click_1(object sender, EventArgs e)
        {
            RemplissageDGV_Client();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                DataGridViewRow dgvrow = dgv_client.CurrentRow;
                SqlCommand sqlCmd = new SqlCommand("ClientAjouterOuModififer", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (dgvrow.Cells["ID_Client"].Value == DBNull.Value)
                    sqlCmd.Parameters.AddWithValue("@ID_Client", 0);
                else
                    sqlCmd.Parameters.AddWithValue("@ID_Client", Convert.ToInt32(dgvrow.Cells["ID_Client"].Value));
                sqlCmd.Parameters.AddWithValue("@Nom", dgvrow.Cells["Nom"].Value == null ? "NR" : dgvrow.Cells["Nom"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Adresse", dgvrow.Cells["Adresse"].Value == null ? "NR" : dgvrow.Cells["Adresse"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Telephone", dgvrow.Cells["Telephone"].Value == null ? "NR" : dgvrow.Cells["Telephone"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Email", dgvrow.Cells["Email"].Value == null ? "NR" : dgvrow.Cells["Email"].Value.ToString());
                sqlCmd.ExecuteNonQuery();
                // si c'est un int 
                // sqlCmd.Parameters.AddWithValue("@Telephone", Convert.ToInt32(dgvrow.Cells["Telephone"].Value == DBNull.Value ? "" : dgvrow.Cells["Telephone"].Value.ToString()));
                RemplissageDGV_Client();

            }
        }

        private void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgv_client.CurrentRow.Cells["ID_Client"].Value != null)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer ces données ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("ClientSuprByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("ID_Client", Convert.ToInt32(dgv_client.CurrentRow.Cells["ID_Client"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void buttonAfficherInter_Click(object sender, EventArgs e)
        {
            RemplissageDGV_Inter();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                DataGridViewRow dgvrow = dgv_inter.CurrentRow;
                SqlCommand sqlCmd = new SqlCommand("InterAjouterouModifier", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (dgvrow.Cells["ID_Intervention"].Value == DBNull.Value)
                    sqlCmd.Parameters.AddWithValue("@ID_Intervention", 0);
                else
                    sqlCmd.Parameters.AddWithValue("@ID_Intervention", Convert.ToInt32(dgvrow.Cells["ID_Intervention"].Value));
                sqlCmd.Parameters.AddWithValue("@Date_PLanifiee", Convert.ToDateTime(dgvrow.Cells["Date_PLanifiee"].Value == null ? "NR" : dgvrow.Cells["Date_PLanifiee"].Value.ToString()));
                sqlCmd.Parameters.AddWithValue("@Commentaire", dgvrow.Cells["Commentaire"].Value == null ? "NR" : dgvrow.Cells["Commentaire"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@ID_Mat", Convert.ToInt32(dgvrow.Cells["ID_Mat"].Value == null ? "NR" : dgvrow.Cells["ID_Mat"].Value).ToString());
                sqlCmd.ExecuteNonQuery();
                // si c'est un int 
                // sqlCmd.Parameters.AddWithValue("@Telephone", Convert.ToInt32(dgvrow.Cells["Telephone"].Value == DBNull.Value ? "" : dgvrow.Cells["Telephone"].Value.ToString()));
                RemplissageDGV_Inter();

            }
        }

        private void dgv_inter_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (dgv_inter.CurrentRow.Cells["ID_Intervention"].Value != null)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer ces données ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("InterSupr", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("ID_Intervention", Convert.ToInt32(dgv_inter.CurrentRow.Cells["ID_Intervention"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void buttonAfficherSite_Click(object sender, EventArgs e)
        {
            RemplissageDGV_Site();
        }

        private void buttonAjouterSite_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                DataGridViewRow dgvrow = dgv_site.CurrentRow;
                SqlCommand sqlCmd = new SqlCommand("SiteAjouterouModifier", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (dgvrow.Cells["ID_Site"].Value == DBNull.Value)
                    sqlCmd.Parameters.AddWithValue("@ID_Site", 0);
                else
                    sqlCmd.Parameters.AddWithValue("@ID_Site", Convert.ToInt32(dgvrow.Cells["ID_Site"].Value));
                sqlCmd.Parameters.AddWithValue("@Nom",dgvrow.Cells["Nom_Site"].Value == null ? "NR" : dgvrow.Cells["Nom_Site"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Adresse", dgvrow.Cells["Adresse_Site"].Value == null ? "NR" : dgvrow.Cells["Adresse_Site"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@CP", dgvrow.Cells["CP"].Value == null ? "NR" : dgvrow.Cells["CP"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Ville",dgvrow.Cells["Ville"].Value == null ? "NR" : dgvrow.Cells["Ville"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@ID_Client", Convert.ToInt32(dgvrow.Cells["ID_Clients"].Value == null ? "NR" : dgvrow.Cells["ID_Clients"].Value.ToString()));
                sqlCmd.ExecuteNonQuery();
                // si c'est un int 
                // sqlCmd.Parameters.AddWithValue("@Telephone", Convert.ToInt32(dgvrow.Cells["Telephone"].Value == DBNull.Value ? "" : dgvrow.Cells["Telephone"].Value.ToString()));
                RemplissageDGV_Site();

            }
        }

        private void dgv_site_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgv_site.CurrentRow.Cells["ID_Site"].Value != null)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer ces données ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("SiteSupr", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("ID_Site", Convert.ToInt32(dgv_site.CurrentRow.Cells["ID_Site"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void buttonAfficherMat_Click(object sender, EventArgs e)
        {
            RemplissageDGV_Mat();
        }

        private void buttonAjouterMat_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                DataGridViewRow dgvrow = dgv_mat.CurrentRow;
                SqlCommand sqlCmd = new SqlCommand("MatAjouterouModifier", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (dgvrow.Cells["ID_Mat2"].Value == DBNull.Value)
                    sqlCmd.Parameters.AddWithValue("@ID_Mat", 0);
                else
                    sqlCmd.Parameters.AddWithValue("@ID_Mat", Convert.ToInt32(dgvrow.Cells["ID_Mat2"].Value));
                sqlCmd.Parameters.AddWithValue("@Nom", dgvrow.Cells["Nom2"].Value == null ? "NR" : dgvrow.Cells["Nom2"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@NoSerie", dgvrow.Cells["NoSerie"].Value == null ? "NR" : dgvrow.Cells["NoSerie"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@MTBF", dgvrow.Cells["MTBF"].Value == null ? "NR" : dgvrow.Cells["MTBF"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Date_Installation", Convert.ToDateTime(dgvrow.Cells["Date_Installation"].Value == null ? "00/00/0000" : dgvrow.Cells["Date_Installation"].Value.ToString()));
                sqlCmd.Parameters.AddWithValue("@ID_TypeMat", Convert.ToInt32(dgvrow.Cells["ID_TypeMat"].Value == null ? "NR" : dgvrow.Cells["ID_TypeMat"].Value.ToString()));
                sqlCmd.Parameters.AddWithValue("@ID_Site", Convert.ToInt32(dgvrow.Cells["ID_Site2"].Value == null ? "NR" : dgvrow.Cells["ID_Site2"].Value.ToString()));
                sqlCmd.Parameters.AddWithValue("@ID_Client", Convert.ToInt32(dgvrow.Cells["ID_Client2"].Value == null ? "NR" : dgvrow.Cells["ID_Client2"].Value.ToString()));
                sqlCmd.Parameters.AddWithValue("@ID_Marque", Convert.ToInt32(dgvrow.Cells["ID_Marque2"].Value == null ? "NR" : dgvrow.Cells["ID_Marque2"].Value.ToString()));
                sqlCmd.ExecuteNonQuery();
                RemplissageDGV_Mat();

            }
        }

        private void dgv_mat_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgv_mat.CurrentRow.Cells["ID_Mat2"].Value != null)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer ces données ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("MatSupr", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("ID_Mat", Convert.ToInt32(dgv_mat.CurrentRow.Cells["ID_Mat2"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void buttonAfficherTM_Click(object sender, EventArgs e)
        {
            RemplissageDGV_TM();
        }

        private void buttonAjouterTM_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                DataGridViewRow dgvrow = dgv_TM.CurrentRow;
                SqlCommand sqlCmd = new SqlCommand("TypeMatAjouterouModifier", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (dgvrow.Cells["ID_TM"].Value == DBNull.Value)
                    sqlCmd.Parameters.AddWithValue("@ID_TM", 0);
                else
                    sqlCmd.Parameters.AddWithValue("@ID_TypeMat", Convert.ToInt32(dgvrow.Cells["ID_TM"].Value));
                sqlCmd.Parameters.AddWithValue("@Nom", dgvrow.Cells["NomMat"].Value == null ? "NR" : dgvrow.Cells["NomMat"].Value.ToString());                
                sqlCmd.ExecuteNonQuery();
                RemplissageDGV_TM();

            }
        }

        private void dgv_TM_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgv_TM.CurrentRow.Cells["ID_TM"].Value != null)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer ces données ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("TypeMatSupr", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("ID_TypeMat", Convert.ToInt32(dgv_TM.CurrentRow.Cells["ID_TM"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void buttonAfficerMarque_Click(object sender, EventArgs e)
        {
            RemplissageDGV_Marque();
        }

        private void buttonAjouterMarque_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                DataGridViewRow dgvrow = dgv_marque.CurrentRow;
                SqlCommand sqlCmd = new SqlCommand("MarqueAjouterouModifier", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (dgvrow.Cells["ID_Marque"].Value == DBNull.Value)
                    sqlCmd.Parameters.AddWithValue("@ID_Marque", 0);
                else
                    sqlCmd.Parameters.AddWithValue("@ID_Marque", Convert.ToInt32(dgvrow.Cells["ID_Marque"].Value));
                sqlCmd.Parameters.AddWithValue("@Nom", dgvrow.Cells["Nom_M"].Value == null ? "NR" : dgvrow.Cells["Nom_M"].Value.ToString());
                sqlCmd.ExecuteNonQuery();
                RemplissageDGV_Marque();

            }
        }

        private void dgv_marque_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgv_marque.CurrentRow.Cells["ID_Marque"].Value != null)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer ces données ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("MarqueSupr", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("ID_Marque", Convert.ToInt32(dgv_marque.CurrentRow.Cells["ID_Marque"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
