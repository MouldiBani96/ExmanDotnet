
namespace BibliothqueApp.Models;

public interface IGestionDocument {
    void AjouterDocument(Document document);
    void ConsulterDocument(string numeroEnregistrement);
    void SupprimerDocument(string numeroEnregistrement);
}