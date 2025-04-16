using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Play Mode Id")]
        public int Id { get; set; }
        [DisplayName("Play Mode Name")]
        [Required(ErrorMessage = "Play Mode Name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Play Mode Name must be between 3 and 50 caracters")]
        public string Name  {get;set;}

        [DisplayName("Play Mode Observation")]
        [Required(ErrorMessage = "Play Observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Play Mode Observation must be between 3 and 200 caracters")]
        public string Observation { get;set;}
    }
}
