namespace AppResaLivre.Class;

public class Emprunteur
{
    /// <summary>
    /// Nom de l'emprunteur
    /// </summary>
    public string Nom { get; set; }
    
    /// <summary>
    /// Prenom de l'emprunteur
    /// </summary>
    public string Prenom { get; set; }
    
    /// <summary>
    /// Date de naissance de l'emprunteur
    /// </summary>
    public DateOnly DateDeNaissance { get; set; }
    
    /// <summary>
    /// Numero de télephone à renseigner sous format 0651768486
    /// </summary>
    public int NumeroTel { get; set; }
    
    /// <summary>
    /// NumeroEmprunteur générer par la méthode CreationNumeroEmprunteur
    /// </summary>
    public string NumeroEmprunteur { get; set; }
    
    //Constructeur
    public Emprunteur()
    {
        this.Nom = "";
        this.Prenom = "";
        this.NumeroEmprunteur = "";
    }

    public string CreationNumeroEmprunteur()
    {
        string initialeNom = Nom.Substring(0, 2);

        string initialePrenom = Prenom.Substring(0, 2);

        int finDateNaissance = DateDeNaissance.DayOfYear;

        string finTel = NumeroTel.ToString().Substring(8,2);

        return initialeNom + "" + initialePrenom + "" + finDateNaissance + "" + finTel;
    }
}