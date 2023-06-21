using Lab04_TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Console Version");

            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Player p1 = new Player();
            Console.WriteLine("Player 1: please Enter Your Name");
            p1.Name = Console.ReadLine();
            Console.WriteLine("What Marker do you prefer X or O");
            p1.Marker = Console.ReadLine().ToUpper();
            if (p1.Marker != "O" && p1.Marker != "X")
            {
                p1.Marker = "O";
            }

            Player p2 = new Player();
            if (p1.Marker == "X")
                p2.Marker = "O";
            else p2.Marker = "X";

            Console.WriteLine("Player 2: You will use " + p2.Marker + ", please Enter Your Name");
            p2.Name = Console.ReadLine();

            Game game = new Game(p1, p2);

            Player winner = game.Play();
            if (winner != null)
            {
                Console.WriteLine($"{winner.Name} is the winner");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }



    }
}
