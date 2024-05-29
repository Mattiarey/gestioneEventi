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
                //Controlla se è stato inserito un artista o meno per la query da eseguire dopo
                if (txt_artista.Text != "")
                {
                    comando = new SqlCommand();
                    comando.Connection = connDB;
                    comando.CommandText = "SELECT * FROM artisti WHERE nome = '" + txt_artista.Text + "'";
                    tabella = comando.ExecuteReader();
                    DataTable paolo = new DataTable();
                    paolo.Load(tabella);
                    //Controllo se l'artista in input esiste
                    if (paolo.Rows.Count == 1)
                    {
                        comando = new SqlCommand();
                        comando.Connection = connDB;

                        //Controllo le la provincia ha 2 lettere
                        if (txt_provincia.Text.Length == 2)
                        {
                            int categoria = int.Parse(menu.Value);
                            switch(categoria)
                            {
                                case 1: comando.CommandText = "INSERT INTO eventi(titolo, luogo, provincia, data, FK_artista, FK_categorie) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + txt_provincia.Text + "', '" + data.Text + "', (SELECT id_artista FROM artisti WHERE nome ='" + txt_artista.Text + "'), 1) "; break;
                                case 2: comando.CommandText = "INSERT INTO eventi(titolo, luogo, provincia, data, FK_artista, FK_categorie) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + txt_provincia.Text + "', '" + data.Text + "', (SELECT id_artista FROM artisti WHERE nome ='" + txt_artista.Text + "'), 2) "; break;
                                case 3: comando.CommandText = "INSERT INTO eventi(titolo, luogo, provincia, data, FK_artista, FK_categorie) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + txt_provincia.Text + "', '" + data.Text + "', (SELECT id_artista FROM artisti WHERE nome ='" + txt_artista.Text + "'), 3) "; break;
                                case 4: comando.CommandText = "INSERT INTO eventi(titolo, luogo, provincia, data, FK_artista, FK_categorie) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + txt_provincia.Text + "', '" + data.Text + "', (SELECT id_artista FROM artisti WHERE nome ='" + txt_artista.Text + "'), 4) "; break;
                            }
                            
                            connDB.Close();
                            connDB.Open();
                            SqlDataReader gino = comando.ExecuteReader();
                            Response.Write("<script>alert('Evento inserito con successo!');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('La provincia deve avere 2 lettere!');</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Questo artista non esiste!');</script>");
                    }
                }
                else
                {
                    if (txt_provincia.Text.Length == 2)
                    {
                        comando = new SqlCommand();
                        comando.Connection = connDB;

                        int categoria = int.Parse(menu.Value);
                        switch (categoria)
                        {
                            case 1: comando.CommandText = "INSERT INTO eventi(titolo, luogo, provincia, data, FK_categorie) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + txt_provincia.Text + "', '" + data.Text + "', 1) "; break;
                            case 2: comando.CommandText = "INSERT INTO eventi(titolo, luogo, provincia, data, FK_categorie) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + txt_provincia.Text + "', '" + data.Text + "', 2) "; break;
                            case 3: comando.CommandText = "INSERT INTO eventi(titolo, luogo, provincia, data, FK_categorie) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + txt_provincia.Text + "', '" + data.Text + "', 3) "; break;
                            case 4: comando.CommandText = "INSERT INTO eventi(titolo, luogo, provincia, data, FK_categorie) VALUES ('" + txt_titolo.Text + "', '" + txt_luogo.Text + "', '" + txt_provincia.Text + "', '" + data.Text + "', 4) "; break;
                        }

                        connDB.Close();
                        connDB.Open();
                        SqlDataReader gino = comando.ExecuteReader();
                        Response.Write("<script>alert('Evento inserito con successo!');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('La provincia deve avere 2 lettere!');</script>");
                    }
                }
            }
                connDB.Close();
            }
        }
}
