using System;

namespace SolidPrinciples
{
    
    //Liskov Substitution Principle
    
    //WRONG
    
    public class Phone
    {
        public virtual string GetModel()
        {
            return "Phone model.";
        }
    }
    
    public class Notebook:Phone
    {
        public override string GetModel()
        {
            return "Notebook model.";
        }
    }
    
    
    public interface ITechnique
    {
        public string getModel();
        
    }

    public class Phone2 : ITechnique
    {
        public string getModel()
        {
            return "Phone model.";

        }
    }
    public class Notebook2 : ITechnique
    {
        public string getModel()
        {
            return "Notebook model.";
        }
    }
    
}