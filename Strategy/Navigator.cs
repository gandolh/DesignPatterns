namespace DesignPatterns.Strategy
{
    internal class Navigator : IRouteStrategy
    {
        public IRouteStrategy RouteStrategy { private get; set; }

        public Navigator(IRouteStrategy routeStrategy)
        {
            this.RouteStrategy = routeStrategy;
        }

        public void BuildRoute(int source, int dest)
        {
            RouteStrategy.BuildRoute(source, dest);
        }
    }
}
