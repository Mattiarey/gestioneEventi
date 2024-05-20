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
    public partial class aggiungiPost : System.Web.UI.Page
    {
        protected static SqlConnection connDB;
        protected static SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            connDB = new SqlConnection();
            connDB.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BluaReyEventi;";
            connDB.Close();
        }

        protected void btn_post_Click(object sender, EventArgs e)
        {
            if (txt_titoloPost.Text != "" && txt_commento.Text != "" && txt_voto.Text != "" && txt_evento.Text != "")
            {
                SqlDataReader tabella;

                connDB.Open();
                comando = new SqlCommand();
                comando.Connection = connDB;

                comando.CommandText = "SELECT id_evento FROM eventi WHERE titolo = '" + txt_evento.Text + "'";
                tabella = comando.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(tabella);

                if (dataTable.Rows.Count == 1)
                {
                    comando.CommandText = "INSERT INTO post(titolo, commento, voto, FK_evento) VALUES ('" + txt_titoloPost.Text + "', '" + txt_commento.Text + "', '" + txt_voto.Text + "', (SELECT id_evento FROM eventi WHERE titolo ='" + txt_evento.Text + "')) ";
                    tabella = comando.ExecuteReader();
                    Response.Write("<script>alert('Post inserito correttamente!'); window.location = './AreaRiservata.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('Non esiste un evento con questo titolo!'); window.location = './aggiungiPost.aspx';</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Devi riempire tutti i campi!'); window.location = './aggiungiPost.aspx';</script>");
            }
        }
    }
}