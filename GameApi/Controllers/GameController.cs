using GameApi.Models;
using GameApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GameApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameRepository _gameRepository;

        public GameController(GameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
        //GET /api/games
        [HttpGet]

        public IActionResult Listar()
        {

            try
            {
                return Ok(_gameRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        //HttpGetAttribute /api/games/1           /api/games/2
        [HttpGet("{id}")]

        public IActionResult BuscarPorID(int id)
        {
            try
            {
                Games gameProcurado = _gameRepository.buscarPorId(id);

                if (gameProcurado == null)
                {
                    return NotFound();
                }

                return Ok(gameProcurado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        [HttpPost]

        public IActionResult Cadastrar(Games games)
        {
            try
            {
                _gameRepository.Cadastrar(games);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult atualizar(int id, Games games)
        {
            try
            {
                _gameRepository.Atualizar(id, games);

                return StatusCode(204);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
          }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _gameRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


       }
    }
