using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewProject1Crud.Models
{
    public class ItemsData
    {   [Key]
    [Required]
        public int Id { get; set; }
        [Required]
        public string ItemName{ get; set; }
        [Required]
        public int ItemPrice{ get; set; }
        [Required]
        public int Stocks { get; set; }
        [Required]
        public string Discription { get; set; }
        [Required]
        public string Images { get; set; }
        [Required]
        public bool Isactive { get; set; }
    }
}
