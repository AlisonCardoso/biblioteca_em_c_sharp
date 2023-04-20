using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca
{
  public class Cliente :Pessoa
   
	{
		[Key]
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		
	}
}