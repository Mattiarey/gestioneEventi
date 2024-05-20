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
    public partial class Login : System.Web.UI.Page
    {
        protected static SqlConnection connDB;
        protected static SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            connDB = new SqlConnection();
            connDB.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BluaReyEventi;";
            connDB.Close();
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            SqlDataReader tabella;
            connDB.Open();
            comando = new SqlCommand();
            comando.Connection = connDB;
            comando.CommandText = "SELECT Email, Password, COUNT(*) FROM [User] WHERE Email = '" + txt_emailL.Text + "' AND [Password] = '" + txt_pwdL.Text + "' GROUP BY Email, Password HAVING COUNT(*) = 1";
            tabella = comando.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(tabella);

            if (txt_emailL.Text != "" || txt_pwdL.Text != "")
            {
                if (dataTable.Rows.Count == 1)
                {
                    Response.Write("<script>alert('Login effettuato con successo!'); window.location.href='../areaRiservata.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('La mail inserita non esiste o le credenziali sono errate!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Devi inserire mail e password!');</script>");
            }


            connDB.Close();

        }
    }
}