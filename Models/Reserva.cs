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

            //Implementado!!
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
            //Implementado!!
                throw new ArgumentException("A quantidade de hóspedes superou a de suítes disponíveis.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Implementado!!
            int qtdHospedes;

            qtdHospedes = Hospedes.Count;

            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            
            //Implementado!!
            decimal valor = DiasReservados*Suite.ValorDiaria;
            decimal descontoPorcentagem = 0.1M;
            decimal desconto;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
           
            //Implementado!!
            if (DiasReservados >= 10)
            {   desconto = valor * descontoPorcentagem;
                valor = valor - desconto;
                Console.WriteLine($"O valor com desconto da diária é de: {valor}");
            }

            return valor;
        }
    }
}