using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument xmlSursa = new XmlDocument();
            //string nume_fisier = Request.QueryString["chestionar"];
            string nume_fisier = "chestionar";
            xmlSursa.Load(Server.MapPath("~/Fisiere/" + nume_fisier + ".xml"));
            ///luam toate nodurile textBox            
            XmlNodeList nodes2 = xmlSursa.SelectNodes("//Chestionar//textbox");
            foreach (XmlNode text in   nodes2)            {
                string idr = text.Attributes["detalii"].Value;
                PlaceHolder1.Controls.Add(new LiteralControl("<p style=\"color: white;\"/>" + idr));
                ///textBox generat                
                TextBox txt = new    TextBox();
                txt.ID = text.Attributes["nume"].Value;
                txt.Text = "";
                txt.CssClass = "form-control";
                PlaceHolder1.Controls.Add(new LiteralControl("<p style=\"color: white;\"/>"));
                PlaceHolder1.Controls.Add(txt);
            }
            //luam toate nodurile radioButton            
            XmlNodeList nodes = xmlSursa.SelectNodes("//Chestionar//radio");
            foreach (XmlNode radio in nodes) {
                string idr = radio.Attributes["detalii"].Value;
                PlaceHolder1.Controls.Add(new LiteralControl("<p style=\"color: white;\"/>" + idr));

                RadioButtonList new_radio = new RadioButtonList();
                new_radio.ID = radio.Attributes["nume"].Value;
                new_radio.CssClass = "radio";
                XmlNodeList valori = radio.ChildNodes;
                foreach (XmlNode valoare in valori) {
                    string val = valoare.InnerText;
                    new_radio.Items.Add(val);
                }
                new_radio.RepeatDirection = RepeatDirection.Vertical;
                new_radio.ForeColor = Color.White;
               
                PlaceHolder1.Controls.Add(new_radio);
                
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string rezultat = "";
            Boolean ok = true;
            foreach (TextBox txt in PlaceHolder1.Controls.OfType<TextBox>()) {
                string nume_Control = txt.ID;
                string valoare_Control = txt.Text;
                rezultat +=  nume_Control + " = " + valoare_Control + Environment.NewLine; 
                if(txt.Text.Trim() == "")
                {
                    ok = false;
                }
            }
            foreach (RadioButtonList rb in PlaceHolder1.Controls.OfType<RadioButtonList>()) {
                string nume_Control = rb.ID;
                string valoare_Control = rb.SelectedValue;
                if (rb.SelectedValue == "")
                    ok = false;
                else 
                    rezultat += nume_Control + " = " + valoare_Control + Environment.NewLine;
            }
            if (ok)
                Label4.Text = "REZULTAT CHESTIONAR: " + rezultat;
            else
                Label4.Text = "Va rugam completati toate campurile mai intai!";
        }
    }
}