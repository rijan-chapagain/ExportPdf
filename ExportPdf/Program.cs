using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ExportPdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // New Doc
            PdfDocument pdfDocument = new PdfDocument();

            // New page
            PdfPage page = pdfDocument.AddPage();

            // The class will provide drawing related methods for specified page
            XGraphics xGraphics = XGraphics.FromPdfPage(page);

            // Choose font to be used on the text
            XFont font = new XFont("Arial", 20);

            xGraphics.DrawString("First line of Text", font, XBrushes.Black, new XRect(0,0, page.Width, page.Height), XStringFormats.TopLeft);
            xGraphics.DrawString("Second line of Text", font, XBrushes.Black, new XRect(0,0, page.Width, page.Height), XStringFormats.Center);

            pdfDocument.Save("test.pdf");
            Console.WriteLine("Document saved successfullly");
            Console.ReadLine();
        }
    }
}
