namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks And Queues");

            StackAndQueues list = new StackAndQueues();

            list.Push(56);
            list.Push(30);
            list.Push(70);

            list.Display();

        }
    }
}