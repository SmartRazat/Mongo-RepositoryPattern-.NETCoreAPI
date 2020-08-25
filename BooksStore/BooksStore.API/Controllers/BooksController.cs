using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksStore.Repository;
using BooksStore.Repository.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookRepository _bookRepository;

        public BooksController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            return _bookRepository.Get();
        }
    }
}