using System;

namespace EVM_updated
{
    class Program
    {
        static void Main(string[] args)
        {
            var booth = new Booth();
             

            Console.WriteLine("***********VOTING APPLICATION*******************");
            Console.WriteLine("PRESS 1 FOR \"ADD CANDIDATE\"");
            Console.WriteLine("PRESS 2 FOR \"CAST VOTE\"");
            
            Console.WriteLine("PRESS 0 FOR \"EXIT\"");
            string key = string.Empty;

            do
            {

                //key = string.Empty;
                Console.Write("\n Please Press any key:");
                key = Console.ReadLine();

                switch (key)
                {
                    case "1":

                        booth.AddCandidate();

                        break;

                    case "2":
                        
                        Console.Clear();
                        Console.WriteLine("***********VOTER INFORMATION***************");
                        booth.AddVoter();
                        Console.Clear();
                        booth.VoterMenu();
                        string nestedKey = string.Empty;

                        nestedKey = Console.ReadLine();
                        switch (nestedKey)
                        {
                            case "1":
                                //statement
                                Console.WriteLine("case 1");
                                break;
                            case "2":
                                //statement
                                Console.WriteLine("case 2");
                                break;

                            case "0":
                                break;
                        }
                        break;

          
                    case "4":
                        Console.Clear();
                        //menu();
                        break;

                    default:
                        Console.WriteLine(" PLEASE PRESS A VALID KEY");
                        break;

                }
            }
            while (key != "0");
            Console.WriteLine("Press any key to close Application");
            Console.ReadKey();





















            booth.Start();
            booth.End();
            
            

        }
    }
}
