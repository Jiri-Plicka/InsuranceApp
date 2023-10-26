using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuredApp
{
    class InsuredList
    {
        /// <summary>
        /// Zalozeni kolekce
        /// </summary>
        private List<Insured> insureds;

        public InsuredList()
        {
            insureds = new List<Insured>();
        }

        /// <summary>
        /// Prida pojistence do kolekce
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="age"></param>
        public void AddInsured(string firstName, string lastName, string phoneNumber, int age)
        {
            insureds.Add(new Insured(firstName, lastName, age, phoneNumber));
        }

        /// <summary>
        /// Vyhledani vsech pojistencu
        /// </summary>
        /// <returns></returns>
        public List<Insured> AllInsureds()
        {
            List<Insured> found = new List<Insured>();
            foreach (Insured foundInsured in insureds)
                found.Add(foundInsured);
            return found;
        }

        /// <summary>
        /// Vyhledani pojistence
        /// </summary>
        /// <param name="findFirstName"></param>
        /// <param name="findLastName"></param>
        /// <returns></returns>
        public List<Insured> FindInsured(string findFirstName, string findLastName)
        {
            List<Insured> found = new List<Insured>();
            foreach (Insured findInsured in insureds)
            {
                if (((findFirstName == findInsured.FirstName) && (findLastName == findInsured.LastName)) || ((findFirstName == findInsured.FirstName.ToLower()) && (findLastName == findInsured.LastName.ToLower())))
                    found.Add(findInsured);
                else
                    Console.WriteLine("Neznamy pojistenec");
            }
            return found;
        }
    }
}
