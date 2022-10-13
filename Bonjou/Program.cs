// See https://aka.ms/new-console-template for more information

namespace bonjour
{
    class Program
    {
        public static bool checkPalindrome(string mainString)
        {
            return mainString.SequenceEqual(mainString.Reverse());
        }

        static void Main(string[] args)
        {
            int HeureJournee = ((int)DateTime.Now.Hour);
            string Reponse = "";
            string Langue = "FR";
            string Input = "";


            if (HeureJournee > 0 && HeureJournee < 12)
            {
                switch (Langue)
                {
                    case "FR":
                        Reponse = "Bonjour !";
                        break;
                    case "EN":
                        Reponse = "Good morning !";
                        break;
                    default:
                        Reponse = "Bonjour !";
                        break;
                }

            }
            else if (HeureJournee > 12 && HeureJournee < 19)
            {
                switch (Langue)
                {
                    case "FR":
                        Reponse = "Bonne après midi !";
                        break;
                    case "EN":
                        Reponse = "Good afternoon !";
                        break;
                    default:
                        Reponse = "Bonne après midi !";
                        break;
                }

            }
            else
            {
                switch (Langue)
                {
                    case "FR":
                        Reponse = "Bonne soirée !";
                        break;
                    case "EN":
                        Reponse = "Good evening !";
                        break;
                    default:
                        Reponse = "Bonne soirée !";
                        break;
                }


            }

            Console.WriteLine(Reponse);


            while(Input != "Quit")
            {
                Console.WriteLine("Vous pouvez me dire ce que vous voulez (Ou 'Quit' pour quitter) ");
                Input = Console.ReadLine();
                if (checkPalindrome(Input))
                {
                    Console.WriteLine("Bien dit !");
                }
                Console.WriteLine(Input.Reverse().ToArray()) ;
            }

            if (HeureJournee > 0 && HeureJournee < 12)
            {
                switch (Langue)
                {
                    case "FR":
                        Reponse = "Bonne journée !";
                        break;
                    case "EN":
                        Reponse = "Have a nice day !";
                        break;
                    default:
                        Reponse = "Bonne journée !";
                        break;
                }

            }
            else if (HeureJournee > 12 && HeureJournee < 19)
            {
                switch (Langue)
                {
                    case "FR":
                        Reponse = "Bonne après midi !";
                        break;
                    case "EN":
                        Reponse = "Good afternoon !";
                        break;
                    default:
                        Reponse = "Bonne après midi !";
                        break;
                }

            }
            else
            {
                switch (Langue)
                {
                    case "FR":
                        Reponse = "Bonne soirée !";
                        break;
                    case "EN":
                        Reponse = "Good evening !";
                        break;
                    default:
                        Reponse = "Bonne soirée !";
                        break;
                }


            }

            Console.WriteLine(Reponse);




        }
    }
}

