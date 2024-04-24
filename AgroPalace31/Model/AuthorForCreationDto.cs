using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.Model
{
    public class AuthorForCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string MainCategory { get; set; }

        //creating child resources with a parent resource
        public ICollection<CourseForCreationDto> Courses { get; set; }
        = new List<CourseForCreationDto>();
    }
}
