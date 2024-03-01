using System.Text.Json;

namespace Luan1006.RiotAPI.Library
{
    public class AccountV1
    {
        const string accountV1BaseURL = "https://europe.api.riotgames.com/riot/account/v1/";
        const string accountsByPuuidURL = "accounts/by-puuid/";
        private readonly HttpClient _client;
        public AccountV1(HttpClient client)
        {
            _client = client;
        }

        public async Task<AccountDto> GetAccountByPuuid(string puuid, string apiKey)
        {
            string url = HelperMethods.CreateApiURL($"{accountV1BaseURL}{accountsByPuuidURL}{puuid}", apiKey);

            HttpResponseMessage response = await _client.GetAsync(url);

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