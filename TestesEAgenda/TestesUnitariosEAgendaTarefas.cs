using Microsoft.VisualStudio.TestTools.UnitTesting;
using E_Agenda1._5._0.Controlador;
using E_Agenda1._5._0.Dominio;
using System;


namespace TestesEAgenda
{
    [TestClass]
    public class TestesUnitariosEAgendaTarefas
    {

        private Tarefa tarefaTeste  = new Tarefa("TituloTeste",Convert.ToDateTime("13/05/2022"),Convert.ToDateTime("14/05/2022"),1,5);
        private Tarefa tarefaTeste2 = new Tarefa("TituloTeste2", Convert.ToDateTime("13/05/2022"), Convert.ToDateTime("14/05/2022"), 1, 50);
        private Tarefa tarefaAux = new Tarefa();
        private ControladorTarefa controladorTarefa = new ControladorTarefa();

        [TestMethod]
        public void InserirNovaTarefa()
        {
            controladorTarefa.InserirRegistro(tarefaTeste);
        }

        [TestMethod]
        public void ExcuirTarefa()
        {
            controladorTarefa.InserirRegistro(tarefaTeste);
            tarefaTeste.id = controladorTarefa.ObterIdPorTitulo(tarefaTeste);
            controladorTarefa.Excluir(tarefaTeste);
        }

        [TestMethod]
        public void SelecionarTodos()
        {
            Assert.IsNotNull(controladorTarefa.SelecionarTodos());
        }

        [TestMethod]
        public void EditarTarefa()
        {
            controladorTarefa.InserirRegistro(tarefaTeste);
            tarefaAux = tarefaTeste2;
            tarefaAux.id = controladorTarefa.ObterIdPorTitulo(tarefaTeste);
            controladorTarefa.Editar(tarefaAux);
        }


    }
}
