namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() {}
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome; 
        Sobrenome = sobrenome;
    }
    public string Nome { get; set; }
    public string Sobrenome{ get; set; }
    public string NomeSobrenome => $"{Nome} {Sobrenome}".ToUpper();


    public static Pessoa adicionarHospede()
    {
      Pessoa pessoa = new Pessoa();
      Console.WriteLine("Qual o nome do hóspede?");
      pessoa.Nome = Console.ReadLine();
      return pessoa;
    }

    // public Pessoa(string nome, string sobrenome)
    // {
        // Nome = nome;
        // Sobrenome = sobrenome;
    // }

    // public string Nome { get; set; }
    // public string Sobrenome { get; set; }
    // public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}