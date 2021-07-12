namespace SolidPrinciples
{

    //Dependency Inversion Principle


    //WRONG


    public class Enemy
    {
        public virtual string getName()
        {
            return "ENEMY";
        }
    }

    public class Player : Enemy
    {
        public override string getName()
        {
            return "Player";
        }
    }




    public interface Units
    {
        public string getName();

    }

    public class Enemy2 : Units
    {
        public string getName()
        {
            return "ENEMY";
        }
    }

    public class Player2 : Units
    {
        public string getName()
        {
            return "PLayer";
        }
    }

}