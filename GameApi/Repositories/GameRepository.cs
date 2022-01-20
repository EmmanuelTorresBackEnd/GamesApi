using GameApi.Contexts;
using GameApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Repositories
{
    public class GameRepository
    {
        private readonly GameContext _context;

        public GameRepository(GameContext context)
        {
            _context = context;
        }

        public List<Games> Listar()
        {
            return _context.Games.ToList();
        }

        public Games buscarPorId(int id)
        {
            return _context.Games.Find(id);

        }

        public void Cadastrar(Games games)
        {
            _context.Games.Add(games);

            _context.SaveChanges();
        }

        public void Atualizar(int id, Games games)
        {
            Games gameBuscado = _context.Games.Find(id);

            if (gameBuscado != null)
            {
                gameBuscado.Titulo = games.Titulo;
                gameBuscado.Genero = games.Genero;
                gameBuscado.Descricao = games.Descricao;
                gameBuscado.Disponivel = games.Disponivel;

            }

            _context.Games.Update(gameBuscado);

            _context.SaveChanges();

        }

        /// <summary>
        /// ATENÇÃO DELETA O GAME DO SISTEMA
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(int id)
        {
            Games gameBuscado = _context.Games.Find(id);

            _context.Games.Remove(gameBuscado);

            _context.SaveChanges();
        }

    }

}

     
        

 

