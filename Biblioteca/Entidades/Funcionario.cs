using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca
{
  public class Funcionario : Pessoa
   
	{
		[Key]
		int Id { get; set; }
		public DateTime DataAdmissao { get; set; }
		public string Cpf { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		
	}
}