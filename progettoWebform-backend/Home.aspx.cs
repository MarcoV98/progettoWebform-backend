using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace progettoWebform_backend
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Articolo> articoli = new List<Articolo>
                {
                    new Articolo { Nome = "Vallon", Prezzo = 100, Descrizione = "Occhiali economici", ImmagineUrl = "https://media.istockphoto.com/id/1417602445/it/foto/occhiali-da-sole-in-colore-dorato-brillante-in-plastica-trasparente-occhiali-vista-dallalto.jpg?s=2048x2048&w=is&k=20&c=xxJ_LjC7ivYgJ3HIkoVmmG5yTpQ3Id4O4GwjwTiiHq0=" },
                    new Articolo { Nome = "Rayban", Prezzo = 150, Descrizione = "Occhiali buoni", ImmagineUrl = "https://media.istockphoto.com/id/1417602445/it/foto/occhiali-da-sole-in-colore-dorato-brillante-in-plastica-trasparente-occhiali-vista-dallalto.jpg?s=2048x2048&w=is&k=20&c=xxJ_LjC7ivYgJ3HIkoVmmG5yTpQ3Id4O4GwjwTiiHq0=" },
                    new Articolo { Nome = "Armani", Prezzo = 300, Descrizione = "Occhiali ottimi", ImmagineUrl = "https://media.istockphoto.com/id/1417602445/it/foto/occhiali-da-sole-in-colore-dorato-brillante-in-plastica-trasparente-occhiali-vista-dallalto.jpg?s=2048x2048&w=is&k=20&c=xxJ_LjC7ivYgJ3HIkoVmmG5yTpQ3Id4O4GwjwTiiHq0=" },
                    new Articolo { Nome = "MOSCOT", Prezzo = 350, Descrizione = "Occhiali eccellenti", ImmagineUrl = "https://media.istockphoto.com/id/1417602445/it/foto/occhiali-da-sole-in-colore-dorato-brillante-in-plastica-trasparente-occhiali-vista-dallalto.jpg?s=2048x2048&w=is&k=20&c=xxJ_LjC7ivYgJ3HIkoVmmG5yTpQ3Id4O4GwjwTiiHq0=" },
                    new Articolo { Nome = "Ralph Lauren", Prezzo = 400, Descrizione = "Occhiali perfetti", ImmagineUrl = "https://media.istockphoto.com/id/1417602445/it/foto/occhiali-da-sole-in-colore-dorato-brillante-in-plastica-trasparente-occhiali-vista-dallalto.jpg?s=2048x2048&w=is&k=20&c=xxJ_LjC7ivYgJ3HIkoVmmG5yTpQ3Id4O4GwjwTiiHq0=" }
                };

                rptArticoli.DataSource = articoli;
                rptArticoli.DataBind();
            }
        }
    }
}