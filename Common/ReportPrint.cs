using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifaClinic.Common
{
    public class ReportPrint
    {
        private List<Stream> m_streams;
        private int m_currentPageIndex = 0;
        public ReportPrint()
        { }

        public void PrintToPrinter(LocalReport report)
        {
            Export(report);
        }

        public void Export(LocalReport report, bool print = true)
        {
            var reportSettings = report.GetDefaultPageSettings();
            float width = (float)reportSettings.PaperSize.Width / 100;
            float height = (float)reportSettings.PaperSize.Height / 100;
            float marginTop = (float)reportSettings.Margins.Top / 100;
            float marginLeft = (float)reportSettings.Margins.Left / 100;
            float marginRight = (float)reportSettings.Margins.Right / 100;
            float marginBottom = (float)reportSettings.Margins.Bottom / 100;
            string deviceInfo =
             $@"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>{width}in</PageWidth>
                <PageHeight>{height}in</PageHeight>
                <MarginTop>{marginTop}in</MarginTop>
                <MarginLeft>{marginLeft}in</MarginLeft>
                <MarginRight>{marginRight}in</MarginRight>
                <MarginBottom>{marginBottom}in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);

            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print(reportSettings);
            }
        }

        public void Print(ReportPageSettings reportPageSettings)
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Margins = reportPageSettings.Margins;
            printDoc.DefaultPageSettings.PaperSize = reportPageSettings.PaperSize;

            printDoc.DefaultPageSettings.Margins = reportPageSettings.Margins;
            //printDoc.DefaultPageSettings.PrintableArea= reportPageSettings.PaperSize;

            printDoc.DefaultPageSettings.Landscape = reportPageSettings.IsLandscape;
            printDoc.PrinterSettings.DefaultPageSettings.PaperSize = printDoc.DefaultPageSettings.PaperSize;
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public void PrintPage(object sender, PrintPageEventArgs ev)
        {

            var pd = sender as PrintDocument;
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                0,
                0,
                pd.DefaultPageSettings.PaperSize.Width,
                pd.DefaultPageSettings.PaperSize.Height);

            //Rectangle adjustedRect = new Rectangle(
            //    ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
            //    ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
            //    ev.PageBounds.Width,
            //    ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

    }
}
