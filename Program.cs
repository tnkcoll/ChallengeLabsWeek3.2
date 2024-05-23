namespace ChallengeLabsWeek3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userString = GetStringFromUser();            
            double total = AddIntegerTotal(userString);
            Console.WriteLine(total);
        }

        static string GetStringFromUser()
        {
            string userInput ="";

            do
            {
                Console.WriteLine("Please enter some text with both numbers and letters.");
                userInput = Console.ReadLine();
            }while (userInput == "");
            
            return userInput;
        }

        static double AddIntegerTotal(string nonsense)
        {
            
            double sum = 0;
            
            for (int i = 0; i < nonsense.Length; i++)
            {
                if(char.IsNumber(nonsense[i]))
                {
                    sum = sum + char.GetNumericValue(nonsense,i);
                }
            }
            return sum;
        }
    }
}
