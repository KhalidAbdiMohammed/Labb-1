namespace labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // console.writeline och string används för att skriva utdata från konsolen med en ny rad som läggs till efter texten
            // Vi använder även Convert.toint32(console.Readline()) så att man kan skriva in ett värde
            Console.WriteLine("Skriv namnet på person 1:");
            string username1 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 1:");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv namnet på person 2:");
            string username2 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 2:");
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv namnet på person 3");
            string username3 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 3:");
            int age3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv namnet på person 4");
            string username4 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 4:");
            int age4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(username1 + " är " + age1 + " år gammal");
            Console.WriteLine(username2 + " är " + age2 + " år gammal");
            Console.WriteLine(username3 + " är " + age3 + " år gammal");
            Console.WriteLine(username4 + " är " + age4 + " år gammal");

            // int gör det möjligt för oss att få ut heltal
            int totalage = age1 + age2 + age3 + age4;
            Console.WriteLine("Sammanlagda åldern är: " + totalage);

            //double gör det möjligt för oss att få ut flera decimaler och i to.String bestämmer vi att vi vill ha två decimaler
            double average = (double)totalage/4;
            string deci = average.ToString("0.00");
            Console.WriteLine("medelåldern är: " + deci);

        }
    }
}