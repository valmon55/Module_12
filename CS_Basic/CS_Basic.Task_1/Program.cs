namespace CS_Basic.Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> _users = new List<User>();

            _users.Add(new User("PJ","Patic",false));
            _users.Add(new User("TL", "Lisbon", true));
            _users.Add(new User("SN", "Sami", false));

            Process(_users);
        }
        static void Process(List<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine($"Hello {user.Name}!");
                if (!user.IsPremium)
                    ShowAds();
            }

        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

    }

}