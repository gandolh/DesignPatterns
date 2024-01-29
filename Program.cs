
#region factory pattern
//using DesignPatterns.Factory;

// factory pattern
// os type should be got by configuration / system environment
//FactoryMain factoryMain = new FactoryMain(OsType.Windows);
//factoryMain.main();

// abstract factory
#endregion

#region abstract factory pattern
using DesignPatterns.AbstractFactory;


// the abstract factory is the gui factory.
AbstractFactoryMain abstractFactoryMain = new AbstractFactoryMain(OsType.Mac);
abstractFactoryMain.Main();
#endregion