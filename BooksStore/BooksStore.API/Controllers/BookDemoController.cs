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
    public class BookDemoController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUnitOfWork _uow;

        public BookDemoController(IBookRepository bookRepository, IUnitOfWork uow)
        {
            _bookRepository = bookRepository;
            _uow = uow;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> Get()
        {
            var books = await _bookRepository.GetAll();
            return Ok(books);
        }
    }
}