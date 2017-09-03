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

namespace ExtraiPDF
{
    public partial class Form1 : Form
    {
        #region Variables
        String htmlFile;
        String Extension = ".pdf";
        String HTTP = "http://";
        String HREF = "href=";
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        #region Buttons
        private void btAction_Click(object sender, EventArgs e)
        {
            //SearchReference();
            SearchinWorking();
        }
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();
            lcLines.Text = "";
            tbFile2Extract.Text = "";
            lcOccurrences.Text = "";
        }
        #endregion

        #region Function OpenFile()
        public void OpenFile()
        {
            ofd.InitialDirectory = @"C:\windows\temp";
            ofd.Title = "Choose HTML file";
            ofd.DefaultExt = "html";
            ofd.Filter = "HTML (*.html)|*.html" +
                "|HTM (*.htm)|*.htm";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FileName = "enem.html";

            DialogResult dr = this.ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                tbFile2Extract.Text = ofd.FileName;
            }

        }
        #endregion
        #region Function SearchReference()
        public void SearchReference()
        {
            htmlFile = tbFile2Extract.Text;
            String content;
            String line;
            String lineLink;
            int countLine = 0;
            int startLine = 0;
            int finishLine = 0;
            int sizeLine = 0;
            int sizeString = 0;
            int startSubstring = 0;
           
            StreamReader str = new StreamReader(htmlFile);//Le o arquivo e joga dentro de str
            while ((content = str.ReadLine()) != null)//Le o str linha a linha e joga em content até encontrar null que é o final do arquivo
            {
                countLine++; //contando as linhas
                line = content; //recebendo o conteudo do html linha a linha
                while (line.Contains(HTTP) && line.Contains(Extension)) //enquanto ainda tiver http e pdf na string continua a buscar links
                {
                    if (line.Contains(HTTP) && line.Contains(Extension) && line.Contains(HREF)) //verificando se a linha contem o http
                    {
                        sizeLine = line.Length; //pega o tamanho da variavel line
                        String cabecalho = (HREF + "\"" + HTTP); // cria variavel para achar a sequencia href + http
                        startLine = line.IndexOf(cabecalho) + HREF.Length + 1; //marca start da linha + tamanho do href
                        sizeString = (sizeLine) - (startLine + 4); //define o tamanho da string
                        lineLink = line.Substring(startLine, sizeString); //usa linelink para armazenar somente a parte que sera buscada o pdf
                        sizeLine = lineLink.Length; //guarda o tamanho do linelink
                        finishLine = lineLink.IndexOf(Extension); //marca o final do trecho onde esta o .pdf
                        finishLine = finishLine + Extension.Length; //marca novamente mas adicionando o tamanho da string .pdf de 4 posições
                        lineLink = lineLink.Substring(0, finishLine); //agora tira até a parte do pdf, separando o link
                        startSubstring = line.IndexOf(Extension); //aqui marca onde esta o .pdf para depois tirar esta parte do line para remover a parte ja extraida
                        rtbResult.AppendText(countLine + " | " + lineLink); //adiciona no textbox o numero da linha e | mais a linha
                        rtbResult.AppendText("\n"); //pula linha no textbox
                    }
                    line = line.Substring(startSubstring+Extension.Length); //aqui retira do line a parte ja procurada para procurar mais links dentro do line
                }
            }
            
            lcLines.Text = Convert.ToString(countLine); //mostra a quantidade de linhas no label
        }
        #endregion
        #region Function SearchinArray()
        public void SearchinWorking()
        {
            htmlFile = tbFile2Extract.Text;
            if (!htmlFile.ToUpper().Contains("HTML") || !htmlFile.ToUpper().Contains("HTM"))
            {
                MessageBox.Show("Favor informar o caminho do arquivo HTML\nValor não pode ser em branco");
            }
            else
            {
                
                String content;
                String line;
                String lineLink;
                int countLine = 0;
                int startLine = 0;
                int finishLine = 0;
                int sizeLine = 0;
                int sizeString = 0;
                int startSubstring = 0;
                String tempContent = "";
                int countOccurrence = 0;

                StreamReader str = new StreamReader(htmlFile);//Le o arquivo e joga dentro de str
                while ((content = str.ReadLine()) != null)//Le o str linha a linha e joga em content até encontrar null que é o final do arquivo
                {
                    countLine++; //contando as linhas
                    line = content; //recebendo o conteudo do html linha a linha
                    while (line.Contains(HTTP) && line.Contains(Extension)) //enquanto ainda tiver http e pdf na string continua a buscar links
                    {

                        if (line.Contains(HTTP) && line.Contains(Extension) && line.Contains(HREF)) //verificando se a linha contem o http
                        {

                            sizeLine = line.Length; //pega o tamanho da variavel line
                            String cabecalho = (HREF + "\"" + HTTP); // cria variavel para achar a sequencia href + http
                            startLine = line.IndexOf(cabecalho) + HREF.Length + 1; //marca start da linha + tamanho do href
                            sizeString = (sizeLine) - (startLine + 4); //define o tamanho da string
                            lineLink = line.Substring(startLine, sizeString); //usa linelink para armazenar somente a parte que sera buscada o pdf
                            sizeLine = lineLink.Length; //guarda o tamanho do linelink
                            finishLine = lineLink.IndexOf(Extension); //marca o final do trecho onde esta o .pdf
                            finishLine = finishLine + Extension.Length; //marca novamente mas adicionando o tamanho da string .pdf de 4 posições
                            lineLink = lineLink.Substring(0, finishLine); //agora tira até a parte do pdf, separando o link
                            startSubstring = line.IndexOf(Extension); //aqui marca onde esta o .pdf para depois tirar esta parte do line para remover a parte ja extraida
                                                    
                            for (int i = 0; i < lineLink.Length; i++) //começa laço para ler a variavel lineLink toda
                            {
                                tempContent = tempContent + lineLink[i]; //vai adicionando caracter a caracter a variavel tempContent
                                if (tempContent.Contains(HTTP) && tempContent.Contains("\">"))
                                {
                                    int posNaoPDF = lineLink.IndexOf("\">"); //procura a posição do final da url sem pdf
                                    lineLink = lineLink.Substring(posNaoPDF + 2); //remove da variavel a parte de url invalida
                                    tempContent = ""; //limpa a variavel temporaria para receber novo valor                                
                                    break; //interrompe a execução para ler novos valores

                                }

                                if (tempContent.Contains(HTTP) && !tempContent.Contains("\">") && tempContent.Contains(Extension)) //verificando se a linha contem o http e final do link ">
                                {
                                    try
                                    {
                                        rtbResult.AppendText(countLine + " | " + tempContent); //adiciona no textbox o numero da linha e | mais a linha
                                        rtbResult.AppendText("\n"); //pula linha no textbox
                                        tempContent = "";   //limpa a variavel temporaria para receber novo valor
                                        countOccurrence++;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString());
                                    }

                                }

                            }
                        }
                        line = line.Substring(startSubstring + Extension.Length); //aqui retira do line a parte ja procurada para procurar mais links dentro do line
                    }
                }
                lcLines.Text = Convert.ToString(countLine); //mostra a quantidade de linhas no label
                lcOccurrences.Text = Convert.ToString(countOccurrence); //mostra a quantidade de ocorrencias no label
            }
            
        }
        #endregion

    }
}

