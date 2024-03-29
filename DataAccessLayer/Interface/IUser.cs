﻿using DataAccessLayer.Entries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    internal interface IUser
    {
        Task<IEnumerable<Course>> Courses { get; set; }
        Task<IEnumerable<User>> Users { get; set; }
        Task<Course> AddCourse(int id);
        Task<Course> RemoveCourse(int id);
        Task UpdateCourseAsync(Course course);
        Task DeleteCourse(int id);
    }
}
