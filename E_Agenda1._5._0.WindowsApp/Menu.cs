using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Agenda1._5._0.Controlador;
using E_Agenda1._5._0.Dominio;
using E_Agenda1._5._0.WindowsApp.UserInterfaces;

namespace E_Agenda1._5._0.WindowsApp
{
    public partial class Menu : Form
    {
        ControladorTarefa controladorTarefas = new ControladorTarefa();
        ControladorContatos controladorContatos = new ControladorContatos();
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        int id;

        public Menu()
        {
            InitializeComponent();
            PopularGridTarefas();
            popularGridContatos();
            popularGridCompromissos();
        }



        private void PopularGridTarefas()
        {
            dataGridViewTarefas.DataSource = controladorTarefas.SelecionarTodos();
        }
        private void popularGridContatos() 
        {
            dataGridViewContatos.DataSource = controladorContatos.SelecionarTodos();
        }
        private void popularGridCompromissos()
        {
            dataGridViewCompromissos.DataSource = controladorCompromisso.SelecionarTodos();
            PopularListaContatosNaTelaCompromissos();
        }
        private void PopularListaContatosNaTelaCompromissos()
        {
            List<Contato> contatos = controladorContatos.SelecionarTodos();
            Dictionary<int, string> contatosFormatados = new Dictionary<int, string>();

            foreach (Contato c in contatos)
            {
                contatosFormatados.Add(c.id, c.nome);
            }

            listBox_Contato_Compromissos.DataSource = contatosFormatados.Keys.ToList();
        }

        #region Tarefas

        private void button_Inserir_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            tarefa.titulo = textBox_Titulo.Text;
            tarefa.percentualConclusao = Convert.ToInt32(maskedTextBox_PercentualConclusao.Text.ToString());
            tarefa.prioridade = Convert.ToInt32(listBox_Prioridade.SelectedValue);
            tarefa.dataAbertura = Convert.ToDateTime(dateTimePicker_DataAbertura.Value);

            controladorTarefas.Inserir(tarefa);

            PopularGridTarefas();
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            tarefa.id = id;
            tarefa.titulo = Convert.ToString(textBox_Titulo.Text);
            tarefa.prioridade = Convert.ToInt32(listBox_Prioridade.SelectedValue);
            tarefa.percentualConclusao = Convert.ToInt32(maskedTextBox_PercentualConclusao.Text);
            tarefa.dataAbertura = Convert.ToDateTime(dateTimePicker_DataAbertura.Value);

            controladorTarefas.Editar(tarefa);
            PopularGridTarefas();
        }

        private void button_Excluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            tarefa.id = id;
            controladorTarefas.Excluir(tarefa);
            PopularGridTarefas();
        }

        private void button_ConcluirTarefa_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            tarefa.id = id;
            controladorTarefas.ConcluirTarefa(tarefa);
            PopularGridTarefas();
        }

        private void button_MostrarConcludos_Click(object sender, EventArgs e)
        {
            dataGridViewTarefas.DataSource = controladorTarefas.ObterComandoSelecionarFechados();
        }

        private void button_MostrarAbertos_Click(object sender, EventArgs e)
        {
            dataGridViewTarefas.DataSource = controladorTarefas.ObterComandoSelecionarAbertos();
        }

        private void button_MostrarTodos_Click(object sender, EventArgs e)
        {
            PopularGridTarefas();
        }

        private void dataGridViewTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTarefas.Rows[e.RowIndex];
                textBox_Titulo.Text = row.Cells["Titulo"].Value.ToString();
                maskedTextBox_PercentualConclusao.Text = row.Cells["percentualConclusao"].Value.ToString();
                dateTimePicker_DataAbertura.Value = Convert.ToDateTime(row.Cells["DataAbertura"].Value.ToString());
                id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
            }
        }
        #endregion

        #region Contatos
        private void dataGridViewContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewContatos.Rows[e.RowIndex];
                textBox_Nome_Contatos.Text = row.Cells["Nome"].Value.ToString();
                maskedTextBox_Telefone_Contatos.Text = row.Cells["Telefone"].Value.ToString();
                textBox_Email_Contatos.Text = row.Cells["Email"].Value.ToString();
                textBox_Empresa_Contatos.Text = row.Cells["Empresa"].Value.ToString();
                textBox_Cargo_Contatos.Text = row.Cells["Cargo"].Value.ToString();
                id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
            }
        }

        private void button_Inserir_Contatos_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.nome = Convert.ToString(textBox_Nome_Contatos.Text);
            contato.telefone = Convert.ToInt64(maskedTextBox_Telefone_Contatos.Text);
            contato.email = Convert.ToString(textBox_Email_Contatos.Text);
            contato.empresa = Convert.ToString(textBox_Empresa_Contatos.Text);
            contato.cargo = Convert.ToString(textBox_Cargo_Contatos.Text);

            controladorContatos.Inserir(contato);
            popularGridContatos();
        }

        private void button_Editar_Contatos_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.id = id;
            contato.nome = Convert.ToString(textBox_Nome_Contatos.Text);
            contato.telefone = Convert.ToInt64(maskedTextBox_Telefone_Contatos.Text);
            contato.email = Convert.ToString(textBox_Email_Contatos.Text);
            contato.empresa = Convert.ToString(textBox_Empresa_Contatos.Text);
            contato.cargo = Convert.ToString(textBox_Cargo_Contatos.Text);
            controladorContatos.Editar(contato);
            popularGridContatos();
        }

        private void button_Excluir_Contatos_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.id = id;
            controladorContatos.Excluir(contato);
            popularGridContatos();
        }
        #endregion

        private void dataGridViewCompromissos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string varTime;
                DataGridViewRow row = this.dataGridViewCompromissos.Rows[e.RowIndex];
                textBox_Assunto_Compromissos.Text = row.Cells["Assunto"].Value.ToString();
                textBox_Local_Compromissos.Text   = row.Cells["Local"].Value.ToString();
                dateTimePicker_DataInicio_Compromissos.Value = Convert.ToDateTime(row.Cells["DataInicio"].Value.ToString());
                dateTimePicker_DataFinal_Compromissos.Value = Convert.ToDateTime(row.Cells["DataFinal"].Value.ToString());
                DateTime horainicio = Convert.ToDateTime(row.Cells["DataInicio"].Value.ToString());
                varTime = (horainicio.Hour.ToString()) + (horainicio.Minute.ToString());
                maskedTextBox_HoraInicio_Compromissos.Text = varTime;
                DateTime horaFinal = Convert.ToDateTime(row.Cells["DataFinal"].Value.ToString());
                varTime = (horaFinal.Hour.ToString()) + (horaFinal.Minute.ToString());
                maskedTextBox_HoraFinal_Compromissos.Text = varTime;
            }
        }

        private void button_Inserir_Compromissos_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = new Compromisso();

            popularGridCompromissos();
        }

        private void button_Editar_Compromissos_Click(object sender, EventArgs e)
        {
            popularGridCompromissos();
        }

        private void button_Excluir_Compromissos_Click(object sender, EventArgs e)
        {
            popularGridCompromissos();
        }

        private void button_ListarFuturos_Compromissos_Click(object sender, EventArgs e)
        {
            controladorCompromisso.selecionarTodosRegistrosFuturo();
        }

        private void button_ListarPassados_Compromissos_Click(object sender, EventArgs e)
        {
            controladorCompromisso.SelecionarTodosRegistrosPassados();
        }

        private void button_ListarTodos_Compromissos_Click(object sender, EventArgs e)
        {
            popularGridCompromissos();
        }
    }
}
