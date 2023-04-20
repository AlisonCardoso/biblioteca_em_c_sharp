using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca
{
  public class Emprestimo 
   
	{
        public int Id { get; set; }
		public Cliente ClienteEmprestimo {get; set; }
		public Livro LivroEmprestado { get; set; }
		public DateTime DataEmprestimo { get; set; }
		public DateTime DataDevolucaoPrevista { get; set; }
		public DateTime? DataDevolucao { get; set; }
		
		public bool Devolido 
		{
			get
			{
				return DataDevolucao != null;
			}
		}	
	}
}