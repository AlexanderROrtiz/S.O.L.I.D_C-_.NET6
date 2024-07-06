namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public Arquitect()
        {
        }

        public void Plan() 
        {
             Console.WriteLine("I'm planning user stories");
        }

        public void Comunicate() 
        {
            Console.WriteLine("I'm talking to the team user");
        }

        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        public void Design()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}