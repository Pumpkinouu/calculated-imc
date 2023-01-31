namespace IMC_DaniloZivanovic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ETML
            //Auteur : Danilo Zivanovic
            //Date   : 11.11.2022
           
            Console.Title = "Calculateur IMC";

            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║              Calculateur IMC               ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");

           
            //Commande pour faire les variables
            int poids;
            float taille;


            
            Console.WriteLine("Entrez votre taille (Exemple : 1,74) :");
            Console.SetCursorPosition(38, 3);//Permet de déplacer le curseur



            string resultatTaille = Console.ReadLine();
           
            taille = Convert.ToSingle(resultatTaille);
            

            Console.Write("Entrez votre poids :");
            string resultatPoids = Console.ReadLine();
            poids = Convert.ToInt32(resultatPoids);
            float imc = poids / (taille * taille);
            Console.WriteLine("Voici votre imc : {0}",imc);
            Console.ReadLine();
            








        }
    }
}