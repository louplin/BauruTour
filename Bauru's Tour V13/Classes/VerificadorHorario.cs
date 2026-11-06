using BaurusTour.Models;

namespace BaurusTour.Classes
{
    // Descobre se o lugar está aberto agora, comparando o horário do pontos.json
    // com a hora do computador (DateTime.Now)
    public static class VerificadorHorario
    {
        public const string Aberto = "Aberto agora";
        public const string Fechado = "Fechado agora";
        public const string NaoInformado = "Horário não informado";

        public static string Situacao(PontoTuristico ponto, DateTime agora)
        {
            if (!TemAlgumHorario(ponto))
                return NaoInformado;

            // Segunda-feira fechado
            if (agora.DayOfWeek == DayOfWeek.Monday && ponto.FechadoSegunda)
                return Fechado;

            // Pega o horário do dia de hoje
            string abre;
            string fecha;
            if (agora.DayOfWeek == DayOfWeek.Saturday)
            {
                abre = ponto.AbreSabado;
                fecha = ponto.FechaSabado;
            }
            else if (agora.DayOfWeek == DayOfWeek.Sunday)
            {
                abre = ponto.AbreDomingo;
                fecha = ponto.FechaDomingo;
            }
            else
            {
                abre = ponto.AbreSemana;
                fecha = ponto.FechaSemana;
            }

            // Tem horário em outros dias, mas não hoje
            if (abre == "" || fecha == "")
                return Fechado;

            TimeSpan horaAbre;
            TimeSpan horaFecha;
            if (!TimeSpan.TryParse(abre, out horaAbre) || !TimeSpan.TryParse(fecha, out horaFecha))
                return NaoInformado;

            TimeSpan horaAtual = agora.TimeOfDay;
            bool aberto;

            if (horaFecha > horaAbre)
            {
                // Horário normal, ex.: 08:00 às 17:00
                aberto = horaAtual >= horaAbre && horaAtual < horaFecha;
            }
            else
            {
                // Fecha depois da meia-noite, ex.: 18:00 às 02:00
                aberto = horaAtual >= horaAbre || horaAtual < horaFecha;
            }

            if (aberto)
                return Aberto;
            else
                return Fechado;
        }

        public static bool TemAlgumHorario(PontoTuristico ponto)
        {
            return ponto.AbreSemana != "" || ponto.AbreSabado != "" || ponto.AbreDomingo != "";
        }

        // Texto dos horários, um dia por linha (usado na tela de detalhes)
        public static string TextoHorario(PontoTuristico ponto)
        {
            if (!TemAlgumHorario(ponto))
                return "Horário não informado. Vale confirmar antes de ir.";

            string texto;
            if (ponto.FechadoSegunda)
            {
                texto = "Segunda:  fechado\n"
                      + "Terça a sexta:  " + Intervalo(ponto.AbreSemana, ponto.FechaSemana) + "\n";
            }
            else
            {
                texto = "Segunda a sexta:  " + Intervalo(ponto.AbreSemana, ponto.FechaSemana) + "\n";
            }

            texto = texto + "Sábado:  " + Intervalo(ponto.AbreSabado, ponto.FechaSabado) + "\n"
                          + "Domingo:  " + Intervalo(ponto.AbreDomingo, ponto.FechaDomingo);

            if (ponto.ObservacaoHorario != "")
                texto = texto + "\n\n" + ponto.ObservacaoHorario;

            return texto;
        }

        private static string Intervalo(string abre, string fecha)
        {
            if (abre == "" || fecha == "")
                return "fechado";

            return abre + " às " + fecha;
        }
    }
}
