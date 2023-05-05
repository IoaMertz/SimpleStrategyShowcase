namespace GenericStrategy
{
    public interface IStrategy<OutT ,InT ,InZ>
    {
        Func<OutT,InT,InZ> Strategy 

    }
}