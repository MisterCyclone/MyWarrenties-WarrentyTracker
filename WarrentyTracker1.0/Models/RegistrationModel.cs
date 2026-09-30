using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrentyTracker1._0.Models
{
	/*Registeration model for user input*/
	public class RegistrationModel
	{
		/*Registration form getting and setting user input*/
		[Required]public string EMail { get; set; }
		[Required] public string Password { get; set; }


	}
}
