public class Enemy : Person
{
    public int numOfAttack;

    public Enemy(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
    }

    // Battle methods -----------------------------------------

    public int EChoice()
    {
        int eChoice;
        Random ran = new Random();
        eChoice = ran.Next(1, numOfAttack + 1);
        return eChoice;
    }
}

public class Bandit : Enemy
{
    public Bandit(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
        numOfAttack = 2;
    }

    //  Battle methods ---------------------------------------------

    public void Steal(Hero target)
    {
        target.health -= attack + 2;
    }

    public void BanditTurn(int choice, Hero target)
    {
        if (choice == 1)
        {
            NormAttack(target);
            Console.WriteLine("Bandit whacked you!");

        }

        if (choice == 2)
        {
            Steal(target);
            Console.WriteLine("Bandit stole from you!");

        }

        Console.ReadLine();
        Console.Clear();
    }
}

public class Knight : Enemy
{
    public Knight(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
        numOfAttack = 3;
    }

    // Battle methods -------------------------------------------

    public void Slash(Hero target)
    {
        target.health -= attack + 5;
    }

    public void SheildSlam(Hero target)
    {
        target.health -= attack + 2;
    }

    public void KnightTurn(int choice, Hero target)
    {
        if (choice == 1)
        {
            NormAttack(target);
            Console.WriteLine("Knight punched you!");
        }

        if (choice == 2)
        {
            Slash(target);
            Console.WriteLine("Knight slashed you!");
        }

        if (choice == 3)
        {
            SheildSlam(target);
            Console.WriteLine("Knight slammed you with his shield!");
        }

        Console.ReadLine();
        Console.Clear();
    }
}

public class Dragon : Enemy
{
    public int armor;

    public Dragon(string _name, int _attack, int _health, int _armor)
        : base(_name, _attack, _health)
    {
        numOfAttack = 4;
        armor = _armor;
    }

    // Battle methods ------------------------------------------------------------

    public void FireBreath(Hero target)
    {
        target.health -= attack * 2;
    }

    public void Claw(Hero target)
    {
        target.health -= attack + 3;
    }

    public void Bite(Hero target)
    {
        target.health -= attack + 4;
    }

    public void DragonTurn(int choice, Hero target)
    {
        if (choice == 1)
        {
            NormAttack(target);
            Console.WriteLine("Dragon sneezed on you!");
        }

        if (choice == 2)
        {
            FireBreath(target);
            Console.WriteLine("Dragon used flamethrower on you!");
        }

        if (choice == 3)
        {
            Claw(target);
            Console.WriteLine("Dragon clawed you!");
        }

        if (choice == 4)
        {
            Bite(target);
            Console.WriteLine("Dragon bite you!");
        }

        Console.ReadLine();
        Console.Clear();
    }
}