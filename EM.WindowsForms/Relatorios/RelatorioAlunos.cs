using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace EM.WindowsForms.Relatorios
{
    public class RelatorioAlunos
    {
        public void GeraRelAlunos()
        {

            Document documento = new Document(PageSize.A4);
            documento.SetMargins(113, 76, 113, 76);
            documento.AddCreationDate();

            string caminho = @"C:\Users\EM Estagio\source\repos\EM\RelatoriosGerados\RelatorioAlunos.pdf";

            PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(caminho, FileMode.Create));

            documento.Open();

            //string dados= "";
            //Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14));
            //paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            //paragrafo.Add("TESTANDO ESSE RELATORIO AQUI");

            PdfPTable tabela = new PdfPTable(5);
            tabela.WidthPercentage = 100;
            tabela.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela.DefaultCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            Font fonte = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 16);
            float[] larguraColunas = new float[] { 38, 60, 32, 44, 44 };
            tabela.SetWidths(larguraColunas);

            var cell1 = new PdfPCell(new Phrase("Relatório de Alunos", fonte));
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            cell1.Colspan = 5;

            var cell2 = new PdfPCell(new Phrase("Matricula", fonte));

            var cell3 = new PdfPCell(new Phrase("Nome", fonte));

            var cell4 = new PdfPCell(new Phrase("Sexo", fonte));

            var cell5 = new PdfPCell(new Phrase("Nascimento", fonte));
            cell5.HorizontalAlignment = Element.ALIGN_CENTER;

            var cell6 = new PdfPCell(new Phrase("CPF", fonte));

            tabela.AddCell(cell1);
            tabela.AddCell(cell2);
            tabela.AddCell(cell3);
            tabela.AddCell(cell4);
            tabela.AddCell(cell5);
            tabela.AddCell(cell6);

            //tabela.HeaderRows

            var listaAlunos = new Repository.RepositorioAluno().GetAll();

            foreach (var aluno in listaAlunos)
            {
                var cellMatricula = new PdfPCell(new Phrase(aluno.Matricula.ToString()));
                tabela.AddCell(cellMatricula);

                var cell = new PdfPCell(new Phrase(aluno.Nome));
                tabela.AddCell(cell);

                cell = new PdfPCell(new Phrase(aluno.Sexo.ToString()));
                tabela.AddCell(cell);

                var cellNascimento = new PdfPCell(new Phrase(aluno.Nascimento.ToShortDateString()));
                cellNascimento.HorizontalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(cellNascimento);

                cell = new PdfPCell(new Phrase(aluno.CPF));
                tabela.AddCell(cell);
            }

            documento.Add(tabela);
            documento.Close();
        }
    }
}
