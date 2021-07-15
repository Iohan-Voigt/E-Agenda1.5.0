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
    public class ControladorTarefa : ControladorBase<Tarefa>
    {
        public override void ObterComandoInserir(Tarefa registro)
        {
            string InserirCommand = "";
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                InserirCommand =
                    @"INSERT INTO TBTAREFAS
                (
                    [TITULO],
                    [PRIORIDADE],
                    [DATAABERTURA],
                    [PERCENTUALCONCLUSAO]             
                )
                VALUES
                (
                    @TITULO,
                    @PRIORIDADE,
                    @DATAABERTURA,
                    @PERCENTUALCONCLUSAO
                );";
                InserirCommand += @"SELECT SCOPE_IDENTITY();";
                SqlCommand comando = new SqlCommand(InserirCommand, ObterConexaoSql());
                comando.Parameters.Add("TITULO", registro.titulo);
                comando.Parameters.Add("PRIORIDADE", registro.prioridade);
                comando.Parameters.Add("DATAABERTURA", registro.dataAbertura);
                comando.Parameters.Add("PERCENTUALCONCLUSAO", registro.percentualConclusao);

                comando.ExecuteNonQuery();

            }
            else
            {
                InserirCommand =
                    @"insert into TbTarefas (Titulo,Prioridade,DataAbertura,PercentualConclusao)
                    VALUES
                    (@Titulo,@Prioridade,@DataAbertura,@PercentualConclusao);";
                InserirCommand += @"SELECT LAST_INSERT_ROWID();";
                SQLiteCommand comando = new SQLiteCommand(InserirCommand, ObterConexaoSqlite());
                ObterConexaoSqlite().Execute(InserirCommand, registro);
            }

        }

        public override void ObterComandoEditar(Tarefa registro)
        {
            string EditarCommand = "";
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                EditarCommand =
                @"UPDATE TBTAREFAS
                    SET
                    [TITULO] = @TITULO,
                    [PRIORIDADE] = @PRIORIDADE,
                    [DataAbertura] = @DataAbertura,
                    [PERCENTUALCONCLUSAO] = @PERCENTUALCONCLUSAO            
                WHERE
                [ID] = @ID;";
                SqlCommand comandoEdicao = new SqlCommand(EditarCommand, ObterConexaoSql());
                comandoEdicao.Parameters.Add("TITULO", registro.titulo);
                comandoEdicao.Parameters.Add("PRIORIDADE", registro.prioridade);
                comandoEdicao.Parameters.Add("DataAbertura", registro.dataAbertura);
                comandoEdicao.Parameters.Add("PERCENTUALCONCLUSAO", registro.percentualConclusao);
                comandoEdicao.Parameters.Add("ID", registro.id);
                comandoEdicao.ExecuteNonQuery();
            }
            else
            {
                EditarCommand =
                @"UPDATE TbTarefas
                    SET
                    (Titulo) = @TITULO,
                    (Prioridade) = @PRIORIDADE,
                    (DataAbertura) = @DataAbertura,
                    (PercentualConclusao) = @PERCENTUALCONCLUSAO            
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
                @"DELETE FROM TBTAREFAS
                    WHERE
                    [ID] = @ID";
                SqlCommand comandoExclusao = new SqlCommand(ExcluirCommand, ObterConexaoSql());
                comandoExclusao.Parameters.Add("ID", id);
                comandoExclusao.ExecuteNonQuery();
            }
            else
            {
                ExcluirCommand =
                    @"DELETE FROM TbTarefas
                WHERE
                (Id) = @Id;";
                SQLiteCommand comandoExclusao = new SQLiteCommand(ExcluirCommand, ObterConexaoSqlite());
                ObterConexaoSqlite().Execute(ExcluirCommand, id);

            }
        }
        public override List<Tarefa> ObterComandoSelecionarTodos()
        {
            string comandoSelect = "";
            List<Tarefa> registros = new List<Tarefa>();
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                comandoSelect = "SELECT * FROM TbTarefas;";
                SqlCommand comandoSelecionarTodos = new SqlCommand(comandoSelect);

                DataTable dataTable = new DataTable(comandoSelect);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelect, ObterConexaoSql());

                int nPI = sqlDataAdapter.Fill(dataTable);
                string nPI2 = dataSet.ToString();


                foreach (DataRow row in dataTable.Rows)
                {
                    Tarefa tr = new Tarefa();
                    tr.id = Convert.ToInt32(row[0]);
                    tr.titulo = row.Field<string>("titulo");
                    tr.dataAbertura = row.Field<DateTime>("DataAbertura");
                    if (tr.dataConclusao == null)
                    {
                        tr.dataConclusao = row.Field<DateTime>("DataConclusao");
                    }
                    tr.prioridade = Convert.ToInt32(row[2]);
                    tr.percentualConclusao = Convert.ToInt32(row[5]);
                    registros.Add(tr);
                }
            }
            else
            {
                comandoSelect = "SELECT * FROM TbTarefas;";
                SQLiteCommand ComandoSelecionartodos = new SQLiteCommand(comandoSelect, ObterConexaoSqlite());


                DataTable dataTable = new DataTable(comandoSelect);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelect, ObterConexaoSql());

                int nPI = sqlDataAdapter.Fill(dataTable);
                string nPI2 = dataSet.ToString();

                foreach (DataRow row in dataTable.Rows)
                {
                    Tarefa tr = new Tarefa();
                    tr.id = Convert.ToInt32(row[0]);
                    tr.titulo = row.Field<string>("titulo");
                    tr.dataAbertura = row.Field<DateTime>("DataAbertura");
                    if (tr.dataConclusao == null)
                    {
                        tr.dataConclusao = row.Field<DateTime>("DataConclusao");
                    }
                    tr.prioridade = Convert.ToInt32(row[2]);
                    tr.percentualConclusao = Convert.ToInt32(row[5]);
                    registros.Add(tr);
                }
            }

            return registros;

        }
        public Tarefa ObterIdPorTitulo(Tarefa registro)
        {
            string comandoSelect = "SELECT * FROM TbTarefas WHERE [Titulo] = " + registro.titulo + ";";

            DataTable dataTable = new DataTable(comandoSelect);
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelect, ObterConexaoSql());

            int nPI = sqlDataAdapter.Fill(dataTable);
            string nPI2 = dataSet.ToString();

            registro.id = Convert.ToInt32(dataTable.Rows[0]);

            return registro;
        }
        public void ConcluirTarefa(int id)
        {
            AbrirBanco();
            string EditarCommand = "";

            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                EditarCommand =
                @"UPDATE TBTAREFAS
                    SET                    
                    [DATACONCLUSAO] = @DATACONCLUSAO,
                    [PercentualConclusao] = @PercentualConclusao
                WHERE
                [ID] = @ID";
                SqlCommand comandoConcluirTareda = new SqlCommand(EditarCommand, ObterConexaoSql());
                comandoConcluirTareda.CommandText = EditarCommand;
                comandoConcluirTareda.Parameters.Add("DATACONCLUSAO", DateTime.Today);
                comandoConcluirTareda.Parameters.Add("PercentualConclusao", 100);
                comandoConcluirTareda.Parameters.Add("ID", id);
                comandoConcluirTareda.ExecuteNonQuery();
            }
            else
            {
                EditarCommand =
                @"UPDATE TbTarefas
                    SET
                    (DATACONCLUSAO) = @DATACONCLUSAO,
                    (PercentualConclusao) = 100           
                    WHERE
                    (ID) = @ID";
                SQLiteCommand comandoEdicao = new SQLiteCommand(EditarCommand, ObterConexaoSqlite());
                DynamicParameters param = new DynamicParameters();
                param.Add("DATACONCLUSAO", DateTime.Now);
                param.Add("Id", id);
                ObterConexaoSqlite().Execute(EditarCommand, param);
            }

            FecharBanco();
        }
        public void EditarPorcentagem(int id, int porcentagem)
        {
            AbrirBanco();
            string EditarPorcentagem = "";
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {

                EditarPorcentagem = @"UPDATE TBTAREFAS SET
                                                [PERCENTUALCONCLUSAO] = @PERCENTUALCONCLUSAO
                                                WHERE [ID] = @ID;";
                SqlCommand comandoEditarPorcentagem = new SqlCommand(EditarPorcentagem, ObterConexaoSql());
                comandoEditarPorcentagem.Parameters.Add("PERCENTUALCONCLUSAO", porcentagem);
                comandoEditarPorcentagem.Parameters.Add("ID", id);
                comandoEditarPorcentagem.ExecuteNonQuery();
            }
            else
            {
                EditarPorcentagem = @"UPDATE TBTAREFAS SET
                                                (PERCENTUALCONCLUSAO) = @PERCENTUALCONCLUSAO
                                                WHERE (ID) = @ID;";
                SQLiteCommand comandoEditarPorcentagem = new SQLiteCommand(EditarPorcentagem);
                DynamicParameters param = new DynamicParameters();
                param.Add("PERCENTUALCONCLUSAO", porcentagem);
                param.Add("Id", id);
                ObterConexaoSqlite().Execute(EditarPorcentagem, param);

            }

            FecharBanco();
        }
        public List<Tarefa> ObterComandoSelecionarAbertos()
        {
            AbrirBanco();
            List<Tarefa> registros = new List<Tarefa>();
            string comandoSelect = "";
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                comandoSelect = "select * from TbTarefas where PercentualConclusao < 100;";
                SqlCommand comandoSelecionarAbertos = new SqlCommand(comandoSelect);

                DataTable dataTable = new DataTable(comandoSelect);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelect, ObterConexaoSql());
                int asds = sqlDataAdapter.Fill(dataTable);
                string asd = dataSet.ToString();

                foreach (DataRow row in dataTable.Rows)
                {
                    Tarefa tr = new Tarefa();
                    tr.id = Convert.ToInt32(row[0]);
                    tr.titulo = row.Field<string>("titulo");
                    tr.dataAbertura = row.Field<DateTime>("DataAbertura");
                    if (tr.dataConclusao == null)
                    {
                        tr.dataConclusao = row.Field<DateTime>("DataConclusao");
                    }
                    tr.prioridade = Convert.ToInt32(row[2]);
                    tr.percentualConclusao = Convert.ToInt32(row[5]);
                    registros.Add(tr);
                }
            }
            else
            {
                comandoSelect = "select * from TbTarefas where PercentualConclusao < 100;";
                SQLiteCommand comandoSelecionarAbertos = new SQLiteCommand(comandoSelect);

                DataTable dataTable = new DataTable(comandoSelect);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelect, ObterConexaoSql());
                int asds = sqlDataAdapter.Fill(dataTable);
                string asd = dataSet.ToString();

                foreach (DataRow row in dataTable.Rows)
                {
                    Tarefa tr = new Tarefa();
                    tr.id = Convert.ToInt32(row[0]);
                    tr.titulo = row.Field<string>("titulo");
                    tr.dataAbertura = row.Field<DateTime>("DataAbertura");
                    if (tr.dataConclusao == null)
                    {
                        tr.dataConclusao = row.Field<DateTime>("DataConclusao");
                    }
                    tr.prioridade = Convert.ToInt32(row[2]);
                    tr.percentualConclusao = Convert.ToInt32(row[5]);
                    registros.Add(tr);
                }
            }
            FecharBanco();
            return registros;
        }
        public List<Tarefa> ObterComandoSelecionarFechados()
        {
            AbrirBanco();
            List<Tarefa> registros = new List<Tarefa>();
            string comandoSelect = "";
            if (ConfigurationManager.ConnectionStrings["Default"].ProviderName == "SQL")
            {
                comandoSelect = "select * from TbTarefas where PercentualConclusao = 100;";
                SqlCommand comandoSelecionarAbertos = new SqlCommand(comandoSelect);

                DataTable dataTable = new DataTable(comandoSelect);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelect, ObterConexaoSql());
                int asds = sqlDataAdapter.Fill(dataTable);
                string asd = dataSet.ToString();

                foreach (DataRow row in dataTable.Rows)
                {
                    Tarefa tr = new Tarefa();
                    tr.id = Convert.ToInt32(row[0]);
                    tr.titulo = row.Field<string>("titulo");
                    tr.dataAbertura = row.Field<DateTime>("DataAbertura");
                    if (tr.dataConclusao == null)
                    {
                        tr.dataConclusao = row.Field<DateTime>("DataConclusao");
                    }
                    tr.prioridade = Convert.ToInt32(row[2]);
                    tr.percentualConclusao = Convert.ToInt32(row[5]);
                    registros.Add(tr);
                }
            }
            else
            {
                comandoSelect = "select * from TbTarefas where PercentualConclusao = 100;";
                SQLiteCommand comandoSelecionarAbertos = new SQLiteCommand(comandoSelect);

                DataTable dataTable = new DataTable(comandoSelect);
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSelect, ObterConexaoSql());
                int asds = sqlDataAdapter.Fill(dataTable);
                string asd = dataSet.ToString();

                foreach (DataRow row in dataTable.Rows)
                {
                    Tarefa tr = new Tarefa();
                    tr.id = Convert.ToInt32(row[0]);
                    tr.titulo = row.Field<string>("titulo");
                    tr.dataAbertura = row.Field<DateTime>("DataAbertura");
                    if (tr.dataConclusao == null)
                    {
                        tr.dataConclusao = row.Field<DateTime>("DataConclusao");
                    }
                    tr.prioridade = Convert.ToInt32(row[2]);
                    tr.percentualConclusao = Convert.ToInt32(row[5]);
                    registros.Add(tr);
                }
            }
            FecharBanco();
            return registros;

        }
    }
}

