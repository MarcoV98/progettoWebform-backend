using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace progettoWebform_backend
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string nomeArticolo = Request.QueryString["Nome"];
                decimal prezzoArticolo = Convert.ToDecimal(Request.QueryString["Prezzo"]);
                string descrizioneArticolo = Request.QueryString["Descrizione"];
                string immagineUrlArticolo = Request.QueryString["ImmagineUrl"];

                Articolo articolo = new Articolo
                {
                    Nome = nomeArticolo,
                    Prezzo = prezzoArticolo,
                    Descrizione = descrizioneArticolo,
                    ImmagineUrl = immagineUrlArticolo,
                };

                lblNomeArticolo.Text = articolo.Nome;
                lblDescrizione.Text = articolo.Descrizione;
                lblPrezzo.Text = string.Format("Prezzo: €{0:N2}", articolo.Prezzo);

                
                    imgArticolo.ImageUrl = ResolveUrl(articolo.ImmagineUrl);
            }
        }

        protected void AggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            string nomeArticolo = Request.QueryString["Nome"];

            HttpCookie carrelloCookie = Request.Cookies["Carrello"];
            if (carrelloCookie == null)
            {
                carrelloCookie = new HttpCookie("Carrello");
            }

            if (carrelloCookie.Values[nomeArticolo] != null)
            {
                int quantitaAttuale = int.Parse(carrelloCookie.Values[nomeArticolo]);
                carrelloCookie.Values[nomeArticolo] = (quantitaAttuale + 1).ToString();
            }
            else
            {
                carrelloCookie.Values[nomeArticolo] = "1";
            }

            decimal prezzoArticolo = Convert.ToDecimal(Request.QueryString["Prezzo"]);
            carrelloCookie.Values[nomeArticolo + "_Prezzo"] = prezzoArticolo.ToString();

            carrelloCookie.Expires = DateTime.Now.AddDays(15);

            Response.Cookies.Add(carrelloCookie);

            lblMessaggio.Text = "Articolo correttamente aggiunto al carrello";
            lblMessaggio.ForeColor = System.Drawing.Color.Red;
        }
    }
}
