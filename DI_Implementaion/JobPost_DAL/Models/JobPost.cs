using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace JobPost_DAL.Models
{
    public class JobPost
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Title { get; set; }
        public String Post { get; set; }

        public DI_Implementaion.Models.JobPost ToBALJobPost()
        {
            return new DI_Implementaion.Models.JobPost
            {
            Id= this.Id,
            Title=this.Title,
            Post= this.Post
            };
        }

    }
}