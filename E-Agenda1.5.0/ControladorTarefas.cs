using System;
using System.Data;
using System.Collections.Generic;
using E_Agenda1._5._0.Dominio;

namespace E_Agenda1._5._0.Controlador
{
    public class ControladorTarefa : ControladorBase<Tarefa>
    {

        #region Querryes

        private const string inserirTarefa =
            @"INSERT INTO [TBTAREFAS]
                (
                    [TITULO],
                    [PRIORIDADE],
                    [DataAbertura],
                    [PERCENTUALCONCLUSAO]             
                )
                VALUES
                (
                    @TITULO,
                    @PRIORIDADE,
                    @DataAbertura,
                    @PERCENTUALCONCLUSAO
                );";
        private const string editarTarefa =
            @"UPDATE TBTAREFAS
                SET
                [TITULO] = @TITULO,
                [PRIORIDADE] = @PRIORIDADE,
                [PercentualConclusao] = @PercentualConclusao            
                WHERE
                [ID] = @ID;";
        private const string excluirTarefa =
            @"DELETE FROM TBTAREFAS
                    WHERE
                    [ID] = @ID;";
        private const string selecionarTodosOsRegistros =
            @"SELECT * FROM [TbTarefas];";
        private const string obterIdPorTitulo =
            "SELECT * FROM[TBTAREFAS] WHERE [TITULO] = @TITULO;";
        private const string concluirTarefa =
            @"UPDATE TBTAREFAS
                    SET                    
                    [DATACONCLUSAO] = @DATACONCLUSAO,
                    [PercentualConclusao] = @PercentualConclusao
                WHERE
                [ID] = @ID;";
        private const string editarPorcentagem =
            @"UPDATE TBTAREFAS SET
              [PERCENTUALCONCLUSAO] = @PERCENTUALCONCLUSAO
              WHERE [ID] = @ID;";
        private const string selecionarTodosAbertos =
            "select * from TbTarefas where PercentualConclusao < 100;";
        private const string selecionarTodosFechados =
            "select * from TbTarefas where PercentualConclusao >= 100;";
        private const string selecionarIdPorTitulo =
            "select [ID] FROM [TbTarefas] where [Titulo] = @Titulo;";
        private const string selecionarTarefaPorId =
            "select * from [TbTarefas] where [ID] = @ID;";

        #endregion

        public override void Inserir(Tarefa registro)
        {
            Db.Inserir(inserirTarefa, ObtemParametrosTarefa(registro));
        }
        public override void Editar(Tarefa registro)
        {
            Db.Atualizar(editarTarefa, ObtemParametrosTarefa(registro));
        }
        public override void Excluir(Tarefa registro)
        {
            Db.Deletar(excluirTarefa, AdicionarParametro("ID", registro.id));
        }
        public override List<Tarefa> SelecionarTodos()
        {
           return Db.SelecionarTodos(selecionarTodosOsRegistros, ConverteEmTarefa);
        }
        public void ConcluirTarefa(Tarefa registro)
        {
            registro.percentualConclusao = 100;
            registro.dataConclusao = DateTime.Now;
            Db.Atualizar(concluirTarefa, ObtemParametrosTarefaConcluirTarefa(registro));
        }
        public void EditarPorcentagem(Tarefa registro)
        {
            registro = SelecionarTarefaPorId(registro);
            if (registro.percentualConclusao == 100)
                ConcluirTarefa(registro);
            else
                Db.Atualizar(editarPorcentagem, ObtemParametrosTarefa(registro));
        }
        public List<Tarefa> ObterComandoSelecionarAbertos()
        {
            return Db.SelecionarTodos(selecionarTodosAbertos,ConverteEmTarefa);
        }
        public List<Tarefa> ObterComandoSelecionarFechados()
        {
            return Db.SelecionarTodos(selecionarTodosFechados, ConverteEmTarefa);
        }
        public int ObterIdPorTitulo(Tarefa registro) 
        {
            var t = Db.Selecionar(obterIdPorTitulo, ConverteEmTarefa, AdicionarParametro("Titulo", registro.titulo));
            return t.id;
        }
        public Tarefa SelecionarTarefaPorId(Tarefa registro)
        {
            return Db.Selecionar(selecionarTarefaPorId,ConverteEmTarefa, AdicionarParametro("ID", registro.id));
        }
        #region Métodos Privados
        private Dictionary<string, object> ObtemParametrosTarefa(Tarefa tarefa)
        {
            var parametros = new Dictionary<string, object>();
            if (tarefa.id != 0)
            parametros.Add("ID", tarefa.id);
            parametros.Add("TITULO", tarefa.titulo);
            parametros.Add("PRIORIDADE", tarefa.prioridade);
            parametros.Add("DataAbertura", tarefa.dataAbertura);
            parametros.Add("PercentualConclusao", tarefa.percentualConclusao);

            return parametros;
        }
        private Dictionary<string, object> ObtemParametrosTarefaConcluirTarefa(Tarefa tarefa)
        {
            var parametros = new Dictionary<string, object>();
            if (tarefa.id != 0)
                parametros.Add("ID", tarefa.id);
            parametros.Add("DataConclusao", tarefa.dataConclusao);
            parametros.Add("PercentualConclusao", tarefa.percentualConclusao);

            return parametros;
        }
        private Tarefa ConverteEmTarefa(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var titulo = Convert.ToString(reader["TITULO"]);
            var percentualConclusao = Convert.ToInt32(reader["PERCENTUALCONCLUSAO"]);
            var dataAbertura = Convert.ToDateTime(reader["DATAABERTURA"]);
            var dataConclusao = DateTime.MinValue;

            if (reader["DATACONCLUSAO"] != DBNull.Value)
                dataConclusao = Convert.ToDateTime(reader["DATACONCLUSAO"]);

            Tarefa tarefa = new Tarefa();

            tarefa.id = id;
            tarefa.titulo = titulo;
            tarefa.percentualConclusao = percentualConclusao;
            tarefa.dataAbertura = dataAbertura;
            tarefa.dataConclusao = dataConclusao;

            return tarefa;
        }
        #endregion
    }
}

