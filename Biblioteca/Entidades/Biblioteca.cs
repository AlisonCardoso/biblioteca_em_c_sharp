using System;
using System.Collections.Generic;

namespace Biblioteca
{
   public class Biblioteca
   
	{
		public List<Cliente> clientes = new List<Cliente>();
		public List<Livro> livros = new List<Livro>();
		public List<Emprestimo> emprestimos = new List<Emprestimo>();
		
		public void EmprestarLivro(int idCliente, int idLivro)
		{
			try {
			Livro livro = livros.Find(l => l.Id_livro == idLivro);
			
			
		if (livro == null)	
		{
			Console.WriteLine("Livro não encontrado ou indisponivel");
			return;
		}
		Cliente cliente = clientes.Find(c => c.Id == idCliente);
		if( cliente ==null)
		{
			Console.WriteLine("Cliente não encontrado:");
			return;
		}
		 
		
		Emprestimo emprestimo = new Emprestimo
		{
			Id = emprestimos.Count + 1,
			ClienteEmprestimo = cliente,
			LivroEmprestado = livro,
			DataDevolucao = DateTime.Today,
			DataDevolucaoPrevista = DateTime.Today.AddDays(7)
		};
		
		
		livro.Disponivel = false;
		emprestimos.Add(emprestimo);
		
		Console.WriteLine("Livro Emprestado com Sucesso");
		
		} 
		catch (Exception ex)
		{
			Console.WriteLine($"ocorreu um erro ao tentar empresrtar um livro: {ex.Message}");
		}
		}
		
		public void DevolverLivro(int idCliente, int idLivro)
		{
			try
			
			{
				Livro livro = livros.Find(l => l.Id_livro == idLivro);
			if( livro== null)
			{
				Console.WriteLine("Livro Não Encorntrado.");
				return;
			}
			
		Emprestimo emprestimo = emprestimos.Find(e=> e.ClienteEmprestimo.Id ==idCliente && e.LivroEmprestado.Id_livro==idLivro);
		if(emprestimo== null)
		{
			Console.WriteLine("Cliente Não Encontrado");
			return;
		}
		emprestimo.LivroEmprestado.Disponivel = true;
		emprestimo.DataDevolucao = DateTime.Today;
		
		Console.WriteLine("Livro devolvido com Sucesso");
			
		}
			catch( Exception ex)
			{
			Console.WriteLine($"ocorreu um erro ao tentar empresrtar um livro: {ex.Message}");
		}
					
		
		
			
	}
}
}