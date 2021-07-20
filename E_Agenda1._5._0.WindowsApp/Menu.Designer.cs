
namespace E_Agenda1._5._0.WindowsApp
{
    partial class Menu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageTarefas = new System.Windows.Forms.TabPage();
            this.textBox_Titulo = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DataAbertura = new System.Windows.Forms.DateTimePicker();
            this.panel_Botoes = new System.Windows.Forms.Panel();
            this.button_MostrarConcludos = new System.Windows.Forms.Button();
            this.button_ConcluirTarefa = new System.Windows.Forms.Button();
            this.button_Inserir = new System.Windows.Forms.Button();
            this.button_MostrarTodos = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_MostrarAbertos = new System.Windows.Forms.Button();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.maskedTextBox_PercentualConclusao = new System.Windows.Forms.MaskedTextBox();
            this.listBox_Prioridade = new System.Windows.Forms.ListBox();
            this.dataGridViewTarefas = new System.Windows.Forms.DataGridView();
            this.label_DataAbertura = new System.Windows.Forms.Label();
            this.label_Prioridade = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_PercentualConclusao = new System.Windows.Forms.Label();
            this.tabPageContatos = new System.Windows.Forms.TabPage();
            this.textBox_Cargo_Contatos = new System.Windows.Forms.TextBox();
            this.textBox_Empresa_Contatos = new System.Windows.Forms.TextBox();
            this.textBox_Email_Contatos = new System.Windows.Forms.TextBox();
            this.textBox_Nome_Contatos = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Telefone_Contatos = new System.Windows.Forms.MaskedTextBox();
            this.label_Cargo_Contatos = new System.Windows.Forms.Label();
            this.label_Empresa_Contatos = new System.Windows.Forms.Label();
            this.label_Email_Contatos = new System.Windows.Forms.Label();
            this.label_Telefone_Contatos = new System.Windows.Forms.Label();
            this.label_Nome_Contatos = new System.Windows.Forms.Label();
            this.button_Excluir_Contatos = new System.Windows.Forms.Button();
            this.button_Editar_Contatos = new System.Windows.Forms.Button();
            this.button_Inserir_Contatos = new System.Windows.Forms.Button();
            this.dataGridViewContatos = new System.Windows.Forms.DataGridView();
            this.tabPageCompromissos = new System.Windows.Forms.TabPage();
            this.listBox_Contato_Compromissos = new System.Windows.Forms.ListBox();
            this.dateTimePicker_DataFinal_Compromissos = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DataInicio_Compromissos = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_HoraFinal_Compromissos = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_HoraInicio_Compromissos = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Local_Compromissos = new System.Windows.Forms.TextBox();
            this.textBox_Assunto_Compromissos = new System.Windows.Forms.TextBox();
            this.label_HoraFinal_Compromissos = new System.Windows.Forms.Label();
            this.label_HoraInicio_Compromissos = new System.Windows.Forms.Label();
            this.label_DataFinal_Compromissos = new System.Windows.Forms.Label();
            this.label_DataInicio_Compromissos = new System.Windows.Forms.Label();
            this.label_Contato_Compromissos = new System.Windows.Forms.Label();
            this.label_local_Compromissos = new System.Windows.Forms.Label();
            this.label_Assunto_Compromissos = new System.Windows.Forms.Label();
            this.button_Excluir_Compromissos = new System.Windows.Forms.Button();
            this.button_Editar_Compromissos = new System.Windows.Forms.Button();
            this.button_Inserir_Compromissos = new System.Windows.Forms.Button();
            this.dataGridViewCompromissos = new System.Windows.Forms.DataGridView();
            this.button_ListarTodos_Compromissos = new System.Windows.Forms.Button();
            this.button_ListarPassados_Compromissos = new System.Windows.Forms.Button();
            this.button_ListarFuturos_Compromissos = new System.Windows.Forms.Button();
            this.tabControlMenu.SuspendLayout();
            this.tabPageTarefas.SuspendLayout();
            this.panel_Botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).BeginInit();
            this.tabPageContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).BeginInit();
            this.tabPageCompromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMenu.Controls.Add(this.tabPageTarefas);
            this.tabControlMenu.Controls.Add(this.tabPageContatos);
            this.tabControlMenu.Controls.Add(this.tabPageCompromissos);
            this.tabControlMenu.Location = new System.Drawing.Point(12, 12);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(732, 549);
            this.tabControlMenu.TabIndex = 2;
            // 
            // tabPageTarefas
            // 
            this.tabPageTarefas.Controls.Add(this.textBox_Titulo);
            this.tabPageTarefas.Controls.Add(this.dateTimePicker_DataAbertura);
            this.tabPageTarefas.Controls.Add(this.panel_Botoes);
            this.tabPageTarefas.Controls.Add(this.maskedTextBox_PercentualConclusao);
            this.tabPageTarefas.Controls.Add(this.listBox_Prioridade);
            this.tabPageTarefas.Controls.Add(this.dataGridViewTarefas);
            this.tabPageTarefas.Controls.Add(this.label_DataAbertura);
            this.tabPageTarefas.Controls.Add(this.label_Prioridade);
            this.tabPageTarefas.Controls.Add(this.label_Titulo);
            this.tabPageTarefas.Controls.Add(this.label_PercentualConclusao);
            this.tabPageTarefas.Location = new System.Drawing.Point(4, 22);
            this.tabPageTarefas.Name = "tabPageTarefas";
            this.tabPageTarefas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTarefas.Size = new System.Drawing.Size(724, 523);
            this.tabPageTarefas.TabIndex = 0;
            this.tabPageTarefas.Text = "Tarefas";
            this.tabPageTarefas.UseVisualStyleBackColor = true;
            // 
            // textBox_Titulo
            // 
            this.textBox_Titulo.Location = new System.Drawing.Point(6, 25);
            this.textBox_Titulo.Name = "textBox_Titulo";
            this.textBox_Titulo.Size = new System.Drawing.Size(286, 20);
            this.textBox_Titulo.TabIndex = 18;
            // 
            // dateTimePicker_DataAbertura
            // 
            this.dateTimePicker_DataAbertura.Location = new System.Drawing.Point(6, 121);
            this.dateTimePicker_DataAbertura.Name = "dateTimePicker_DataAbertura";
            this.dateTimePicker_DataAbertura.Size = new System.Drawing.Size(286, 20);
            this.dateTimePicker_DataAbertura.TabIndex = 8;
            // 
            // panel_Botoes
            // 
            this.panel_Botoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Botoes.Controls.Add(this.button_MostrarConcludos);
            this.panel_Botoes.Controls.Add(this.button_ConcluirTarefa);
            this.panel_Botoes.Controls.Add(this.button_Inserir);
            this.panel_Botoes.Controls.Add(this.button_MostrarTodos);
            this.panel_Botoes.Controls.Add(this.button_editar);
            this.panel_Botoes.Controls.Add(this.button_MostrarAbertos);
            this.panel_Botoes.Controls.Add(this.button_Excluir);
            this.panel_Botoes.Location = new System.Drawing.Point(506, 6);
            this.panel_Botoes.Name = "panel_Botoes";
            this.panel_Botoes.Size = new System.Drawing.Size(212, 121);
            this.panel_Botoes.TabIndex = 17;
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
            // maskedTextBox_PercentualConclusao
            // 
            this.maskedTextBox_PercentualConclusao.Location = new System.Drawing.Point(72, 64);
            this.maskedTextBox_PercentualConclusao.Mask = "000";
            this.maskedTextBox_PercentualConclusao.Name = "maskedTextBox_PercentualConclusao";
            this.maskedTextBox_PercentualConclusao.Size = new System.Drawing.Size(123, 20);
            this.maskedTextBox_PercentualConclusao.TabIndex = 7;
            // 
            // listBox_Prioridade
            // 
            this.listBox_Prioridade.FormattingEnabled = true;
            this.listBox_Prioridade.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.listBox_Prioridade.Location = new System.Drawing.Point(27, 64);
            this.listBox_Prioridade.Name = "listBox_Prioridade";
            this.listBox_Prioridade.Size = new System.Drawing.Size(19, 43);
            this.listBox_Prioridade.TabIndex = 6;
            // 
            // dataGridViewTarefas
            // 
            this.dataGridViewTarefas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarefas.Location = new System.Drawing.Point(6, 267);
            this.dataGridViewTarefas.Name = "dataGridViewTarefas";
            this.dataGridViewTarefas.Size = new System.Drawing.Size(712, 250);
            this.dataGridViewTarefas.TabIndex = 15;
            this.dataGridViewTarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTarefas_CellContentClick);
            // 
            // label_DataAbertura
            // 
            this.label_DataAbertura.AutoSize = true;
            this.label_DataAbertura.Location = new System.Drawing.Point(102, 105);
            this.label_DataAbertura.Name = "label_DataAbertura";
            this.label_DataAbertura.Size = new System.Drawing.Size(94, 13);
            this.label_DataAbertura.TabIndex = 5;
            this.label_DataAbertura.Text = "Data de Aberetura";
            // 
            // label_Prioridade
            // 
            this.label_Prioridade.AutoSize = true;
            this.label_Prioridade.Location = new System.Drawing.Point(9, 48);
            this.label_Prioridade.Name = "label_Prioridade";
            this.label_Prioridade.Size = new System.Drawing.Size(54, 13);
            this.label_Prioridade.TabIndex = 3;
            this.label_Prioridade.Text = "Prioridade";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(111, 7);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(35, 13);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Text = "Título";
            // 
            // label_PercentualConclusao
            // 
            this.label_PercentualConclusao.AutoSize = true;
            this.label_PercentualConclusao.Location = new System.Drawing.Point(69, 48);
            this.label_PercentualConclusao.Name = "label_PercentualConclusao";
            this.label_PercentualConclusao.Size = new System.Drawing.Size(126, 13);
            this.label_PercentualConclusao.TabIndex = 4;
            this.label_PercentualConclusao.Text = "Percentual de Conclusão";
            // 
            // tabPageContatos
            // 
            this.tabPageContatos.Controls.Add(this.textBox_Cargo_Contatos);
            this.tabPageContatos.Controls.Add(this.textBox_Empresa_Contatos);
            this.tabPageContatos.Controls.Add(this.textBox_Email_Contatos);
            this.tabPageContatos.Controls.Add(this.textBox_Nome_Contatos);
            this.tabPageContatos.Controls.Add(this.maskedTextBox_Telefone_Contatos);
            this.tabPageContatos.Controls.Add(this.label_Cargo_Contatos);
            this.tabPageContatos.Controls.Add(this.label_Empresa_Contatos);
            this.tabPageContatos.Controls.Add(this.label_Email_Contatos);
            this.tabPageContatos.Controls.Add(this.label_Telefone_Contatos);
            this.tabPageContatos.Controls.Add(this.label_Nome_Contatos);
            this.tabPageContatos.Controls.Add(this.button_Excluir_Contatos);
            this.tabPageContatos.Controls.Add(this.button_Editar_Contatos);
            this.tabPageContatos.Controls.Add(this.button_Inserir_Contatos);
            this.tabPageContatos.Controls.Add(this.dataGridViewContatos);
            this.tabPageContatos.Location = new System.Drawing.Point(4, 22);
            this.tabPageContatos.Name = "tabPageContatos";
            this.tabPageContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContatos.Size = new System.Drawing.Size(724, 523);
            this.tabPageContatos.TabIndex = 1;
            this.tabPageContatos.Text = "Contatos";
            this.tabPageContatos.UseVisualStyleBackColor = true;
            // 
            // textBox_Cargo_Contatos
            // 
            this.textBox_Cargo_Contatos.Location = new System.Drawing.Point(12, 192);
            this.textBox_Cargo_Contatos.Name = "textBox_Cargo_Contatos";
            this.textBox_Cargo_Contatos.Size = new System.Drawing.Size(228, 20);
            this.textBox_Cargo_Contatos.TabIndex = 13;
            // 
            // textBox_Empresa_Contatos
            // 
            this.textBox_Empresa_Contatos.Location = new System.Drawing.Point(12, 155);
            this.textBox_Empresa_Contatos.Name = "textBox_Empresa_Contatos";
            this.textBox_Empresa_Contatos.Size = new System.Drawing.Size(228, 20);
            this.textBox_Empresa_Contatos.TabIndex = 12;
            // 
            // textBox_Email_Contatos
            // 
            this.textBox_Email_Contatos.Location = new System.Drawing.Point(12, 116);
            this.textBox_Email_Contatos.Name = "textBox_Email_Contatos";
            this.textBox_Email_Contatos.Size = new System.Drawing.Size(228, 20);
            this.textBox_Email_Contatos.TabIndex = 11;
            // 
            // textBox_Nome_Contatos
            // 
            this.textBox_Nome_Contatos.Location = new System.Drawing.Point(12, 31);
            this.textBox_Nome_Contatos.Name = "textBox_Nome_Contatos";
            this.textBox_Nome_Contatos.Size = new System.Drawing.Size(228, 20);
            this.textBox_Nome_Contatos.TabIndex = 10;
            // 
            // maskedTextBox_Telefone_Contatos
            // 
            this.maskedTextBox_Telefone_Contatos.Location = new System.Drawing.Point(76, 73);
            this.maskedTextBox_Telefone_Contatos.Mask = "00000-0000";
            this.maskedTextBox_Telefone_Contatos.Name = "maskedTextBox_Telefone_Contatos";
            this.maskedTextBox_Telefone_Contatos.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Telefone_Contatos.TabIndex = 9;
            this.maskedTextBox_Telefone_Contatos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label_Cargo_Contatos
            // 
            this.label_Cargo_Contatos.AutoSize = true;
            this.label_Cargo_Contatos.Location = new System.Drawing.Point(109, 176);
            this.label_Cargo_Contatos.Name = "label_Cargo_Contatos";
            this.label_Cargo_Contatos.Size = new System.Drawing.Size(35, 13);
            this.label_Cargo_Contatos.TabIndex = 8;
            this.label_Cargo_Contatos.Text = "Cargo";
            // 
            // label_Empresa_Contatos
            // 
            this.label_Empresa_Contatos.AutoSize = true;
            this.label_Empresa_Contatos.Location = new System.Drawing.Point(102, 137);
            this.label_Empresa_Contatos.Name = "label_Empresa_Contatos";
            this.label_Empresa_Contatos.Size = new System.Drawing.Size(48, 13);
            this.label_Empresa_Contatos.TabIndex = 7;
            this.label_Empresa_Contatos.Text = "Empresa";
            // 
            // label_Email_Contatos
            // 
            this.label_Email_Contatos.AutoSize = true;
            this.label_Email_Contatos.Location = new System.Drawing.Point(108, 96);
            this.label_Email_Contatos.Name = "label_Email_Contatos";
            this.label_Email_Contatos.Size = new System.Drawing.Size(36, 13);
            this.label_Email_Contatos.TabIndex = 6;
            this.label_Email_Contatos.Text = "E-Mail";
            // 
            // label_Telefone_Contatos
            // 
            this.label_Telefone_Contatos.AutoSize = true;
            this.label_Telefone_Contatos.Location = new System.Drawing.Point(102, 57);
            this.label_Telefone_Contatos.Name = "label_Telefone_Contatos";
            this.label_Telefone_Contatos.Size = new System.Drawing.Size(49, 13);
            this.label_Telefone_Contatos.TabIndex = 5;
            this.label_Telefone_Contatos.Text = "Telefone";
            // 
            // label_Nome_Contatos
            // 
            this.label_Nome_Contatos.AutoSize = true;
            this.label_Nome_Contatos.Location = new System.Drawing.Point(109, 14);
            this.label_Nome_Contatos.Name = "label_Nome_Contatos";
            this.label_Nome_Contatos.Size = new System.Drawing.Size(35, 13);
            this.label_Nome_Contatos.TabIndex = 4;
            this.label_Nome_Contatos.Text = "Nome";
            // 
            // button_Excluir_Contatos
            // 
            this.button_Excluir_Contatos.Location = new System.Drawing.Point(577, 73);
            this.button_Excluir_Contatos.Name = "button_Excluir_Contatos";
            this.button_Excluir_Contatos.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir_Contatos.TabIndex = 3;
            this.button_Excluir_Contatos.Text = "Excluir";
            this.button_Excluir_Contatos.UseVisualStyleBackColor = true;
            this.button_Excluir_Contatos.Click += new System.EventHandler(this.button_Excluir_Contatos_Click);
            // 
            // button_Editar_Contatos
            // 
            this.button_Editar_Contatos.Location = new System.Drawing.Point(577, 44);
            this.button_Editar_Contatos.Name = "button_Editar_Contatos";
            this.button_Editar_Contatos.Size = new System.Drawing.Size(75, 23);
            this.button_Editar_Contatos.TabIndex = 2;
            this.button_Editar_Contatos.Text = "Editar";
            this.button_Editar_Contatos.UseVisualStyleBackColor = true;
            this.button_Editar_Contatos.Click += new System.EventHandler(this.button_Editar_Contatos_Click);
            // 
            // button_Inserir_Contatos
            // 
            this.button_Inserir_Contatos.Location = new System.Drawing.Point(577, 15);
            this.button_Inserir_Contatos.Name = "button_Inserir_Contatos";
            this.button_Inserir_Contatos.Size = new System.Drawing.Size(75, 23);
            this.button_Inserir_Contatos.TabIndex = 1;
            this.button_Inserir_Contatos.Text = "Inserir";
            this.button_Inserir_Contatos.UseVisualStyleBackColor = true;
            this.button_Inserir_Contatos.Click += new System.EventHandler(this.button_Inserir_Contatos_Click);
            // 
            // dataGridViewContatos
            // 
            this.dataGridViewContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContatos.Location = new System.Drawing.Point(0, 222);
            this.dataGridViewContatos.Name = "dataGridViewContatos";
            this.dataGridViewContatos.Size = new System.Drawing.Size(660, 301);
            this.dataGridViewContatos.TabIndex = 0;
            this.dataGridViewContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContatos_CellContentClick);
            // 
            // tabPageCompromissos
            // 
            this.tabPageCompromissos.Controls.Add(this.button_ListarFuturos_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.button_ListarPassados_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.button_ListarTodos_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.listBox_Contato_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.dateTimePicker_DataFinal_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.dateTimePicker_DataInicio_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.maskedTextBox_HoraFinal_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.maskedTextBox_HoraInicio_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.textBox_Local_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.textBox_Assunto_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.label_HoraFinal_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.label_HoraInicio_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.label_DataFinal_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.label_DataInicio_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.label_Contato_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.label_local_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.label_Assunto_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.button_Excluir_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.button_Editar_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.button_Inserir_Compromissos);
            this.tabPageCompromissos.Controls.Add(this.dataGridViewCompromissos);
            this.tabPageCompromissos.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompromissos.Name = "tabPageCompromissos";
            this.tabPageCompromissos.Size = new System.Drawing.Size(724, 523);
            this.tabPageCompromissos.TabIndex = 2;
            this.tabPageCompromissos.Text = "Compromissos";
            this.tabPageCompromissos.UseVisualStyleBackColor = true;
            // 
            // listBox_Contato_Compromissos
            // 
            this.listBox_Contato_Compromissos.FormattingEnabled = true;
            this.listBox_Contato_Compromissos.Location = new System.Drawing.Point(2, 191);
            this.listBox_Contato_Compromissos.Name = "listBox_Contato_Compromissos";
            this.listBox_Contato_Compromissos.Size = new System.Drawing.Size(279, 17);
            this.listBox_Contato_Compromissos.TabIndex = 17;
            // 
            // dateTimePicker_DataFinal_Compromissos
            // 
            this.dateTimePicker_DataFinal_Compromissos.Location = new System.Drawing.Point(0, 144);
            this.dateTimePicker_DataFinal_Compromissos.Name = "dateTimePicker_DataFinal_Compromissos";
            this.dateTimePicker_DataFinal_Compromissos.Size = new System.Drawing.Size(282, 20);
            this.dateTimePicker_DataFinal_Compromissos.TabIndex = 16;
            // 
            // dateTimePicker_DataInicio_Compromissos
            // 
            this.dateTimePicker_DataInicio_Compromissos.Location = new System.Drawing.Point(3, 105);
            this.dateTimePicker_DataInicio_Compromissos.Name = "dateTimePicker_DataInicio_Compromissos";
            this.dateTimePicker_DataInicio_Compromissos.Size = new System.Drawing.Size(279, 20);
            this.dateTimePicker_DataInicio_Compromissos.TabIndex = 15;
            // 
            // maskedTextBox_HoraFinal_Compromissos
            // 
            this.maskedTextBox_HoraFinal_Compromissos.Location = new System.Drawing.Point(151, 62);
            this.maskedTextBox_HoraFinal_Compromissos.Mask = "00:00";
            this.maskedTextBox_HoraFinal_Compromissos.Name = "maskedTextBox_HoraFinal_Compromissos";
            this.maskedTextBox_HoraFinal_Compromissos.Size = new System.Drawing.Size(56, 20);
            this.maskedTextBox_HoraFinal_Compromissos.TabIndex = 14;
            this.maskedTextBox_HoraFinal_Compromissos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox_HoraInicio_Compromissos
            // 
            this.maskedTextBox_HoraInicio_Compromissos.Location = new System.Drawing.Point(65, 62);
            this.maskedTextBox_HoraInicio_Compromissos.Mask = "00:00";
            this.maskedTextBox_HoraInicio_Compromissos.Name = "maskedTextBox_HoraInicio_Compromissos";
            this.maskedTextBox_HoraInicio_Compromissos.Size = new System.Drawing.Size(56, 20);
            this.maskedTextBox_HoraInicio_Compromissos.TabIndex = 13;
            this.maskedTextBox_HoraInicio_Compromissos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Local_Compromissos
            // 
            this.textBox_Local_Compromissos.Location = new System.Drawing.Point(141, 20);
            this.textBox_Local_Compromissos.Name = "textBox_Local_Compromissos";
            this.textBox_Local_Compromissos.Size = new System.Drawing.Size(141, 20);
            this.textBox_Local_Compromissos.TabIndex = 12;
            // 
            // textBox_Assunto_Compromissos
            // 
            this.textBox_Assunto_Compromissos.Location = new System.Drawing.Point(3, 20);
            this.textBox_Assunto_Compromissos.Name = "textBox_Assunto_Compromissos";
            this.textBox_Assunto_Compromissos.Size = new System.Drawing.Size(132, 20);
            this.textBox_Assunto_Compromissos.TabIndex = 11;
            // 
            // label_HoraFinal_Compromissos
            // 
            this.label_HoraFinal_Compromissos.AutoSize = true;
            this.label_HoraFinal_Compromissos.Location = new System.Drawing.Point(152, 46);
            this.label_HoraFinal_Compromissos.Name = "label_HoraFinal_Compromissos";
            this.label_HoraFinal_Compromissos.Size = new System.Drawing.Size(55, 13);
            this.label_HoraFinal_Compromissos.TabIndex = 10;
            this.label_HoraFinal_Compromissos.Text = "Hora Final";
            // 
            // label_HoraInicio_Compromissos
            // 
            this.label_HoraInicio_Compromissos.AutoSize = true;
            this.label_HoraInicio_Compromissos.Location = new System.Drawing.Point(64, 45);
            this.label_HoraInicio_Compromissos.Name = "label_HoraInicio_Compromissos";
            this.label_HoraInicio_Compromissos.Size = new System.Drawing.Size(59, 13);
            this.label_HoraInicio_Compromissos.TabIndex = 9;
            this.label_HoraInicio_Compromissos.Text = "Hora início";
            // 
            // label_DataFinal_Compromissos
            // 
            this.label_DataFinal_Compromissos.AutoSize = true;
            this.label_DataFinal_Compromissos.Location = new System.Drawing.Point(114, 128);
            this.label_DataFinal_Compromissos.Name = "label_DataFinal_Compromissos";
            this.label_DataFinal_Compromissos.Size = new System.Drawing.Size(55, 13);
            this.label_DataFinal_Compromissos.TabIndex = 8;
            this.label_DataFinal_Compromissos.Text = "Data Final";
            // 
            // label_DataInicio_Compromissos
            // 
            this.label_DataInicio_Compromissos.AutoSize = true;
            this.label_DataInicio_Compromissos.Location = new System.Drawing.Point(112, 89);
            this.label_DataInicio_Compromissos.Name = "label_DataInicio_Compromissos";
            this.label_DataInicio_Compromissos.Size = new System.Drawing.Size(60, 13);
            this.label_DataInicio_Compromissos.TabIndex = 7;
            this.label_DataInicio_Compromissos.Text = "Data Início";
            // 
            // label_Contato_Compromissos
            // 
            this.label_Contato_Compromissos.AutoSize = true;
            this.label_Contato_Compromissos.Location = new System.Drawing.Point(119, 175);
            this.label_Contato_Compromissos.Name = "label_Contato_Compromissos";
            this.label_Contato_Compromissos.Size = new System.Drawing.Size(44, 13);
            this.label_Contato_Compromissos.TabIndex = 6;
            this.label_Contato_Compromissos.Text = "Contato";
            // 
            // label_local_Compromissos
            // 
            this.label_local_Compromissos.AutoSize = true;
            this.label_local_Compromissos.Location = new System.Drawing.Point(200, 4);
            this.label_local_Compromissos.Name = "label_local_Compromissos";
            this.label_local_Compromissos.Size = new System.Drawing.Size(33, 13);
            this.label_local_Compromissos.TabIndex = 5;
            this.label_local_Compromissos.Text = "Local";
            // 
            // label_Assunto_Compromissos
            // 
            this.label_Assunto_Compromissos.AutoSize = true;
            this.label_Assunto_Compromissos.Location = new System.Drawing.Point(52, 4);
            this.label_Assunto_Compromissos.Name = "label_Assunto_Compromissos";
            this.label_Assunto_Compromissos.Size = new System.Drawing.Size(45, 13);
            this.label_Assunto_Compromissos.TabIndex = 4;
            this.label_Assunto_Compromissos.Text = "Assunto";
            // 
            // button_Excluir_Compromissos
            // 
            this.button_Excluir_Compromissos.Location = new System.Drawing.Point(646, 62);
            this.button_Excluir_Compromissos.Name = "button_Excluir_Compromissos";
            this.button_Excluir_Compromissos.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir_Compromissos.TabIndex = 3;
            this.button_Excluir_Compromissos.Text = "Excluir";
            this.button_Excluir_Compromissos.UseVisualStyleBackColor = true;
            this.button_Excluir_Compromissos.Click += new System.EventHandler(this.button_Excluir_Compromissos_Click);
            // 
            // button_Editar_Compromissos
            // 
            this.button_Editar_Compromissos.Location = new System.Drawing.Point(646, 33);
            this.button_Editar_Compromissos.Name = "button_Editar_Compromissos";
            this.button_Editar_Compromissos.Size = new System.Drawing.Size(75, 23);
            this.button_Editar_Compromissos.TabIndex = 2;
            this.button_Editar_Compromissos.Text = "Editar";
            this.button_Editar_Compromissos.UseVisualStyleBackColor = true;
            this.button_Editar_Compromissos.Click += new System.EventHandler(this.button_Editar_Compromissos_Click);
            // 
            // button_Inserir_Compromissos
            // 
            this.button_Inserir_Compromissos.Location = new System.Drawing.Point(646, 4);
            this.button_Inserir_Compromissos.Name = "button_Inserir_Compromissos";
            this.button_Inserir_Compromissos.Size = new System.Drawing.Size(75, 23);
            this.button_Inserir_Compromissos.TabIndex = 1;
            this.button_Inserir_Compromissos.Text = "Inserir";
            this.button_Inserir_Compromissos.UseVisualStyleBackColor = true;
            this.button_Inserir_Compromissos.Click += new System.EventHandler(this.button_Inserir_Compromissos_Click);
            // 
            // dataGridViewCompromissos
            // 
            this.dataGridViewCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompromissos.Location = new System.Drawing.Point(0, 222);
            this.dataGridViewCompromissos.Name = "dataGridViewCompromissos";
            this.dataGridViewCompromissos.Size = new System.Drawing.Size(721, 301);
            this.dataGridViewCompromissos.TabIndex = 0;
            this.dataGridViewCompromissos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompromissos_CellContentClick);
            // 
            // button_ListarTodos_Compromissos
            // 
            this.button_ListarTodos_Compromissos.Location = new System.Drawing.Point(536, 62);
            this.button_ListarTodos_Compromissos.Name = "button_ListarTodos_Compromissos";
            this.button_ListarTodos_Compromissos.Size = new System.Drawing.Size(104, 23);
            this.button_ListarTodos_Compromissos.TabIndex = 18;
            this.button_ListarTodos_Compromissos.Text = "ListarFuturos";
            this.button_ListarTodos_Compromissos.UseVisualStyleBackColor = true;
            this.button_ListarTodos_Compromissos.Click += new System.EventHandler(this.button_ListarTodos_Compromissos_Click);
            // 
            // button_ListarPassados_Compromissos
            // 
            this.button_ListarPassados_Compromissos.Location = new System.Drawing.Point(536, 33);
            this.button_ListarPassados_Compromissos.Name = "button_ListarPassados_Compromissos";
            this.button_ListarPassados_Compromissos.Size = new System.Drawing.Size(104, 23);
            this.button_ListarPassados_Compromissos.TabIndex = 19;
            this.button_ListarPassados_Compromissos.Text = "Listar Passados";
            this.button_ListarPassados_Compromissos.UseVisualStyleBackColor = true;
            this.button_ListarPassados_Compromissos.Click += new System.EventHandler(this.button_ListarPassados_Compromissos_Click);
            // 
            // button_ListarFuturos_Compromissos
            // 
            this.button_ListarFuturos_Compromissos.Location = new System.Drawing.Point(536, 4);
            this.button_ListarFuturos_Compromissos.Name = "button_ListarFuturos_Compromissos";
            this.button_ListarFuturos_Compromissos.Size = new System.Drawing.Size(104, 23);
            this.button_ListarFuturos_Compromissos.TabIndex = 20;
            this.button_ListarFuturos_Compromissos.Text = "Listar Futuros";
            this.button_ListarFuturos_Compromissos.UseVisualStyleBackColor = true;
            this.button_ListarFuturos_Compromissos.Click += new System.EventHandler(this.button_ListarFuturos_Compromissos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 573);
            this.Controls.Add(this.tabControlMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageTarefas.ResumeLayout(false);
            this.tabPageTarefas.PerformLayout();
            this.panel_Botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).EndInit();
            this.tabPageContatos.ResumeLayout(false);
            this.tabPageContatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).EndInit();
            this.tabPageCompromissos.ResumeLayout(false);
            this.tabPageCompromissos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromissos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageTarefas;
        private System.Windows.Forms.TabPage tabPageContatos;
        private System.Windows.Forms.DataGridView dataGridViewContatos;
        private System.Windows.Forms.Button button_Excluir_Contatos;
        private System.Windows.Forms.Button button_Editar_Contatos;
        private System.Windows.Forms.Button button_Inserir_Contatos;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Telefone_Contatos;
        private System.Windows.Forms.Label label_Cargo_Contatos;
        private System.Windows.Forms.Label label_Empresa_Contatos;
        private System.Windows.Forms.Label label_Email_Contatos;
        private System.Windows.Forms.Label label_Telefone_Contatos;
        private System.Windows.Forms.Label label_Nome_Contatos;
        private System.Windows.Forms.TextBox textBox_Cargo_Contatos;
        private System.Windows.Forms.TextBox textBox_Empresa_Contatos;
        private System.Windows.Forms.TextBox textBox_Email_Contatos;
        private System.Windows.Forms.TextBox textBox_Nome_Contatos;
        private System.Windows.Forms.TabPage tabPageCompromissos;
        private System.Windows.Forms.ListBox listBox_Contato_Compromissos;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataFinal_Compromissos;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataInicio_Compromissos;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_HoraFinal_Compromissos;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_HoraInicio_Compromissos;
        private System.Windows.Forms.TextBox textBox_Local_Compromissos;
        private System.Windows.Forms.TextBox textBox_Assunto_Compromissos;
        private System.Windows.Forms.Label label_HoraFinal_Compromissos;
        private System.Windows.Forms.Label label_HoraInicio_Compromissos;
        private System.Windows.Forms.Label label_DataFinal_Compromissos;
        private System.Windows.Forms.Label label_DataInicio_Compromissos;
        private System.Windows.Forms.Label label_Contato_Compromissos;
        private System.Windows.Forms.Label label_local_Compromissos;
        private System.Windows.Forms.Label label_Assunto_Compromissos;
        private System.Windows.Forms.Button button_Excluir_Compromissos;
        private System.Windows.Forms.Button button_Editar_Compromissos;
        private System.Windows.Forms.Button button_Inserir_Compromissos;
        private System.Windows.Forms.DataGridView dataGridViewCompromissos;
        private System.Windows.Forms.Panel panel_Botoes;
        private System.Windows.Forms.Button button_MostrarConcludos;
        private System.Windows.Forms.Button button_ConcluirTarefa;
        private System.Windows.Forms.Button button_Inserir;
        private System.Windows.Forms.Button button_MostrarTodos;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_MostrarAbertos;
        private System.Windows.Forms.Button button_Excluir;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataAbertura;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PercentualConclusao;
        private System.Windows.Forms.ListBox listBox_Prioridade;
        private System.Windows.Forms.Label label_DataAbertura;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_PercentualConclusao;
        private System.Windows.Forms.Label label_Prioridade;
        private System.Windows.Forms.DataGridView dataGridViewTarefas;
        private System.Windows.Forms.TextBox textBox_Titulo;
        private System.Windows.Forms.Button button_ListarFuturos_Compromissos;
        private System.Windows.Forms.Button button_ListarPassados_Compromissos;
        private System.Windows.Forms.Button button_ListarTodos_Compromissos;
    }
}