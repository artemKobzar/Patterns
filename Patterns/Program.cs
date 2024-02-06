using Patterns.Adapter;
using Patterns.Bridge;
using Patterns.ChainOfResponsobility;
using Patterns.Command;
using Patterns.Composite;
using Patterns.Facade;
using Patterns.FactoryMethod;
using Patterns.Observer;
using Patterns.Proxy;
using Patterns.State;
using Patterns.Strategy;

namespace Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select pattern:");
            string key = Console.ReadLine();
            Dictionary<string, Action> patterns = new Dictionary<string, Action>()
            {
                { "Facade", CallFacade },
                { "Adapter", CallAdapter },
                { "Strategy", CallStrategy },
                { "FactoryMethod", CallFactoryMethod},
                { "State", CallState},
                { "Command", CallCommand},
                { "Bridge", CallBridge},
                { "Composite", CallComposite},
                { "Proxy", CallProxy},
                { "Chain", CallChainOfResponsibility},
                { "Observer", CallObserver}
            };

            PrintResults(key);

            void CallObserver()
            {
                EmailSender sender = new EmailSender();
                Company company = new Company(sender);
                Observer.User user = new Observer.User(sender);
                user.Name = "Tom";
                company.Name = "Amazon";

                sender.SendMessage("You have been subscribed on newsletter");

                user.Unsubscribe();
                Console.WriteLine(new string('*', 10));
                sender.SendMessage("You have been subscribed on newsletter");
            }
            void CallChainOfResponsibility()
            {
                var client = new ClientChainOfResponsibility();
                client.Chain();
            }
            void CallProxy()
            {
                var client = new ClientProxy();
                client.UseProxy();
            }
            void CallComposite()
            {
                Component disc = new Direct("Disc C");
                Component folder1 = new Folder("Photos");
                Component folder2 = new Folder("Movies");

                Component file1 = new MyFile("Photo.jpg");
                Component file2 = new MyFile("Picture.jpg");
                Component file3 = new MyFile("AnotherPicture.jpg");

                Component file4 = new MyFile("Saw.mpeg4");
                Component file5 = new MyFile("Saw2.mpeg4");

                folder1.Add(file1);
                folder1.Add(file2);
                folder1.Add(file3);
                folder2.Add(file4);
                folder2.Add(file5);
                disc.Display();
                folder1.Display();
                folder2.Display();
            }
            void CallBridge()
            {
                InsuranceDiscount discount = new SafetyDriverDiscount();
                CarInsurance insurance = new Comprehensive("Tom", "VW", "Transporter", 2017, discount);
                CarInsurance insurance1 = new ThirdPart("Sam", "Audi", "A4", 2012, discount);
                Console.WriteLine($"Tom's insurance costs: {insurance.CalculateInsurance()}$");
                Console.WriteLine($"Sam's insurance costs: {insurance1.CalculateInsurance()}$");
            }
            void CallCommand()
            {
                InvokerOrder order = new InvokerOrder();
                order.SetCommand(1);
                order.SetItem(new MenuItem("Pizza", 1, 10.75));
                order.ExecuteCommand();
                Thread.Sleep(2000);
                order.SetCommand(1);
                order.SetItem(new MenuItem("Burger", 3, 7.35));
                order.ExecuteCommand();
                order.ShowOrder();

            }
            void CallState()
            {
                Elevator elevator = new Elevator(new ZeroLevel());
                while(true)
                {
                    Console.WriteLine("Select the direction:");
                    string direction = Console.ReadLine();
                    switch (direction)
                    {
                        case "up":
                            elevator.Up(elevator);
                            break;
                        case "down":
                            elevator.Down(elevator);
                            break;
                    }
                }

            }
            void CallFactoryMethod()
            {
                string message = "Your order number is 47930208.";
                MessageSender sender = new SmsMessageSender("+380960001122", "+380961112200");
                IMessage smsMessage =  sender.Send(message);
                Console.WriteLine($"{message} From: {sender.From} to {sender.To} ");

                sender = new EmailMessageSender("rrrr@gmail.com", "qqqq@gmail.com");
                IMessage emailMessage = sender.Send(message);
                Console.WriteLine($"{message} From: {sender.From} to {sender.To} ");
            }

            void CallStrategy()
            {
                ClientStrategy client = new ClientStrategy();
                client.UseStrategy();
            }
            void CallAdapter()
            {
                ClientAdapter client = new ClientAdapter();
                client.UseAdapter();
            }
            void CallFacade()
            {
                Facade.User user = new Facade.User();
                PC pC = new PC();
                user.UseComputer(pC);
                user.StopComputer(pC);
            }
            void PrintResults(string name)
            {
                foreach(var pattern in patterns)
                {
                    if(name == pattern.Key)
                    {
                        Console.WriteLine($"\n--------{pattern.Key}--------\n");
                        pattern.Value.Invoke();
                    }
                }
            }
        }
    }
}