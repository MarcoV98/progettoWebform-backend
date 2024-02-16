using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace progettoWebform_backend
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie carrelloCookie = Request.Cookies["Carrello"];

                if (carrelloCookie != null)
                {
                    List<Articolo> articoliCarrello = new List<Articolo>();

                    for (int i = 0; i < carrelloCookie.Values.Count; i++)
                    {
                        string nomeArticolo = carrelloCookie.Values.GetKey(i);

                        decimal prezzoArticolo;
                        if (decimal.TryParse(carrelloCookie.Values.Get(nomeArticolo + "_Prezzo"), out prezzoArticolo))
                        {
                            int quantitaArticolo = int.Parse(carrelloCookie.Values.Get(nomeArticolo));

                            Articolo articolo = new Articolo
                            {
                                Nome = nomeArticolo,
                                Prezzo = prezzoArticolo,
                                Quantita = quantitaArticolo,
                            };

                            articoliCarrello.Add(articolo);
                        }
                    }

                    rptCarrello.DataSource = articoliCarrello;
                    rptCarrello.DataBind();

                    decimal totalePrezzi = CalcolaTotalePrezzi(articoliCarrello);
                    lblTotalePrezzi.Text = string.Format("Totale: €{0:N2}", totalePrezzi);
                }
                else
                {
                    lblMessaggio3.Text = "Il tuo carrello è vuoto.";
                }
            }
        }

        private decimal CalcolaTotalePrezzi(List<Articolo> articoli)
        {
            decimal totale = 0;

            for (int i = 0; i < articoli.Count; i++)
            {
                totale += articoli[i].Prezzo * articoli[i].Quantita;
            }

            return totale;
        }

        protected void EliminaArticolo_Click(object sender, EventArgs e)
        {
            Button btnEliminaArticolo = (Button)sender;
            string nomeArticoloDaEliminare = btnEliminaArticolo.CommandArgument;

            HttpCookie carrelloCookie = Request.Cookies["Carrello"];

            if (carrelloCookie != null)
            {
                carrelloCookie.Values.Remove(nomeArticoloDaEliminare);
                carrelloCookie.Values.Remove(nomeArticoloDaEliminare + "_Prezzo");
                carrelloCookie.Values.Remove(nomeArticoloDaEliminare + "_Quantita");

                carrelloCookie.Expires = DateTime.Now.AddDays(15);

                Response.Cookies.Add(carrelloCookie);

                Response.Redirect(Request.Url.ToString());

                lblMessaggio2.Text = "Articolo correttamente rimosso dal carrello";
                lblMessaggio2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
