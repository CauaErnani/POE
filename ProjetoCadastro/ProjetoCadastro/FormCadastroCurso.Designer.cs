namespace ProjetoCadastro
{
    partial class FormCadastroCurso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCurso));
            TabControlCadastroConsultaCurso = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastroCurso = new TabPage();
            btnCancelarCurso = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvarCurso = new ReaLTaiizor.Controls.MaterialButton();
            txtPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtArea = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDuracao = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsultaCurso = new TabPage();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            mlvCursos = new ReaLTaiizor.Controls.MaterialListView();
            imageList1 = new ImageList(components);
            TabControlCadastroConsultaCurso.SuspendLayout();
            tabPageCadastroCurso.SuspendLayout();
            tabPageConsultaCurso.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastroConsultaCurso
            // 
            TabControlCadastroConsultaCurso.Controls.Add(tabPageCadastroCurso);
            TabControlCadastroConsultaCurso.Controls.Add(tabPageConsultaCurso);
            TabControlCadastroConsultaCurso.Depth = 0;
            TabControlCadastroConsultaCurso.Dock = DockStyle.Fill;
            TabControlCadastroConsultaCurso.ImageList = imageList1;
            TabControlCadastroConsultaCurso.Location = new Point(3, 48);
            TabControlCadastroConsultaCurso.Margin = new Padding(3, 2, 3, 2);
            TabControlCadastroConsultaCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastroConsultaCurso.Multiline = true;
            TabControlCadastroConsultaCurso.Name = "TabControlCadastroConsultaCurso";
            TabControlCadastroConsultaCurso.SelectedIndex = 0;
            TabControlCadastroConsultaCurso.Size = new Size(694, 288);
            TabControlCadastroConsultaCurso.TabIndex = 0;
            // 
            // tabPageCadastroCurso
            // 
            tabPageCadastroCurso.Controls.Add(btnCancelarCurso);
            tabPageCadastroCurso.Controls.Add(btnSalvarCurso);
            tabPageCadastroCurso.Controls.Add(txtPeriodo);
            tabPageCadastroCurso.Controls.Add(txtArea);
            tabPageCadastroCurso.Controls.Add(txtDuracao);
            tabPageCadastroCurso.Controls.Add(txtNivel);
            tabPageCadastroCurso.Controls.Add(txtNome);
            tabPageCadastroCurso.Controls.Add(txtCodigo);
            tabPageCadastroCurso.ImageKey = "form.png";
            tabPageCadastroCurso.Location = new Point(4, 31);
            tabPageCadastroCurso.Margin = new Padding(3, 2, 3, 2);
            tabPageCadastroCurso.Name = "tabPageCadastroCurso";
            tabPageCadastroCurso.Padding = new Padding(3, 2, 3, 2);
            tabPageCadastroCurso.Size = new Size(686, 253);
            tabPageCadastroCurso.TabIndex = 0;
            tabPageCadastroCurso.Text = "Cadastro";
            tabPageCadastroCurso.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCurso
            // 
            btnCancelarCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelarCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelarCurso.Depth = 0;
            btnCancelarCurso.HighEmphasis = true;
            btnCancelarCurso.Icon = null;
            btnCancelarCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelarCurso.Location = new Point(482, 224);
            btnCancelarCurso.Margin = new Padding(4);
            btnCancelarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelarCurso.Name = "btnCancelarCurso";
            btnCancelarCurso.NoAccentTextColor = Color.Empty;
            btnCancelarCurso.Size = new Size(96, 36);
            btnCancelarCurso.TabIndex = 28;
            btnCancelarCurso.Text = "Cancelar";
            btnCancelarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelarCurso.UseAccentColor = false;
            btnCancelarCurso.UseVisualStyleBackColor = true;
            btnCancelarCurso.Click += btnCancelarCurso_Click;
            // 
            // btnSalvarCurso
            // 
            btnSalvarCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvarCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvarCurso.Depth = 0;
            btnSalvarCurso.HighEmphasis = true;
            btnSalvarCurso.Icon = null;
            btnSalvarCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvarCurso.Location = new Point(573, 224);
            btnSalvarCurso.Margin = new Padding(4);
            btnSalvarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvarCurso.Name = "btnSalvarCurso";
            btnSalvarCurso.NoAccentTextColor = Color.Empty;
            btnSalvarCurso.Size = new Size(76, 36);
            btnSalvarCurso.TabIndex = 27;
            btnSalvarCurso.Text = "Salvar";
            btnSalvarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvarCurso.UseAccentColor = false;
            btnSalvarCurso.UseVisualStyleBackColor = true;
            btnSalvarCurso.Click += btnSalvarCurso_Click;
            // 
            // txtPeriodo
            // 
            txtPeriodo.AutoResize = false;
            txtPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            txtPeriodo.Depth = 0;
            txtPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            txtPeriodo.DropDownHeight = 174;
            txtPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPeriodo.DropDownWidth = 121;
            txtPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtPeriodo.FormattingEnabled = true;
            txtPeriodo.Hint = "Período";
            txtPeriodo.IntegralHeight = false;
            txtPeriodo.ItemHeight = 43;
            txtPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            txtPeriodo.Location = new Point(365, 172);
            txtPeriodo.Margin = new Padding(3, 2, 3, 2);
            txtPeriodo.MaxDropDownItems = 4;
            txtPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(275, 49);
            txtPeriodo.StartIndex = 0;
            txtPeriodo.TabIndex = 26;
            // 
            // txtArea
            // 
            txtArea.AutoResize = false;
            txtArea.BackColor = Color.FromArgb(255, 255, 255);
            txtArea.Depth = 0;
            txtArea.DrawMode = DrawMode.OwnerDrawVariable;
            txtArea.DropDownHeight = 174;
            txtArea.DropDownStyle = ComboBoxStyle.DropDownList;
            txtArea.DropDownWidth = 121;
            txtArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtArea.FormattingEnabled = true;
            txtArea.Hint = "Área";
            txtArea.IntegralHeight = false;
            txtArea.ItemHeight = 43;
            txtArea.Items.AddRange(new object[] { "Administração", "Industria", "Informática", "Licencitura" });
            txtArea.Location = new Point(45, 172);
            txtArea.Margin = new Padding(3, 2, 3, 2);
            txtArea.MaxDropDownItems = 4;
            txtArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(302, 49);
            txtArea.StartIndex = 0;
            txtArea.TabIndex = 25;
            // 
            // txtDuracao
            // 
            txtDuracao.AutoResize = false;
            txtDuracao.BackColor = Color.FromArgb(255, 255, 255);
            txtDuracao.Depth = 0;
            txtDuracao.DrawMode = DrawMode.OwnerDrawVariable;
            txtDuracao.DropDownHeight = 174;
            txtDuracao.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDuracao.DropDownWidth = 121;
            txtDuracao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtDuracao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtDuracao.FormattingEnabled = true;
            txtDuracao.Hint = "Duração";
            txtDuracao.IntegralHeight = false;
            txtDuracao.ItemHeight = 43;
            txtDuracao.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            txtDuracao.Location = new Point(365, 122);
            txtDuracao.Margin = new Padding(3, 2, 3, 2);
            txtDuracao.MaxDropDownItems = 4;
            txtDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(275, 49);
            txtDuracao.StartIndex = 0;
            txtDuracao.TabIndex = 24;
            // 
            // txtNivel
            // 
            txtNivel.AutoResize = false;
            txtNivel.BackColor = Color.FromArgb(255, 255, 255);
            txtNivel.Depth = 0;
            txtNivel.DrawMode = DrawMode.OwnerDrawVariable;
            txtNivel.DropDownHeight = 174;
            txtNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNivel.DropDownWidth = 121;
            txtNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtNivel.FormattingEnabled = true;
            txtNivel.Hint = "Nível";
            txtNivel.IntegralHeight = false;
            txtNivel.ItemHeight = 43;
            txtNivel.Items.AddRange(new object[] { "Superior", "Técnico" });
            txtNivel.Location = new Point(45, 122);
            txtNivel.Margin = new Padding(3, 2, 3, 2);
            txtNivel.MaxDropDownItems = 4;
            txtNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(302, 49);
            txtNivel.StartIndex = 0;
            txtNivel.TabIndex = 22;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(45, 64);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(595, 48);
            txtNome.TabIndex = 19;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Código";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(45, 6);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(595, 48);
            txtCodigo.TabIndex = 17;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            txtCodigo.Click += txtCodigo_Click;
            // 
            // tabPageConsultaCurso
            // 
            tabPageConsultaCurso.Controls.Add(btnExcluir);
            tabPageConsultaCurso.Controls.Add(btnEditar);
            tabPageConsultaCurso.Controls.Add(btnNovo);
            tabPageConsultaCurso.Controls.Add(mlvCursos);
            tabPageConsultaCurso.ImageKey = "search.png";
            tabPageConsultaCurso.Location = new Point(4, 31);
            tabPageConsultaCurso.Margin = new Padding(3, 2, 3, 2);
            tabPageConsultaCurso.Name = "tabPageConsultaCurso";
            tabPageConsultaCurso.Padding = new Padding(3, 2, 3, 2);
            tabPageConsultaCurso.Size = new Size(686, 253);
            tabPageConsultaCurso.TabIndex = 1;
            tabPageConsultaCurso.Text = "Consultar";
            tabPageConsultaCurso.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(606, 226);
            btnExcluir.Margin = new Padding(4);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(537, 226);
            btnEditar.Margin = new Padding(4);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.MouseClick += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(474, 226);
            btnNovo.Margin = new Padding(4);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 6;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // mlvCursos
            // 
            mlvCursos.AutoSizeTable = false;
            mlvCursos.BackColor = Color.FromArgb(255, 255, 255);
            mlvCursos.BorderStyle = BorderStyle.None;
            mlvCursos.Depth = 0;
            mlvCursos.FullRowSelect = true;
            mlvCursos.Location = new Point(3, 0);
            mlvCursos.Margin = new Padding(3, 2, 3, 2);
            mlvCursos.MinimumSize = new Size(175, 75);
            mlvCursos.MouseLocation = new Point(-1, -1);
            mlvCursos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mlvCursos.Name = "mlvCursos";
            mlvCursos.OwnerDraw = true;
            mlvCursos.Size = new Size(675, 220);
            mlvCursos.TabIndex = 5;
            mlvCursos.UseCompatibleStateImageBehavior = false;
            mlvCursos.View = View.Details;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormCadastroCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(TabControlCadastroConsultaCurso);
            DrawerTabControl = TabControlCadastroConsultaCurso;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroCurso";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cursos";
            Load += FormCadastroCurso_Load;
            TabControlCadastroConsultaCurso.ResumeLayout(false);
            tabPageCadastroCurso.ResumeLayout(false);
            tabPageCadastroCurso.PerformLayout();
            tabPageConsultaCurso.ResumeLayout(false);
            tabPageConsultaCurso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastroConsultaCurso;
        private TabPage tabPageCadastroCurso;
        private TabPage tabPageConsultaCurso;
        private ReaLTaiizor.Controls.MaterialComboBox txtDuracao;
        private ReaLTaiizor.Controls.MaterialComboBox txtNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
        private ReaLTaiizor.Controls.MaterialComboBox txtPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox txtArea;
        private ReaLTaiizor.Controls.MaterialButton btnSalvarCurso;
        private ReaLTaiizor.Controls.MaterialButton btnCancelarCurso;
        private ReaLTaiizor.Controls.MaterialListView mlvCursos;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ImageList imageList1;
    }
}