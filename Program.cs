using static System.Console;
using projeto1.src.Entities;
namespace projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard Merlin = new Wizard("Merlin", 23, "wizard");
            Ninja Naruto = new Ninja("Naruto", 23, "Ninja");
            BlackWizard Shamira = new BlackWizard("Shamira", 23, "BlackWizard");

            WriteLine("Escolha com que Herói você vai atacar:");
            WriteLine("1 - Arus");
            WriteLine("2 - Merlin");
            WriteLine("3 - Naruto");
            WriteLine("4 - Shamira");
            var opcao = ReadLine();
            

            switch (opcao){
                case "1":
                    WriteLine("Você escolheu Arus");
                    WriteLine(Arus.Attack());
                    break;
                case "2":
                    WriteLine("Você escolheu Merlin");
                    WriteLine(Merlin.Attack());
                    WriteLine(Merlin.Attack(8));
                    break;
                case "3":
                    WriteLine("Você escolheu Naruto");
                    WriteLine(Naruto.Attack());
                    break;
                case "4":
                    WriteLine("Você escolheu Shamira");
                    WriteLine(Shamira.Attack());
                    break;
                default:
                    WriteLine("Opçao errada! Game Over");
                    break;
            }
        }
    }
}
