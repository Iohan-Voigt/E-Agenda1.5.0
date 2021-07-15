using System;
using System.Collections.Generic;
using E_Agenda1._5._0.Controlador;
using E_Agenda1._5._0.Dominio;

namespace E_Agenda1._5._0.Tela
{
    //Refac p2
    public class TelaTarefas : TelaBase<Tarefa>
    {
        private int opcao;
        ControladorTarefa controladorTarefas;
        static string titulo = "Tarefas";
        public TelaTarefas(ControladorTarefa ctrTf) : base(titulo)
        {
            controladorTarefas = ctrTf;
        }

        public void inicializarAcao()
        {
            Console.Clear();
            Console.WriteLine("1 -> Inserir nova tarefa");
            Console.WriteLine("2 -> Editar uma tarefa");
            Console.WriteLine("3 -> Excluir uma tarefa");
            Console.WriteLine("4 -> Listar todas as tarefas");
            Console.WriteLine("5 -> Listar tarefas abertas");
            Console.WriteLine("6 -> Listar tarefas finalizadas");
            Console.WriteLine("7 -> Atualizar a procentagem de uma tarefa");
            Console.WriteLine("8 -> Concluir uma tarefa");
            Console.WriteLine("0 -> Sair");
            opcao = Convert.ToInt32(Console.ReadLine());
            ExecutarAcaoSelecionada(opcao);

        }
        private void ExecutarAcaoSelecionada(int opcao)
        {
            switch (opcao)
            {
                case 0:
                    break;
                case 1:
                    InserirTarefa();
                    break;
                case 2:
                    EditarTarefa();
                    break;
                case 3:
                    ExcluirTarefa();
                    break;
                case 4:
                    ListarTodasTarefas();
                    break;
                case 5:
                    ListarTarefasAbertas();
                    break;
                case 6:
                    ListarTarefasFinalizadas();
                    break;
                case 7:
                    AtualizarPorcentagemDeUmaTarefa();
                    break;
                case 8:
                    ConcluirUmaTarefa();
                    break;
            }
        }
        private void ListarTarefasFinalizadas()
        {
            string Conclusao;
            Console.Clear();
            List<Tarefa> tarefasPrioridadeBaixa = new List<Tarefa>();
            List<Tarefa> tarefasPrioridadeMedia = new List<Tarefa>();
            List<Tarefa> tarefasPrioridadeAlta = new List<Tarefa>();
            List<Tarefa> tarefas = controladorTarefas.ObterComandoSelecionarAbertos();
            if (tarefas.Count == 0)
                Console.WriteLine("Não existem tarefas registradas");
            foreach (Tarefa tarefa in tarefas)
            {
                if (tarefa.prioridade == 1)
                    tarefasPrioridadeAlta.Add(tarefa);
                else if (tarefa.prioridade == 2)
                    tarefasPrioridadeMedia.Add(tarefa);
                else
                    tarefasPrioridadeBaixa.Add(tarefa);
            }
            Console.WriteLine("");
            foreach (Tarefa tarefa in tarefasPrioridadeAlta)
            {
                Conclusao = tarefa.percentualConclusao != 100 ? "Não concluido" : Convert.ToString(tarefa.dataConclusao);

                Console.WriteLine("ID: " + Convert.ToString(tarefa.id) + "| Titulo: " + tarefa.titulo + "| Prioridade: " +
                    ConvertePrioridade(tarefa.prioridade) + "| Data de Abertura: " + Convert.ToString(tarefa.dataAbertura) +
                    "| Data Conclusão: " + Conclusao + "| Percentual de conclusão: " +
                    Convert.ToString(tarefa.percentualConclusao) + "%");
            }
            Console.WriteLine("");
            foreach (Tarefa tarefa in tarefasPrioridadeMedia)
            {
                Conclusao = tarefa.percentualConclusao != 100 ? "Não concluido" : Convert.ToString(tarefa.dataConclusao);

                Console.WriteLine("ID: " + Convert.ToString(tarefa.id) + "| Titulo: " + tarefa.titulo + "| Prioridade: " +
                    ConvertePrioridade(tarefa.prioridade) + "| Data de Abertura: " + Convert.ToString(tarefa.dataAbertura) +
                    "| Data Conclusão: " + Conclusao + "| Percentual de conclusão: " +
                    Convert.ToString(tarefa.percentualConclusao) + "%");
            }
            Console.WriteLine("");
            foreach (Tarefa tarefa in tarefasPrioridadeBaixa)
            {
                Conclusao = tarefa.percentualConclusao != 100 ? "Não concluido" : Convert.ToString(tarefa.dataConclusao);

                Console.WriteLine("ID: " + Convert.ToString(tarefa.id) + "| Titulo: " + tarefa.titulo + "| Prioridade: " +
                    ConvertePrioridade(tarefa.prioridade) + "| Data de Abertura: " + Convert.ToString(tarefa.dataAbertura) +
                    "| Data Conclusão: " + Conclusao + "| Percentual de conclusão: " +
                    Convert.ToString(tarefa.percentualConclusao) + "%");
            }
            Console.ReadKey();
        }
        private void ListarTarefasAbertas()
        {
            string Conclusao;
            Console.Clear();
            List<Tarefa> tarefasPrioridadeBaixa = new List<Tarefa>();
            List<Tarefa> tarefasPrioridadeMedia = new List<Tarefa>();
            List<Tarefa> tarefasPrioridadeAlta = new List<Tarefa>();
            List<Tarefa> tarefas = controladorTarefas.ObterComandoSelecionarAbertos();
            if (tarefas.Count == 0)
                Console.WriteLine("Não existem tarefas registradas");
            foreach (Tarefa tarefa in tarefas)
            {
                if (tarefa.prioridade == 1)
                    tarefasPrioridadeAlta.Add(tarefa);
                else if (tarefa.prioridade == 2)
                    tarefasPrioridadeMedia.Add(tarefa);
                else
                    tarefasPrioridadeBaixa.Add(tarefa);
            }
            Console.WriteLine("");
            foreach (Tarefa tarefa in tarefasPrioridadeAlta)
            {
                Conclusao = tarefa.percentualConclusao != 100 ? "Não concluido" : Convert.ToString(tarefa.dataConclusao);

                Console.WriteLine("ID: " + Convert.ToString(tarefa.id) + "| Titulo: " + tarefa.titulo + "| Prioridade: " +
                    ConvertePrioridade(tarefa.prioridade) + "| Data de Abertura: " + Convert.ToString(tarefa.dataAbertura) +
                    "| Data Conclusão: " + Conclusao + "| Percentual de conclusão: " +
                    Convert.ToString(tarefa.percentualConclusao) + "%");
            }
            Console.WriteLine("");
            foreach (Tarefa tarefa in tarefasPrioridadeMedia)
            {
                Conclusao = tarefa.percentualConclusao != 100 ? "Não concluido" : Convert.ToString(tarefa.dataConclusao);

                Console.WriteLine("ID: " + Convert.ToString(tarefa.id) + "| Titulo: " + tarefa.titulo + "| Prioridade: " +
                    ConvertePrioridade(tarefa.prioridade) + "| Data de Abertura: " + Convert.ToString(tarefa.dataAbertura) +
                    "| Data Conclusão: " + Conclusao + "| Percentual de conclusão: " +
                    Convert.ToString(tarefa.percentualConclusao) + "%");
            }
            Console.WriteLine("");
            foreach (Tarefa tarefa in tarefasPrioridadeBaixa)
            {
                Conclusao = tarefa.percentualConclusao != 100 ? "Não concluido" : Convert.ToString(tarefa.dataConclusao);

                Console.WriteLine("ID: " + Convert.ToString(tarefa.id) + "| Titulo: " + tarefa.titulo + "| Prioridade: " +
                    ConvertePrioridade(tarefa.prioridade) + "| Data de Abertura: " + Convert.ToString(tarefa.dataAbertura) +
                    "| Data Conclusão: " + Conclusao + "| Percentual de conclusão: " +
                    Convert.ToString(tarefa.percentualConclusao) + "%");
            }
            Console.ReadKey();
        }
        private void AtualizarPorcentagemDeUmaTarefa()
        {
            ListarTodasTarefas();
            Console.Clear();
            Console.WriteLine("Informe o id da tarefa");
            int id = Convert.ToInt32(Console.ReadLine());
            int porcentagem;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Informe a porcentagem");
                porcentagem = Convert.ToInt32(Console.ReadLine());
                if (porcentagem <= 100 && porcentagem >= 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Numero inválido");
                }
            }
            Console.Clear();
            controladorTarefas.EditarPorcentagem(id, porcentagem);
            Console.WriteLine("Porcentagem atualizada com sucesso!");

        }
        private void ConcluirUmaTarefa()
        {
            Console.Clear();
            ListarTodasTarefas();
            Console.Clear();
            Console.WriteLine("Informe o id da tarefa a ser concluida");
            controladorTarefas.ConcluirTarefa(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("Tarefa concluida!");
        }
        private void EditarTarefa()
        {
            Console.Clear();
            ListarTodasTarefas();
            Console.WriteLine("Informe o id a ser editado");
            Tarefa tarefa = ObterNovaTarefa();
            tarefa.id = Convert.ToInt32(Console.ReadLine());
            controladorTarefas.EditarRegistro(tarefa);
            Console.Clear();
            Console.WriteLine("Tarefa editada com sucesso!");
        }
        private void ExcluirTarefa()
        {
            Console.Clear();
            ListarTodasTarefas();
            Console.WriteLine("Informe o id a ser excluido");
            controladorTarefas.ExcluiRegistro(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("Excluido com sucesso!");
            Console.ReadKey();
        }
        private void ListarTodasTarefas()
        {
            string Conclusao;
            Console.Clear();
            List<Tarefa> tarefasPrioridadeBaixa = new List<Tarefa>();
            List<Tarefa> tarefasPrioridadeMedia = new List<Tarefa>();
            List<Tarefa> tarefasPrioridadeAlta = new List<Tarefa>();
            List<Tarefa> tarefas = controladorTarefas.SelecionarTodosRegistros();
            if (tarefas.Count == 0)
                Console.WriteLine("Não existem tarefas registradas");
            foreach (Tarefa tarefa in tarefas)
            {
                if (tarefa.prioridade == 1)
                    tarefasPrioridadeAlta.Add(tarefa);
                else if (tarefa.prioridade == 2)
                    tarefasPrioridadeMedia.Add(tarefa);
                else
                    tarefasPrioridadeBaixa.Add(tarefa);
            }
            Console.WriteLine("");
            foreach (Tarefa tarefa in tarefasPrioridadeAlta)
            {
                Conclusao = tarefa.percentualConclusao != 100 ? "Não concluido" : Convert.ToString(tarefa.dataConclusao);

                Console.WriteLine("ID: " + Convert.ToString(tarefa.id) + "| Titulo: " + tarefa.titulo + "| Prioridade: " +
                    ConvertePrioridade(tarefa.prioridade) + "| Data de Abertura: " + Convert.ToString(tarefa.dataAbertura) +
                    "| Data Conclusão: " + Conclusao + "| Percentual de conclusão: " +
                    Convert.ToString(tarefa.percentualConclusao) + "%");
            }
            Console.WriteLine("");
            foreach (Tarefa tarefa in tarefasPrioridadeMedia)
            {
                Conclusao = tarefa.percentualConclusao != 100 ? "Não concluido" : Convert.ToString(tarefa.dataConclusao);

                Console.WriteLine("ID: " + Convert.ToString(tarefa.id) + "| Titulo: " + tarefa.titulo + "| Prioridade: " +
                    ConvertePrioridade(tarefa.prioridade) + "| Data de Abertura: " + Convert.ToString(tarefa.dataAbertura) +
                    "| Data Conclusão: " + Conclusao + "| Percentual de conclusão: " +
                    Convert.ToString(tarefa.percentualConclusao) + "%");
            }
            Console.WriteLine("");
            foreach (Tarefa tarefa in tarefasPrioridadeBaixa)
            {
                Conclusao = tarefa.percentualConclusao != 100 ? "Não concluido" : Convert.ToString(tarefa.dataConclusao);

                Console.WriteLine("ID: " + Convert.ToString(tarefa.id) + "| Titulo: " + tarefa.titulo + "| Prioridade: " +
                    ConvertePrioridade(tarefa.prioridade) + "| Data de Abertura: " + Convert.ToString(tarefa.dataAbertura) +
                    "| Data Conclusão: " + Conclusao + "| Percentual de conclusão: " +
                    Convert.ToString(tarefa.percentualConclusao) + "%");
            }
            Console.ReadKey();
        }
        private void InserirTarefa()
        {
            controladorTarefas.InserirRegistro(ObterNovaTarefa());
            Console.Clear();
            Console.WriteLine("Tarefa Inserida com sucesso!");
            Console.ReadKey();
        }
        private Tarefa ObterNovaTarefa()
        {
            Tarefa tarefa = new Tarefa();
            bool valido = true;
            while (valido)
            {
                Console.Clear();
                Console.WriteLine("Informe o título da tarefa");
                tarefa.titulo = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Informe a prioridade da tarefa(1 para alto, 2 para médio e 3 para baixa)");
                tarefa.prioridade = Convert.ToInt32(Console.ReadLine());

                tarefa.dataAbertura = DateTime.Today;
                tarefa.percentualConclusao = 0;
                if (tarefa.Validar(tarefa))
                    valido = false;
            }
            return tarefa;
        }
        private string ConvertePrioridade(int prioridade)
        {
            switch (prioridade)
            {
                case 1:
                    return "Alta";
                    break;
                case 2:
                    return "Média";
                    break;
                case 3:
                    return "Baixa";
                    break;
            }
            return "Nenhuma";
        }
    }
}
