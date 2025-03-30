using System.Globalization;

namespace Application.Listas
{
    public static class ListaDeStringMeses
    {
        public static List<string> Meses()
        {
            DateTime mes = DateTime.Now;
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string mesAtual = textInfo.ToTitleCase(mes.ToString("MMMM"));
            mesAtual = (mesAtual == "Agosto") ? "Agôsto" : mesAtual;
            var listaDeMeses = new List<string>()
            {
                mesAtual,
                "Janeiro",
                "Fevereiro",
                "Março",
                "Abril",
                "Maio",
                "Junho",
                "Julho",
                "Agôsto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro",
            };
            return listaDeMeses;
        }
    }
}
