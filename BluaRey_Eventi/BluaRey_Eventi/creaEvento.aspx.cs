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
    public partial class creaEvento : System.Web.UI.Page
    {
        protected static SqlConnection connDB;
        protected static SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            connDB = new SqlConnection();
            connDB.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BluaReyEventi;";
        }

        protected void btn_aggiungi_Click(object sender, EventArgs e)
        {
            SqlDataReader tabella;

            connDB.Open();
            comando = new SqlCommand();
            comando.Connection = connDB;

            comando.CommandText = "SELECT titolo FROM eventi WHERE titolo = '" + txt_titolo.Text + "'";
            tabella = comando.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(tabella);

            if (dataTable.Rows.Count == 1)
            {
                Response.Write("<script>alert('Esiste già un evento con questo titolo!');</script>");
            }
            else
            {
                if (txt_artista.Text != "")
                {
                    comando = new SqlCommand();
                    comando.Connection = connDB;
                    comando.CommandText = "SELECT * FROM artisti WHERE nome = '" + txt_artista.Text + "'";
                    tabella = comando.ExecuteReader();
                    DataTable paolo = new DataTable();
                    paolo.Load(tabella);
                    if (paolo.Rows.Count == 1)
                    {
                        comando = new SqlCommand();
                        comando.Connection = connDB;
                        comando.CommandText = "INSERT INTO eventi(titolo, luogo, data, FK_artista) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + data.Text + "', (SELECT id_artista FROM artisti WHERE nome ='" + txt_artista.Text + "')) ";
                        connDB.Close();
                        connDB.Open();
                        SqlDataReader gino = comando.ExecuteReader();
                        Response.Write("<script>alert('Evento inserito con successo!');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('L'artista inserito non esiste!');</script>");
                    }
                }
                else
                {
                    comando = new SqlCommand();
                    comando.Connection = connDB;
                    comando.CommandText = "INSERT INTO eventi(titolo, luogo, data) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + data.Text + "') ";
                    connDB.Close();
                    connDB.Open();
                    SqlDataReader gino = comando.ExecuteReader();
                    Response.Write("<script>alert('Evento inserito con successo!');</script>");
                }
            }
                connDB.Close();
            }
        }
}
