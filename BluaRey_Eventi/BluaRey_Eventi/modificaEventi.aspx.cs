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
    public partial class modificaEventi : System.Web.UI.Page
    {
        protected static SqlConnection connDB;
        protected static SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            connDB = new SqlConnection();
            connDB.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BluaReyEventi;";
            comando = new SqlCommand();
            comando.Connection = connDB;
        }

        protected void btn_titolo_Click(object sender, EventArgs e)
        {
            if(txt_titolo.Text != "" && txt_titoloM.Text != "")
            {
                connDB.Close();
                connDB.Open();

                comando.CommandText = "SELECT titolo FROM eventi WHERE titolo = '" + txt_titolo.Text + "'";
                SqlDataReader controllo = comando.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(controllo);

                if (dataTable.Rows.Count == 1)
                {
                    comando.CommandText = "UPDATE eventi  SET titolo = '" + txt_titoloM.Text + "' WHERE id_evento = (SELECT id_evento FROM eventi WHERE titolo = '" + txt_titolo.Text + "')";
                    int titoloUpdate = comando.ExecuteNonQuery();
                    Response.Write("<script>alert('Titolo modificato con successo!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Non esiste nessun evento con questo titolo!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Devi inserire sia il nome dell'evento pre-modifica sia il titolo!');</script>");
            }
        }

        protected void btn_luogo_Click(object sender, EventArgs e)
        {
            if (txt_titolo.Text != "" && txt_luogoM.Text != "")
            {
                connDB.Close();
                connDB.Open();
                comando.CommandText = "SELECT titolo FROM eventi WHERE titolo = '" + txt_titolo.Text + "'";
                SqlDataReader controllo = comando.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(controllo);

                if (dataTable.Rows.Count == 1)
                {
                    connDB.Close();
                    connDB.Open();
                    comando.CommandText = "UPDATE eventi  SET luogo = '" + txt_luogoM.Text + "' WHERE id_evento = (SELECT id_evento FROM eventi WHERE titolo = '" + txt_titolo.Text + "')";
                    int luogoUpdate = comando.ExecuteNonQuery();
                    Response.Write("<script>alert('Luogo modificato con successo!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Non esiste nessun evento con questo titolo!');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Devi inserire sia il nome dell'evento pre-modifica sia il luogo!');</script>");
            }
        }

        protected void btn_provincia_Click(object sender, EventArgs e)
        {
            if (txt_titolo.Text != "" && txt_provinciaM.Text != "")
            {
                connDB.Close();
                connDB.Open();
                comando.CommandText = "SELECT titolo FROM eventi WHERE titolo = '" + txt_titolo.Text + "'";
                SqlDataReader controllo = comando.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(controllo);
                if (dataTable.Rows.Count == 1)
                {
                    if (txt_provinciaM.Text.Length == 2)
                    {
                        connDB.Close();
                        connDB.Open();
                        comando.CommandText = "UPDATE eventi  SET provincia = '" + txt_provinciaM.Text + "' WHERE id_evento = (SELECT id_evento FROM eventi WHERE titolo = '" + txt_titolo.Text + "')";
                        SqlDataReader provinciaUpdate = comando.ExecuteReader();
                        Response.Write("<script>alert('Provincia modificata con successo!');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('La provincia deve avere 2 lettere!');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Non esiste nessun evento con questo titolo!');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Devi inserire sia il nome dell'evento pre-modifica sia la provincia!');</script>");
            }
        }

        protected void btn_artista_Click(object sender, EventArgs e)
        {
            if (txt_titolo.Text != "" && txt_artista.Text != "" && txt_artistaM.Text != "")
            {
                connDB.Close();
                connDB.Open();
                comando.CommandText = "SELECT titolo FROM eventi WHERE titolo = '" + txt_titolo.Text + "'";
                SqlDataReader controllo = comando.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(controllo);

                if (dataTable.Rows.Count == 1)
                {
                    if (txt_artista.Text != "")
                    {
                        connDB.Close();
                        connDB.Open();
                        comando.CommandText = "UPDATE eventi  SET FK_artista = (SELECT id_artista FROM  artisti WHERE nome = '" + txt_artistaM.Text + "') WHERE id_artista = (SELECT id_artista FROM artisti WHERE nome = '" + txt_artista.Text + "')";
                        SqlDataReader artistaUpdate = comando.ExecuteReader();
                        Response.Write("<script>alert('Artista modificato con successo!');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Devi inserire anche il nome dell'artista pre-modifica!');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Non esiste nessun evento con questo titolo!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Devi inserire sia il nome dell'evento pre-modifica sia l'artista!');</script>");
            }
        }

        protected void btn_data_Click(object sender, EventArgs e)
        {
            if(txt_titolo.Text != "" && dataM.Text != null)
            {
                connDB.Close();
                connDB.Open();
                comando.CommandText = "SELECT titolo FROM eventi WHERE titolo = '" + txt_titolo.Text + "'";
                SqlDataReader controllo = comando.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(controllo);

                if (dataTable.Rows.Count == 1)
                {
                    connDB.Close();
                    connDB.Open();
                    comando.CommandText = "UPDATE eventi  SET data = '" + dataM.Text + "' WHERE id_evento = (SELECT id_evento FROM eventi WHERE titolo = '" + txt_titolo.Text + "')";
                    SqlDataReader dataUpdate = comando.ExecuteReader();
                    Response.Write("<script>alert('Data modificata con successo!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Non esiste nessun evento con questo titolo!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Devi inserire sia il nome dell'evento pre-modifica sia la data!');</script>");
            }
        }
    }
}