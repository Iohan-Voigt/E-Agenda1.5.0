using Microsoft.VisualStudio.TestTools.UnitTesting;
using E_Agenda1._5._0.Controlador;
using E_Agenda1._5._0.Dominio;
using System;

namespace TestesEAgenda
{
    [TestClass]
    public class TestesUnitariosEAgendaContatos
    {
        ControladorContatos controladorContatos = new ControladorContatos();
        Contato contato1 = new Contato("Teste", 111111111,"teste@mail.com","EmpresaTeste","Cargo Teste");
        Contato contato2 = new Contato("Teste2", 222222222,"teste2@mail.com","EmpresaTeste 2","Cargo Teste 2");
        Contato contatoAux = new Contato();

        [TestMethod]
        public void InserirContato()
        {
            controladorContatos.Inserir(contato1);
        }

        [TestMethod]
        public void SelecinarTodosContato()
        {
            controladorContatos.SelecionarTodos();
        }

        [TestMethod]
        public void EditarContato()
        {
            controladorContatos.Inserir(contato1);
            contatoAux = contato2;
            contatoAux.id = controladorContatos.ObterIdPeloNome(contato1);
            controladorContatos.Editar(contatoAux);
        }

        [TestMethod]
        public void ExcluirContato()
        {
            controladorContatos.Inserir(contato1);
            contatoAux = contato2;
            contatoAux.id = controladorContatos.ObterIdPeloNome(contato1);
            controladorContatos.Excluir(contatoAux);
        }
    }
}
