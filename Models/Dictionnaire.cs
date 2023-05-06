namespace BibliothqueApp.Models;
public class Dictionnaire : Document {
    public string Langue { get; set; }
    public int NombreTomes { get; set; }

    public Dictionnaire(string numeroEnregistrement, string titre, string langue, int nombreTomes)
        : base(numeroEnregistrement, titre) {
        Langue = langue;
        NombreTomes = nombreTomes;
    }
}