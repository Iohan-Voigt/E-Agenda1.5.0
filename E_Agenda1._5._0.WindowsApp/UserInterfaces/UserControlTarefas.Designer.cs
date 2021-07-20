
namespace E_Agenda1._5._0.WindowsApp.UserInterfaces
{
    partial class UserControlTarefas
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Background = new System.Windows.Forms.Panel();
            this.panel_Botoes = new System.Windows.Forms.Panel();
            this.button_MostrarConcludos = new System.Windows.Forms.Button();
            this.button_ConcluirTarefa = new System.Windows.Forms.Button();
            this.button_Inserir = new System.Windows.Forms.Button();
            this.button_MostrarTodos = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_MostrarAbertos = new System.Windows.Forms.Button();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_DataAbertura = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_PercentualConclusao = new System.Windows.Forms.MaskedTextBox();
            this.listBox_Prioridade = new System.Windows.Forms.ListBox();
            this.textBox_Titulo = new System.Windows.Forms.TextBox();
            this.label_DataAbertura = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_PercentualConclusao = new System.Windows.Forms.Label();
            this.label_Prioridade = new System.Windows.Forms.Label();
            this.dataGridViewTarefas = new System.Windows.Forms.DataGridView();
            this.panel_Background.SuspendLayout();
            this.panel_Botoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Background
            // 
            this.panel_Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Background.Controls.Add(this.panel_Botoes);
            this.panel_Background.Controls.Add(this.panel1);
            this.panel_Background.Controls.Add(this.dataGridViewTarefas);
            this.panel_Background.Location = new System.Drawing.Point(3, 3);
            this.panel_Background.Name = "panel_Background";
            this.panel_Background.Size = new System.Drawing.Size(609, 486);
            this.panel_Background.TabIndex = 0;
            // 
            // panel_Botoes
            // 
            this.panel_Botoes.Controls.Add(this.button_MostrarConcludos);
            this.panel_Botoes.Controls.Add(this.button_ConcluirTarefa);
            this.panel_Botoes.Controls.Add(this.button_Inserir);
            this.panel_Botoes.Controls.Add(this.button_MostrarTodos);
            this.panel_Botoes.Controls.Add(this.button_editar);
            this.panel_Botoes.Controls.Add(this.button_MostrarAbertos);
            this.panel_Botoes.Controls.Add(this.button_Excluir);
            this.panel_Botoes.Location = new System.Drawing.Point(394, 3);
            this.panel_Botoes.Name = "panel_Botoes";
            this.panel_Botoes.Size = new System.Drawing.Size(212, 224);
            this.panel_Botoes.TabIndex = 14;
            // 
            // button_MostrarConcludos
            // 
            this.button_MostrarConcludos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MostrarConcludos.Location = new System.Drawing.Point(6, 3);
            this.button_MostrarConcludos.Name = "button_MostrarConcludos";
            this.button_MostrarConcludos.Size = new System.Drawing.Size(121, 23);
            this.button_MostrarConcludos.TabIndex = 10;
            this.button_MostrarConcludos.Text = "Mostrar Concluidos";
            this.button_MostrarConcludos.UseVisualStyleBackColor = true;
            this.button_MostrarConcludos.Click += new System.EventHandler(this.button_MostrarConcludos_Click);
            // 
            // button_ConcluirTarefa
            // 
            this.button_ConcluirTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ConcluirTarefa.Location = new System.Drawing.Point(6, 90);
            this.button_ConcluirTarefa.Name = "button_ConcluirTarefa";
            this.button_ConcluirTarefa.Size = new System.Drawing.Size(202, 23);
            this.button_ConcluirTarefa.TabIndex = 13;
            this.button_ConcluirTarefa.Text = "Concluir Tarefa";
            this.button_ConcluirTarefa.UseVisualStyleBackColor = true;
            this.button_ConcluirTarefa.Click += new System.EventHandler(this.button_ConcluirTarefa_Click);
            // 
            // button_Inserir
            // 
            this.button_Inserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Inserir.Location = new System.Drawing.Point(133, 3);
            this.button_Inserir.Name = "button_Inserir";
            this.button_Inserir.Size = new System.Drawing.Size(75, 23);
            this.button_Inserir.TabIndex = 7;
            this.button_Inserir.Text = "Inserir";
            this.button_Inserir.UseVisualStyleBackColor = true;
            this.button_Inserir.Click += new System.EventHandler(this.button_Inserir_Click);
            // 
            // button_MostrarTodos
            // 
            this.button_MostrarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MostrarTodos.Location = new System.Drawing.Point(6, 61);
            this.button_MostrarTodos.Name = "button_MostrarTodos";
            this.button_MostrarTodos.Size = new System.Drawing.Size(121, 23);
            this.button_MostrarTodos.TabIndex = 12;
            this.button_MostrarTodos.Text = "Mostrar Todos";
            this.button_MostrarTodos.UseVisualStyleBackColor = true;
            this.button_MostrarTodos.Click += new System.EventHandler(this.button_MostrarTodos_Click);
            // 
            // button_editar
            // 
            this.button_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_editar.Location = new System.Drawing.Point(133, 32);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 8;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_MostrarAbertos
            // 
            this.button_MostrarAbertos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MostrarAbertos.Location = new System.Drawing.Point(6, 32);
            this.button_MostrarAbertos.Name = "button_MostrarAbertos";
            this.button_MostrarAbertos.Size = new System.Drawing.Size(121, 23);
            this.button_MostrarAbertos.TabIndex = 11;
            this.button_MostrarAbertos.Text = "Mostrar Abertos";
            this.button_MostrarAbertos.UseVisualStyleBackColor = true;
            this.button_MostrarAbertos.Click += new System.EventHandler(this.button_MostrarAbertos_Click);
            // 
            // button_Excluir
            // 
            this.button_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Excluir.Location = new System.Drawing.Point(133, 61);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir.TabIndex = 9;
            this.button_Excluir.Text = "Excluir";
            this.button_Excluir.UseVisualStyleBackColor = true;
            this.button_Excluir.Click += new System.EventHandler(this.button_Excluir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker_DataAbertura);
            this.panel1.Controls.Add(this.maskedTextBox_PercentualConclusao);
            this.panel1.Controls.Add(this.listBox_Prioridade);
            this.panel1.Controls.Add(this.textBox_Titulo);
            this.panel1.Controls.Add(this.label_DataAbertura);
            this.panel1.Controls.Add(this.label_Titulo);
            this.panel1.Controls.Add(this.label_PercentualConclusao);
            this.panel1.Controls.Add(this.label_Prioridade);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 224);
            this.panel1.TabIndex = 6;
            // 
            // dateTimePicker_DataAbertura
            // 
            this.dateTimePicker_DataAbertura.Location = new System.Drawing.Point(3, 119);
            this.dateTimePicker_DataAbertura.Name = "dateTimePicker_DataAbertura";
            this.dateTimePicker_DataAbertura.Size = new System.Drawing.Size(286, 20);
            this.dateTimePicker_DataAbertura.TabIndex = 8;
            // 
            // maskedTextBox_PercentualConclusao
            // 
            this.maskedTextBox_PercentualConclusao.Location = new System.Drawing.Point(69, 62);
            this.maskedTextBox_PercentualConclusao.Mask = "000%";
            this.maskedTextBox_PercentualConclusao.Name = "maskedTextBox_PercentualConclusao";
            this.maskedTextBox_PercentualConclusao.Size = new System.Drawing.Size(123, 20);
            this.maskedTextBox_PercentualConclusao.TabIndex = 7;
            this.maskedTextBox_PercentualConclusao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // listBox_Prioridade
            // 
            this.listBox_Prioridade.FormattingEnabled = true;
            this.listBox_Prioridade.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.listBox_Prioridade.Location = new System.Drawing.Point(24, 62);
            this.listBox_Prioridade.Name = "listBox_Prioridade";
            this.listBox_Prioridade.Size = new System.Drawing.Size(19, 43);
            this.listBox_Prioridade.TabIndex = 6;
            // 
            // textBox_Titulo
            // 
            this.textBox_Titulo.Location = new System.Drawing.Point(3, 21);
            this.textBox_Titulo.Name = "textBox_Titulo";
            this.textBox_Titulo.Size = new System.Drawing.Size(286, 20);
            this.textBox_Titulo.TabIndex = 2;
            // 
            // label_DataAbertura
            // 
            this.label_DataAbertura.AutoSize = true;
            this.label_DataAbertura.Location = new System.Drawing.Point(99, 103);
            this.label_DataAbertura.Name = "label_DataAbertura";
            this.label_DataAbertura.Size = new System.Drawing.Size(94, 13);
            this.label_DataAbertura.TabIndex = 5;
            this.label_DataAbertura.Text = "Data de Aberetura";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(108, 5);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(35, 13);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Text = "Título";
            // 
            // label_PercentualConclusao
            // 
            this.label_PercentualConclusao.AutoSize = true;
            this.label_PercentualConclusao.Location = new System.Drawing.Point(66, 46);
            this.label_PercentualConclusao.Name = "label_PercentualConclusao";
            this.label_PercentualConclusao.Size = new System.Drawing.Size(126, 13);
            this.label_PercentualConclusao.TabIndex = 4;
            this.label_PercentualConclusao.Text = "Percentual de Conclusão";
            // 
            // label_Prioridade
            // 
            this.label_Prioridade.AutoSize = true;
            this.label_Prioridade.Location = new System.Drawing.Point(6, 46);
            this.label_Prioridade.Name = "label_Prioridade";
            this.label_Prioridade.Size = new System.Drawing.Size(54, 13);
            this.label_Prioridade.TabIndex = 3;
            this.label_Prioridade.Text = "Prioridade";
            // 
            // dataGridViewTarefas
            // 
            this.dataGridViewTarefas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarefas.Location = new System.Drawing.Point(3, 233);
            this.dataGridViewTarefas.Name = "dataGridViewTarefas";
            this.dataGridViewTarefas.Size = new System.Drawing.Size(603, 250);
            this.dataGridViewTarefas.TabIndex = 0;
            this.dataGridViewTarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTarefas_CellContentClick);
            // 
            // UserControlTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Background);
            this.Name = "UserControlTarefas";
            this.Size = new System.Drawing.Size(615, 492);
            this.panel_Background.ResumeLayout(false);
            this.panel_Botoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Background;
        private System.Windows.Forms.DataGridView dataGridViewTarefas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Titulo;
        private System.Windows.Forms.Label label_DataAbertura;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_PercentualConclusao;
        private System.Windows.Forms.Label label_Prioridade;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataAbertura;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PercentualConclusao;
        private System.Windows.Forms.ListBox listBox_Prioridade;
        private System.Windows.Forms.Panel panel_Botoes;
        private System.Windows.Forms.Button button_MostrarConcludos;
        private System.Windows.Forms.Button button_ConcluirTarefa;
        private System.Windows.Forms.Button button_Inserir;
        private System.Windows.Forms.Button button_MostrarTodos;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_MostrarAbertos;
        private System.Windows.Forms.Button button_Excluir;
    }
}
