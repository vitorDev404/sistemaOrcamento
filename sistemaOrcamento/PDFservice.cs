using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.Kernel.Colors;

namespace sistemaOrcamento
{
    public class PdfService
    {
        public void GerarPdf(
            string caminho,
            string cliente,
            string data,
            List<ItemOrcamento> itens)
        {
            PdfWriter writer = new PdfWriter(caminho);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            Paragraph titulo = new Paragraph("ORÇAMENTO")
                .SetFont(bold)
                .SetFontSize(20)
                .SetTextAlignment(TextAlignment.CENTER);
            document.Add(titulo);
            Paragraph sub = new Paragraph("LAPO - Comunicação Visual")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(10);
            document.Add(sub);
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Cliente: {cliente}"));
            document.Add(new Paragraph($"Data: {data}"));
            document.Add(new Paragraph("\n"));
            Table tabela = new Table(6);
            tabela.SetWidth(UnitValue.CreatePercentValue(100));
            DeviceGray cinza = new DeviceGray(0.85f);
            string[] headers = { "Material", "Máquina", "Dimensão", "M²", "Qtd", "Valor" };
            foreach (var h in headers)
            {
                Cell cell = new Cell()
                    .Add(new Paragraph(h).SetFont(bold))
                    .SetBackgroundColor(cinza)
                    .SetTextAlignment(TextAlignment.CENTER);
                tabela.AddHeaderCell(cell);
            }
            double totalGeral = 0;
            foreach (var item in itens)
            {
                tabela.AddCell(new Cell().Add(new Paragraph(item.Material)));
                tabela.AddCell(new Cell().Add(new Paragraph(item.Maquina)));
                tabela.AddCell(new Cell().Add(new Paragraph($"{item.Largura} x {item.Comprimento}")));
                tabela.AddCell(new Cell().Add(new Paragraph(item.M2.ToString("F2"))));
                tabela.AddCell(new Cell().Add(new Paragraph(item.Quantidade.ToString())));
                tabela.AddCell(new Cell().Add(new Paragraph(item.Valor.ToString("C"))));
                totalGeral += item.Valor;
            }
            document.Add(tabela);
            document.Add(new Paragraph("\n"));
            Paragraph total = new Paragraph($"TOTAL: {totalGeral:C}")
                .SetFont(bold)
                .SetFontSize(16)
                .SetTextAlignment(TextAlignment.RIGHT);
            document.Add(total);
            document.Add(new Paragraph("\n"));
            Paragraph contato = new Paragraph("Contato: (11) 99999-9999")
                .SetFontSize(10);
            Paragraph endereco = new Paragraph("Endereço: Sua empresa")
                .SetFontSize(10);
            document.Add(contato);
            document.Add(endereco);
            document.Close();
        }
    }
}