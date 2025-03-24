namespace Application.Listas
{
    public static class ListaDeFinanca
    {
        public static List<string> ListaDeNomesDeFinancas()
        {
            var listaDetipos = new List<string>()
            {
               "Poupança",
               "INSS",
               "Investimento",
               "Outros"
            };
            return listaDetipos;
        }
        public static List<string> ListaDeNomesDeOperacao()//Categorias
        {
            var listaDetipos = new List<string>()
            {
                "Receita",
                "Débito da Poupança",                
                "Depósito no Pix",
                "Depósito",
                "Saldo da Carteira",
                "Saldo da Poupança",
                "Reembolso",
                "Débito de Investimentos",
                "Saldo de Investimentos"
            };
            return listaDetipos;
        }

        public static List<string> ListaDeTiposDeFinancas()
        {
            var listaDetipos = new List<string>()
            {
                "Crédito",
                "Renda",
                "Débito",
                "Carteira",
                "Saldo Anterior"
            };
            return listaDetipos;

        }
    }
}
