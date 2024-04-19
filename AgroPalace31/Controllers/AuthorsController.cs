using AgroPalace31.Helper;
using AgroPalace31.Model;
using AutoMapper;
using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController :ControllerBase
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;
        //adding mapper
        private readonly IMapper _mapper;
        public AuthorsController(ICourseLibraryRepository courseLibraryRepository,
            IMapper mapper)
        {
            _courseLibraryRepository = courseLibraryRepository ??
                throw new ArgumentNullException(nameof(courseLibraryRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        } 
        //action return type
        /* [HttpGet()]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _courseLibraryRepository.GetAuthors();
            var authors = new List<AuthorDto>();
            foreach (var author in authorsFromRepo)
            {
                authors.Add(new AuthorDto()
                    {
                        Id = author.Id,
                        Name = $"(author.FirstName)(author.LastName)",
                        MainCategory = author.MainCategory,
                        Age = author.DateOfBirth.GetCurrentAge()
                    });
            }
            return Ok(authors);
        } */

        //actionresult-T & object Mapping
        [HttpGet()]
        public ActionResult<IEnumerable<AuthorDto>> GetAuthors()
        {
            var authorsFromRepo = _courseLibraryRepository.GetAuthors(); 
            return Ok(_mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo));
        }

        //using actionresult
        /* [HttpGet("authorId ")]
        public IActionResult GetAuthor(Guid authorId)
        {
            var authorsFromRepo = _courseLibraryRepository.GetAuthor(authorId);
            if(authorsFromRepo == null)
            {
                return NotFound();
            }
            return Ok(authorsFromRepo);
        } */

        //using mapping 
        public ActionResult<IEnumerable<AuthorDto>> GetAuthor(Guid authorId)
        {
            var authorFromRepo = _courseLibraryRepository.GetAuthor(authorId);
            if (authorFromRepo == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<AuthorDto>>(authorFromRepo));
        }
    }
}
 