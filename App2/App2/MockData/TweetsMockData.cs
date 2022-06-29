using App2.BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.MockData
{
    public class TweetsMockData
    {
        public static List<Tweet> ListeTweets()
        {
            var tweets = new List<Tweet>
        {
            new Tweet { Temps = 50, Texte = @"En vrai c'est le temps idéal pour une raclette. Tu mets le fromage au soleil sur du métal. Il fond. Tu manges. Zéro consommation d'énergie. 
On appellerait ça une caniclette.", AuteurAt = "@TheLilyCroft", AuteurName="Lily Croft 🔎" },
            new Tweet { Temps = 50, Texte = @"Bonne fête à toutes les musiques", AuteurAt = "@kronomuzik", AuteurName="Krono Muzik" },
            new Tweet { Temps = 50, Texte = @"On m’a volé un sac que j’avais laissé à la laverie du coup je peux pas transporter toutes mes affaires, la délinquance dans ce pays n’a donc aucune limite ?", AuteurAt = "@terracid", AuteurName="Terracid" },
            new Tweet { Temps = 50, Texte = @"pire date il a aidé a remboursé la dette de pecresse", AuteurAt = "@sk8tzr", AuteurName="laura !!" },

        };

            return tweets;
        }
    }
}
