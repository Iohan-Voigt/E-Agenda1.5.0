using System;
using System.Collections.Generic;
using E_Agenda1._5._0.Dominio;
using E_Agenda1._5._0.Controlador;

namespace E_Agenda1._5._0.Tela
{
    public class TelaContatos : TelaBase<Contato>
    {
        private int opcao;
        public ControladorContatos controladorContatos;
        static string titulo = "Contatos";
        public TelaContatos(ControladorContatos ctrCt) : base(titulo)
        {
            controladorContatos = ctrCt;
        }

        public void inicializarAcao()
        {
            Console.Clear();
            Console.WriteLine("1 -> Inserir novo contato");
            Console.WriteLine("2 -> Editar um contato");
            Console.WriteLine("3 -> Excluir um contato");
            Console.WriteLine("4 -> Listar todos os contatos");
            Console.WriteLine("5 -> Sair");
            opcao = Convert.ToInt32(Console.ReadLine());
            ExecutarAcaoSelecionada(opcao);

        }

        private void ExecutarAcaoSelecionada(int opcao)
        {
            switch (opcao)
            {
                case 5:
                    break;
                case 1:
                    InserirContato();
                    break;
                case 2:
                    EditarContato();
                    break;
                case 3:
                    ExcluirContato();
                    break;
                case 4:
                    ListarTodosContatos();
                    break;
            }
        }
        private void InserirContato()
        {
            controladorContatos.InserirRegistro(ObterNovoContato());
            Console.Clear();
            Console.WriteLine("Contato inserido com sucesso!");
            Console.ReadKey();
        }
        private void EditarContato()
        {
            ListarTodosContatos();
            Console.Clear();
            Console.WriteLine("Infore o id que deseja editar");
            int id = Convert.ToInt32(Console.ReadLine());
            Contato contato = ObterNovoContato();
            contato.id = id;
            controladorContatos.EditarRegistro(contato);

        }
        private void ExcluirContato()
        {
            ListarTodosContatos();
            Console.Clear();
            Console.WriteLine("infore o id que deseja excluir");
            Contato contato = new Contato();
            contato.id = Convert.ToInt32(Console.ReadLine());
            controladorContatos.ExcluiRegistro(contato);
            Console.WriteLine("Excluido com sucesso!");
            Console.ReadLine();
        }
        public void ListarTodosContatos()
        {
            List<Contato> contatos;
            Console.Clear();
            Console.WriteLine("Contatos");
            contatos = controladorContatos.SelecionarTodosRegistros();
            if (contatos.Count == 0)
                Console.WriteLine("Não exitem contatos registrados");
            foreach (var v in contatos)
            {
                Console.WriteLine("ID: " + v.id + " Nome: " + v.nome + " Telefone: " + Convert.ToString(v.telefone) + " Cargo: " + v.cargo + " Empresa: " + v.empresa + " E-mail: " + v.email);
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
        public Contato ObterNovoContato()
        {
            Contato contatoNovo = new Contato();
            bool valido = true;
            while (valido)
            {
                Console.Clear();
                contatoNovo = new Contato();
                Console.WriteLine("Informe o nome:");
                contatoNovo.nome = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Informe o telefone");
                contatoNovo.telefone = Convert.ToInt64(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Informe o email");
                contatoNovo.email = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Informe a empresa");
                contatoNovo.empresa = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Informe o cargo");
                contatoNovo.cargo = Console.ReadLine();

                if (contatoNovo.Validar(contatoNovo))
                    valido = false;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Uma ou mais informações estão incorreta(s)");
                    Console.WriteLine("Tente novamente...");
                    Console.ReadLine();
                }
            }

            return contatoNovo;
        }

    }
}
