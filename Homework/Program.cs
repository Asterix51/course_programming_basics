namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj meno osoby 1");
            string Meno1 = Console.ReadLine();
            Console.WriteLine("Zadaj priezvisko osoby 1");
            string Priezvisko1 = Console.ReadLine();
            Console.WriteLine("Zadaj vek osoby 1 v rokoch");
            int Vek1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj hmotnosť osoby 1 v kg");
            int Vaha1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj výšku osoby 1 v cm");
            int Vyska1 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1} je starý(á) {2} rokov. Váži {3} kg a je {4} cm vysoký(á).",
               Meno1, Priezvisko1, Vek1, Vaha1, Vyska1);
            float BMI1;
            float Vyska1M = (float)(Vyska1 / 100.0);
            BMI1 = (float)(Vaha1 / (Vyska1M * Vyska1M));
            Console.WriteLine("Jeho/jej BMI je {0}", BMI1);

            Console.WriteLine("Zadaj meno osoby 2");
            Meno1 = Console.ReadLine();
            Console.WriteLine("Zadaj priezvisko osoby 2");
            Priezvisko1 = Console.ReadLine();
            Console.WriteLine("Zadaj vek osoby 2 v rokoch");
            Vek1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj hmotnosť osoby 2 v kg");
            Vaha1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj výšku osoby 2 v cm");
            Vyska1 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1} je starý(á) {2} rokov. Váži {3} kg a je {4} cm vysoký(á).",
               Meno1, Priezvisko1, Vek1, Vaha1, Vyska1);
            Vyska1M = (float)(Vyska1 / 100.0);
            BMI1 = (float)(Vaha1 / (Vyska1M * Vyska1M));
            Console.WriteLine("Jeho/jej BMI je {0}", BMI1);
        }
    }
}
