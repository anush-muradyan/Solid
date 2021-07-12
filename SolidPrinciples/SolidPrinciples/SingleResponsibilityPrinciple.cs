namespace SolidPrinciples
{
    //Single Responsibility Principle
    
    
    //WRONG ONE
    public class Person
    {
        protected string name;
        protected string lastName;
        protected int age;
        
        protected string workPlace;
        protected int salary;

        public Person(string name, string lastName, int age, string workPlace, int salary)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.workPlace = workPlace;
            this.salary = salary;
        }
    }

    
    public class Person2
    {
        protected string name;
        protected string lastName;
        protected int age;

        public Person2(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }
    }

    public class Emplayee : Person2
    {
        protected string workPlace;
        protected int salary;

        public Emplayee(string name, string lastName, int age, string workPlace, int salary) : base(name, lastName, age)
        {
            this.workPlace = workPlace;
            this.salary = salary;
        }
    }
    
}