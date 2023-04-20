using System;

namespace Biblioteca
{
	
	internal class Program
	{
		
		static void Main(string[] args)
		{
		   Biblioteca biblioteca = new Biblioteca(); 
		   //adicionando clientes
		
		   biblioteca.clientes.Add(new Cliente {Id= 1, Nome= "Jaspion",
			DataNascimento= new DateTime(1979, 01,10), Telefone= "419494-5898" });
			
			biblioteca.clientes.Add(new Cliente {Id= 2, Nome= "Jiraia",
			DataNascimento= new DateTime(1959, 11,09), Telefone= "439494-6789" });
			
			//adicionando livro
			biblioteca.livros.Add(new Livro { Id_livro= 1, Titulo= "Dom Casmurro",
			Autor="Machado de Asiss", Disponivel= true});
		  
		  biblioteca.livros.Add(new Livro { Id_livro= 2, Titulo= "Harry Poter - E a Crianca Amaldicoada",
			Autor="J.H Hollings", Disponivel= true});
			
			// Metodo Esprestando Livro
			biblioteca.EmprestarLivro(1, 1);
			
			// Metodo Devolvendo Livro
			biblioteca.DevolverLivro(1,1);
		}
	}
}