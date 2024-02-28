namespace Luan1006.RiotAPI
{
    class Program
    {
        public static string Key { get; set; } = APIKey.Key;

        static void Main(string[] args)
        {
            User user = new User
            {
                // Set the game name and tag line
                // Riot Game ID = gameName#tagLine
                gameName = "",
                tagLine = "",
            };
        }
    }
}