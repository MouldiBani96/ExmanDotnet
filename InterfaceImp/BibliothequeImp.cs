
namespace BibliothqueApp.Models;

public class  BibliothequeImp: IGestionDocument {
    
    private List<Document> documents = new List<Document>();
    public void AjouterDocument(Document document) {
        documents.Add(document);
        Console.WriteLine($"{document.Titre} a été ajouté avec succès à la bibliothèque.");
    }
     public void ConsulterDocument(string numeroEnregistrement) {
        foreach (Document document in documents) {
            if (document.NumeroEnregistrement == numeroEnregistrement) {
                Console.WriteLine($"Titre: {document.Titre}");
                if (document is Livre) {
                    Console.WriteLine($"Auteur: {(document as Livre).Auteur}");
                    Console.WriteLine($"Nombre de pages: {(document as Livre).NombrePages}");
                } else if (document is Dictionnaire) {
                    Console.WriteLine($"Langue: {(document as Dictionnaire).Langue}");
                    Console.WriteLine($"Nombre de tomes: {(document as Dictionnaire).NombreTomes}");
                }
                return;
            }
        }
        Console.WriteLine($"Aucun document avec le numéro d'enregistrement {numeroEnregistrement} n'a été trouvé.");
    }

    public void SupprimerDocument(string numeroEnregistrement) {
        foreach (Document document in documents) {
            if (document.NumeroEnregistrement == numeroEnregistrement) {
                documents.Remove(document);
                Console.WriteLine($"{document.Titre} a été supprimé avec succès de la bibliothèque.");
                return;
            }
        }
        Console.WriteLine($"Aucun document avec le numéro d'enregistrement {numeroEnregistrement} n'a été trouvé.");
    }

    
}