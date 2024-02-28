using System.Text.Json;

namespace Luan1006.RiotAPI.Library
{
    public class AccountV1
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<AccountDto> GetAccountByPuuid(string puuid, string apiKey)
        {
            string url = HelperMethods.GetApiURL($"https://europe.api.riotgames.com/riot/account/v1/accounts/by-puuid/{puuid}", apiKey);

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                AccountDto account = JsonSerializer.Deserialize<AccountDto>(responseBody);
                return account;
            }
            else
            {
                string errorBody = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request to {url} failed with status code {response.StatusCode}. Response body: {errorBody}");
            }
        }
    }
}