using Microsoft.VisualStudio.TestTools.UnitTesting;
using E_Agenda1._5._0.Controlador;
using E_Agenda1._5._0.Dominio;
using System;

namespace TestesEAgenda
{
    [TestClass]
    public class TestesUnitariosEAgendaCompromissos
    {
        ControladorContatos controladorContatos = new ControladorContatos();
        Contato contato1 = new Contato("Teste", 111111111, "teste@mail.com", "EmpresaTeste", "Cargo Teste");
        Contato contato2 = new Contato("Teste2", 222222222, "teste2@mail.com", "EmpresaTeste 2", "Cargo Teste 2");
        Contato contatoAux = new Contato();

        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        Compromisso compromisso2 = new Compromisso("AssuntoTeste2", "LocalTeste2", Convert.ToDateTime("14/03/2021 13:00"), Convert.ToDateTime("15/03/2021 13:00"));


        [TestMethod]
        public void InserirCompromisso()
        {
            Compromisso compromisso1 = new Compromisso("AssuntoTeste", "LocalTeste", contato2, Convert.ToDateTime("13/03/2021 13:00"), Convert.ToDateTime("13/03/2021 14:00"));
            controladorContatos.InserirRegistro(contato2);
            contato2.id = controladorContatos.ObterIdPeloNome(contato2);
            controladorCompromisso.Inserir(compromisso1);
            controladorCompromisso.Inserir(compromisso2);
        }

        [TestMethod]
        public void SelecinarTodosCompromisso()
        {
            controladorCompromisso.SelecionarTodos();
        }

        [TestMethod]
        public void EditarCompromisso()
        {
            controladorCompromisso.Inserir(compromisso2);
            Compromisso compromissoAux = compromisso2;
            compromissoAux.id = controladorCompromisso.ObterIdContatoPorAssunto(compromisso2);
            controladorCompromisso.Editar(compromissoAux);
        }

        [TestMethod]
        public void ExcluirCompromisso()
        {
            controladorCompromisso.Inserir(compromisso2);
            Compromisso compromissoAux = compromisso2;
            controladorCompromisso.Excluir(compromissoAux);

        }
    }
}