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
    public partial class Registrazione : System.Web.UI.Page
    {
        protected static SqlConnection connDB;
        protected static SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            connDB = new SqlConnection();
            connDB.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BluaReyEventi;";
            connDB.Close();
        }

        protected void btn_registrazione_Click(object sender, EventArgs e)
        {
            SqlDataReader tabella;

            connDB.Open();
            comando = new SqlCommand();
            comando.Connection = connDB;

            //Controllo se l'utente che si vuole registrare lo è già
            comando.CommandText = "SELECT Email, Password, COUNT(*) FROM [User] WHERE Email = '" + txt_emailR.Text + "' AND [Password] = '" + txt_pwdR.Text + "' GROUP BY Email, Password HAVING COUNT(*) = 1";
            tabella = comando.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(tabella);

            int paolo = 0;
            if (txt_emailR.Text != "" || txt_pwdR.Text != "")
            {
                if (dataTable.Rows.Count == 0)
                {
                    //Se l'utente è nuovo lo inserisco nel DB
                    comando.CommandText = "INSERT INTO [User](Email, Password, Nickname, Nome, Cognome) VALUES ('" + txt_emailR.Text + "', '" + txt_pwdR.Text + "', '" + txt_nickname.Text + "', '" + txt_nome.Text + "', '" + txt_cognome.Text + "') ";
                    string giacomo = $"INSERT INTO [User](Email, Password) VALUES ('{txt_emailR.Text}', '{txt_pwdR.Text}') ";

                    SqlDataReader gino = comando.ExecuteReader();

                    comando.Parameters.AddWithValue("@Email", txt_emailR.Text);
                    comando.Parameters.AddWithValue("@Password", txt_pwdR.Text);

                    Response.Write("<script>alert('Registrazione effettuata con successo!'); window.location = './AreaRiservata.aspx'; </script>");
                }
                else
                {
                    Response.Write("<script>alert('La mail inserita è già registrata!'); window.location = './Registrazione.aspx';</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Devi inserire mail e password!'); window.location = './Registrazione.aspx';</script>");
            }


            connDB.Close();
        }
    }
}