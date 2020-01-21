using BRQ.Avaliacao.Business.RodrigoNettoOliveira;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BRQ.Avaliacao.WinForms.RodrigoNettoOliveira
{

    public partial class frmLeitorDeArquivos : Form
    {
        private Thread thread;
        private DataTable dttNovo;

        #region Construtor
        public frmLeitorDeArquivos()
        {
            InitializeComponent();

            btnSelecione.Click += Clicar_Botao_Selecione;
            tsbtnIniciar.Click += Clicar_Botao_Iniciar;
            tsbtnParar.Click += ClicarBotaoParar;
        }

        #endregion

        #region Eventos
        private void ClicarBotaoParar(object sender, EventArgs e)
        {
            try
            {
                AbortarThread();

                FinalizarTratamentoArquivo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro - Parar");
                LimparCamposTela();
            }
        }


        private void Clicar_Botao_Selecione(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var linhasArquivo = File.ReadLines(openFileDialog.FileName);
                    if (linhasArquivo.Count() == 0)
                    {
                        MessageBox.Show("O arquivo não possui linhas a serem tratadas.", this.Text, MessageBoxButtons.OK);
                        return;
                    }

                    if (linhasArquivo.First().ToString().Split(',').Count() == 0)
                    {
                        MessageBox.Show("O arquivo não possui separador de colunas por virgula.", this.Text, MessageBoxButtons.OK);
                        return;
                    }

                    if (linhasArquivo.First().ToString().Split(',').Count() < 6)
                    {
                        MessageBox.Show("O arquivo não pode ser tratado, possui menos de 6 colunas.", this.Text, MessageBoxButtons.OK);
                        return;
                    }

                    if (linhasArquivo.Count() < 10)
                    {
                        MessageBox.Show("O arquivo não pode ser tratado, possui menos de 10 linhas.", this.Text, MessageBoxButtons.OK);
                        return;
                    }

                    txtArquivoEntrada.Text = openFileDialog.FileName;
                }
            }

            MessageBox.Show("Escolha o local e o nome do aquivo de saida.", this.Text, MessageBoxButtons.OK);

            EscolherArquivoSaida();
        }

        private void Clicar_Botao_Iniciar(object sender, EventArgs e)
        {
            try
            {
                if (txtArquivoEntrada.Text.Length == 0)
                {
                    MessageBox.Show("Favor escolher o arquivo.", this.Text, MessageBoxButtons.OK);
                    return;
                }

                thread = new Thread(ProcessarArquivo);
                dttNovo = CriarDataTable();
                thread.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro - Iniciar");
                LimparCamposTela();
            }
        }

        #endregion

        #region Métodos Privados

        private void AbortarThread()
        {
            thread.Abort();
        }

        private void EscolherArquivoSaida()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDiretorioSaida.Text = saveFileDialog.FileName;
                }
            }
        }

        private void ProcessarArquivo()
        {
            string line;
            var contador = 0;

            StreamReader file = new StreamReader(txtArquivoEntrada.Text);
            while ((line = file.ReadLine()) != null)
            {
                this.Invoke(new Action(() => { rtbLogExecucao.AppendText(line + "\n"); }));
                Thread.Sleep(1000);
                if (contador > 0)
                {
                    var row = dttNovo.NewRow();
                    string[] itemArray = line.Split(',');
                    row.ItemArray = itemArray;
                    dttNovo.Rows.Add(row);
                }
                contador++;
            }

            file.Close();

            FinalizarTratamentoArquivo();

        }

        private void FinalizarTratamentoArquivo()
        {
            try
            {
                new ImportarArquivoBusiness(dttNovo, "ArquivoTexto").Importar();

                new GerarArquivo(txtDiretorioSaida.Text).CriarArquivoTxt();

                MessageBox.Show("Arquivo salvo no banco de dados e gerado arquivo de saida.", this.Text, MessageBoxButtons.OK);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                LimparCamposTela();
                AbortarThread();
            }
        }

        private void LimparCamposTela()
        {
            try
            {
                this.Invoke(new Action(() => { txtArquivoEntrada.Text = string.Empty; }));
                this.Invoke(new Action(() => { txtDiretorioSaida.Text = string.Empty; }));
                this.Invoke(new Action(() => { rtbLogExecucao.Text = string.Empty; }));
            }
            catch (Exception)
            {
                throw;
            }       
        }

        private static DataTable CriarDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("NOME");
            dt.Columns.Add("ENDERECO");
            dt.Columns.Add("BAIRRO");
            dt.Columns.Add("CIDADE");
            dt.Columns.Add("ESTADO");
            dt.Columns.Add("SEXO");
            dt.Columns.Add("DATANASCIMENTO");
            return dt;
        }

        #endregion    
    }
}
