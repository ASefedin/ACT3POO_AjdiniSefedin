// See https://aka.ms/new-console-template for more information
using Act3Elephant;

string reset = "";
Elephant E1 = new Elephant("Zazou", 82);
Elephant E2 = new Elephant("Titi", 100);

do
{
    Console.WriteLine("Bienvenue dans cet échange d'éléphants");
    Console.WriteLine("Tapez : ");
    Console.WriteLine("1 : pour afficher les informations de Zazou");
    Console.WriteLine("2 : pour Titi");
    Console.WriteLine("3 : pour les échanger");
    Console.WriteLine("4 : pour voir le transfert d'un message de Zazou à Titi");
    Console.WriteLine("5 : pour réviser la notion de tableaux et l'appliquer à des objets");
    string reponse = Console.ReadLine();
    switch (reponse)
    {
        case "1":
            Console.WriteLine(E1.AfficheQuiJeSuis());
            break;
        case "2":
            Console.WriteLine(E2.AfficheQuiJeSuis());
            break;
        case "3":
            Elephant tempo = E1;
            E1 = E2;
            E2 = tempo;

            break;
        case "4":
            E1.EnvoieMessage("Hello Titi !", E2);
            break;
        case "5":
            Elephant[] tabElephant = new Elephant[7];
            tabElephant[0] = E1;
            tabElephant[1] = E2;
            tabElephant[2] = new Elephant("Quelqu'un", 10);
            Elephant Elephant = tabElephant[0];
            for (int i = 0; i < tabElephant.Length; i++)
            {
                if (tabElephant[i].TailleOreilles > Elephant.TailleOreilles)
                {
                    Elephant = tabElephant[i];
                }

            }
            Console.WriteLine(Elephant.Nom + " a les bien grosse oreilles d'une taille de : " + Elephant.TailleOreilles);
            break;
    } while (reset == " ") ;