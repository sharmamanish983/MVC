
using System.Collections.Generic;
using System.Web;
using DI_Implementaion.Repository;
using JobPost_DAL.Context;


namespace JobPost_DAL.Repository
{
    public class SQLJobPostRepository: IJobPost_Repository
    {
        public IEnumerable<DI_Implementaion.Models.JobPost> GetAllPositions()
        {
            using (JobPostConext context = new JobPostConext())
            {
                IList<JobPost_DAL.Models.JobPost> blogposts = context.JobPosts.
                
               
            }
        }

    }
}