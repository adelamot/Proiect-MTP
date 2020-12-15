using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(connect);
        static string connect = "Server=127.0.0.1;Database=agentie;Uid=user;Pwd=parola; convert zero datetime=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                try
                {
                    string sql = "SELECT * FROM excursii ORDER BY locatie";
                    con.Open();
                    //punem datele in datagrid
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();

                    //punem datele in dropdown
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read()) {
                        DropDownList1.Items.Add(dr[1].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';";
                    row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
                    row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + row.DataItemIndex, true);
                    row.Style.Add(HtmlTextWriterStyle.Cursor, "pointer");
                }
            }
            base.Render(writer);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            string query = "select * from excursii where Locatie like '" + TextBox1.Text + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            if (GridView1.Rows.Count == 0)
                Label1.Text = "Termenul cautat nu a fost gasit!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM excursii WHERE Locatie='"+DropDownList1.SelectedValue.ToString()+"';";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            //MySqlDataReader dr = cmd.ExecuteReader();
            //Label1.Text = dr.ToString();
            Response.Redirect(Request.RawUrl);
            con.Close();
        }
    }
}