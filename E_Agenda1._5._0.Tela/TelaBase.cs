using System;

namespace E_Agenda1._5._0.Tela
{
    public class TelaBase<T>
    {
        private string titulo;

        public string Titulo { get { return titulo; } }

        public TelaBase(string titulo) { this.titulo = titulo; }
        protected void MontarCabecalhoTabela(string configuracaoColunasTabela, params object[] colunas)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(configuracaoColunasTabela, colunas);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }
        protected void ConfigurarTela(string subtitulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();

            Console.WriteLine(subtitulo);

            Console.WriteLine();
        }
    }
}

