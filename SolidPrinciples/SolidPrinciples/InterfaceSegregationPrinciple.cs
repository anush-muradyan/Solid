namespace SolidPrinciples
{
    
    //Interface Segregation Principle
    
    //WRONG

    public interface IOperation
    {
        public void CalculateSum();
        public void CalculateMultiplication();

    }

    public interface ISum
    {
        public void CalculateSum();
    }


    public interface IMultiplication
    {
        public void CalculateMultiplication();
    }
    
}