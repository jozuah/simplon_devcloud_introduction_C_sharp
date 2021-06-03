using System;
using System.IO;

namespace Brief44_dotnet_tuto
{
    class Program
    {
        static void Main(string[] args)
        {

            /***************** AFFICHAGE DU CHEMIN DU DOSSIER COURANT **************/
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0} : ", path);
            // Console.WriteLine("Adlane et Tiphaine sont dans les champs et mangent de la terre");


            /********* AFFICHAGE DES DOSSIER ET FICHER DU DOSSIER COURANT **********/


            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Console.WriteLine("{0, -30}\t directory", d.Name);
            }

            foreach (FileInfo f in dir.GetFiles())
            {
                Console.WriteLine("{0, -30}\t File", f.Name);
            }


            // Console.WriteLine("Enter your age:");
            // int age = Convert.ToInt32(Console.ReadLine()*2);
            // Console.WriteLine("L'age du Pere Fourasse : " + age);


            /****** Recherche avec un custom path ******/

            Console.WriteLine("Enter your path:");
            string my_path = Console.ReadLine();
            Console.WriteLine("Your path is: " + my_path);

            DirectoryInfo dir_custom = new DirectoryInfo(my_path);

            foreach (DirectoryInfo d in dir_custom.GetDirectories())
            {
                Console.WriteLine("{0, -20}\t directory", d.Name);
            }

            foreach (FileInfo f in dir_custom.GetFiles())
            {
                Console.WriteLine("{0, -20}\t File", f.Name);
            }

        }
    }
}
