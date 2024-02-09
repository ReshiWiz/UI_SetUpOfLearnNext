using DataAccessLayer.Entries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    internal class CustomerRepository : IUser
    {
        public Task<IEnumerable<Course>> Courses { get; set; }
        public Task<IEnumerable<User>> Users { get; set; }

        public Task<Course> AddCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> RemoveCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
