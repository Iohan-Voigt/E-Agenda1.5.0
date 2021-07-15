using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SQLite;

namespace E_Agenda1._5._0.Controlador
{
    public abstract class ControladorBase<T>
    {
        public static string enderecoBancoAgenda = ObterEnderecoBanco().ToString();
        public static SqlConnection conexaoComBancoAgendaSql = new SqlConnection(enderecoBancoAgenda);
        public static SQLiteConnection conexaoComBancoAgendaSqlite = new SQLiteConnection(enderecoBancoAgenda);

        public bool InserirRegistro(T registro)
        {
            bool conseguiuInserir = false;
            AbrirBanco();
            ObterComandoInserir(registro);
            FecharBanco();
            return conseguiuInserir;
        }

        public bool ExcluiRegistro(int id)
        {
            bool conseguiuExcluir = false;
            conseguiuExcluir = true;
            AbrirBanco();
            ObterComandoExcluir(id);
            FecharBanco();
            return conseguiuExcluir;
        }

        public bool EditarRegistro(T registro)
        {
            bool conseguiuEditar = false;
            conseguiuEditar = true;
            AbrirBanco();
            ObterComandoEditar(registro);
            FecharBanco();
            return conseguiuEditar;
        }

        public List<T> SelecionarTodosRegistros()
        {
            List<T> registros = new List<T>();
            AbrirBanco();
            registros = ObterComandoSelecionarTodos();
            FecharBanco();
            return registros;
        }

        public abstract List<T> ObterComandoSelecionarTodos();

        public abstract void ObterComandoInserir(T registro);

        public abstract void ObterComandoEditar(T registro);

        public abstract void ObterComandoExcluir(int id);

        public string RetirarEspacos(string registroEntrada)
        {
            string registroSaida = "";
            char[] chArr = registroEntrada.ToCharArray();
            int i = 0;
            while (true)
            {
                if (chArr[i] == ' ' && chArr[i + 1] == ' ')
                {
                    for (int j = 0; j < i; j++)
                    {
                        registroSaida += chArr[j];
                    }
                    break;
                }
                i++;
            }

            return registroSaida;
        }

        static string ObterEnderecoBanco()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
        public void AbrirBanco()
        {
            if (ObterTipoBanco().Equals("SQL"))
                conexaoComBancoAgendaSql.Open();
            else
                conexaoComBancoAgendaSqlite.Open();
        }
        public void FecharBanco()
        {
            if (ObterTipoBanco().Equals("SQL"))
                conexaoComBancoAgendaSql.Close();
            else
                conexaoComBancoAgendaSqlite.Close();
        }

        public SqlConnection ObterConexaoSql()
        {
            return conexaoComBancoAgendaSql;
        }

        public SQLiteConnection ObterConexaoSqlite()
        {
            return conexaoComBancoAgendaSqlite;
        }

        private string ObterTipoBanco()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ProviderName;
        }

    }
}
