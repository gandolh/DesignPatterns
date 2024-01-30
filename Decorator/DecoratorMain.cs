using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    internal class DecoratorMain
    {
        public DecoratorMain()
        {
            
        }

        public void Main()
        {

            // Decorator with Notifiers
            Notifier stack = new Notifier();
            stack = new FacebookDecorator(stack);
            stack = new SlackDecorator(stack);
            stack = new SmsDecorator(stack);
            stack.Send("Hello world!");

            // Decorator with datasource

            IDataSource source = new FileDataSource();
            source = new EncryptionDecorator(source);
            source = new CompressionDecorator(source);
            source.WriteData("hello world!");
            Console.WriteLine(source.ReadData());

        }
    }
}
