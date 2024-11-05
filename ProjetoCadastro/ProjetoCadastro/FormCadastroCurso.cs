using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroCurso : MaterialForm
    {
        string cursosFileName = "cursos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public FormCadastroCurso()
        {
            InitializeComponent();
        }

        private void FormCadastroCurso_Load(object sender, EventArgs e)
        {
            CarregaListView();
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Código Obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome Obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNivel.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtNivel.Text))
            {
                MessageBox.Show("Nível Obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuracao.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtDuracao.Text))
            {
                MessageBox.Show("Duração Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtArea.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtArea.Text))
            {
                MessageBox.Show("Área Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPeriodo.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtPeriodo.Text))
            {
                MessageBox.Show("Texto Obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return true;
            }
            return true;
        }

        private void Salvar()
        {
            var line = $"{txtCodigo.Text};" +
               $"{txtNome.Text};" +
               $"{txtNivel.Text};" +
               $"{txtDuracao.Text};" +
               $"{txtArea.Text};" +
               $"{txtPeriodo.Text};";

            if (!isAlteracao)
            {
                using (var file = new StreamWriter(cursosFileName, true))
                {
                    file.WriteLine(line);
                }
            }
            else
            {
                string[] cursos = File.ReadAllLines(cursosFileName);
                cursos[indexSelecionado] = line;
                File.WriteAllLines(cursosFileName, cursos);
            }

            LimpaCampos();
            CarregaListView();

        }

        public void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastroCurso.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }

        }
        private void txtCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarCurso_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();

                TabControlCadastroConsultaCurso.SelectedIndex = 1;
            }
        }

        private void btnCancelarCurso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas.\r\n" + "Deseja Cancelar", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastroConsultaCurso.SelectedIndex = 1;
            }
        }

        private void CarregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            mlvCursos.Columns.Clear();
            mlvCursos.Items.Clear();

            
            mlvCursos.Columns.Add("Código");
            mlvCursos.Columns.Add("Nome");
            mlvCursos.Columns.Add("Nível");
            mlvCursos.Columns.Add("Duração");
            mlvCursos.Columns.Add("Área");
            mlvCursos.Columns.Add("Período");

            if (File.Exists(cursosFileName))
            {
                string[] cursos = File.ReadAllLines(cursosFileName);
                foreach (string curso in cursos)
                {
                    var campos = curso.Split(';');
                    if (campos.Length >= 6)
                        mlvCursos.Items.Add(new ListViewItem(campos));
                }
            }

            mlvCursos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaListView();
        }

        private void Editar()
        {
            if (mlvCursos.SelectedIndices.Count > 0)
            {
                indexSelecionado = mlvCursos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = mlvCursos.SelectedItems[0];
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtNivel.Text = item.SubItems[2].Text;
                txtDuracao.Text = item.SubItems[3].Text;
                txtArea.Text = item.SubItems[4].Text;
                txtPeriodo.Text = item.SubItems[5].Text;

                TabControlCadastroConsultaCurso.SelectedIndex = 0;
                txtCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void mlvCursos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void btnEditar_Click(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void mlvAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas.\r\n" + "Deseja Cancelar", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastroConsultaCurso.SelectedIndex = 1;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastroConsultaCurso.SelectedIndex = 0; 
            txtCodigo.Focus();
        }

        private void Excluir()
        {
            List<string> cursos = File.ReadAllLines(cursosFileName).ToList();
            cursos.RemoveAt(indexSelecionado);
            File.WriteAllLines(cursosFileName, cursos);
            MessageBox.Show("Curso excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (mlvCursos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente deletar o curso selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = mlvCursos.SelectedItems[0].Index;
                    Excluir();
                    CarregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione um curso para deletar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
