using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WarrentyTracker1._0.Models;

namespace WarrentyTracker1._0.Services
{
	public class AppService : IAppService

	{
		/*Virtual server link */
		private string _baseUrl = "https://localhost:3000";
		/*Authenticate user function*/
		public async Task<string> AuthenticateUser(LoginModel loginModel)
		{
			string returnStr = string.Empty;
			using (var client = new HttpClient())
			{
				var url = $"{_baseUrl}{APIs.AuthenticateUser}";
				var serializedStr = JsonConvert.SerializeObject(loginModel);
				var response = await client.PostAsync(url,new StringContent(serializedStr,Encoding.UTF8,"application/json"));
				if (response.IsSuccessStatusCode)
				{
					returnStr = await response.Content.ReadAsStringAsync();
				}
			}
			return returnStr;
		}
		/*Register user function*/
		public async Task<(bool isSuccess, string errorMessage)> RegisterUser(RegistrationModel registerUser)
		{
			string errorMessage = string.Empty;
			bool isSuccess = false;
			using (var client = new HttpClient())
			{
				var url = $"{_baseUrl}{APIs.RegisterUser}";
				var serializedStr = JsonConvert.SerializeObject(registerUser);
				var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));
				if (response.IsSuccessStatusCode)
				{
					isSuccess = true;
				}
				else
				{
					errorMessage= await response.Content.ReadAsStringAsync();
				}
			}
			return (isSuccess, errorMessage);
		}
	}
}
