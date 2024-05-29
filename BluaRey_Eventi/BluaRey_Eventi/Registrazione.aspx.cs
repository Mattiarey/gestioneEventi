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
                    SqlDataReader gino;
                    SqlDataReader pino;
                    SqlDataReader alfonso;
                    SqlDataReader gaetano;
                    int rocci;

                    if (cultura.Checked || musica.Checked  || tecnologia.Checked || sport.Checked)
                    {
                        int categoria;
                        comando.CommandText = "INSERT INTO [User](Email, Password, Nickname, Nome, Cognome) VALUES ('" + txt_emailR.Text + "', '" + txt_pwdR.Text + "', '" + txt_nickname.Text + "', '" + txt_nome.Text + "', '" + txt_cognome.Text + "') ";
                        gino = comando.ExecuteReader();

                        if (cultura.Checked)
                        {
                            connDB.Close();
                            connDB.Open();
                            comando.CommandText = "INSERT INTO categorieInteressate(FK_categorie, FK_user) VALUES ((SELECT id_categoria FROM categorie WHERE nome ='" + cultura.Text + "'), (SELECT Id_email FROM [User] WHERE Email ='" + txt_emailR.Text + "'))";
                            pino = comando.ExecuteReader();
                            categoria = 1;
                        }
                        if(musica.Checked)
                        {
                            connDB.Close();
                            connDB.Open();
                            comando.CommandText = "INSERT INTO categorieInteressate(FK_categorie, FK_user) VALUES ((SELECT id_categoria FROM categorie WHERE nome ='" + musica.Text + "'), (SELECT Id_email FROM [User] WHERE Email ='" + txt_emailR.Text + "'))";
                            alfonso = comando.ExecuteReader();
                            categoria = 2;
                        }
                        if (tecnologia.Checked)
                        {
                            connDB.Close();
                            connDB.Open();
                            comando.CommandText = "INSERT INTO categorieInteressate(FK_categorie, FK_user) VALUES ((SELECT id_categoria FROM categorie WHERE nome ='" + tecnologia.Text + "'), (SELECT Id_email FROM [User] WHERE Email ='" + txt_emailR.Text + "'))";
                            gaetano = comando.ExecuteReader();
                            categoria = 3;
                        }
                        if (sport.Checked)
                        {
                            connDB.Close();
                            connDB.Open();
                            comando.CommandText = "INSERT INTO categorieInteressate(FK_categorie, FK_user) VALUES ((SELECT id_categoria FROM categorie WHERE nome ='" + sport.Text + "'), (SELECT Id_email FROM [User] WHERE Email ='" + txt_emailR.Text + "'))";
                            rocci = comando.ExecuteNonQuery();
                            categoria = 4;
                        }
                    }
                    //Se l'utente è nuovo lo inserisco nel DB
                    
                    //string giacomo = $"INSERT INTO [User](Email, Password) VALUES ('{txt_emailR.Text}', '{txt_pwdR.Text}') ";

                    /*comando.Parameters.AddWithValue("@Email", txt_emailR.Text);
                    comando.Parameters.AddWithValue("@Password", txt_pwdR.Text);*/

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