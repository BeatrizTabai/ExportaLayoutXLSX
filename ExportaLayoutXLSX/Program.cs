

using DevExpress.Spreadsheet;

namespace ExportaLayoutXLSX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = string.Empty;
            string[] colunas = Array.Empty<string>();

            try
            {
                caminho = args[0];
                colunas = args[1].Split(';');
            }
            catch (Exception)
            {
               Environment.Exit(-1);
            }

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
                
            for (int i = 0; i < colunas.Length; i++)
            {
                worksheet.Cells[i].Value = colunas[i];
            }

            workbook.EndUpdate();
            workbook.SaveDocument(caminho, DocumentFormat.Xlsx);
        }
    }
}
