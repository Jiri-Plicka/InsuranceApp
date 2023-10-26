using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuredApp
{
    class Insured
    {
        /// <summary>
        /// Jmeno pojistence
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Prijmeni
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Telefonni cislo
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Vek
        /// </summary>
        public int Age { get; set; }

        public Insured(string firstName, string lastName, int age, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return FirstName.PadRight(10) + LastName.PadRight(10) + Age + PhoneNumber.PadLeft(15);
        }
    }
}
