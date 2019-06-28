using HelloWorld.Interfaces;
using HelloWorldRepo.Data;



namespace HelloWorld.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public readonly IHelloWorldRepository _helloWorldRepository;
        public HelloWorldService(IHelloWorldRepository helloWorldRepository)
        {
            _helloWorldRepository = helloWorldRepository;
        }
        public string GetMessage()
        {
            return _helloWorldRepository.GetMessageFromDatabase();
           
        }
    }
}
