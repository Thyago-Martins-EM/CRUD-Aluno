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
    public class Class1
    {
        public string GeraPdf(string arquivo, string texto, string fonte, int tamanho)
        {
            string retorno = string.Empty;

            Document documento = new Document(PageSize.A4);
            documento.SetMargins(40, 40, 40, 80);
            documento.AddCreationDate();

            try
            {
                PdfWriter encriptor = PdfWriter.GetInstance(documento, new FileStream(arquivo, FileMode.Create));
                documento.Open();

                documento.Add(new Phrase(texto, FontFactory.GetFont(fonte, tamanho)));

                retorno = "Arquivo gerado com sucesso!";

                documento.Close();
            }
            catch(IOException Ex)
            {
                retorno = Ex.Message.ToString();
            }
            catch(Exception e)
            {
                retorno = e.Message.ToString();
            }

            return retorno.ToString();
        }      
        
    }
}
