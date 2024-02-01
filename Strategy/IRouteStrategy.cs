namespace DesignPatterns.Strategy
{
    internal interface IRouteStrategy
    {
        public void BuildRoute(int source, int dest);
    }
}
