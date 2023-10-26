namespace InsuredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Insured insured = new Insured("Jan", "Novak", 33, "123456789");
            Console.WriteLine(insured);  */     // kontrola tridy Insured v prvni fazi vyvoje

            InsuredApp InsuredApp = new InsuredApp();
            char choice = '0';
            while (choice != '4')
            {
                Console.Clear();
                InsuredApp.Intro();
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        InsuredApp.AddNewInsured();
                        break;
                    case '2':
                        InsuredApp.ViewInsured();
                        break;
                    case '3':
                        InsuredApp.FindInsured();
                        break;
                    case '4':
                        Console.WriteLine("\nProgram ukoncite libovolnou klavesou...");
                        break;
                    default:
                        Console.WriteLine("Neplatna volba, stisknete libovolnou klavesu a zadejte znovu:");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}