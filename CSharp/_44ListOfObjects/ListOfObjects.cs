namespace _44ListOfObjects;

public class ListOfObjects
{
    public static void Main(string[] args)
    {
        List<Player> players = new List<Player>(); // this can store a list of player objects

        Player player1 = new Player("Lebron James");
        Player player2 = new Player("Stephen Curry");
        Player player3 = new Player("Michael Jordan");
        
        // now we want to add this objects to the array list.
        players.Add(player1);
        players.Add(player2);
        players.Add(player3);
        players.Add(new Player("James Harden")); // you can anonymously pass a variable like this and not bother naming the object anymore
        players.Add(new Player("Kobe Bryant"));
        players.Add(new Player("Louis Lapayags"));
        foreach (Player player in players)
        {
            Console.WriteLine(player);
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