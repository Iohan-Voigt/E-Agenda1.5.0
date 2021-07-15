using System;
using E_Agenda1._5._0.Controlador;
using E_Agenda1._5._0.Tela;

namespace E_Agenda1._5._0.ConsoleApp
{
    //Medida de horas trabalhadas =~ 37hrs
    //Refatorar o código;
    //Implementar sistema de exception para caso o banco não funcione;
    class Program
    {
        static void Main(string[] args)
        {

            string opcao;
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Digite:");
                Console.WriteLine("1 -> contatos");
                Console.WriteLine("2 -> tarefas");
                Console.WriteLine("3 -> compromissos");
                Console.WriteLine("S -> sair");
                opcao = Console.ReadLine();

                loop = SelecionarTela(opcao, loop);

            }

        }

        private static bool SelecionarTela(string opcao, bool loop)
        {
            ControladorContatos ctrCt = new ControladorContatos();
            TelaContatos tlCt = new TelaContatos(ctrCt);
            ControladorTarefa ctrTf = new ControladorTarefa();
            TelaTarefas tlTf = new TelaTarefas(ctrTf);
            ControladorCompromisso ctrCp = new ControladorCompromisso();
            TelaCompromisso tlCp = new TelaCompromisso(ctrCp, tlCt);

            switch (opcao)
            {
                case "s":
                    loop = false;
                    break;
                case "S":
                    loop = false;
                    break;
                case "1":
                    tlCt.inicializarAcao();
                    break;
                case "2":
                    tlTf.inicializarAcao();
                    break;
                case "3":
                    tlCp.inicializarAcao();
                    break;
            }

            return loop;
        }
    }
}
