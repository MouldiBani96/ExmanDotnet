namespace BibliothqueApp.Models;
public class Document {
    public string NumeroEnregistrement { get; set; }
    public string Titre { get; set; }

    public Document(string numeroEnregistrement, string titre) {
        NumeroEnregistrement = numeroEnregistrement;
        Titre = titre;
    }
}
