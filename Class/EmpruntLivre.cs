namespace AppResaLivre.Class;

public class EmpruntLivre
{
    /// <summary>
    /// Récupère le livre qui est emprunté
    /// </summary>
    public Livre Livre { get; set; }

    /// <summary>
    /// Récupère l'emprunteur de ce livre
    /// </summary>
    public Emprunteur Emprunteur { get; set; }
    
    /// <summary>
    /// Genère la date d'emprunt
    /// </summary>
    public DateTime DateEmprunt { get; set; }
    
    public NombreLivreIdentique StockRestant { get; set; }

    //Constructeur
    public EmpruntLivre()
    {
        
    }
    /// <summary>
    /// Méthode récupérant la date d'emprunt et créer la date de restituion du livre
    /// </summary>
    /// <returns>une date 21 jours après la date d'emprunt</returns>
    public DateTime DateRestitution()
    {
        return DateEmprunt.AddDays(21);
    }
    /// <summary>
    /// Methode permettant d'afficher les données de l'emprunt si il est possible. Si l'emprunt n'est pas possible retourne un message que le livre n'est pas ou plus en stock.
    /// </summary>
    /// <returns></returns>
    public string AfficherEmprunt()
    {
        StockRestant.Livres.Add(Livre);
        string result = "";
        if (StockRestant.Stock > 0)
        {
             result = $"Titre : {Livre.Titre} /n Nom et Prénom : {Emprunteur.Nom} {Emprunteur.Prenom} /n NumeroEmprunteur : {Emprunteur.NumeroEmprunteur} /n  Date d'emprunt : {DateEmprunt} /n Date de retour : {DateRestitution()}";
             StockRestant.Stock--;
        }
        else
        {
            result = $"Titre : {Livre.Titre} n'est pas / plus en stock"; 
        }

        return result;
    }
    
}