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

namespace E_Agenda1._5._0.WindowsApp.UserInterfaces
{
    public partial class UserControlTarefas : UserControl
    {
        ControladorTarefa controladorTarefas = new ControladorTarefa();
        int id;
        public UserControlTarefas()
        {
            InitializeComponent();
            PopularGridTarefas();
        }

        public void PopularGridTarefas()
        {
            dataGridViewTarefas.DataSource = controladorTarefas.SelecionarTodos();
        }

        private void button_MostrarConcludos_Click(object sender, EventArgs e)
        {
            dataGridViewTarefas.DataSource = controladorTarefas.ObterComandoSelecionarFechados();
        }

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

        private void button_MostrarAbertos_Click(object sender, EventArgs e)
        {
            dataGridViewTarefas.DataSource = controladorTarefas.ObterComandoSelecionarAbertos();
        }

        private void button_MostrarTodos_Click(object sender, EventArgs e)
        {
            PopularGridTarefas();
        }

        private void button_ConcluirTarefa_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            tarefa.id = id;
            controladorTarefas.ConcluirTarefa(tarefa);
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
    }
}
