using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Collections.Generic;
using E_Agenda1._5._0.Dominio;
using System.Configuration;

namespace E_Agenda1._5._0.Controlador
{
    public class ControladorContatos : ControladorBase<Contato>
    {

        public override void ObterComandoEditar(Contato registro)
        {
            string EditarCommand = "";
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                EditarCommand =
                @"UPDATE TbContatos
                    SET
                    [NOME] = @NOME,
                    [email] = @email,
                    [EMPRESA] = @EMPRESA,
                    [CARGO] = @CARGO,
                    [TELEFONE] = @TELEFONE
                WHERE
                [ID] = @ID;";
                SqlCommand comandoEdicao = new SqlCommand(EditarCommand, ObterConexaoSql());

                comandoEdicao.CommandText = EditarCommand;
                comandoEdicao.Parameters.Add("NOME", registro.nome);
                comandoEdicao.Parameters.Add("email", registro.email);
                comandoEdicao.Parameters.Add("EMPRESA", registro.empresa);
                comandoEdicao.Parameters.Add("CARGO", registro.cargo);
                comandoEdicao.Parameters.Add("TELEFONE", registro.telefone);
                comandoEdicao.Parameters.Add("ID", registro.id);

                comandoEdicao.ExecuteNonQuery();
            }
            else
            {
                EditarCommand =
                @"UPDATE TbContatos
                    SET
                    (NOME) = @NOME,
                    (email) = @email,
                    (EMPRESA) = @EMPRESA,
                    (CARGO) = @CARGO,
                    (TELEFONE) = @TELEFONE
                WHERE
                (ID) = @ID";

                SQLiteCommand comandoEdicao = new SQLiteCommand(EditarCommand, ObterConexaoSqlite());
                ObterConexaoSqlite().Execute(EditarCommand, registro);
            }
        }


        public override void ObterComandoExcluir(int id)
        {
            string ExcluirCommand = "";
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                ExcluirCommand =
                @"DELETE FROM TBCONTATOS
                    WHERE
                    [id] = @id;";
                SqlCommand comandoExclusao = new SqlCommand(ExcluirCommand, ObterConexaoSql());
                comandoExclusao.CommandText = ExcluirCommand;

                comandoExclusao.Parameters.Add("ID", id);
                comandoExclusao.ExecuteNonQuery();
            }
            else
            {
                ExcluirCommand =
                @"DELETE FROM TBCONTATOS
                WHERE
                (id) = @id;";

                SQLiteCommand comandoExclusao = new SQLiteCommand(ExcluirCommand, ObterConexaoSqlite());
                ObterConexaoSqlite().Execute(ExcluirCommand, id);
            }
        }
        public override void ObterComandoInserir(Contato registro)

        {
            string InserirCommand = "";
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                InserirCommand =
                @"INSERT INTO TBCONTATOS
                (
                    [nome],
                    [email],
                    [telefone],
                    [empresa],
                    [cargo]
                )
                VALUES
                (
                    @nome,
                    @email,
                    @telefone,
                    @empresa,
                    @cargo
                );";
                InserirCommand += @"SELECT SCOPE_IDENTITY();";

                SqlCommand comandoInsercao = new SqlCommand(InserirCommand, ObterConexaoSql());

                comandoInsercao.CommandText = InserirCommand;
                comandoInsercao.Parameters.Add("nome", registro.nome);
                comandoInsercao.Parameters.Add("email", registro.email);
                comandoInsercao.Parameters.Add("telefone", registro.telefone);
                comandoInsercao.Parameters.Add("empresa", registro.empresa);
                comandoInsercao.Parameters.Add("cargo", registro.cargo);

                comandoInsercao.ExecuteNonQuery();
            }
            else
            {
                InserirCommand = @"INSERT INTO TbContatos 
                    ( Nome, email, telefone, empresa, cargo)
                    VALUES
                    (@Nome, @email, @telefone, @empresa, @cargo);";
                InserirCommand += @"SELECT LAST_INSERT_ROWID();";
                SQLiteCommand comando = new SQLiteCommand(InserirCommand, ObterConexaoSqlite());
                ObterConexaoSqlite().Execute(InserirCommand, registro);
            }
        }

        public override List<Contato> ObterComandoSelecionarTodos()
        {
            string comandoSelectComand = "";
            List<Contato> registros = new List<Contato>();
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                comandoSelectComand = "SELECT * FROM TbContatos;";

                DataTable dataTable = new DataTable(comandoSelectComand);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelectComand, ObterConexaoSql());
                sqlDataAdapter.Fill(dataTable);
                dataSet.ToString();

                foreach (DataRow row in dataTable.Rows)
                {
                    Contato ct = new Contato();
                    ct.id = Convert.ToInt32(row[0]);
                    ct.nome = RetirarEspacos(row.Field<string>("nome"));
                    ct.email = RetirarEspacos(row.Field<string>("email"));
                    ct.telefone = Convert.ToInt64(row[3]);
                    ct.empresa = RetirarEspacos(row.Field<string>("empresa"));
                    ct.cargo = RetirarEspacos(row.Field<string>("cargo"));
                    registros.Add(ct);
                }
            }
            else
            {
                comandoSelectComand = "SELECT * FROM TbTarefas;";
                SQLiteCommand ComandoSelecionartodos = new SQLiteCommand(comandoSelectComand, ObterConexaoSqlite());

                DataTable dataTable = new DataTable(comandoSelectComand);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelectComand, ObterConexaoSql());

                int nPI = sqlDataAdapter.Fill(dataTable);
                string nPI2 = dataSet.ToString();
            }
            return registros;
        }

        public Contato ObterContatoPeloId(int id)
        {
            string comandoSelectComand = "";
            Contato contato = new Contato();
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                comandoSelectComand = "SELECT * FROM TbContatos WHERE [Id] = @Id;";

                DataTable dataTable = new DataTable(comandoSelectComand);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelectComand, ObterConexaoSql());
                sqlDataAdapter.Fill(dataTable);
                dataSet.ToString();
                foreach (DataRow row in dataTable.Rows)
                {
                    Contato ct = new Contato();
                    ct.id = Convert.ToInt32(row[0]);
                    ct.nome = RetirarEspacos(row.Field<string>("nome"));
                    ct.email = RetirarEspacos(row.Field<string>("email"));
                    ct.telefone = Convert.ToInt64(row[3]);
                    ct.empresa = RetirarEspacos(row.Field<string>("empresa"));
                    ct.cargo = RetirarEspacos(row.Field<string>("cargo"));
                    contato = ct;
                }
            }
            else
            {
                comandoSelectComand = "SELECT * FROM TbContatos WHERE (Id) = @Id;";

                DataTable dataTable = new DataTable(comandoSelectComand);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelectComand, ObterConexaoSql());
                sqlDataAdapter.Fill(dataTable);
                dataSet.ToString();
                foreach (DataRow row in dataTable.Rows)
                {
                    Contato ct = new Contato();
                    ct.id = Convert.ToInt32(row[0]);
                    ct.nome = RetirarEspacos(row.Field<string>("nome"));
                    ct.email = RetirarEspacos(row.Field<string>("email"));
                    ct.telefone = Convert.ToInt64(row[3]);
                    ct.empresa = RetirarEspacos(row.Field<string>("empresa"));
                    ct.cargo = RetirarEspacos(row.Field<string>("cargo"));
                    contato = ct;
                }
            }
            return contato;
        }

    }
}
