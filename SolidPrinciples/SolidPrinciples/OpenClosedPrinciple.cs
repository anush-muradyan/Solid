using SolidPrinciples;

namespace SolidPrinciples
{
    //Open-Closed Principle

    //WRONGONE

    public interface IShape
    {
        public string name { get; }
    }



    public class Shape
    {
        public IShape Shape1 { get; }

        public Shape(IShape shape)
        {
            Shape1 = shape;
        }

        public string getName()
        {
            if (Shape1.name.ToLower().Equals("triangle"))
            {
                return "triangle";
            }

            if (Shape1.name.ToLower().Equals("rectangle"))
            {
                return "rectangle";
            }

            return null;
        }
    }

//USING Open-Closed Principle
    public abstract class Shape2
    {
        public IShape Shape1 { get; }

        public Shape2(IShape shape)
        {
            Shape1 = shape;
        }

        public abstract string getName();
    }

    public class Triangle : Shape2
    {
        public Triangle(IShape shape) : base(shape)
        {
        }

        public override string getName()
        {
            return "triangle";
        }
    }


    public class Rectangle : Shape2
    {
        public Rectangle(IShape shape) : base(shape)
        {
        }

        public override string getName()
        {
            return "rectangle";
        }
    }
}