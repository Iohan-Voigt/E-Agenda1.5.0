using System;

namespace E_Agenda1._5._0.Dominio
{
    public class Compromisso
    {
        public int id { get; set; }
        public string assunto { get; set; }
        public string local { get; set; }
        public Contato contato { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFinal { get; set; }


        public bool Validar()
        {
            return true;
        }
    }
}
