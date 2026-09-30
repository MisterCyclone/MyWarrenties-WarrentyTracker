using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrentyTracker1._0.Models
{
    internal class AddWarrentyModel
    {
        [Required] public string ProductManafacturers { get; set; }
        [Required] public string ProductDescription { get; set; }
        [Required] public string WarrentyCovers { get; set; }
        [Required] public string WarrentyExpiry { get; set; }
    }
}
