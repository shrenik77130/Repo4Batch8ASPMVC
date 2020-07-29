/* WAP to create class Player. Define class function to read Player Details playerid, playername, 
scored runs. show 3 records of players creating objects of class */


using System;

namespace TestNamespace
{
    class Player
    {
        public int playercode;
        public string playername;
        public int runs;

        public void addPlayer(int playercode,string playername,int runs)
        {
            this.playercode = playercode;
            this.playername = playername;
            this.runs = runs;
        }

        public void showPlayer()
        {
            Console.Write("\n Player Code = " + this.playercode);
            Console.Write("\n Player Name = " + this.playername);
            Console.Write("\n Runs = " + this.runs);
        }
    }


    public class MainApp
    {
        public static void Main(string []args)
        {
            Player p1 = new Player();
            p1.addPlayer(101,"Virat",2900);

            Player p2 = new Player();
            p2.addPlayer(102,"Sehwag",1800);

            Player p3 = new Player();
            p3.addPlayer(103,"Sachin",2400);

            p1.showPlayer();
            p2.showPlayer();
            p3.showPlayer();
            
        }
    }
}