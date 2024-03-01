namespace Luan1006.RiotAPI.Library
{
    public class HelperMethods
    {
        public static string CreateApiURL(string endpoint, string apiKey)
        {
            if (endpoint.Contains("?"))
            {
                return $"{endpoint}&api_key={apiKey}";
            }
            else
            {
                return $"{endpoint}?api_key={apiKey}";
            }
        }
    }
}