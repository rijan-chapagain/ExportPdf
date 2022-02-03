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

            xGraphics.DrawLine(new XPen(XColor.FromArgb(50, 30, 200)), new XPoint(50, 290), new XPoint(550, 290));

            // generate Header for table
            xGraphics.DrawString("First Name", font, XBrushes.Black, new XPoint(100,280));
            xGraphics.DrawString("First Name", font, XBrushes.Black, new XPoint(250,280));
            xGraphics.DrawString("First Name", font, XBrushes.Black, new XPoint(400,280));
            xGraphics.DrawLine(new XPen(XColor.FromArgb(50, 30, 200)), new XPoint(50, 290), new XPoint(550, 290));

            int currentYposition_value = 303;
            int currentYposition_line = 310;

            /*count number of rows to display in one table
             * TODO: Add statement to control new page
              if(count <= 20)
            {

            }*/

            for(int i = 0; i < 20; i++)
            {
                xGraphics.DrawString("FirstName", font, XBrushes.Black, new XPoint(100, currentYposition_value));
                xGraphics.DrawString("FirstName", font, XBrushes.Black, new XPoint(250, currentYposition_value));
                xGraphics.DrawString("FirstName", font, XBrushes.Black, new XPoint(400, currentYposition_value));
                xGraphics.DrawLine(new XPen(XColor.FromArgb(50, 30, 200)), new XPoint(50, currentYposition_line), new XPoint(550, currentYposition_line));

                currentYposition_value += 20;
                currentYposition_line += 20;
            }

            /*
             * TODO: Add statement to control new page
             else {

                        same + 
            count.Remove(count[i])

                        page = pdfDocument.AddPage();
            xGraphics = XGraphics.FromPdfPage(page);
            }
             */
            xGraphics.DrawString("First line of Text", font, XBrushes.Black, new XRect(0,0, page.Width, page.Height), XStringFormats.TopLeft);

            pdfDocument.Save("test.pdf");
            Console.WriteLine("Document saved successfullly");
            Console.ReadLine();
        }
    }
}

/*
// The class will provide drawing related methods for specified page
XGraphics xGraphics = XGraphics.FromPdfPage(page);

// Choose font to be used on the text
XFont font = new XFont("Arial", 20);

xGraphics.DrawString("First line of Text", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft);
xGraphics.DrawString("Second line of Text", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

pdfDocument.Save("test.pdf");
Console.WriteLine("Document saved successfullly");
Console.ReadLine();*/