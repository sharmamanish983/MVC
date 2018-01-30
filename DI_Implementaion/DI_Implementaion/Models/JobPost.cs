using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DI_Implementaion.Models
{
    public class JobPost
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Title { get; set; }
        public String Post { get; set; }
        
    }
}   