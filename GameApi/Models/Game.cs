namespace GameApi.Models
{
    public class Games
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Genero { get; set; }

        public string Descricao { get; set; }

        public bool Disponivel { get; set; }
    }
}
