using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Autocar");
            DropDownList1.Items.Add("Avion");
            DropDownList1.Items.Add("Vapor");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim() == "" || TextBox2.Text.Trim() == "")
            {
                Label4.Text = "Pentru a adauga excursie trebuie sa completati toate campurile!";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(TextBox2.Text, @"^[0-9]*$")) {
                Label4.Text = "Pret invalid. Introduceti un numar!";
            } 
            else
            {
                try
                {
                    string connect = "Server=127.0.0.1;Database=agentie;Uid=user;Pwd=parola; convert zero datetime=True";
                    MySqlConnection con = new MySqlConnection(connect);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into excursii (Locatie,Pret,Transport) values(@loc,@pr,@tr) ", con);

                    cmd.Parameters.AddWithValue("@loc", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@pr", int.Parse(TextBox2.Text.Trim()));
                    cmd.Parameters.AddWithValue("@tr", DropDownList1.SelectedValue);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected == 1)
                    {
                        Label4.Text = "Excursie adaugata cu succes!";
                        Response.Redirect("WebForm2.aspx");
                    }
                    else
                    {
                        Label4.Text = "Eroare la inserare!";
                    }
                }
                catch (Exception ex)
                {
                    Label4.Text = ex.Message;
                }
            }
        }
    }
}