using BLL;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ConfigutacoesBLL
{
    public partial class frmConfiguracoes : Form
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();

        BackupBLL backup = new BackupBLL();

        bool inicio = true;

        private void BtnDefinir_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {

                decimal multa;
                try { multa = Convert.ToDecimal(txtMulta.Text); }
                catch
                {
                    erro = "Valor Inválido!";
                    throw new Exception("O valor da multa foi digitado incorretamente!");
                }

                if (MessageBox.Show("Deseja modificar o valor principal da multa?", "Valor Principal!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    configuracoesBLL.DefinirMulta(multa);
                    MessageBox.Show("Multa principal atualizada!\nTodas as multas serão atualizadas da próxima vez que o menu iniciar for carregado!", "Multa Atualizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbAtualizarModulo_Click_1(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbAtualizarModulo.IsOn;

                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os módulos dos alunos do ensino técnico não serão mais atualizados semestralmente!\n\nContinuar?", "Desativar Avanço de Módulo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarAvancoModulo(status);
                    }
                    else slbAtualizarModulo.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção os módulos dos alunos do ensino técnico serão atualizados semestralmente!\n\nContinuar?", "Ativar Avanço de Módulo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarAvancoModulo(status);
                    }
                    else slbAtualizarModulo.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbAtualizarAno_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbAtualizarAno.IsOn;

                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os anos dos alunos do ensino médio não serão mais atualizados anualmente!\n\nContinuar?", "Desativar Avanço de Ano?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarAvancoAno(status);
                    }
                    else slbAtualizarAno.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção os módulos dos alunos do ensino médio serão atualizados anualmente!\n\nContinuar?", "Ativar Avanço de Ano?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarAvancoAno(status);
                    }
                    else slbAtualizarAno.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbExcluirFinalizados_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbExcluirFinalizados.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os alunos que terminarem seus cursos não serão mais exclídos automaticamente!\n\nContinuar?", "Desativar Exclusão de Alunos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarExcluirFinalizados(status);
                    }
                    else slbExcluirFinalizados.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção os alunos que terminarem seus cursos serão excluídos automaticamente!\n\nContinuar?", "Ativar Exclusão de Alunos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarExcluirFinalizados(status);
                    }
                    else slbExcluirFinalizados.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbExcluirAlunosRemanescentes_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbExcluirAlunosRemanescentes.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os alunos no arquivo morto não serão apagados automaticamente!\n\nContinuar?", "Desativar Exclusão de Alunos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarExcluirAlunosMortoAtivo(status);
                        cbxExcluirAlunosMortoMeses.Visible = false;
                    }
                    else slbExcluirAlunosRemanescentes.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção os alunos que terminarem seus cursos serão excluídos automaticamente!\n\nContinuar?", "Ativar Exclusão de Alunos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarExcluirAlunosMortoAtivo(status);
                        cbxExcluirAlunosMortoMeses.Visible = true;
                    }
                    else slbExcluirAlunosRemanescentes.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void CbxExcluirAlunosMortoMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int meses;

            if (!inicio)
            {
                if (cbxExcluirAlunosMortoMeses.SelectedIndex == 0) meses = 6;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 1) meses = 7;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 2) meses = 8;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 3) meses = 9;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 4) meses = 10;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 5) meses = 11;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 6) meses = 12;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 7) meses = 13;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 8) meses = 14;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 9) meses = 15;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 10) meses = 16;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 11) meses = 17;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 12) meses = 18;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 13) meses = 19;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 14) meses = 20;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 15) meses = 21;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 16) meses = 22;
                else if (cbxExcluirAlunosMortoMeses.SelectedIndex == 17) meses = 23;
                else meses = 24;

                configuracoesBLL.AtualizarMesesAlunoMorto(meses);
            }
        }

        private void CbxExcluirEmprestimos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int meses;

            if (!inicio)
            {
                if (cbxExcluirEmprestimos.SelectedIndex == 0) meses = 6;
                else if (cbxExcluirEmprestimos.SelectedIndex == 1) meses = 7;
                else if (cbxExcluirEmprestimos.SelectedIndex == 2) meses = 8;
                else if (cbxExcluirEmprestimos.SelectedIndex == 3) meses = 9;
                else if (cbxExcluirEmprestimos.SelectedIndex == 4) meses = 10;
                else if (cbxExcluirEmprestimos.SelectedIndex == 5) meses = 11;
                else if (cbxExcluirEmprestimos.SelectedIndex == 6) meses = 12;
                else if (cbxExcluirEmprestimos.SelectedIndex == 7) meses = 13;
                else if (cbxExcluirEmprestimos.SelectedIndex == 8) meses = 14;
                else if (cbxExcluirEmprestimos.SelectedIndex == 9) meses = 15;
                else if (cbxExcluirEmprestimos.SelectedIndex == 10) meses = 16;
                else if (cbxExcluirEmprestimos.SelectedIndex == 11) meses = 17;
                else if (cbxExcluirEmprestimos.SelectedIndex == 12) meses = 18;
                else if (cbxExcluirEmprestimos.SelectedIndex == 13) meses = 19;
                else if (cbxExcluirEmprestimos.SelectedIndex == 14) meses = 20;
                else if (cbxExcluirEmprestimos.SelectedIndex == 15) meses = 21;
                else if (cbxExcluirEmprestimos.SelectedIndex == 16) meses = 22;
                else if (cbxExcluirEmprestimos.SelectedIndex == 17) meses = 23;
                else meses = 24;

                configuracoesBLL.ExcluirEmprestimosAlunosMeses(meses);
            }
        }

        private void SlbExcluirEmprestimos_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbExcluirEmprestimos.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os emprestimos dos alunos no arquivo morto não serão apagados automaticamente!\n\nContinuar?", "Desativar Exclusão de Empréstimos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarExcluirEmprestimosAlunosMortoAtivo(status);
                        cbxExcluirEmprestimos.Visible = false;
                    }
                    else slbExcluirEmprestimos.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção os emprestimos dos alunos no arquivo morto não serão apagados automaticamente!\n\nContinuar?", "Ativar Exclusão de Empréstimos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarExcluirEmprestimosAlunosMortoAtivo(status);
                        cbxExcluirEmprestimos.Visible = true;
                    }
                    else slbExcluirEmprestimos.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbLimiteAluno_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbLimiteAluno.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os alunos poderão emprestar quantos livros desejarem!\n\nContinuar?", "Livros Máximo Aluno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarMaxLivroAtivo(status);
                        cbxMaxLivros.Visible = false;
                    }
                    else slbLimiteAluno.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção os alunos só poderão emprestar a quantidade de livros definida pelo usuário!\n\nContinuar?", "Livros Máximo Aluno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtualizarMaxLivroAtivo(status);
                        cbxMaxLivros.Visible = true;
                    }
                    else slbLimiteAluno.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void CbxMaxLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtd;

            if (!inicio)
            {
                if (cbxMaxLivros.SelectedIndex == 0) qtd = 1;
                else if (cbxMaxLivros.SelectedIndex == 1) qtd = 2;
                else if (cbxMaxLivros.SelectedIndex == 2) qtd = 3;
                else if (cbxMaxLivros.SelectedIndex == 3) qtd = 4;
                else if (cbxMaxLivros.SelectedIndex == 4) qtd = 5;
                else if (cbxMaxLivros.SelectedIndex == 5) qtd = 6;
                else if (cbxMaxLivros.SelectedIndex == 6) qtd = 7;
                else if (cbxMaxLivros.SelectedIndex == 7) qtd = 8;
                else if (cbxMaxLivros.SelectedIndex == 8) qtd = 9;
                else if (cbxMaxLivros.SelectedIndex == 9) qtd = 10;
                else if (cbxMaxLivros.SelectedIndex == 10) qtd = 11;
                else if (cbxMaxLivros.SelectedIndex == 11) qtd = 12;
                else if (cbxMaxLivros.SelectedIndex == 12) qtd = 13;
                else if (cbxMaxLivros.SelectedIndex == 13) qtd = 14;
                else if (cbxMaxLivros.SelectedIndex == 14) qtd = 15;
                else if (cbxMaxLivros.SelectedIndex == 15) qtd = 16;
                else if (cbxMaxLivros.SelectedIndex == 16) qtd = 17;
                else if (cbxMaxLivros.SelectedIndex == 17) qtd = 18;
                else if (cbxMaxLivros.SelectedIndex == 18) qtd = 19;
                else qtd = 20;

                configuracoesBLL.MaxLivrosQtd(qtd);
            }
        }

        private void SlbExcluirEmprestimosProfessores_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbExcluirEmprestimosProfessores.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os empréstimos realizados dos alunos não serão mais deletados automaticamente!\n\nContinuar?", "Desativar Exclusão de Empréstimos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.ExcluirEmprestimosProfessoresAtivos(status);
                        cbxExcluirEmprestimosProfessores.Visible = false;
                    }
                    else slbExcluirEmprestimosProfessores.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção os empréstimos realizados dos alunos serão deletados automaticamente!\n\nContinuar?", "Ativar Exclusão de Empréstimos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.ExcluirEmprestimosProfessoresAtivos(status);
                        cbxExcluirEmprestimosProfessores.Visible = true;
                    }
                    else slbExcluirEmprestimosProfessores.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void CbxExcluirEmprestimosProfessores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int meses;

            if (!inicio)
            {
                if (cbxExcluirEmprestimos.SelectedIndex == 0) meses = 6;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 1) meses = 7;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 2) meses = 8;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 3) meses = 9;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 4) meses = 10;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 5) meses = 11;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 6) meses = 12;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 7) meses = 13;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 8) meses = 14;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 9) meses = 15;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 10) meses = 16;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 11) meses = 17;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 12) meses = 18;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 13) meses = 19;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 14) meses = 20;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 15) meses = 21;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 16) meses = 22;
                else if (cbxExcluirEmprestimosProfessores.SelectedIndex == 17) meses = 23;
                else meses = 24;

                configuracoesBLL.ExcluirEmprestimosProfessoresMeses(meses);
            }
        }

        private void CbxMaxLivrosFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtd;

            if (!inicio)
            {
                if (cbxMaxLivrosFuncionarios.SelectedIndex == 0) qtd = 1;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 1) qtd = 2;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 2) qtd = 3;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 3) qtd = 4;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 4) qtd = 5;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 5) qtd = 6;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 6) qtd = 7;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 7) qtd = 8;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 8) qtd = 9;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 9) qtd = 10;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 10) qtd = 11;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 11) qtd = 12;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 12) qtd = 13;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 13) qtd = 14;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 14) qtd = 15;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 15) qtd = 16;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 16) qtd = 17;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 17) qtd = 18;
                else if (cbxMaxLivrosFuncionarios.SelectedIndex == 18) qtd = 19;
                else qtd = 20;

                configuracoesBLL.MaxLivrosQtdFuncionario(qtd);
            }
        }

        private void SlbMaxLivroFuncionario_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbMaxLivroFuncionario.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os funcionários poderão emprestar quantos livros desejarem!\n\nContinuar?", "Livros Máximos Funcionário?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.MaxLivroFuncionariosAtivo(status);
                        cbxMaxLivrosFuncionarios.Visible = false;
                    }
                    else slbMaxLivroFuncionario.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção os funcionarios só poderão emprestar a quantidade de livros definida pelo usuário!\n\nContinuar?", "Livros Máximos Funcionário?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.MaxLivroFuncionariosAtivo(status);
                        cbxMaxLivrosFuncionarios.Visible = true;
                    }
                    else slbMaxLivroFuncionario.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbBackup_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbBackup.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção o backup automático ao sair não será mais realizado!\n\nContinuar?", "Desativar Backup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.BackupAtivo(status);
                    }
                    else slbBackup.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção o bakcup automático ao sair será realizado!\n\nContinuar?", "Ativar Backup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.BackupAtivo(status);
                    }
                    else slbBackup.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnGerarBackup_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                backup.GerarBackup();
                MessageBox.Show("Backup gerado com sucesso!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbExcluirMultas_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbExcluirMultas.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção as multas no arquivo morto não serão mais apagadas automaticamente!\n\nContinuar?", "Desativar Exclusão de Multas?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.ExcluirMultasAtivo(status);
                        cbxExcluirMultasMeses.Visible = false;
                    }
                    else slbExcluirMultas.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção as multas no arquivo morto serão mais apagadas automaticamente!\n\nContinuar?", "Ativar Exclusão de Multas?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.ExcluirMultasAtivo(status);
                        cbxExcluirMultasMeses.Visible = true;
                    }
                    else slbExcluirMultas.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void CbxExcluirMultasMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int meses;
            if (!inicio)
            {
                if (cbxExcluirMultasMeses.SelectedIndex == 0) meses = 6;
                else if (cbxExcluirMultasMeses.SelectedIndex == 1) meses = 7;
                else if (cbxExcluirMultasMeses.SelectedIndex == 2) meses = 8;
                else if (cbxExcluirMultasMeses.SelectedIndex == 3) meses = 9;
                else if (cbxExcluirMultasMeses.SelectedIndex == 4) meses = 10;
                else if (cbxExcluirMultasMeses.SelectedIndex == 5) meses = 11;
                else if (cbxExcluirMultasMeses.SelectedIndex == 6) meses = 12;
                else if (cbxExcluirMultasMeses.SelectedIndex == 7) meses = 13;
                else if (cbxExcluirMultasMeses.SelectedIndex == 8) meses = 14;
                else if (cbxExcluirMultasMeses.SelectedIndex == 9) meses = 15;
                else if (cbxExcluirMultasMeses.SelectedIndex == 10) meses = 16;
                else if (cbxExcluirMultasMeses.SelectedIndex == 11) meses = 17;
                else if (cbxExcluirMultasMeses.SelectedIndex == 12) meses = 18;
                else if (cbxExcluirMultasMeses.SelectedIndex == 13) meses = 19;
                else if (cbxExcluirMultasMeses.SelectedIndex == 14) meses = 20;
                else if (cbxExcluirMultasMeses.SelectedIndex == 15) meses = 21;
                else if (cbxExcluirMultasMeses.SelectedIndex == 16) meses = 22;
                else if (cbxExcluirMultasMeses.SelectedIndex == 17) meses = 23;
                else meses = 24;

                configuracoesBLL.ExcluirMultasMeses(meses);
            }
        }

        private void SlbExcluirDatasPassadas_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbExcluirDatasPassadas.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção as datas passadas do calendário escolar não serão mais apagadas!\n\nContinuar?", "Desativar Exclusão de Datas?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.ExcluirDataPassadasAtivo(status);
                    }
                    else slbExcluirDatasPassadas.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção as datas passadas do calendário escolar serão mais apagadas!\n\nContinuar?", "Ativar Exclusão de Datas?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.ExcluirDataPassadasAtivo(status);
                    }
                    else slbExcluirDatasPassadas.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnDefinirSenhaPrincipal_Click(object sender, EventArgs e)
        {
            pnlMudarSenhaPrincipal.Visible = true;
            pnlConteudo.Enabled = false;

        }

        private void BtnVerificarPasso1_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                string senhaDigitada = txtSenhaDigitada.Text;

                if (configuracoesBLL.ValidarSenha(senhaDigitada))
                {
                    lblSenhaPrincipal.Text = configuracoesBLL.BuscarSenhaPrinciapal();
                    pnlMudarPrincipal.Visible = true;
                    pnlConfirmacao.Visible = false;
                }
                else
                {
                    MessageBox.Show("A senha digitada está incorreta ou não pertence ao usuário logado!", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            pnlMudarSenhaPrincipal.Visible = false;
            pnlConteudo.Enabled = true;
            pnlMudarPrincipal.Visible = false;
            pnlConfirmacao.Visible = true;

            txtSenhaDigitada.Text = "";
            txtRepetirSenhaPrincipal.Text = "";
            txtSenhaPrincipal.Text = "";
        }

        private void BtnMudarSenhaPrincipal_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                string senha = txtSenhaPrincipal.Text,
                        repetirSenha = txtRepetirSenhaPrincipal.Text;

                configuracoesBLL.MudarSenhaPrincipal(senha, repetirSenha, ref erro);
                MessageBox.Show("A senha principal foi alterada com sucesso!", "Senha Alterada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnCancelar2_Click(object sender, EventArgs e)
        {
            BtnCancelar_Click(null, null);
        }

        private void SlbAtrasadosVisivel_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbAtrasadosVisivel.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os alunos com empréstimos atrasados não serão mostrados!\n\nContinuar?", "Desativar Atrasados?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtrasadosAtivo(status);
                    }
                    else slbAtrasadosVisivel.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opçãoos alunos com empréstimos atrasados serão mostrados!\n\nContinuar?", "Ativar Atrasados?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.AtrasadosAtivo(status);
                    }
                    else slbAtrasadosVisivel.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbMaisSaidosCharVisivel_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbMaisSaidosCharVisivel.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção o gráfico de livros mais saídos será ocultado!\n\nContinuar?", "Desativar Gráfico?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.ChartAtivo(status);
                    }
                    else slbMaisSaidosCharVisivel.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opçãoos o gráfico de livros mais saídos será exibído!\n\nContinuar?", "Ativar Gráfico?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.ChartAtivo(status);
                    }
                    else slbMaisSaidosCharVisivel.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbMostrarMaisSaidos_Click(object sender, EventArgs e)
        {

            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbMostrarMaisSaidos.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção a lista de livros mais saídos será ocultada!\n\nContinuar?", "Desativar Listagem?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.MaisSaidosAtivo(status);
                    }
                    else slbMostrarMaisSaidos.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opçãoos a lista de livros mais saídos será exibído!\n\nContinuar?", "Ativar Listagem?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.MaisSaidosAtivo(status);
                    }
                    else slbMostrarMaisSaidos.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbLoginAtivo_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbLoginAtivo.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção a tela de login será desativada!\n\nContinuar?", "Desativar Tela de Login?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.LoginAtivo(status);
                    }
                    else slbLoginAtivo.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção a tela de login será!\n\nContinuar?", "Desativar Tela de Login?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.LoginAtivo(status);
                    }
                    else slbLoginAtivo.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            CarregarDados();
            inicio = false;
        }

        void CarregarDados()
        {
            string erro = "Erro Não Previsto!";
            try
            {
                object[] dados = configuracoesBLL.CarregarDados();

                slbAtualizarModulo.IsOn = Convert.ToBoolean(dados[0]);

                slbAtualizarAno.IsOn = Convert.ToBoolean(dados[1]);

                slbExcluirFinalizados.IsOn = Convert.ToBoolean(dados[2]);

                slbExcluirAlunosRemanescentes.IsOn = Convert.ToBoolean(dados[3]);
                if (Convert.ToBoolean(dados[3])) cbxExcluirAlunosMortoMeses.Visible = true;
                else cbxExcluirAlunosMortoMeses.Visible = false;
                if (Convert.ToInt32(dados[4]) == 6) cbxExcluirAlunosMortoMeses.SelectedIndex = 0;
                else if (Convert.ToInt32(dados[4]) == 7) cbxExcluirAlunosMortoMeses.SelectedIndex = 1;
                else if (Convert.ToInt32(dados[4]) == 8) cbxExcluirAlunosMortoMeses.SelectedIndex = 2;
                else if (Convert.ToInt32(dados[4]) == 9) cbxExcluirAlunosMortoMeses.SelectedIndex = 3;
                else if (Convert.ToInt32(dados[4]) == 10) cbxExcluirAlunosMortoMeses.SelectedIndex = 4;
                else if (Convert.ToInt32(dados[4]) == 11) cbxExcluirAlunosMortoMeses.SelectedIndex = 5;
                else if (Convert.ToInt32(dados[4]) == 12) cbxExcluirAlunosMortoMeses.SelectedIndex = 6;
                else if (Convert.ToInt32(dados[4]) == 13) cbxExcluirAlunosMortoMeses.SelectedIndex = 7;
                else if (Convert.ToInt32(dados[4]) == 14) cbxExcluirAlunosMortoMeses.SelectedIndex = 8;
                else if (Convert.ToInt32(dados[4]) == 15) cbxExcluirAlunosMortoMeses.SelectedIndex = 9;
                else if (Convert.ToInt32(dados[4]) == 16) cbxExcluirAlunosMortoMeses.SelectedIndex = 10;
                else if (Convert.ToInt32(dados[4]) == 17) cbxExcluirAlunosMortoMeses.SelectedIndex = 11;
                else if (Convert.ToInt32(dados[4]) == 18) cbxExcluirAlunosMortoMeses.SelectedIndex = 12;
                else if (Convert.ToInt32(dados[4]) == 19) cbxExcluirAlunosMortoMeses.SelectedIndex = 13;
                else if (Convert.ToInt32(dados[4]) == 20) cbxExcluirAlunosMortoMeses.SelectedIndex = 14;
                else if (Convert.ToInt32(dados[4]) == 21) cbxExcluirAlunosMortoMeses.SelectedIndex = 15;
                else if (Convert.ToInt32(dados[4]) == 22) cbxExcluirAlunosMortoMeses.SelectedIndex = 16;
                else if (Convert.ToInt32(dados[4]) == 23) cbxExcluirAlunosMortoMeses.SelectedIndex = 17;
                else if (Convert.ToInt32(dados[4]) == 24) cbxExcluirAlunosMortoMeses.SelectedIndex = 18;

                slbExcluirEmprestimos.IsOn = Convert.ToBoolean(dados[5]);
                if (Convert.ToBoolean(dados[5])) cbxExcluirEmprestimos.Visible = true;
                else cbxExcluirEmprestimos.Visible = false;
                if (Convert.ToInt32(dados[6]) == 6) cbxExcluirEmprestimos.SelectedIndex = 0;
                else if (Convert.ToInt32(dados[6]) == 7) cbxExcluirEmprestimos.SelectedIndex = 1;
                else if (Convert.ToInt32(dados[6]) == 8) cbxExcluirEmprestimos.SelectedIndex = 2;
                else if (Convert.ToInt32(dados[6]) == 9) cbxExcluirEmprestimos.SelectedIndex = 3;
                else if (Convert.ToInt32(dados[6]) == 10) cbxExcluirEmprestimos.SelectedIndex = 4;
                else if (Convert.ToInt32(dados[6]) == 11) cbxExcluirEmprestimos.SelectedIndex = 5;
                else if (Convert.ToInt32(dados[6]) == 12) cbxExcluirEmprestimos.SelectedIndex = 6;
                else if (Convert.ToInt32(dados[6]) == 13) cbxExcluirEmprestimos.SelectedIndex = 7;
                else if (Convert.ToInt32(dados[6]) == 14) cbxExcluirEmprestimos.SelectedIndex = 8;
                else if (Convert.ToInt32(dados[6]) == 15) cbxExcluirEmprestimos.SelectedIndex = 9;
                else if (Convert.ToInt32(dados[6]) == 16) cbxExcluirEmprestimos.SelectedIndex = 10;
                else if (Convert.ToInt32(dados[6]) == 17) cbxExcluirEmprestimos.SelectedIndex = 11;
                else if (Convert.ToInt32(dados[6]) == 18) cbxExcluirEmprestimos.SelectedIndex = 12;
                else if (Convert.ToInt32(dados[6]) == 19) cbxExcluirEmprestimos.SelectedIndex = 13;
                else if (Convert.ToInt32(dados[6]) == 20) cbxExcluirEmprestimos.SelectedIndex = 14;
                else if (Convert.ToInt32(dados[6]) == 21) cbxExcluirEmprestimos.SelectedIndex = 15;
                else if (Convert.ToInt32(dados[6]) == 22) cbxExcluirEmprestimos.SelectedIndex = 16;
                else if (Convert.ToInt32(dados[6]) == 23) cbxExcluirEmprestimos.SelectedIndex = 17;
                else if (Convert.ToInt32(dados[6]) == 24) cbxExcluirEmprestimos.SelectedIndex = 18;

                slbLimiteAluno.IsOn = Convert.ToBoolean(dados[7]);
                if (Convert.ToBoolean(dados[7])) cbxMaxLivros.Visible = true;
                else cbxMaxLivros.Visible = false;
                if (Convert.ToInt32(dados[8]) == 1) cbxMaxLivros.SelectedIndex = 0;
                else if (Convert.ToInt32(dados[8]) == 2) cbxMaxLivros.SelectedIndex = 1;
                else if (Convert.ToInt32(dados[8]) == 3) cbxMaxLivros.SelectedIndex = 2;
                else if (Convert.ToInt32(dados[8]) == 4) cbxMaxLivros.SelectedIndex = 3;
                else if (Convert.ToInt32(dados[8]) == 5) cbxMaxLivros.SelectedIndex = 4;
                else if (Convert.ToInt32(dados[8]) == 6) cbxMaxLivros.SelectedIndex = 5;
                else if (Convert.ToInt32(dados[8]) == 7) cbxMaxLivros.SelectedIndex = 6;
                else if (Convert.ToInt32(dados[8]) == 8) cbxMaxLivros.SelectedIndex = 7;
                else if (Convert.ToInt32(dados[8]) == 9) cbxMaxLivros.SelectedIndex = 8;
                else if (Convert.ToInt32(dados[8]) == 10) cbxMaxLivros.SelectedIndex = 9;
                else if (Convert.ToInt32(dados[8]) == 11) cbxMaxLivros.SelectedIndex = 10;
                else if (Convert.ToInt32(dados[8]) == 12) cbxMaxLivros.SelectedIndex = 11;
                else if (Convert.ToInt32(dados[8]) == 13) cbxMaxLivros.SelectedIndex = 12;
                else if (Convert.ToInt32(dados[8]) == 14) cbxMaxLivros.SelectedIndex = 13;
                else if (Convert.ToInt32(dados[8]) == 15) cbxMaxLivros.SelectedIndex = 14;
                else if (Convert.ToInt32(dados[8]) == 16) cbxMaxLivros.SelectedIndex = 15;
                else if (Convert.ToInt32(dados[8]) == 17) cbxMaxLivros.SelectedIndex = 16;
                else if (Convert.ToInt32(dados[8]) == 18) cbxMaxLivros.SelectedIndex = 17;
                else if (Convert.ToInt32(dados[8]) == 19) cbxMaxLivros.SelectedIndex = 18;
                else if (Convert.ToInt32(dados[8]) == 20) cbxMaxLivros.SelectedIndex = 19;

                slbExcluirEmprestimosProfessores.IsOn = Convert.ToBoolean(dados[9]);
                if (Convert.ToBoolean(dados[9])) cbxExcluirEmprestimosProfessores.Visible = true;
                else cbxExcluirEmprestimosProfessores.Visible = false;
                if (Convert.ToInt32(dados[10]) == 6) cbxExcluirEmprestimosProfessores.SelectedIndex = 0;
                else if (Convert.ToInt32(dados[10]) == 7) cbxExcluirEmprestimosProfessores.SelectedIndex = 1;
                else if (Convert.ToInt32(dados[10]) == 8) cbxExcluirEmprestimosProfessores.SelectedIndex = 2;
                else if (Convert.ToInt32(dados[10]) == 9) cbxExcluirEmprestimosProfessores.SelectedIndex = 3;
                else if (Convert.ToInt32(dados[10]) == 10) cbxExcluirEmprestimosProfessores.SelectedIndex = 4;
                else if (Convert.ToInt32(dados[10]) == 11) cbxExcluirEmprestimosProfessores.SelectedIndex = 5;
                else if (Convert.ToInt32(dados[10]) == 12) cbxExcluirEmprestimosProfessores.SelectedIndex = 6;
                else if (Convert.ToInt32(dados[10]) == 13) cbxExcluirEmprestimosProfessores.SelectedIndex = 7;
                else if (Convert.ToInt32(dados[10]) == 14) cbxExcluirEmprestimosProfessores.SelectedIndex = 8;
                else if (Convert.ToInt32(dados[10]) == 15) cbxExcluirEmprestimosProfessores.SelectedIndex = 9;
                else if (Convert.ToInt32(dados[10]) == 16) cbxExcluirEmprestimosProfessores.SelectedIndex = 10;
                else if (Convert.ToInt32(dados[10]) == 17) cbxExcluirEmprestimosProfessores.SelectedIndex = 11;
                else if (Convert.ToInt32(dados[10]) == 18) cbxExcluirEmprestimosProfessores.SelectedIndex = 12;
                else if (Convert.ToInt32(dados[10]) == 19) cbxExcluirEmprestimosProfessores.SelectedIndex = 13;
                else if (Convert.ToInt32(dados[10]) == 20) cbxExcluirEmprestimosProfessores.SelectedIndex = 14;
                else if (Convert.ToInt32(dados[10]) == 21) cbxExcluirEmprestimosProfessores.SelectedIndex = 15;
                else if (Convert.ToInt32(dados[10]) == 22) cbxExcluirEmprestimosProfessores.SelectedIndex = 16;
                else if (Convert.ToInt32(dados[10]) == 23) cbxExcluirEmprestimosProfessores.SelectedIndex = 17;
                else if (Convert.ToInt32(dados[10]) == 24) cbxExcluirEmprestimosProfessores.SelectedIndex = 18;

                slbMaxLivroFuncionario.IsOn = Convert.ToBoolean(dados[11]);
                if (Convert.ToBoolean(dados[11])) cbxMaxLivrosFuncionarios.Visible = true;
                else cbxMaxLivrosFuncionarios.Visible = false;
                if (Convert.ToInt32(dados[12]) == 1) cbxMaxLivrosFuncionarios.SelectedIndex = 0;
                else if (Convert.ToInt32(dados[12]) == 2) cbxMaxLivrosFuncionarios.SelectedIndex = 1;
                else if (Convert.ToInt32(dados[12]) == 3) cbxMaxLivrosFuncionarios.SelectedIndex = 2;
                else if (Convert.ToInt32(dados[12]) == 4) cbxMaxLivrosFuncionarios.SelectedIndex = 3;
                else if (Convert.ToInt32(dados[12]) == 5) cbxMaxLivrosFuncionarios.SelectedIndex = 4;
                else if (Convert.ToInt32(dados[12]) == 6) cbxMaxLivrosFuncionarios.SelectedIndex = 5;
                else if (Convert.ToInt32(dados[12]) == 7) cbxMaxLivrosFuncionarios.SelectedIndex = 6;
                else if (Convert.ToInt32(dados[12]) == 8) cbxMaxLivrosFuncionarios.SelectedIndex = 7;
                else if (Convert.ToInt32(dados[12]) == 9) cbxMaxLivrosFuncionarios.SelectedIndex = 8;
                else if (Convert.ToInt32(dados[12]) == 10) cbxMaxLivrosFuncionarios.SelectedIndex = 9;
                else if (Convert.ToInt32(dados[12]) == 11) cbxMaxLivrosFuncionarios.SelectedIndex = 10;
                else if (Convert.ToInt32(dados[12]) == 12) cbxMaxLivrosFuncionarios.SelectedIndex = 11;
                else if (Convert.ToInt32(dados[12]) == 13) cbxMaxLivrosFuncionarios.SelectedIndex = 12;
                else if (Convert.ToInt32(dados[12]) == 14) cbxMaxLivrosFuncionarios.SelectedIndex = 13;
                else if (Convert.ToInt32(dados[12]) == 15) cbxMaxLivrosFuncionarios.SelectedIndex = 14;
                else if (Convert.ToInt32(dados[12]) == 16) cbxMaxLivrosFuncionarios.SelectedIndex = 15;
                else if (Convert.ToInt32(dados[12]) == 17) cbxMaxLivrosFuncionarios.SelectedIndex = 16;
                else if (Convert.ToInt32(dados[12]) == 18) cbxMaxLivrosFuncionarios.SelectedIndex = 17;
                else if (Convert.ToInt32(dados[12]) == 19) cbxMaxLivrosFuncionarios.SelectedIndex = 18;
                else if (Convert.ToInt32(dados[12]) == 20) cbxMaxLivrosFuncionarios.SelectedIndex = 19;

                slbBackup.IsOn = Convert.ToBoolean(dados[13]);

                slbExcluirMultas.IsOn = Convert.ToBoolean(dados[14]);
                if (Convert.ToBoolean(dados[14])) cbxExcluirMultasMeses.Visible = true;
                else cbxExcluirMultasMeses.Visible = false;
                if (Convert.ToInt32(dados[1]) == 1) cbxExcluirMultasMeses.SelectedIndex = 0;
                else if (Convert.ToInt32(dados[15]) == 2) cbxExcluirMultasMeses.SelectedIndex = 1;
                else if (Convert.ToInt32(dados[15]) == 3) cbxExcluirMultasMeses.SelectedIndex = 2;
                else if (Convert.ToInt32(dados[15]) == 4) cbxExcluirMultasMeses.SelectedIndex = 3;
                else if (Convert.ToInt32(dados[15]) == 5) cbxExcluirMultasMeses.SelectedIndex = 4;
                else if (Convert.ToInt32(dados[15]) == 6) cbxExcluirMultasMeses.SelectedIndex = 5;
                else if (Convert.ToInt32(dados[15]) == 7) cbxExcluirMultasMeses.SelectedIndex = 6;
                else if (Convert.ToInt32(dados[15]) == 8) cbxExcluirMultasMeses.SelectedIndex = 7;
                else if (Convert.ToInt32(dados[15]) == 9) cbxExcluirMultasMeses.SelectedIndex = 8;
                else if (Convert.ToInt32(dados[15]) == 10) cbxExcluirMultasMeses.SelectedIndex = 9;
                else if (Convert.ToInt32(dados[15]) == 11) cbxExcluirMultasMeses.SelectedIndex = 10;
                else if (Convert.ToInt32(dados[15]) == 12) cbxExcluirMultasMeses.SelectedIndex = 11;
                else if (Convert.ToInt32(dados[15]) == 13) cbxExcluirMultasMeses.SelectedIndex = 12;
                else if (Convert.ToInt32(dados[15]) == 14) cbxExcluirMultasMeses.SelectedIndex = 13;
                else if (Convert.ToInt32(dados[15]) == 15) cbxExcluirMultasMeses.SelectedIndex = 14;
                else if (Convert.ToInt32(dados[15]) == 16) cbxExcluirMultasMeses.SelectedIndex = 15;
                else if (Convert.ToInt32(dados[15]) == 17) cbxExcluirMultasMeses.SelectedIndex = 16;
                else if (Convert.ToInt32(dados[15]) == 18) cbxExcluirMultasMeses.SelectedIndex = 17;
                else if (Convert.ToInt32(dados[15]) == 19) cbxExcluirMultasMeses.SelectedIndex = 18;
                else if (Convert.ToInt32(dados[15]) == 20) cbxExcluirMultasMeses.SelectedIndex = 19;

                txtMulta.Text = Convert.ToString(dados[16]);

                slbExcluirDatasPassadas.IsOn = Convert.ToBoolean(dados[17]);

                slbLoginAtivo.IsOn = Convert.ToBoolean(dados[18]);

                slbAtrasadosVisivel.IsOn = Convert.ToBoolean(dados[19]);
                slbMaisSaidosCharVisivel.IsOn = Convert.ToBoolean(dados[20]);
                slbMostrarMaisSaidos.IsOn = Convert.ToBoolean(dados[21]);

                txtDiretorio.Text = Convert.ToString(dados[22]);

                if (Convert.ToBoolean(dados[23]))
                {
                    btnConfigurarEmail.Visible = true;
                    slbEmailAutomatico.IsOn = true;
                }
                else
                {
                    btnConfigurarEmail.Visible = false;
                    slbEmailAutomatico.IsOn = false;
                }

                txtFonte.Text = Convert.ToString(dados[24]);
                txtTamLinhas.Text = Convert.ToString(dados[25]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnDefinirDiretorio_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                string diretorio;
                try
                {
                    diretorio = txtDiretorio.Text;
                }
                catch
                {
                    erro = "Valor Inválido!";
                    throw new Exception("O valor da multa foi digitado incorretamente!");
                }

                if (diretorio.Trim() == "")
                {
                    erro = "Campo Vazio!";
                    throw new Exception("É preciso infnormar um diretório antes de confirmar!");
                }

                if (Directory.Exists(diretorio))
                {
                    configuracoesBLL.DefinirDiretorio(diretorio);
                    MessageBox.Show("O novo diretório foi definido com sucesso!", "Diretório Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    erro = "Diretório Inexistente!";
                    throw new Exception("O diretório informado não foi encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void SlbEmailAutomatico_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                bool status = slbEmailAutomatico.IsOn;
                if (!status)
                {
                    if (MessageBox.Show("Ao desativar esta opção os email não serão mais enviados automaticamente!\n\nContinuar?", "Desativar Email Automático?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.EmailAtivo(status);
                        btnConfigurarEmail.Visible = false;
                    }
                    else slbEmailAutomatico.IsOn = !status;
                }
                else
                {
                    if (MessageBox.Show("Ao ativar esta opção os email serão enviados automaticamente!\n\nContinuar?", "Desativar Email Automático?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        configuracoesBLL.EmailAtivo(status);
                        btnConfigurarEmail.Visible = true;
                    }
                    else slbEmailAutomatico.IsOn = !status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnConfigurarEmail_Click(object sender, EventArgs e)
        {
            pnlConfigurarEmail.BringToFront();
            pnlConfigurarEmail.Visible = true;
            pnlConteudo.Enabled = false;
            TxtTexto1_TextChanged(null, null);
            CarregarInformacoesSalvas();
        }

        void CarregarInformacoesSalvas()
        {
            string erro = "Erro Não Previsto!";
            try
            {
                object[] dados = configuracoesBLL.CarregarDadosEmail();

                txtTexto1.Text = Convert.ToString(dados[0]);
                txtTexto2.Text = Convert.ToString(dados[1]);
                txtTexto3.Text = Convert.ToString(dados[2]);
                txtTexto4.Text = Convert.ToString(dados[3]);
                txtTexto5.Text = Convert.ToString(dados[4]);
                txtTexto6.Text = Convert.ToString(dados[5]);
                txtTexto7.Text = Convert.ToString(dados[6]);
                txtTexto8.Text = Convert.ToString(dados[7]);

                cbxDado1.SelectedIndex = Convert.ToInt32(dados[8]);
                cbxDado2.SelectedIndex = Convert.ToInt32(dados[9]);
                cbxDado3.SelectedIndex = Convert.ToInt32(dados[10]);
                cbxDado4.SelectedIndex = Convert.ToInt32(dados[11]);
                cbxDado5.SelectedIndex = Convert.ToInt32(dados[12]);
                cbxDado6.SelectedIndex = Convert.ToInt32(dados[13]);
                cbxDado7.SelectedIndex = Convert.ToInt32(dados[14]);
                cbxDado8.SelectedIndex = Convert.ToInt32(dados[15]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void TxtTexto1_TextChanged(object sender, EventArgs e)
        {
            string mensagem;

            string
                dado1,
                dado2,
                dado3,
                dado4,
                dado5,
                dado6,
                dado7,
                dado8;

            if (cbxDado1.SelectedIndex == 0) dado1 = " _@nome@_ ";
            else if (cbxDado1.SelectedIndex == 1) dado1 = " _@rm@_ ";
            else if (cbxDado1.SelectedIndex == 2) dado1 = " _@livro@_ ";
            else if (cbxDado1.SelectedIndex == 3) dado1 = " _@retirada@_ ";
            else if (cbxDado1.SelectedIndex == 4) dado1 = " _@devolucao@_ ";
            else dado1 = " ";

            if (cbxDado2.SelectedIndex == 0) dado2 = " _@nome@_ ";
            else if (cbxDado2.SelectedIndex == 1) dado2 = " _@rm@_ ";
            else if (cbxDado2.SelectedIndex == 2) dado2 = " _@livro@_ ";
            else if (cbxDado2.SelectedIndex == 3) dado2 = " _@retirada@_ ";
            else if (cbxDado2.SelectedIndex == 4) dado2 = " _@devolucao@_ ";
            else dado2 = " ";

            if (cbxDado3.SelectedIndex == 0) dado3 = " _@nome@_ ";
            else if (cbxDado3.SelectedIndex == 1) dado3 = " _@rm@_ ";
            else if (cbxDado3.SelectedIndex == 2) dado3 = " _@livro@_ ";
            else if (cbxDado3.SelectedIndex == 3) dado3 = " _@retirada@_ ";
            else if (cbxDado3.SelectedIndex == 4) dado3 = " _@devolucao@_ ";
            else dado3 = " ";

            if (cbxDado4.SelectedIndex == 0) dado4 = " _@nome@_ ";
            else if (cbxDado4.SelectedIndex == 1) dado4 = " _@rm@_ ";
            else if (cbxDado4.SelectedIndex == 2) dado4 = " _@livro@_ ";
            else if (cbxDado4.SelectedIndex == 3) dado4 = " _@retirada@_ ";
            else if (cbxDado4.SelectedIndex == 4) dado4 = " _@devolucao@_ ";
            else dado4 = " ";

            if (cbxDado5.SelectedIndex == 0) dado5 = " _@nome@_ ";
            else if (cbxDado5.SelectedIndex == 1) dado5 = " _@rm@_ ";
            else if (cbxDado5.SelectedIndex == 2) dado5 = " _@livro@_ ";
            else if (cbxDado5.SelectedIndex == 3) dado5 = " _@retirada@_ ";
            else if (cbxDado5.SelectedIndex == 4) dado5 = " _@devolucao@_ ";
            else dado5 = " ";

            if (cbxDado6.SelectedIndex == 0) dado6 = " _@nome@_ ";
            else if (cbxDado6.SelectedIndex == 1) dado6 = " _@rm@_ ";
            else if (cbxDado6.SelectedIndex == 2) dado6 = " _@livro@_ ";
            else if (cbxDado6.SelectedIndex == 3) dado6 = " _@retirada@_ ";
            else if (cbxDado6.SelectedIndex == 4) dado6 = " _@devolucao@_ ";
            else dado6 = " ";

            if (cbxDado7.SelectedIndex == 0) dado7 = " _@nome@_ ";
            else if (cbxDado7.SelectedIndex == 1) dado7 = " _@rm@_ ";
            else if (cbxDado7.SelectedIndex == 2) dado7 = " _@livro@_ ";
            else if (cbxDado7.SelectedIndex == 3) dado7 = " _@retirada@_ ";
            else if (cbxDado7.SelectedIndex == 4) dado7 = " _@devolucao@_ ";
            else  dado7 = " ";

            if (cbxDado8.SelectedIndex == 0) dado8 = " _@nome@_.";
            else if (cbxDado8.SelectedIndex == 1) dado8 = " _@rm@_.";
            else if (cbxDado8.SelectedIndex == 2) dado8 = " _@livro@_.";
            else if (cbxDado8.SelectedIndex == 3) dado8 = " _@retirada@_.";
            else if (cbxDado8.SelectedIndex == 4) dado8 = " _@devolucao@_.";
            else dado8 = " ";


            lblParagrafo1.Text = txtTexto1.Text.Trim() + " " + dado1.Trim() + " "
                               + txtTexto2.Text.Trim() + " " + dado2.Trim();

            lblParagrafo2.Text = txtTexto3.Text.Trim() + " " + dado3.Trim() + " "
                               + txtTexto4.Text.Trim() + " " + dado4.Trim() + " "
                               + txtTexto5.Text.Trim() + " " + dado5.Trim() + " "
                               + txtTexto6.Text.Trim() + " " + dado6.Trim();

            lblParagrafo3.Text = txtTexto7.Text.Trim() + " " + dado7.Trim() + " "
                               + txtTexto8.Text.Trim() + " " + dado8.Trim();
        }

        private void CbxDado4_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTexto1_TextChanged(null, null);
        }

        private void CbxDado5_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTexto1_TextChanged(null, null);
        }

        private void CbxDado3_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTexto1_TextChanged(null, null);
        }

        private void CbxDado1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTexto1_TextChanged(null, null);
        }

        private void CbxDado8_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTexto1_TextChanged(null, null);
        }

        private void CbxDado6_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTexto1_TextChanged(null, null);
        }

        private void CbxDado7_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTexto1_TextChanged(null, null);
        }

        private void CbxDado2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTexto1_TextChanged(null, null);
        }

        private void BtnCancelarEmail_Click(object sender, EventArgs e)
        {
            pnlConfigurarEmail.Visible = false;
            pnlConteudo.Enabled = true;
        }

        private void BtnDefinirMensagem_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (MessageBox.Show("Alterar o email da biblioteca?", "Email Automátic0", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    EmailInformation email = new EmailInformation(txtTexto1.Text,
                                                                  txtTexto2.Text,
                                                                  txtTexto3.Text,
                                                                  txtTexto4.Text,
                                                                  txtTexto5.Text,
                                                                  txtTexto6.Text,
                                                                  txtTexto7.Text,
                                                                  txtTexto8.Text,
                                                                  cbxDado1.SelectedIndex,
                                                                  cbxDado2.SelectedIndex,
                                                                  cbxDado3.SelectedIndex,
                                                                  cbxDado4.SelectedIndex,
                                                                  cbxDado5.SelectedIndex,
                                                                  cbxDado6.SelectedIndex,
                                                                  cbxDado7.SelectedIndex,
                                                                  cbxDado8.SelectedIndex);

                    configuracoesBLL.DefinirMensagemAutomatica(lblParagrafo1.Text.Trim(), lblParagrafo2.Text.Trim(), lblParagrafo3.Text.Trim(), email);
                    MessageBox.Show("Mensagem de email definida com sucesso!", "Email Automático", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnCancelarEmail_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnDefinirFonte_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                int tam = 0;
                try { tam = int.Parse(txtFonte.Text); }
                catch
                {
                    erro = "Tamanho Inválido!";
                    throw new Exception("O tamanho informado da fonte não é válida!");
                }
                configuracoesBLL.DefinirTamanho(tam);
                MessageBox.Show("Tamanho da fonte das listagens definido como " + tam + "!", "Tamanho da Fonte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnCancelarEmail_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(fbdBuscarDiretorio.ShowDialog() == DialogResult.OK) txtDiretorio.Text = fbdBuscarDiretorio.SelectedPath;
        }

        private void BtnDefinirLinhas_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                int tam = 0;
                try { tam = int.Parse(txtTamLinhas.Text); }
                catch
                {
                    erro = "Tamanho Inválido!";
                    throw new Exception("O tamanho informado da linha não é válida!");
                }
                configuracoesBLL.DefinirTamanhoLinha(tam);
                MessageBox.Show("Tamanho das linhas listagens definido como " + tam + "!", "Tamanho da linha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnCancelarEmail_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void TxtSenhaDigitada_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter) BtnVerificarPasso1_Click(null, null);
            }
            catch { }

        }

        private void TxtSenhaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter) BtnMudarSenhaPrincipal_Click(null, null);
            }
            catch { }
        }
    }
}