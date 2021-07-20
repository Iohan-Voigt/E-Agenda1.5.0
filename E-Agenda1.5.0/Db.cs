﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.Common;

namespace E_Agenda1._5._0
{
    public delegate T ConverterDelegate<T>(IDataReader reader);
    
    public static class Db
    {
        private static readonly string bancoDeDados;
        private static readonly string connectionString = "";
        private static readonly string nomeProvider;
        private static readonly DbProviderFactory fabricaProvedor;

        static Db()
        {
            bancoDeDados = ConfigurationManager.AppSettings["bancoDeDados"];
            connectionString = ConfigurationManager.ConnectionStrings[bancoDeDados].ConnectionString;
            nomeProvider = ConfigurationManager.ConnectionStrings[bancoDeDados].ProviderName;
            fabricaProvedor = DbProviderFactories.GetFactory(nomeProvider);
        }

        public static void Inserir(string comando, Dictionary<string, object> parametros) 
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = comando.ObterIdentity();
                    command.Connection = connection;
                    command.SetarParametros(parametros);
                    connection.Open();
                    command.ExecuteScalar();
                }
            }
        }

        public static void Atualizar(string comando, Dictionary<string, object> parametros)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = comando;
                    command.Connection = connection;
                    command.SetarParametros(parametros);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Deletar(string comando, Dictionary<string, object> parametros)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = comando;
                    command.Connection = connection;
                    command.SetarParametros(parametros);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<T> SelecionarTodos<T>(string comando, ConverterDelegate<T> converte, Dictionary<string, object> parametros = null)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = comando;
                    command.Connection = connection;
                    command.SetarParametros(parametros);
                    connection.Open();

                    var list = new List<T>();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var obj = converte(reader);
                            list.Add(obj);
                        }

                        return list;
                    }
                }
            }
        }

        public static T Selecionar<T>(string comando, ConverterDelegate<T> converte, Dictionary<string,object> parametros)
        {
            using (IDbConnection connection = fabricaProvedor.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                using (IDbCommand command = fabricaProvedor.CreateCommand())
                {
                    command.CommandText = comando;
                    command.Connection = connection;
                    command.SetarParametros(parametros);
                    connection.Open();

                    T t = default;

                    using (IDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                            t = converte(reader);

                        return t;
                    }
                }
            }
        }

        private static string ObterIdentity(this string comando)
        {
            switch (nomeProvider)
            {
                case "System.Data.SqlClient": return comando + "SELECT SCOPE_IDENTITY();";

                case "System.Data.SQLite": return comando + "SELECT LAST_INSERT_ROWID();";

                default: return comando;
            }            
        }

        private static void SetarParametros(this IDbCommand command, Dictionary<string,object> parametros)
        {
            if (parametros == null || parametros.Count == 0)
                return;

            foreach (var parameter in parametros)
            {
                string name = parameter.Key;

                object value = parameter.ValueIsNullOrEmpty() ? DBNull.Value : parameter.Value;

                IDataParameter dbParameter = command.CreateParameter();

                dbParameter.ParameterName = name;
                dbParameter.Value = value;

                command.Parameters.Add(dbParameter);
            }
        }

        private static bool ValueIsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) || value == null;
        }
    }
}
