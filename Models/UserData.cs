using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewProject1Crud.Models
{
    public class UserData
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Mobile_No { get; set; }
        [Required]
        public string Email_Id { get; set; }
        
        [Required]
        public string Address  { get; set; }

        [Required]
        public bool Isactive { get; set; }



    }
}
