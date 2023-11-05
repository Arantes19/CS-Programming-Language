using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ListObjects
{
    class ListObjectsC
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }

        }
    }

    class Player 
    {
        public String username;
        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}