namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2:

            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is hard!");
                    break;
                case "science":
                    Console.WriteLine("Science is intersting!");
                    break;
                case "history":
                    Console.WriteLine("History is boring!");
                    break;
                case "English":
                    Console.WriteLine("English is exhausting!");
                    break;
                case "recess":
                    Console.WriteLine("Recess is BEST!");
                    break;
                default:
                    Console.WriteLine($"{favSubject} sounds like a blast!");
                    break;
            }
        }
    }
}