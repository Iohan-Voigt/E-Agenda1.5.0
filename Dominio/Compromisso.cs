using System;

namespace E_Agenda1._5._0.Dominio
{
    public class Compromisso
    {
        public Compromisso(string assunto, string local, Contato contato, DateTime dataInicio, DateTime dataFinal)
        {
            this.assunto = assunto;
            this.local = local;
            this.contato = contato;
            this.dataInicio = dataInicio;
            this.dataFinal = dataFinal;
        }
        public Compromisso(string assunto, string local, DateTime dataInicio, DateTime dataFinal)
        {
            this.assunto = assunto;
            this.local = local;
            this.dataInicio = dataInicio;
            this.dataFinal = dataFinal;
        }

        public Compromisso() { }
        
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
