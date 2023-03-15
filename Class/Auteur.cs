namespace AppResaLivre.Class;

public class Auteur
{
    public string Nom { get; set; }
    
    public string Prenom { get; set; }
    
    public DateOnly DateDeNaissance { get; set; }

    public Auteur()
    {
        this.Nom = "";
        this.Prenom = "";
    }

    public static string AffichageAuteur(string nom, string prenom, DateOnly dateDeNaissance)
    {
        return $"L'auteur s'appelle {nom} {prenom} et est né le {dateDeNaissance}";
    }
    
    
    

}