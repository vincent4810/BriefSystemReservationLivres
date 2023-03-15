namespace AppResaLivre.Class;

public class Livre
{
    /// <summary>
    /// Titre d'un livre
    /// </summary>
    public string Titre { get; set; }
    
    /// <summary>
    /// Liste contenant un ou plusieur Hauteur en fonction du livre
    /// </summary>
    public List<Auteur> Auteurs { get; set; }
    
    /// <summary>
    /// Strign permettant d'indiquer la collection (ex: Livre de poche, Chaire de poule, Marvel)
    /// </summary>
    public string Collection { get; set; }

    /// <summary>
    /// int indiquant le nombre de page du livre
    /// </summary>
    public int NombrePage { get; set; }
    
    /// <summary>
    /// Date de publication au format DateOnly
    /// </summary>
    public DateOnly DatePublication { get; set; }
    
    /// <summary>
    /// Permet de récupérer un genre qu'on poussera dans la liste de genre
    /// </summary>
    // public Genre GenreAAjouter { get; set; }
    
    /// <summary>
    /// List permettant d'avoir un ou plusieur genre
    /// </summary>
    public List<Genre> Genres { get; set; }
    
    /// <summary>
    /// Nom de l'éditeur ou maison d'édition
    /// </summary>
    public Editeur Editeur { get; set; }

    /// <summary>
    /// Constructeur par défault
    /// </summary>
    public Livre()
    {
        this.Titre = "";
        this.Collection = "";
        
    }
    
    /// <summary>
    /// Permet d'ajouter des genre à la liste de genre
    /// </summary>
    /// <returns>La list des genres</returns>
    // public List<Genre> AjoutGenre()
    // {
    //     Genres = new();
    //     Genres.Add(GenreAAjouter);
    //
    //     return Genres;
    // }
    
    /// <summary>
    /// Permet l'affichage des données d'un livre
    /// </summary>
    /// <returns>Une string décrivant le livre</returns>
    public string AfficherLivre()
    {
        string auteur = "";
        string genre = "";
        
        //permet de récuper le ou les auteur dans la variable auteur
        foreach (Auteur aut in Auteurs)
        {
            auteur += $"{aut.ToString()}, ";
        }
        // permet de récupérer le ou les genre dans la variable genre
        foreach (Genre genr in Genres)
        {
            genre += $"{genr.ToString()}, ";
        }

        if (Auteurs.Count() > 1 && Genres.Count() >1)
        {
            return $"Le Livre {Titre} à pour auteurs {auteur} et ses genres son {genre}, sa date de publication est {DatePublication.ToShortDateString()}";
        }else if (Auteurs.Count() > 1)
        {
            return $"Le Livre {Titre} à pour auteurs {auteur} et son genre est {genre}, sa date de publication est {DatePublication.ToShortDateString()}";
        }else if (Auteurs.Count() == 1 && Genres.Count() > 1)
        {
            return $"Le Livre {Titre} à pour auteur {auteur} et ses genre sont {genre}, sa date de publication est {DatePublication.ToShortDateString()}";
        }
        else
        {
        return $"Le livre {Titre} à pour auteur {auteur} et son genre est {genre} et sa date de publication est {DatePublication.ToShortDateString()}"; 
        }
    }
    
    
    
    
}