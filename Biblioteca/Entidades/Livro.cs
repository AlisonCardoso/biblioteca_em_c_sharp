using System;

namespace Biblioteca
{
   public class Livro
   
	{
		
		public int Id_livro { get; set; }
		public string Titulo { get; set; }
		public string? Autor { get; set; }
		public string? Genero { get; set; }
		public bool Disponivel { get; set; }
		
	}
}