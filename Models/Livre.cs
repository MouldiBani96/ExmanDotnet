namespace BibliothqueApp.Models;


public class Livre : Document {
    public string Auteur { get; set; }
    public int NombrePages { get; set; }

    public Livre(string numeroEnregistrement, string titre, string auteur, int nombrePages)
        : base(numeroEnregistrement, titre) {
        Auteur = auteur;
        NombrePages = nombrePages;
    }
}