namespace DesafioFundamentos.Models
{
        class Estacionamento
    {
        private decimal precoFixo;
        private decimal precoPorHora;

        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoFixo, decimal precoPorHora)
        {
            this.precoFixo = precoFixo;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Insira a placa do veículo a ser adicionado:");
            string placa = Console.ReadLine();

            if (veiculos.Any(i => i.Equals(placa.ToUpper())))
            {
                Console.WriteLine("Este veículo ja está estacionado.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("O veículo foi estacionado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Insira a placa do veiculo a ser retirado:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Insira a quantidade de horas em que o veículo ficou estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorFinal = precoFixo + precoPorHora * horas;

                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo de placa: {placa} foi removido.");
                Console.WriteLine($"O preço total foi de: R$ {valorFinal}");
            }
            else
            {
                Console.WriteLine($"O veículo com placa: {placa} não foi encontrado!");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados:");
                foreach(var y in veiculos)
                {
                    Console.WriteLine(y);
                }
            }
            else
            {
                Console.WriteLine("O estacionamento está vazio");
            }
        }
    }
}