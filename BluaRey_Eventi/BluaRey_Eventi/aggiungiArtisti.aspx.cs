using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BluaRey_Eventi
{
    public partial class aggiungiArtisti : System.Web.UI.Page
    {
        protected static SqlConnection connDB;
        protected static SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            connDB = new SqlConnection();
            connDB.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BluaReyEventi;";
            connDB.Close();
        }

        protected void btn_aggiungiArtista_Click(object sender, EventArgs e)
        {
            if (txt_nomeArtista.Text != "")
            {
                SqlDataReader tabella;

                connDB.Open();
                comando = new SqlCommand();
                comando.Connection = connDB;

                comando.CommandText = "SELECT nome FROM artisti WHERE nome = '" + txt_nomeArtista.Text + "'";
                tabella = comando.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(tabella);

                if (dataTable.Rows.Count == 1)
                {
                    Response.Write("<script>alert('Esiste già un artista con questo nome!');</script>");
                }
                else
                {
                    comando.CommandText = "INSERT INTO artisti(nome) VALUES ('" + txt_nomeArtista.Text + "') ";
                    tabella = comando.ExecuteReader();
                    Response.Write("<script>alert('Artista creato con successo!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Devi inserire un nome!');</script>");
            }
        }
    }
}