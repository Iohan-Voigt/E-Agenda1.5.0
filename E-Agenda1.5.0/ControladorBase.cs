using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SQLite;

namespace E_Agenda1._5._0.Controlador
{
    public abstract class ControladorBase<T>
    {
        public bool InserirRegistro(T registro)
        {
            bool conseguiuInserir = false;
            Inserir(registro);
            return conseguiuInserir;
        }

        public bool ExcluiRegistro(T registro)
        {
            bool conseguiuExcluir = false;
            Excluir(registro);
            return conseguiuExcluir;
        }

        public bool EditarRegistro(T registro)
        {
            bool conseguiuEditar = false;
            Editar(registro);
            return conseguiuEditar;
        }

        public List<T> SelecionarTodosRegistros()
        {
            List<T> registros = new List<T>();
            registros = SelecionarTodos();
            return registros;
        }

        public abstract List<T> SelecionarTodos();

        public abstract void Inserir(T registro);

        public abstract void Editar(T registro);

        public abstract void Excluir(T registro);

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
        protected Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }

    }
}
