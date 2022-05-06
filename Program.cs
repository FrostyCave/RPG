class Program
{
    static void Main(string[] args)
    {
        Hero Dash = new Hero("Dash", 3, 15);

        Bandit Keith = new Bandit("Bandit Keith", 1, 5);
        Bandit Ben = new Bandit("Bandit Ben", 2, 8);

        Knight Leeroy = new Knight("Knight Leeroy", 3, 12);
        Knight Seth = new Knight("Knight Seth", 5, 15);

        Dragon BlueDrag = new Dragon("Blue Dragon", 7, 20, 2);
        Dragon RedDrag = new Dragon("Red Dragon", 8, 20, 3);
        Dragon BlackDrag = new Dragon("Black Dragon", 10, 25, 4);

        Story.BeforeBandits();
        Battle.WithBandit(Dash, Keith);
        Battle.WithBandit(Dash, Ben);

        Dash.LevelUp();

        Story.BeforeKnights();
        Battle.WithKnight(Dash, Leeroy);
        Battle.WithKnight(Dash, Seth);

        Dash.LevelUp();

        Story.BeforeDragons();
        Battle.WithDragon(Dash, BlueDrag);
        Battle.WithDragon(Dash, RedDrag);
        Battle.WithDragon(Dash, BlackDrag);

        Story.TheEnd();
    }
}