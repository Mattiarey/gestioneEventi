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
    public partial class areaOspite : System.Web.UI.Page
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
            string dataSqlFormatted = data_data.ToString();
            comando.CommandText = "SELECT titolo, COUNT(*) FROM eventi WHERE luogo = '" + txt_territorio.Text + "' AND provincia = '" + txt_provincia.Text + "' AND [data] >= '" + data_data.Text.ToString() + "' GROUP BY titolo";
            tabella = comando.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(tabella);


            if (dataTable.Rows.Count >= 1)
            {
                comando.CommandText = "SELECT * FROM eventi WHERE luogo = '" + txt_territorio.Text + "' AND provincia = '" + txt_provincia.Text + "' AND [data] >= '" + data_data.Text.ToString() + "';";
                tabella = comando.ExecuteReader();
                dgvDati.DataSource = tabella;
                dgvDati.DataBind();
                connDB.Close();
            }
            else
            {
                Response.Write("<script>alert('Non ci sono eventi in questa zona e/o da questa data!');</script>");
            }
        }

        protected void btn_visualizzaPost_Click(object sender, EventArgs e)
        {
            SqlDataReader tabella;
            connDB.Open();
            comando = new SqlCommand();
            comando.Connection = connDB;
            comando.CommandText = "SELECT titolo, COUNT(*) FROM eventi WHERE titolo = '" + txt_evento.Text + "' GROUP BY titolo";
            tabella = comando.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(tabella);


            if (dataTable.Rows.Count == 1)
            {
                comando.CommandText = "SELECT * FROM post WHERE FK_evento = (SELECT id_evento FROM eventi WHERE titolo = '" + txt_evento.Text + "');";
                tabella = comando.ExecuteReader();
                dgvDati.DataSource = tabella;
                dgvDati.DataBind();
                connDB.Close();
            }
            else
            {
                Response.Write("<script>alert('Non ci sono eventi con questo titolo!');</script>");
            }
        }
    }
}