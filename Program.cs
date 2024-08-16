using System.Text;
using DesafioProjetoHospedagem.Models;


Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
//Implementado, Insere Hospedes a partir do terminal, e cria uma lista de hospedes;
List<Pessoa> hospedes = new List<Pessoa>();

bool adicioneHospede = true;
while (adicioneHospede)
{
    Pessoa p1 = Pessoa.adicionarHospede();
    hospedes.Add(p1);
    Console.Write("Deseja outro hóspede? \n pressine 0 para NÃO ou qualquer outra tecla se sim.\n");
    String resposta = Console.ReadLine();

    if (resposta == "0")
    {
        adicioneHospede = false;
    }

}
// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
//implementado!
Console.WriteLine("Quantos dias deseja reservar?");
int DiasReserva;
bool adicioneDias = int.TryParse(Console.ReadLine(), out DiasReserva);
if (adicioneDias)
{
    Reserva reserva = new Reserva(diasReservados: DiasReserva);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);
    Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor total da hóspedagem: {reserva.CalcularValorDiaria():C}");
}
// implementado! caso o usuário digite um valor diferente de Inteiro para a aplicação, e dá um retorno;
else
{
    Console.WriteLine($"Não é possível continuar a reserva, Voce adicionou um valor invalido.");
}