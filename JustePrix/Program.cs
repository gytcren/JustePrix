using System;

namespace JustePrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeurATrouver = new Random().Next(0, 101);
            bool trouve = false;
            int nombreDeCoups = 0;

            Console.WriteLine("Veuillez saisir un nombre compris entre 1 et 100");

            while (!trouve)
            {
                string saisie = Console.ReadLine();
                int valeurSaisie;
                if (int.TryParse(saisie, out valeurSaisie))
                {
                    if (valeurSaisie > 100 || valeurSaisie < 1)
                    {
                        Console.WriteLine("La valeur saisie n'est pas comprise entre 1 et 100.");
                    }
                    else
                    {
                        if (valeurSaisie == valeurATrouver)
                        {
                            trouve = true;
                        }
                        else
                        {
                            Console.WriteLine(valeurSaisie > valeurATrouver ? "C'est moins." : "C'est plus.");
                        }
                        nombreDeCoups++;
                    }
                    
                }
                else
                {
                    Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer.");
                }
            }
            Console.WriteLine("Bravo, vous avez trouvé en " + nombreDeCoups + " coups");
        }
    }
}
