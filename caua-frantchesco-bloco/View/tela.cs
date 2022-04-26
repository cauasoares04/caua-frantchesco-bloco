using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caua_frantchesco_bloco.View
{
    public partial class tela : Form
    {
        public tela()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Arquivos txt|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = leitor.ReadToEnd();
                leitor.Close();
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.Title = "Abrir arquivo";
                openFileDialog1.FileName = "";
                openFileDialog1.InitialDirectory = "C:\\";
                openFileDialog1.Filter = "Arquivos txt|*.txt";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);
                    richTextBox1.Text = leitor.ReadToEnd();
                    leitor.Close();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar como";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Arquivo txt| *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                System.IO.StreamWriter gravar = new System.IO.StreamWriter(saveFileDialog1.FileName);
                gravar.Write(richTextBox1.Text);
                gravar.Close();

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar como";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Arquivo txt| *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                System.IO.StreamWriter gravar = new System.IO.StreamWriter(saveFileDialog1.FileName);
                gravar.Write(richTextBox1.Text);
                gravar.Close();

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.SelectedText == "")
                {
                    MessageBox.Show("nehum texto selecionado");
                }

                else
                {
                    Clipboard.SetText(richTextBox1.SelectedText);
                    richTextBox1.SelectedText = "";
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.SelectedText == "")
                {
                    MessageBox.Show("selecione um texto");
                }

                else
                {
                    Clipboard.SetText(richTextBox1.SelectedText);
                }
            }

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = Clipboard.GetText();

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = Clipboard.GetText();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                {

                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
            }

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (colorDialog1.ShowDialog().Equals(DialogResult.OK))
                {

                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
            }

        }
    }
}