using AgroPalace31.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.Model
{
    //validating input when updating a rseource with put
    public class CourseForCreationDto : CourseForManipulationDto
    {
    }
    /*
    //class level input validation with a custom attribute
    [CourseTitleMustBeDifferentFromDescriptionAttributes(
        ErrorMessage ="title must be different from description")]

    //customizing error message
    public class CourseForCreationDto : IValidatableObject
    {
        
        [Required(ErrorMessage = "You should fill out a title.")]
        [MaxLength(100, ErrorMessage = "The title shouldn`t have more than 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You should fill out a description")]
        [MaxLength(1500, ErrorMessage = "the description shouldn`t have more than 1500 characters.")]
        public string Description { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
        
    }
    */

    //class level input validation with IValidatableObject

    /* public class CourseForCreationDto :IValidatableObject
     {
         [Required]
         [MaxLength(100)]
         public string Title { get; set; }

         [MaxLength(1500)]
         public string Description { get; set; }

         public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
         {
             if(Title == Description)
             {
                 yield return new ValidationResult(
                     "The provided description should be different from the title.",
                     new[] { "CourseForCreationDto" });
             }
         } 
     } */
}
 