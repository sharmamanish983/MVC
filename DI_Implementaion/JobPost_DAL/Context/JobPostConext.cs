using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using JobPost_DAL.Models;

namespace JobPost_DAL.Context
{
    public class JobPostConext: DbContext
    {
        public DbSet<JobPost> JobPosts { get; set; }
    }
}