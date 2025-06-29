using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExoKaiza42
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*Exo1

            string prenom = "Loïc";

            Console.WriteLine($"Bonjour {prenom} !");*/

            //Exo2

            /*int nombreEntier = 32;
            Console.WriteLine($"Voici un nombre {nombreEntier}");*/

            //Exo3

            /* Console.WriteLine($"Quel est ton prénom ? ");
             string prenom = Console.ReadLine();

             Console.WriteLine($"Bonjour {prenom} !");*/

            //Exo4


            /* 
             string nom = "chien";
             int age = 32;

             Console.WriteLine("Mon " + nom + " a " + age + " ans.");*/



            /*            //Exo5

                        Console.WriteLine("Quel est votre âge ? ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        if ( age >= 18)
                        {
                            Console.WriteLine("Accès autorisé");
                        }
                        else
                        {
                            Console.WriteLine("accès refusé");
                        }*/

            /*            //Exo6

                        Console.WriteLine("Donner moi deux nombre ");
                        Console.WriteLine("Donner moi le premier nombre : ");
                        int nombre1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Donner moi le deuxieme nombre : ");
                        int nombre2 = Convert.ToInt32(Console.ReadLine());


                        if (nombre1 > nombre2)
                        {
                            Console.WriteLine($"{nombre1} est plus grand que {nombre2}");
                        }
                        else
                        {
                            Console.WriteLine($"{nombre2} est plus grand que {nombre1}");
                        }
            */


            /*            //Exo7

                        string mot = "";

                        while (mot != "exit")
                        {
                            Console.WriteLine("Tape un mot (ou 'exit' pour quitter) : ");
                            mot = Console.ReadLine();
                        }*/


            //Exo8

            /*            Console.WriteLine("Donner moi un nombre ");
                        int saissieUtilisateur = Convert.ToInt32(Console.ReadLine());

                        while( saissieUtilisateur > 0)
                        {

                            saissieUtilisateur--;

                            Console.WriteLine(saissieUtilisateur);
                        }*/


            /*            Exercice 9 - Compteur pair / impair
                            Demande à l'utilisateur un nombre. Affiche tous les nombres de 0 jusqu'à ce nombre, en indiquant s'ils sont pairs ou impairs.*/


            /*            Console.WriteLine("Donne moi un nombre ");
                        int pairImpair = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i <= pairImpair; i++)
                        {
                            if( i % 2 == 0)
                            {
                                Console.WriteLine( i + " Est pair ! ");
                            }
                            else
                            {
                                Console.WriteLine( i + " Est impair ! ");
                            }
                        }*/


            /*            Exercice 10 - Devine le nombre
                            Le programme choisit un nombre entre 1 et 5(au lieu de 10).L'utilisateur a 3 essais pour deviner ce nombre. Après chaque essai, 
                            il est averti si c'est bon ou non. Fin du jeu si trouvé ou si essais épuisés.*/


            /*            Random aleatoire = new Random();
                        int nbMystere = aleatoire.Next(1, 5);

                        int chiffreUtilisateur = 0;

                        while(chiffreUtilisateur != nbMystere)
                        {
                            Console.WriteLine("Trouve le chiffre aléatoire entre 1 et 5, Quel chiffre choisi tu ?");
                                chiffreUtilisateur = Convert.ToInt32(Console.ReadLine());
                        }*/


            /* Exercice 11 - Jours de la semaine(switch simple)
                 Demande à l'utilisateur un chiffre entre 1 et 7. Affiche le jour de la semaine correspondant (1 = Lundi, 7 = Dimanche).*/


            /*            Console.WriteLine("Entre un chiffre ( 1 à 7 )");
                        int chiffre = Convert.ToInt32(Console.ReadLine());

                        switch (chiffre)
                        {
                            case 1:
                                Console.WriteLine("C'est Lundi");
                                break;

                            case 2:
                                Console.WriteLine("C'est Mardi");
                                break;

                            case 3:
                                Console.WriteLine("C'est Mercredi");
                                break;

                            case 4:
                                Console.WriteLine("C'est Jeudi");
                                break;

                            case 5:
                                Console.WriteLine("C'est Vendredi");
                                break;

                            case 6:
                                Console.WriteLine("C'est Samedi");
                                break;

                            case 7:
                                Console.WriteLine("C'est Dimanche");
                                break;

                            default:
                                Console.WriteLine("Mauvais chiffre");
                                break;
                        }
            */


            /*Exercice 12 - Animaux et leurs sons(switch avec saisie)
                Demande à l'utilisateur d'entrer le nom d'un animal courant (ex : chien, chat, vache). Selon l'animal saisi, affiche un son correspondant en utilisant un switch.*/

/*            Console.WriteLine("Entrer le nom d'un animal");
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "emerick":
                    Console.WriteLine("Ouaf Ouaf !");
                    break;

                case "chat":
                    Console.WriteLine("Miaou !");
                    break;

                case "vache":
                    Console.WriteLine("Meuh !");
                    break;

                case "coq":
                    Console.WriteLine("Cocorico !");
                    break;

                case "canard":
                    Console.WriteLine("Coin Coin !");
                    break;

                default:
                    Console.WriteLine("Je ne connais pas cet animal");
                    break;

            }*/



        }
    }
}
