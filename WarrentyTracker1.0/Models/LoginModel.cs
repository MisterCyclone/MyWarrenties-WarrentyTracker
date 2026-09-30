using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*login model for getting user input*/
namespace WarrentyTracker1._0.Models
{
	public class LoginModel
	{
		/*Get set for username and password*/
		[Required]public string EMail { get; set; }
		
		[Required]public string Password { get; set; }
	}
}
