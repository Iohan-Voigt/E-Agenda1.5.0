using System;
using System.Collections.Generic;
using E_Agenda1._5._0.Dominio;
using E_Agenda1._5._0.Controlador;


namespace E_Agenda1._5._0.Tela
{
    public class TelaCompromisso : TelaBase<Compromisso>
    {
        private int opcao;
        ControladorCompromisso controladorCompromisso;
        TelaContatos telaContatos;
        static string titulo = "Compromissos";

        public TelaCompromisso(ControladorCompromisso ctrCp, TelaContatos tlCt) : base(titulo)
        {
            controladorCompromisso = ctrCp;
            telaContatos = tlCt;
        }

        public void inicializarAcao()
        {
            Console.Clear();
            Console.WriteLine("1 -> Inserir novo compromisso");
            Console.WriteLine("2 -> Editar um compromisso");
            Console.WriteLine("3 -> Excluir um compromisso");
            Console.WriteLine("4 -> Listar todos os compromissos");
            Console.WriteLine("5 -> Listar todos os futuros compromissos");
            Console.WriteLine("6 -> Listar todos os compromissos passados");
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
                    InserirCompromisso();
                    break;
                case 2:
                    EditarCompromisso();
                    break;
                case 3:
                    ExcluirCompromisso();
                    break;
                case 4:
                    ListarTodosCompromissos();
                    break;
                case 5:
                    ListarTodosCompromissosFuturos();
                    break;
                case 6:
                    ListarTodosCompromissosPassados();
                    break;
            }
        }

        private void ListarTodosCompromissosPassados()
        {
            List<Compromisso> compromissos;
            Console.Clear();
            Console.WriteLine("Compromissos");
            compromissos = controladorCompromisso.SelecionarTodosRegistrosPassados();
            if (compromissos.Count == 0)
                Console.WriteLine("Não exitem contatos registrados");
            foreach (var v in compromissos)
            {
                string nomeContato;
                if (v.contato == null)
                    nomeContato = "Nenhum";
                else
                    nomeContato = v.contato.nome;

                Console.WriteLine("ID: " + v.id + " | Assunto: " + v.assunto + " | Local: " + v.local + " | Contato: " + nomeContato +
                    " | Data e hora de início: " + v.dataInicio.ToString() + " | Data e hora do término: " + v.dataFinal.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }

        private void ListarTodosCompromissosFuturos()
        {
            List<Compromisso> compromissos;
            Console.Clear();
            Console.WriteLine("Compromissos");
            compromissos = controladorCompromisso.selecionarTodosRegistrosFuturo();
            if (compromissos.Count == 0)
                Console.WriteLine("Não exitem contatos registrados");
            foreach (var v in compromissos)
            {
                string nomeContato;
                if (v.contato == null)
                    nomeContato = "Nenhum";
                else
                    nomeContato = v.contato.nome;

                Console.WriteLine("ID: " + v.id + " | Assunto: " + v.assunto + " | Local: " + v.local + " | Contato: " + nomeContato +
                    " | Data e hora de início: " + v.dataInicio.ToString() + " | Data e hora do término: " + v.dataFinal.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }

        private void EditarCompromisso()
        {
            ListarTodosCompromissos();
            Console.Clear();
            Console.WriteLine("Infore o id que deseja editar");
            int id = Convert.ToInt32(Console.ReadLine());
            Compromisso compromisso = ObterNovoCompromisso();
            compromisso.id = id;
            controladorCompromisso.EditarRegistro(compromisso);
        }

        private void ExcluirCompromisso()
        {
            ListarTodosCompromissos();
            Console.Clear();
            Console.WriteLine("infore o id que deseja excluir");
            controladorCompromisso.ExcluiRegistro(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Excluidocom sucesso!");
            Console.ReadLine();
        }

        private void ListarTodosCompromissos()
        {
            List<Compromisso> compromissos;
            Console.Clear();
            Console.WriteLine("Compromissos");
            compromissos = controladorCompromisso.SelecionarTodosRegistros();
            if (compromissos.Count == 0)
                Console.WriteLine("Não exitem contatos registrados");
            foreach (var v in compromissos)
            {
                string nomeContato;
                if (v.contato == null)
                    nomeContato = "Nenhum";
                else
                    nomeContato = v.contato.nome;

                Console.WriteLine("ID: " + v.id + " | Assunto: " + v.assunto + " | Local: " + v.local + " | Contato: " + nomeContato +
                    " | Data e hora de início: " + v.dataInicio.ToString() + " | Data e hora do término: " + v.dataFinal.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }

        private void InserirCompromisso()
        {
            Console.Clear();
            controladorCompromisso.InserirRegistro(ObterNovoCompromisso());
            Console.WriteLine("Compromisso inserido com sucesso!");
            Console.ReadKey();
        }

        private Compromisso ObterNovoCompromisso()
        {
            Compromisso compromisso = new Compromisso();
            Contato contato = new Contato();
            bool valido = true;
            while (valido)
            {
                Console.Clear();
                Console.WriteLine("Informe o assunto do compromisso");
                compromisso.assunto = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Informe o local do compromisso");
                compromisso.local = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Deseja adicionar um contato? (S/N)");
                if ((Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase).Equals("s"))
                {


                    Console.Clear();
                    Console.WriteLine("1 -> Contato existente");
                    Console.WriteLine("2 -> Contato novo");

                    if (Console.ReadLine() == "1")
                    {
                        telaContatos.ListarTodosContatos();
                        Console.Clear();
                        Console.WriteLine("Informe o id do contato");
                        contato = telaContatos.controladorContatos.ObterContatoPeloId
                            (Convert.ToInt32(Console.ReadLine()));

                    }
                    else
                    {
                        contato = telaContatos.ObterNovoContato();

                    }
                }

                Console.Clear();
                Console.WriteLine("Informe a data e horário de início : (xx/xx/xxxx hh:mm)");
                compromisso.dataInicio = Convert.ToDateTime(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Informe a data e horário de t[ermino : (xx/xx/xxxx hh:mm)");
                compromisso.dataFinal = Convert.ToDateTime(Console.ReadLine());

                if (compromisso.Validar())
                    break;
            }

            return compromisso;
        }
    }
}

