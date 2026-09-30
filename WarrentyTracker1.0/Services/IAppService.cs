using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrentyTracker1._0.Models;

namespace WarrentyTracker1._0.Services
{
	public interface IAppService
	{
		public Task<string> AuthenticateUser(LoginModel loginModel);
		Task<(bool isSuccess, string errorMessage)> RegisterUser(RegistrationModel registerUser);

	}
}
	

