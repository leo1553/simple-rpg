using rpg.src.Entities;

namespace rpg
{
    public class Program
    {
        public void Main()
        {
            Knight knight = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 24, "White Wizard");

            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizard.Attack(2));
            Console.WriteLine(wizard.Attack(8));
        }
    }
}