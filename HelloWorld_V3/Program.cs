using System.Security.Cryptography.X509Certificates;

namespace HelloWorld_V3
{
    
    internal class Program
    {
       
        static void Main(string[] args)
        {
             

            Message myMessage = new Message("Hello, World! Greetings from Message Object.");
            myMessage.Print();

            Console.WriteLine("Please enter your name:");
            string yourName = Console.ReadLine();

            List<Message> messages = new List<Message>();

            messages.Add(new Message("Kon'nichiwa " + yourName));
            messages.Add(new Message("Hola "  + yourName));
            messages.Add(new Message("Nǐ hǎo " + yourName));
            messages.Add(new Message("Bonjour "  + yourName));
            messages.Add(myMessage);

            if (yourName.ToLower() == "wilma")
            {
                messages[0].Print();
            }
            else if (yourName.ToLower() == "fred")
            {
                messages[1].Print();
            }
            else if (yourName.ToLower() == "bob")
            {
                messages[2].Print();
            }
            else if (yourName.ToLower() == "jessica")
            {
                messages[3].Print();
            }
            else
            {
                messages[4].Print();
            }
        }
    }
}
