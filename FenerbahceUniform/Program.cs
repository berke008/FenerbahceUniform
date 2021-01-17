using System;

namespace FenerbahceUniform
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Mesut Ozil";
            double Number = 67;
            int Age = 32;
            string Position = "10 numara";

            

            Player player1 = new Player();
            player1.Name = "Mesut Ozil";
            player1.Number = 67;
            player1.Age = 32;
            player1.Position = "10 numara";

            Player player2 = new Player();
            player2.Name = "Szalai";
            player2.Number = 41;
            player2.Age = 22;
            player2.Position = "Sol stoper";

            Player[] players = new Player[] {player1, player2 };
                //class ismi(veritipi) - farketmez - in - yukarıdaki list ismi  
            foreach (Player player in players)
            {
                Console.WriteLine("Name: " + player.Name);
                Console.WriteLine("Number: " + player.Number);
                Console.WriteLine("Age: " + player.Age);
                Console.WriteLine("Position: " + player.Position);
                Console.WriteLine(" ");
            }
            
            Console.WriteLine("---------------METHODS---------------");

            TeamMenager teamMenager = new TeamMenager();
            teamMenager.Add(player1);
            teamMenager.Add(player2);

        }
    }
}
