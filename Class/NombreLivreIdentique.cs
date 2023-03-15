using System.Xml;

namespace AppResaLivre.Class;

public class NombreLivreIdentique
{
    /// <summary>
    /// Stock du même livre
    /// </summary>
    public int Stock { get; set; }
    
    /// <summary>
    /// Livre à ajouter à la liste Livres pour trouver le nombre d'exemplaire avec la methode CalculLivreIdentique
    /// </summary>
    public Livre LivreAAjouter { get; set; }
    
    /// <summary>
    /// List de Livre utiliser pour trouver le nombre d'exemplaire parla méthode CalculLivreIdentique
    /// </summary>
    public List<Livre> Livres { get; set; }
    
    // Constructeur
    public NombreLivreIdentique()
    {
        this.Stock = 0;
    }
    
    /// <summary>
    /// Methode permettant d'ajouter un livre à la liste de livres
    /// </summary>
    /// <returns>La liste de livre compléter</returns>
    public List<Livre> AjoutLivre()
    {
        Livres = new();
        Livres.Add(LivreAAjouter);

        return Livres;
    }

    /// <summary>
    /// Permet de calucler le nombre de livre identique
    /// </summary>
    /// <returns>retourn</returns>
    public int CalculLivreIdentique()
    {
        int countStock = 0;
        for (int index = 0; index < Livres.Count(); index++)
        {
            if (Livres[index] == Livres[index + 1])
            {
                countStock++;
            }
        }

        Stock = countStock;
        return Stock;

    }
    /// <summary>
    /// Affiche une phrase du nombre de livre identique
    /// </summary>
    /// <returns>string du nombre de livre en stock</returns>
    public string AffichageNombreLivreIdentique()
    {
        return
            $"Le livre {LivreAAjouter.Titre} avec pour date de publication {LivreAAjouter.DatePublication.ToShortDateString()} existe en {Stock} exemplaire";
    }

}