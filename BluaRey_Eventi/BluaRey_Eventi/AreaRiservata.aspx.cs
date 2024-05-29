using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BluaRey_Eventi
{
    public partial class AreaRiservata : System.Web.UI.Page
    {
        protected static SqlConnection connDB;
        protected static SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            connDB = new SqlConnection();
            connDB.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BluaReyEventi;";
            connDB.Close();
        }

        protected void btn_visualizzaEventi_Click(object sender, EventArgs e)
        {
            SqlDataReader tabella;
            connDB.Open();
            comando = new SqlCommand();
            comando.Connection = connDB;
            comando.CommandText = "SELECT * FROM eventi;";
            tabella = comando.ExecuteReader();
            dgvDati.DataSource = tabella;
            dgvDati.DataBind();
            connDB.Close();
        }

        protected void btn_visualizzaPost_Click(object sender, EventArgs e)
        {
            SqlDataReader tabella;
            connDB.Open();
            comando = new SqlCommand();
            comando.Connection = connDB;
            comando.CommandText = "SELECT * FROM post;";
            tabella = comando.ExecuteReader();
            dgvDati.DataSource = tabella;
            dgvDati.DataBind();
            connDB.Close();
        }
        protected void creaEvento(object sender, EventArgs e)
        {
            Response.Redirect("creaEvento.aspx");
        }
        protected void aggiungiArtisti(object sender, EventArgs e)
        {
            Response.Redirect("aggiungiArtisti.aspx");
        }
        protected void aggiungiPost(object sender, EventArgs e)
        {
            Response.Redirect("aggiungiPost.aspx");
        }
    }
}