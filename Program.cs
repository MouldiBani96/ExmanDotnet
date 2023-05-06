namespace BibliothqueApp.Models;

public class Bibliotheque  {
    static void Main(string[] args) {
        // ---------------------pour la Question 1 (voir la parie Models)--------------------------

        // ---------------------pour la Question 2 (voir la parie Models)--------------------------
        Livre livre = new Livre("001", "How to get money", "Mouldi Bani", 100);
        Dictionnaire dictionnaire = new Dictionnaire("002", "Larousse", "français", 3);

        Console.WriteLine($"{livre.Titre} a été enregistré avec succès dans la bibliothèque.");
        Console.WriteLine($"{dictionnaire.Titre} a été enregistré avec succès dans la bibliothèque.");
       // ---------------------fin Q2 --------------------------

    // ---------------------pour la Question 3 (voir la parie Models et interface et interfaceImp)--------------------------
         BibliothequeImp bibliotheque = new BibliothequeImp();
        // Ajouter livre
        Livre livres = new Livre("1234", "Mon livre", "Bani", 200);

        //Ajouter livre to Biblio
        bibliotheque.AjouterDocument(livres);

        // Consulter Doc
        bibliotheque.ConsulterDocument("1234");

        // supprimer Doc
        bibliotheque.SupprimerDocument("1234");


        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
      // ---------------------fin Q3 --------------------------

    }
    


   
}