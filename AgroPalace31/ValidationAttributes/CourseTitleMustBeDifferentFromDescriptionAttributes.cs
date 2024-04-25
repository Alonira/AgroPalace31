using AgroPalace31.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.ValidationAttributes
{



    //class level input validation with a custom attribute
    public class CourseTitleMustBeDifferentFromDescriptionAttributes : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {


            // var course = (CourseForCreationDto)validationContext.ObjectInstance;

            // //validating input when updating a resource with put
            var course = (CourseForManipulationDto)validationContext.ObjectInstance;

            if(course.Title == course.Description)
            {
                //class level input validation with IValidatableObject
                /*
                return new ValidationResult(
                    "The provided description should be differnt from the title.",
                    new[] {nameof(CourseForCreationDto)}
                    );
                */
                return new ValidationResult(ErrorMessage,
                   // new[] { nameof(CourseForCreationDto) });

                    //validating input when updating a resource with put
                 new[] { nameof(CourseForManipulationDto) });
            }
            return ValidationResult.Success;   
        }
    }
}
