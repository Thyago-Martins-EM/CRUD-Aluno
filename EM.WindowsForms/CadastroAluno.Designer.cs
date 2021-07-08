
namespace EM.WindowsForms
{
    partial class CadastroAluno
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoCPF = new System.Windows.Forms.TextBox();
            this.textoMatricula = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.textoPesquisa = new System.Windows.Forms.TextBox();
            this.botaoPesquisa = new System.Windows.Forms.Button();
            this.gridViewAluno = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoCPF);
            this.groupBox1.Controls.Add(this.textoMatricula);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.comboGenero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.botaoAdicionar);
            this.groupBox1.Controls.Add(this.botaoLimpar);
            this.groupBox1.Controls.Add(this.textoNome);
            this.groupBox1.Location = new System.Drawing.Point(9, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(543, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textoCPF
            // 
            this.textoCPF.Location = new System.Drawing.Point(274, 74);
            this.textoCPF.Margin = new System.Windows.Forms.Padding(2);
            this.textoCPF.MaxLength = 11;
            this.textoCPF.Name = "textoCPF";
            this.textoCPF.Size = new System.Drawing.Size(122, 20);
            this.textoCPF.TabIndex = 5;
            this.textoCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoSoComNumeros);
            // 
            // textoMatricula
            // 
            this.textoMatricula.Location = new System.Drawing.Point(4, 28);
            this.textoMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.textoMatricula.MaxLength = 9;
            this.textoMatricula.Name = "textoMatricula";
            this.textoMatricula.Size = new System.Drawing.Size(131, 20);
            this.textoMatricula.TabIndex = 1;
            this.textoMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textoMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoSoComNumeros);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(149, 75);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox1_MouseClick);
            // 
            // comboGenero
            // 
            this.comboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Location = new System.Drawing.Point(5, 73);
            this.comboGenero.Margin = new System.Windows.Forms.Padding(2);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(130, 21);
            this.comboGenero.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(4, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Matrícula";
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(476, 74);
            this.botaoAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(67, 21);
            this.botaoAdicionar.TabIndex = 6;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(400, 74);
            this.botaoLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(73, 21);
            this.botaoLimpar.TabIndex = 5;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // textoNome
            // 
            this.textoNome.Location = new System.Drawing.Point(149, 28);
            this.textoNome.Margin = new System.Windows.Forms.Padding(2);
            this.textoNome.MaxLength = 100;
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(386, 20);
            this.textoNome.TabIndex = 2;
            // 
            // textoPesquisa
            // 
            this.textoPesquisa.Location = new System.Drawing.Point(9, 125);
            this.textoPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.textoPesquisa.MaxLength = 100;
            this.textoPesquisa.Name = "textoPesquisa";
            this.textoPesquisa.Size = new System.Drawing.Size(472, 20);
            this.textoPesquisa.TabIndex = 7;
            // 
            // botaoPesquisa
            // 
            this.botaoPesquisa.Location = new System.Drawing.Point(485, 124);
            this.botaoPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.botaoPesquisa.Name = "botaoPesquisa";
            this.botaoPesquisa.Size = new System.Drawing.Size(67, 21);
            this.botaoPesquisa.TabIndex = 8;
            this.botaoPesquisa.Text = "Pesquisar";
            this.botaoPesquisa.UseVisualStyleBackColor = true;
            this.botaoPesquisa.Click += new System.EventHandler(this.botaoPesquisa_Click);
            // 
            // gridViewAluno
            // 
            this.gridViewAluno.AllowUserToAddRows = false;
            this.gridViewAluno.AllowUserToOrderColumns = true;
            this.gridViewAluno.AllowUserToResizeColumns = false;
            this.gridViewAluno.AllowUserToResizeRows = false;
            this.gridViewAluno.AutoGenerateColumns = false;
            this.gridViewAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn});
            this.gridViewAluno.DataSource = this.alunoBindingSource;
            this.gridViewAluno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewAluno.EnableHeadersVisualStyles = false;
            this.gridViewAluno.Location = new System.Drawing.Point(9, 158);
            this.gridViewAluno.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewAluno.Name = "gridViewAluno";
            this.gridViewAluno.RowHeadersVisible = false;
            this.gridViewAluno.RowHeadersWidth = 51;
            this.gridViewAluno.RowTemplate.Height = 24;
            this.gridViewAluno.Size = new System.Drawing.Size(543, 112);
            this.gridViewAluno.TabIndex = 11;
            this.gridViewAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewAluno_CellContentClick);
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.matriculaDataGridViewTextBoxColumn.Width = 55;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sexoDataGridViewTextBoxColumn.Width = 70;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nascimentoDataGridViewTextBoxColumn.Width = 95;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(EM.Domain.Aluno);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(409, 283);
            this.botaoEditar.Margin = new System.Windows.Forms.Padding(2);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(73, 21);
            this.botaoEditar.TabIndex = 9;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(485, 283);
            this.botaoExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(67, 21);
            this.botaoExcluir.TabIndex = 10;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Novo Aluno";
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.gridViewAluno);
            this.Controls.Add(this.botaoPesquisa);
            this.Controls.Add(this.textoPesquisa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroAluno";
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.TextBox textoPesquisa;
        private System.Windows.Forms.Button botaoPesquisa;
        private System.Windows.Forms.DataGridView gridViewAluno;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textoCPF;
        private System.Windows.Forms.TextBox textoMatricula;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
    }
}

