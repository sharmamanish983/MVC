using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_Implementaion.Models;
namespace DI_Implementaion.Repository
{
    interface IJobPost_Repository
    {
        IEnumerable<JobPost> GetAllPositions();
        void CreateJobPosition(JobPost job);
        JobPost JobPostInfo(int Id);
        void UpdateJobPosition(JobPost job);
        void DeleteJobPosition(int Id);
    }
}
