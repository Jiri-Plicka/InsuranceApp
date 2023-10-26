using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuredApp
{
    class InsuredApp
    {
        private InsuredList insuredsList;

        public InsuredApp()
        {
            insuredsList = new InsuredList();
        }

        /// <summary>
        /// Prida noveho pojistence
        /// </summary>
        public void AddNewInsured()
        {
            Console.WriteLine("\nZadejte jmeno pojistence: ");
            string firstName;
            while (string.IsNullOrWhiteSpace(firstName = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte jmeno znovu: ");
            }
            Console.WriteLine("Zadejte prijmeni: ");
            string lastName;
            while (string.IsNullOrWhiteSpace(lastName = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte prijmeni znovu: ");
            }
            Console.WriteLine("Zadejte telefonni cislo: ");
            string phoneNumber;
            while (string.IsNullOrWhiteSpace(phoneNumber = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte telefonni cislo znovu: ");
            }
            Console.WriteLine("Zadejte vek: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Zadejte vek znovu: ");
            }
            insuredsList.AddInsured(firstName, lastName, phoneNumber, age);
        }

        /// <summary>
        /// Vypis vsech pojistencu
        /// </summary>
        public void ViewInsured()
        {
            List<Insured> insureds = insuredsList.AllInsureds();
            Console.WriteLine("\n");
            foreach (Insured found in insureds)
                Console.WriteLine(found);
            Console.WriteLine("\nPokracujte libovolnou klavesou...");
            Console.ReadKey();
        }

        /// <summary>
        /// Vyhledani pojistence
        /// </summary>
        public void FindInsured()
        {
            Console.WriteLine("\nZadejte jmeno pojistence:");
            string findFirstName = Console.ReadLine();
            Console.WriteLine("Zadejte prijmeni:");
            string findLastName = Console.ReadLine();
            Console.WriteLine();
            List<Insured> insureds = insuredsList.FindInsured(findFirstName, findLastName);
            foreach (Insured found in insureds)
                Console.WriteLine(found);
            Console.WriteLine("\nPokracujte libovolnou klavesou...");
            Console.ReadKey();
        }

        /// <summary>
        /// Uvodni obrazovka
        /// </summary>
        public void Intro()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Evidence pojistenych");
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("Vyberte si akci: ");
            Console.WriteLine("1 - Pridat noveho pojisteneho");
            Console.WriteLine("2 - Vyhledat vsechny pojistene");
            Console.WriteLine("3 - Vyhledat pojisteneho");
            Console.WriteLine("4 - Konec\n");
        }
    }
}
