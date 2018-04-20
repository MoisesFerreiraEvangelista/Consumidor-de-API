using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var retorno = API.Consumer.API.Consumir<ObjetoRetorno>("https://viacep.com.br", "ws/01001000/json");

            Console.WriteLine(String.Format("Logradouro: {0}", retorno.logradouro));
            Console.WriteLine(String.Format("Bairro: {0}", retorno.bairro));
            Console.WriteLine(String.Format("Localidade: {0}", retorno.localidade));
            Console.WriteLine(String.Format("Estado: {0}", retorno.uf));


            Console.ReadKey();
        }
    }
    public class ObjetoRetorno
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
    }
}
