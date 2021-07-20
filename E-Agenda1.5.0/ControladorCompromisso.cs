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
        #region Querryes
        private const string inserirCompromissoSemContato =
            @"INSERT INTO [TbCompromissos]
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
        private const string inserirCompromissoComContato =
            @"INSERT INTO [TbCompromissos]
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
        private const string selecionarTodosCompromissos =
            "SELECT * FROM [TbCompromissos];";
        private const string selecionarCompromissosFuturos =
            "SELECT * FROM [TbCompromissos] where SYSDATETIME() < [dataInicio];";
        private const string selecionarCompromissosPassados =
            "SELECT * FROM [TbCompromissos] where SYSDATETIME() > [dataInicio];";
        private const string editarCompromissosComContato =
            @"UPDATE [TbCompromissos]
                    SET
                    [Assunto] = @Assunto,
                    [Local] = @Local,
                    [Id_Contato] = @Id_Contato,
                    [DataInicio] = @DataInicio,
                    [DataFinal] = @DataFinal
                WHERE
                [ID] = @ID;";
        private const string editarCompromissosSemContato =
            @"UPDATE [TbCompromissos]
                    SET
                    [Assunto] = @Assunto,
                    [Local] = @Local,
                    [DataInicio] = @DataInicio,
                    [DataFinal] = @DataFinal
                WHERE
                [ID] = @ID;";
        private const string excluirCompromisso =
            @"DELETE FROM [TBCOMPROMISSOS]
                    WHERE
                    [ID] = @ID;";
        private const string obterIdCompromissoPorAssunto =
            "SELECT * FROM [TBCOMPROMISSOS] WHERE [ASSUNTO] = @ASSUNTO;";

        #endregion

        public override void Editar(Compromisso registro)
        {
            if(registro.contato != null)
                Db.Atualizar(editarCompromissosComContato,ObtemParametrosCompromisso(registro));
            else
                Db.Atualizar(editarCompromissosSemContato, ObtemParametrosCompromisso(registro));
        }
        public override void Excluir(Compromisso registro)
        {
            Db.Deletar(excluirCompromisso, AdicionarParametro("ID", registro.id));
        }
        public override void Inserir(Compromisso registro)
        {
            if(registro.contato == null)
                Db.Inserir(inserirCompromissoSemContato, ObtemParametrosCompromisso(registro));
            else
                Db.Inserir(inserirCompromissoComContato, ObtemParametrosCompromisso(registro));
        }
        public override List<Compromisso> SelecionarTodos()
        {  
            return Db.SelecionarTodos(selecionarTodosCompromissos,ConverteEmCompromisso);
        }
        public List<Compromisso> selecionarTodosRegistrosFuturo()
        {
            return Db.SelecionarTodos(selecionarCompromissosFuturos, ConverteEmCompromisso);
        }
        public List<Compromisso> SelecionarTodosRegistrosPassados()
        {
            return Db.SelecionarTodos(selecionarCompromissosPassados,ConverteEmCompromisso);
        }
        public int ObterIdContatoPorAssunto(Compromisso registro)
        {
            var t=Db.Selecionar(obterIdCompromissoPorAssunto,ConverteEmCompromisso,AdicionarParametro("ASSUNTO",registro.assunto));
            return t.id;
        }

        #region Métodos privados
        private Dictionary<string, object> ObtemParametrosCompromisso(Compromisso compromisso)
        {
            var parametros = new Dictionary<string, object>();
            if (compromisso.id != 0)
                parametros.Add("ID", compromisso.id);
            parametros.Add("ASSUNTO", compromisso.assunto);
            parametros.Add("LOCAL", compromisso.local);
            if(compromisso.contato != null)
            parametros.Add("ID_CONTATO", compromisso.contato.id);
            parametros.Add("DATAINICIO", compromisso.dataInicio);
            parametros.Add("DATAFINAL", compromisso.dataFinal);

            return parametros;
        }
        private Compromisso ConverteEmCompromisso(IDataReader reader)
        {
            Compromisso compromisso = new Compromisso();
            ControladorContatos ctr = new ControladorContatos();

            Contato contato = new Contato();

            var id = Convert.ToInt32(reader["ID"]);
            var assunto = Convert.ToString(reader["ASSUNTO"]);
            var local = Convert.ToString(reader["LOCAL"]);
            var dataInicio = Convert.ToDateTime(reader["DATAINICIO"]);
            var dataFinal = Convert.ToDateTime(reader["DATAFINAL"]);

            if (reader["ID_CONTATO"] != DBNull.Value)
            {
                var idc = Convert.ToInt32(reader["ID_CONTATO"]);
                contato.id = idc;
                contato = ctr.ObterContatoPorId(contato);
                contato.id = idc;
            }

            compromisso.id = id;
            compromisso.assunto = assunto;
            compromisso.local = local;
            compromisso.contato = contato;
            compromisso.dataInicio = dataInicio;
            compromisso.dataFinal = dataFinal;

            return compromisso;
        }
        #endregion
    }
}
