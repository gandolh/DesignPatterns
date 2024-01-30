
#region factory pattern
//using DesignPatterns.Factory;

//// factory pattern - creates object of some kind having an context.
//// os type should be got by configuration / system environment
//FactoryMain factoryMain = new FactoryMain(OsType.Windows);
//factoryMain.main();

// abstract factory
#endregion

#region abstract factory pattern
//using DesignPatterns.AbstractFactory;
//// the abstract factory is the gui factory.
//// it is a factory but it is abstract. Other factories inherits this.
//AbstractFactoryMain abstractFactoryMain = new AbstractFactoryMain(OsType.Mac);
//abstractFactoryMain.Main();
#endregion

#region builder pattern
//using DesignPatterns.Builder;
//// builder pattern use methods to build the object.
//BuilderMain builderMain = new BuilderMain();
//builderMain.Main();

#endregion

#region Prototype pattern

//using DesignPatterns.Prototype;
//// There exists an interface (prototype) that has method: Clone.
//// The clone method uses a copy constructor (or clone in clone method) and creates
//// a new object that is copy of current object
//PrototypeMain prototypeMain = new PrototypeMain();
//prototypeMain.Main();

#endregion

#region Singleton pattern
//using DesignPatterns.Singleton;
//SingletonMain singletonMain = new SingletonMain();
//singletonMain.Main();
#endregion

#region Adapter pattern
//using DesignPatterns.Adapter;

//AdapterMain adapterMain = new AdapterMain();
//adapterMain.Main();

#endregion
#region Bridge pattern
//using DesignPatterns.Bridge;

//BridgeMain bridgeMain = new BridgeMain();
//bridgeMain.Main();
#endregion
#region Composite pattern
//using DesignPatterns.Composite;

//CompositeMain compositeMain = new CompositeMain();
//compositeMain.Main();

#endregion
#region Decorator pattern
//using DesignPatterns.Decorator;

//DecoratorMain decoratorMain = new DecoratorMain();
//decoratorMain.Main();
#endregion
#region Facade Pattern
//using DesignPatterns.Facade;

//FacadeMain main = new FacadeMain();
//main.Main();
#endregion

#region Flyweight pattern
using DesignPatterns.Flyweight;

FlyweightMain flyweightMain = new FlyweightMain();
flyweightMain.Main();

#endregion