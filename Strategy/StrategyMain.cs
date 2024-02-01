namespace DesignPatterns.Strategy
{
    internal class StrategyMain 
    {

        public void Main()
        {
            int source = 10;
            int dest = 20;
            PublicTransportStrategy pts = new PublicTransportStrategy();
            WalkingStrategy ws = new WalkingStrategy();
            RoadStrategy rs = new RoadStrategy();
            Navigator navigator = new Navigator(pts);
            navigator.BuildRoute(source, dest);
            navigator.RouteStrategy = ws;
            navigator.BuildRoute(source, dest);
            navigator.RouteStrategy = rs;
            navigator.BuildRoute(source, dest);
        }
    }
}
