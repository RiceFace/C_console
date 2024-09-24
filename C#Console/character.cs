
class Character
{
    public string name "sarah";
    public int health;
    public int stregnth;

    public static void Players()
    {
      Character player1 = new Character();
      string a = player1.name;
      player1.name = "Damaris"
      player1.health = 100;
      player1.stregnth = 100;

      Console.Writeline("Player1 Name: " + player1.name);

      Character player2 = new Character();
      player2.name ="Tom";
      player2.health = 50;
      player2.stregnth = 50;

    }
}