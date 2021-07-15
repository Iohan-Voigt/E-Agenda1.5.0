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
    public class ControladorCompromisso : ControladorBase<Compromisso>
    {
        public override void ObterComandoEditar(Compromisso registro)
        {

            string EditarCommand = "";
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                EditarCommand =
               @"UPDATE TbCompromissos
                    SET
                    [Assunto] = @Assunto,
                    [Local] = @Local,
                    [Id_Contato] = @Id_Contato,
                    [DataInicio] = @DataInicio,
                    [DataFinal] = @DataFinal
                WHERE
                [ID] = @ID";
                SqlCommand comandoEdicao = new SqlCommand(EditarCommand, ObterConexaoSql());

                comandoEdicao.CommandText = EditarCommand;
                comandoEdicao.Parameters.Add("Assunto", registro.assunto);
                comandoEdicao.Parameters.Add("Local", registro.local);
                comandoEdicao.Parameters.Add("Id_Contato", registro.contato.id);
                comandoEdicao.Parameters.Add("DataInicio", registro.dataInicio);
                comandoEdicao.Parameters.Add("DataFinal", registro.dataFinal);
                comandoEdicao.Parameters.Add("ID", registro.id);

                comandoEdicao.ExecuteNonQuery();
            }
            else
            {
                EditarCommand =
                @"UPDATE TbCompromissos
                    SET
                    [Assunto] = @Assunto,
                    [Local] = @Local,
                    [Id_Contato] = @Id_Contato,
                    [DataInicio] = @DataInicio,
                    [DataFinal] = @DataFinal
                WHERE
                [ID] = @ID";
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
                @"DELETE FROM TBCOMPROMISSOS
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
                    @"DELETE FROM TbCompromissos
                    WHERE
                    (Id) = @Id;";
                SQLiteCommand comandoExclusao = new SQLiteCommand(ExcluirCommand, ObterConexaoSqlite());
                ObterConexaoSqlite().Execute(ExcluirCommand, id);
            }

        }
        public override void ObterComandoInserir(Compromisso registro)
        {
            int possuicontato = 0;
            string InserirCommand;
            if (registro.contato == null)
            {
                InserirCommand =
                    @"INSERT INTO TbCompromissos
                (
                    [Assunto],
                    [Local],
                    [DataInicio],
                    [DataFinal]
                )
                VALUES
                (
                    @Assunto,
                    @Local,
                    @DataInicio,
                    @DataFinal
                );";
                InserirCommand += @"SELECT SCOPE_IDENTITY();";
            }
            else
            {
                possuicontato = 1;
                InserirCommand =
                       @"INSERT INTO TbCompromissos
                (
                    [Assunto],
                    [Local],
                    [Id_Contato],
                    [DataInicio],
                    [DataFinal]
                )
                VALUES
                (
                    @Assunto,
                    @Local,
                    @Id_Contato,
                    @DataInicio,
                    @DataFinal
                );";
                InserirCommand += @"SELECT LAST_INSERT_ROWID();";
            }

            SqlCommand comandoInsercao = new SqlCommand(InserirCommand, ObterConexaoSql());

            comandoInsercao.CommandText = InserirCommand;

            comandoInsercao.Parameters.Add("Assunto", registro.assunto);
            comandoInsercao.Parameters.Add("Local", registro.local);

            if (possuicontato == 1)
                comandoInsercao.Parameters.Add("Id_Contato", registro.contato.id);

            comandoInsercao.Parameters.Add("DataInicio", registro.dataInicio);
            comandoInsercao.Parameters.Add("DataFinal", registro.dataFinal);


            comandoInsercao.ExecuteNonQuery();
        }
        public override List<Compromisso> ObterComandoSelecionarTodos()
        {
            string comandoSelectComand = "";
            List<Compromisso> compromisso = new List<Compromisso>();
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                comandoSelectComand = "SELECT * FROM TbCompromissos";

                DataTable dataTable = new DataTable(comandoSelectComand);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelectComand, ObterConexaoSql());
                sqlDataAdapter.Fill(dataTable);
                dataSet.ToString();
                foreach (DataRow row in dataTable.Rows)
                {
                    Compromisso cp = new Compromisso();
                    cp.id = Convert.ToInt32(row[0]);
                    cp.assunto = RetirarEspacos(row.Field<string>("Assunto"));
                    cp.local = RetirarEspacos(row.Field<string>("Local"));
                    var idContato = row[3];
                    if (idContato == null)
                        cp.contato.id = Convert.ToInt32(idContato);

                    cp.dataInicio = Convert.ToDateTime(row.Field<DateTime>("DataInicio"));
                    cp.dataFinal = Convert.ToDateTime(row.Field<DateTime>("DataFinal"));

                    compromisso.Add(cp);
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

                foreach (DataRow row in dataTable.Rows)
                {
                    Compromisso cp = new Compromisso();
                    cp.id = Convert.ToInt32(row[0]);
                    cp.assunto = RetirarEspacos(row.Field<string>("Assunto"));
                    cp.local = RetirarEspacos(row.Field<string>("Local"));
                    var idContato = row[3];
                    if (idContato == null)
                        cp.contato.id = Convert.ToInt32(idContato);

                    cp.dataInicio = Convert.ToDateTime(row.Field<DateTime>("DataInicio"));
                    cp.dataFinal = Convert.ToDateTime(row.Field<DateTime>("DataFinal"));

                    compromisso.Add(cp);
                }
            }
            return compromisso;
        }
        public List<Compromisso> selecionarTodosRegistrosFuturo()
        {
            string comandoSelectComand = "";
            List<Compromisso> compromisso = new List<Compromisso>();
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                comandoSelectComand = "SELECT * FROM TbCompromissos where SYSDATETIME() < [dataInicio];";

                DataTable dataTable = new DataTable(comandoSelectComand);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelectComand, ObterConexaoSql());
                sqlDataAdapter.Fill(dataTable);
                dataSet.ToString();
                foreach (DataRow row in dataTable.Rows)
                {
                    Compromisso cp = new Compromisso();
                    cp.id = Convert.ToInt32(row[0]);
                    cp.assunto = RetirarEspacos(row.Field<string>("Assunto"));
                    cp.local = RetirarEspacos(row.Field<string>("Local"));
                    var idContato = row[3];
                    if (idContato == null)
                        cp.contato.id = Convert.ToInt32(idContato);

                    cp.dataInicio = Convert.ToDateTime(row.Field<DateTime>("DataInicio"));
                    cp.dataFinal = Convert.ToDateTime(row.Field<DateTime>("DataFinal"));

                    compromisso.Add(cp);
                }
            }
            else
            {
                comandoSelectComand = "SELECT * FROM TbTarefas WHERE [DataInicio] < date('now');";
                SQLiteCommand ComandoSelecionartodos = new SQLiteCommand(comandoSelectComand, ObterConexaoSqlite());


                DataTable dataTable = new DataTable(comandoSelectComand);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelectComand, ObterConexaoSql());

                int nPI = sqlDataAdapter.Fill(dataTable);
                string nPI2 = dataSet.ToString();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compromisso cp = new Compromisso();
                    cp.id = Convert.ToInt32(row[0]);
                    cp.assunto = RetirarEspacos(row.Field<string>("Assunto"));
                    cp.local = RetirarEspacos(row.Field<string>("Local"));
                    var idContato = row[3];
                    if (idContato == null)
                        cp.contato.id = Convert.ToInt32(idContato);

                    cp.dataInicio = Convert.ToDateTime(row.Field<DateTime>("DataInicio"));
                    cp.dataFinal = Convert.ToDateTime(row.Field<DateTime>("DataFinal"));

                    compromisso.Add(cp);
                }
            }
            return compromisso;
        }
        public List<Compromisso> SelecionarTodosRegistrosPassados()
        {
            string comandoSelectComand = "";
            List<Compromisso> compromisso = new List<Compromisso>();
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                comandoSelectComand = "SELECT * FROM TbCompromissos where SYSDATETIME() > [dataInicio];";

                DataTable dataTable = new DataTable(comandoSelectComand);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelectComand, ObterConexaoSql());
                sqlDataAdapter.Fill(dataTable);
                dataSet.ToString();
                foreach (DataRow row in dataTable.Rows)
                {
                    Compromisso cp = new Compromisso();
                    cp.id = Convert.ToInt32(row[0]);
                    cp.assunto = RetirarEspacos(row.Field<string>("Assunto"));
                    cp.local = RetirarEspacos(row.Field<string>("Local"));
                    var idContato = row[3];
                    if (idContato == null)
                        cp.contato.id = Convert.ToInt32(idContato);

                    cp.dataInicio = Convert.ToDateTime(row.Field<DateTime>("DataInicio"));
                    cp.dataFinal = Convert.ToDateTime(row.Field<DateTime>("DataFinal"));

                    compromisso.Add(cp);
                }
            }
            else
            {
                comandoSelectComand = "SELECT * FROM TbTarefas WHERE [DataInicio] > date('now');";
                SQLiteCommand ComandoSelecionartodos = new SQLiteCommand(comandoSelectComand, ObterConexaoSqlite());


                DataTable dataTable = new DataTable(comandoSelectComand);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelectComand, ObterConexaoSql());

                int nPI = sqlDataAdapter.Fill(dataTable);
                string nPI2 = dataSet.ToString();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compromisso cp = new Compromisso();
                    cp.id = Convert.ToInt32(row[0]);
                    cp.assunto = RetirarEspacos(row.Field<string>("Assunto"));
                    cp.local = RetirarEspacos(row.Field<string>("Local"));
                    var idContato = row[3];
                    if (idContato == null)
                        cp.contato.id = Convert.ToInt32(idContato);

                    cp.dataInicio = Convert.ToDateTime(row.Field<DateTime>("DataInicio"));
                    cp.dataFinal = Convert.ToDateTime(row.Field<DateTime>("DataFinal"));

                    compromisso.Add(cp);
                }
            }
            return compromisso;
        }
    }
}
