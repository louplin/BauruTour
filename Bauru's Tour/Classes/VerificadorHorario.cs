using BaurusTour.Modelos;

namespace BaurusTour.Classes
{
    // Vê se o lugar está aberto agora, comparando o horário do JSON com a hora do computador
    public static class VerificadorHorario
    {
        public const string Aberto = "Aberto agora";
        public const string Fechado = "Fechado agora";
        public const string NaoInformado = "Horário não informado";

        public static string Situacao(PontoTuristico ponto, DateTime agora)
        {
            if (!TemAlgumHorario(ponto))
                return NaoInformado;

            if (agora.DayOfWeek == DayOfWeek.Monday && ponto.FechadoSegunda)
                return Fechado;

            // pega o horário do dia de hoje
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

            // não abre hoje
            if (abre == "" || fecha == "")
                return Fechado;

            // TryParse transforma o texto "08:00" em hora. Se o texto estiver errado ele devolve false.
            TimeSpan horaAbre;
            TimeSpan horaFecha;
            if (!TimeSpan.TryParse(abre, out horaAbre) || !TimeSpan.TryParse(fecha, out horaFecha))
                return NaoInformado;

            TimeSpan horaAtual = agora.TimeOfDay;
            bool aberto;

            if (horaAbre == horaFecha)
            {
                // abre e fecha no mesmo horário (ex: 00:00 às 00:00) = funciona 24 horas
                aberto = true;
            }
            else if (horaFecha > horaAbre)
            {
                // ex: 08:00 às 17:00
                aberto = horaAtual >= horaAbre && horaAtual < horaFecha;
            }
            else
            {
                // fecha depois da meia-noite, ex: 18:00 às 02:00
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

        // texto dos horários que aparece na tela de detalhes, um dia por linha
        public static string TextoHorario(PontoTuristico ponto)
        {
            if (!TemAlgumHorario(ponto))
            {
                // lugares sem horário fixo (ex: estádio, teatro) mostram só a explicação
                if (ponto.ObservacaoHorario != "")
                    return ponto.ObservacaoHorario;

                return "Horário não informado. Vale confirmar antes de ir.";
            }

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

            if (abre == fecha)
                return "24 horas";

            return abre + " às " + fecha;
        }
    }
}
