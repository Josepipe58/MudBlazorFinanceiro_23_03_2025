namespace Application.Listas
{
    public static class ListaDeCategorias
    {
        public static List<string> CategoriaDeDespesa()
        {
            var listaDetipos = new List<string>()
            {
                "Alimentação",
                "Bazar",
                "Bebidas",
                "Cama, Mesa e Banho",
                "Caridade",
                "Contas Básicas",
                "Despesas Extras",
                "Diversão",
                "Diversos",
                "Higiene Pessoal",
                "Informática",
                "Limpeza",
                "Manutenção Geral",
                "Saúde",
                "Transportes",
                "Utensílios Domésticos",
                "Vestuário",
            };
            return listaDetipos;
        }
    }
}
