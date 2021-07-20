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
        #region Querryes
        private const string inserirContato =
            @"INSERT INTO [TBCONTATOS]
                (
                    [NOME],
                    [EMAIL],
                    [TELEFONE],
                    [EMPRESA],
                    [CARGO]
                )
                VALUES
                (
                    @NOME,
                    @EMAIL,
                    @TELEFONE,
                    @EMPRESA,
                    @CARGO
                );";
        private const string editarContato =
            @"UPDATE [TbContatos]
                    SET
                    [NOME] = @NOME,
                    [email] = @email,
                    [EMPRESA] = @EMPRESA,
                    [CARGO] = @CARGO,
                    [TELEFONE] = @TELEFONE
                WHERE
                [ID] = @ID;";
        private const string excluirContato =
            @"DELETE FROM [TBCONTATOS]
                    WHERE
                    [id] = @id;";
        private const string selecionarTodosContatos =
            @"SELECT * FROM [TbContatos];";
        private const string selecionarTodosIdsContatos =
            @"SELECT * FROM [TbContatos];";
        private const string selecionarContatoPorId =
            "SELECT * FROM TbContatos WHERE[Id] = @Id;";
        private const string obterIdPorNome =
            "SELECT * FROM [TBCONTATOS] WHERE [NOME] = @NOME;";
        private const string obterContatoPorId =
            "SELECT * FROM [TBCONTATOS] WHERE [ID] = @ID;";
        #endregion
        public override void Editar(Contato registro)
        {
            Db.Atualizar(editarContato,ObtemParametrosContato(registro));
        }
        public override void Excluir(Contato registro)
        {
            Db.Deletar(excluirContato,AdicionarParametro("ID", registro.id));
        }
        public override void Inserir(Contato registro)
        {
            Db.Inserir(inserirContato, ObtemParametrosContato(registro));
        }
        public override List<Contato> SelecionarTodos()
        {
            return Db.SelecionarTodos(selecionarTodosContatos,ConverteEmContato);
        }
        public Contato ObterContatoPeloId(Contato registro)
        {
            return Db.Selecionar(selecionarContatoPorId,ConverteEmContato,AdicionarParametro("ID",registro.id));
        }
        public int ObterIdPeloNome(Contato registro)
        {
            var t = Db.Selecionar(obterIdPorNome, ConverteEmContato, AdicionarParametro("NOME", registro.nome));
            return t.id;
        }
        public Contato ObterContatoPorId(Contato registro)
        {
            return Db.Selecionar(obterContatoPorId,ConverteEmContato,AdicionarParametro("ID",registro.id));
        }

        #region Métodos privados
        private Dictionary<string, object> ObtemParametrosContato(Contato contato)
        {
            var parametros = new Dictionary<string, object>();
            if (contato.id != 0)
                parametros.Add("ID", contato.id);
            parametros.Add("NOME", contato.nome);
            parametros.Add("EMAIL", contato.email);
            parametros.Add("TELEFONE", contato.telefone);
            parametros.Add("EMPRESA", contato.empresa);
            parametros.Add("CARGO", contato.cargo);

            return parametros;
        }
        private Contato ConverteEmContato(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var email = Convert.ToString(reader["EMAIL"]);
            var telefone = Convert.ToInt32(reader["TELEFONE"]);
            var empresa = Convert.ToString(reader["EMPRESA"]);
            var cargo = Convert.ToString(reader["CARGO"]);

            Contato contato = new Contato();

            contato.id = id;
            contato.nome = nome;
            contato.email = email;
            contato.telefone = telefone;
            contato.empresa = empresa;
            contato.cargo = cargo;

            return contato;
        }
        #endregion
    }
}
