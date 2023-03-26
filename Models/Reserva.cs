namespace DesafioProjetoHospedagem.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

      if (hospedes.Count() <= Suite.Capacidade)
      {
        Hospedes = hospedes;
      }
      else
      {
        // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
        int totalHospedes = hospedes.Count();

        throw new Exception($"A capacidade não suporta {totalHospedes} hospedes");
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
      return Hospedes.Count();
    }

    public decimal CalcularValorDiaria()
    {
      // TODO: Retorna o valor da diária
      decimal valor = DiasReservados * Suite.ValorDiaria;
      // *IMPLEMENTE AQUI*
      if (DiasReservados >= 10)
      {
        decimal desconto = valor * 0.1m;
        valor = valor - desconto;
      }

      return decimal.Parse(valor.ToString("F2"));
    }
  }
}