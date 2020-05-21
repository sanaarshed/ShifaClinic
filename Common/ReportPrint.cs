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
using System.Windows.Forms;

namespace ShifaClinic.Common
{
    public class ReportPrint
    {
        private List<Stream> m_streams;
        private int m_currentPageIndex = 0;
        public List<ReportParameter> ReportParameters { get; set; }
        public ReportPrint()
        {
            this.ReportParameters = new List<ReportParameter>();
        }

        public void PrintToPrinter(LocalReport report)
        {
            if (ReportParameters.Count > 0)
                report.SetParameters(ReportParameters);
            Export(report);
        }

        private void Export(LocalReport report, bool print = true)
        {
            float width = 0, height = 0;
            var reportSettings = report.GetDefaultPageSettings();
            if (reportSettings.IsLandscape)
            {
                height = (float)reportSettings.PaperSize.Width / 100;
                width = (float)reportSettings.PaperSize.Height / 100;
            }
            else
            {
                width = (float)reportSettings.PaperSize.Width / 100;
                height = (float)reportSettings.PaperSize.Height / 100;
            }
            float marginTop = (float)reportSettings.Margins.Top / 100;
            float marginLeft = (float)reportSettings.Margins.Left / 100;
            float marginRight = (float)reportSettings.Margins.Right / 100;
            float marginBottom = (float)reportSettings.Margins.Bottom / 100;

            string deviceInfo = "";
            deviceInfo = $@"<DeviceInfo>
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

        private void Print(ReportPageSettings reportPageSettings)
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.MaximumPage = 1;
            printDoc.DefaultPageSettings.Landscape = reportPageSettings.IsLandscape;

            if (reportPageSettings.IsLandscape)
            {
                printDoc.DefaultPageSettings.PaperSize = new PaperSize("9 X 6",
                    reportPageSettings.PaperSize.Height,
                    reportPageSettings.PaperSize.Width);
            }
            else
            {
                printDoc.DefaultPageSettings.PaperSize = reportPageSettings.PaperSize;
            }

            printDoc.DefaultPageSettings.Margins = reportPageSettings.Margins;
            using (var db = new ShifaClinic.DataContext.clinicDbContext())
            { printDoc.PrinterSettings.PrinterName = db.PrinterInfoes.Where(p => p.id == 1).FirstOrDefault().name; }

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

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            var pd = sender as PrintDocument;
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle();
            adjustedRect.Width = pd.DefaultPageSettings.PaperSize.Width;
            adjustedRect.Height = pd.DefaultPageSettings.PaperSize.Height;

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

        public void Print(System.Data.DataTable DataSource, string DatasetName, string ReportFileName, string FolderName)
        {
            string p = Path.GetDirectoryName(Application.ExecutablePath);
            string path = p.Remove(p.Length - 10) + "\\" + FolderName + "\\Reports\\" + ReportFileName;
            LocalReport report = new LocalReport();
            report.ReportPath = path;
            ReportDataSource ds = new ReportDataSource();
            ds.Name = DatasetName;
            ds.Value = DataSource;
            report.DataSources.Add(ds);

            this.PrintToPrinter(report);
        }

        public void Print(List<System.Data.DataTable> DataSource, string ReportFileName, string FolderName)
        {
            string p = Path.GetDirectoryName(Application.ExecutablePath);
            string path = p.Remove(p.Length - 10) + "\\" + FolderName + "\\Reports\\" + ReportFileName;
            LocalReport report = new LocalReport();
            report.ReportPath = path;

            foreach (var d in DataSource)
            {
                ReportDataSource ds = new ReportDataSource();
                ds.Name = d.TableName;
                ds.Value = d;
                report.DataSources.Add(ds);
            }

            this.PrintToPrinter(report);
        }

    }
}
