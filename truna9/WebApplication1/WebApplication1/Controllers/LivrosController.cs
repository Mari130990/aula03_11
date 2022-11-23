﻿using Chapterturma9.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapterturma9.Contexts
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivrosController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository; ;
        }


        [HttpGet]
        public IActionResult Listar()
        {

            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}