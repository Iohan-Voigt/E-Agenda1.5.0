using System;

namespace E_Agenda1._5._0.Dominio
{
    public class Tarefa
    {
        public Tarefa(string titulo, DateTime dataAbertura, DateTime dataConclusao, int prioridade, int percentualConclusao)
        {
            this.titulo = titulo;
            this.dataAbertura = dataAbertura;
            this.dataConclusao = dataConclusao;
            this.prioridade = prioridade;
            this.percentualConclusao = percentualConclusao;
        }

        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime dataAbertura { get; set; }
        public DateTime dataConclusao { get; set; }
        public int prioridade { get; set; }
        public int percentualConclusao { get; set; }

        public Tarefa() { }


        public bool Validar(Tarefa tarefa)
        {
            int validador = 0;

            if (titulo.Length < 3)
                validador++;
            if (prioridade < 0)
                validador++;
            if (prioridade > 100)
                validador++;
            if (prioridade != 1 || prioridade != 2 || prioridade != 3)
                validador++;
            if (validador != 0)
                return true;
            else
                return false;
        }
    }
}
