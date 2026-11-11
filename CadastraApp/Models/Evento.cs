using System;
using System.Collections.Generic;
using System.Text;

namespace CadastraApp.Models
{
    public class Evento
    {
        public String Nome { get; set; } = String.Empty; //
        public DateTime DataInicio { get; set; } = DateTime.Today; //
        public DateTime DataTermino { get; set; } = DateTime.Today; //
        public int QtdParticipantes { get; set; } = 0;
        public String Local { get; set; } = String.Empty; //
        public decimal CustoParticipante { get; set; } = 0; //


        public TimeSpan Duracao => DataTermino - DataInicio; //
        public int DuracaoDias => Duracao.Days; //
        public decimal CustoTotal => CustoParticipante * QtdParticipantes; //


    }
}
