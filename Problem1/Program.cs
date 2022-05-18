
namespace Problem1
{
    public class Problem1
    {
        public static void Main()
        {
            var cardapio = new Cardapio();
            cardapio.Pratos = new List<Pratos>();

            var feijoada = new Pratos("Feijoada");
            feijoada.Componentes = new List<Ingrediente>();
            feijoada.Componentes.Add(new Ingrediente("Feijao", 1, "kg"));
            feijoada.Componentes.Add(new Ingrediente("Agua", 1, "L"));
            cardapio.Pratos.Add(feijoada);

            var ratatouile = new Pratos("Ratatouille");
            ratatouile.Componentes = new List<Ingrediente>();
            ratatouile.Componentes.Add(new Ingrediente("Abobrinha", 2, "und"));
            ratatouile.Componentes.Add(new Ingrediente("Beringela", 2, "und"));
            ratatouile.Componentes.Add(new Ingrediente("Cebola", 2, "und"));
            cardapio.Pratos.Add(ratatouile);

            foreach (var obj in cardapio.Pratos)
            {
                Console.WriteLine($"Prato: {obj.Descrição}");
                foreach (var receita in obj.Componentes)
                {
                    Console.WriteLine($"Componentes: {receita.Descrição}, Quantidade: {receita.Quantidade}, Unidade: {receita.Unidade}");
                }
		Console.WriteLine();
            }
        }
    }

    public class Ingrediente
    {
        public Ingrediente(string descrição, int quantidade, string unidade)
        {
            Descrição = descrição;
            Quantidade = quantidade;
            Unidade = unidade;
        }

        public string Descrição { get; set; }
        public int Quantidade { get; set; }
        public string Unidade { get; set; }
    }

    public class Receita
    {
        public List<Ingrediente> Componentes { get; set; }
    }

    public class Pratos : Receita
    {
        public Pratos(string descrição)
        {
            Descrição = descrição;
        }

        public string Descrição { get; set; }
    }

    public class Cardapio
    {
        public List<Pratos> Pratos { get; set; }
    }
}
