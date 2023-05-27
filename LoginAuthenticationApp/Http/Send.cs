using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Text.Json;
using System.IO;

namespace LoginAuthenticationApp.Http
{
    public class Send
    {
        // For testing...
        private static readonly string saveLoginPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\response.txt";
        private static readonly string saveRegisterPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\regResponse.txt";

        public static async Task<bool> Login(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                LoginInfo credentials = new LoginInfo(username, password);
                string json = JsonSerializer.Serialize(credentials);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("http://localhost:3001/api/v2/login", content);

                string responseString = await response.Content.ReadAsStringAsync();

                LoginResponse loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseString);

                // To access login info -> loginResponse.*
                // E.G. File.WriteAllText(saveLoginPath, loginResponse.token);

                if (loginResponse.error)
                {
                    return false;
                }

                using (HttpClient _client = new HttpClient())
                {
                    _client.DefaultRequestHeaders.Add("Authorization", loginResponse.token);
                    HttpResponseMessage _response = await _client.GetAsync($"http://localhost:3001/api/v1/user/{loginResponse.result.data[0].id}");

                    string _responseString = await _response.Content.ReadAsStringAsync();

                    List<UserInfoResponse> userInfoResponse = JsonSerializer.Deserialize<List<UserInfoResponse>>(_responseString);

                    // To access user info -> userInfoResponse[0].*

                    if (userInfoResponse[0].error)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        public static async Task<bool> Register(string fullname, string username, string email, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                RegisterInfo credentials = new RegisterInfo(username, password, fullname, email);

                string json = JsonSerializer.Serialize(credentials);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("http://localhost:3001/api/v1/register", content);
                string responseString = await response.Content.ReadAsStringAsync();

                RegisterResponse registerResponse = JsonSerializer.Deserialize<RegisterResponse>(responseString);

                // To access register info -> registerResponse.* 

                if (registerResponse.error == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
