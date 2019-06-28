

namespace HelloWorldRepo.Data
{
   public class HelloWorldRepository : IHelloWorldRepository
    {
        public string GetMessageFromDatabase()
        {
            //Connect to database and retrieve the message
            return "Gretings:Hello World";
        }
    }
}
