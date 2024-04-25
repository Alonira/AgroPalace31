using AgroPalace31.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.Model
{
    //we made it abstract bcuz we dont want this class to be used on it own, we
    //want it to be derived from (i.e the base class of oter class)
    [CourseTitleMustBeDifferentFromDescriptionAttributes(
        ErrorMessage = "title must be different from description")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a title.")]
        [MaxLength(100, ErrorMessage = "The title shouldn`t have more than 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You should fill out a description")]
        [MaxLength(1500, ErrorMessage = "the description shouldn`t have more than 1500 characters.")]
       
        //Abstract : states that the description member must be implemented by
        //class that derived from the abstract class
       // public abstract string Description { get; set; }

        //virtual properties are great when you have a implementation 
        //in the based class but we do want to allow override
        public virtual string Description { get; set; }
    }
}
