namespace Airsoft.Facade
{
    public static class Client
    {
        public static void ClientMethod()
        {
            var facade = new Aluguel();
            Console.WriteLine(facade.AlugarArmas());
        }
    }
}
