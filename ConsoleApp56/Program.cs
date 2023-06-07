namespace ConsoleApp56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandCloseProgram = "exit";
            string userInput;
            bool userIsExit = false;

            while (userIsExit == false)
            {
                Console.WriteLine("Введите команду - " + "\"" + commandCloseProgram + "\"" + " для закрытия программы.");
                userInput = Console.ReadLine();

                if (userInput == commandCloseProgram)
                {
                    userIsExit = true;
                }
            }
        }
    }
}