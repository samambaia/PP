using System;
using System.IO;
using System.Data;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace PPDotNet.Formulários.Sistema
{
    class Helpers
    {
        public class Demo : IDisposable
        {
            private int m_currentPageIndex;
            private IList<Stream> m_streams;

            private DataTable LoadSalesData(string idorca)
            {
                DataSources.dsSaida.view_imp_orcaDataTable dt = new DataSources.dsSaida.view_imp_orcaDataTable();
                DataSources.dsSaidaTableAdapters.view_imp_orcaTableAdapter ta = new DataSources.dsSaidaTableAdapters.view_imp_orcaTableAdapter();
                
                ta.Fill(dt, int.Parse(idorca));

                return ta.GetData(int.Parse(idorca));
            }

            private Stream CreateStream(string name, string fileNameExtension, Encoding encoding,
                                      string mimeType, bool willSeek)
            {
                Stream stream = new FileStream(name + "." + fileNameExtension, FileMode.Create);
                m_streams.Add(stream);
                return stream;
            }

            private void Export(LocalReport report)
            {
                string deviceInfo =
                  "<DeviceInfo>" +
                  //"  <OutputFormat>XLS</OutputFormat>" + 
                  "  <DpiX>800</DpiX> " +
                  "  <DpiY>600</DpiY> " +
                  "  <PageWidth>8.5in</PageWidth>" +
                  "  <PageHeight>11in</PageHeight>" +
                  "  <MarginTop>0.25in</MarginTop>" +
                  "  <MarginLeft>0.25in</MarginLeft>" +
                  "  <MarginRight>0.25in</MarginRight>" +
                  "  <MarginBottom>0.25in</MarginBottom>" +
                  "</DeviceInfo>";
                Warning[] warnings;
                m_streams = new List<Stream>();
                report.Render("PDF", deviceInfo, CreateStream, out warnings);

                foreach (Stream stream in m_streams)
                    stream.Position = 0;
            }

            public void Run(string path, string idorca, string printername)
            {
                LocalReport report = new LocalReport();
                report.ReportPath = path;//"Report.rdlc";
                report.DataSources.Add(new ReportDataSource("dsOrca", LoadSalesData(idorca)));

                Export(report);

                m_currentPageIndex = 0;
                Print(printername);
            }

            private void Print(string printerName)
            {
                //const string printerName = "Microsoft XPS Document Writer";

                if (m_streams == null || m_streams.Count == 0)
                    return;

                PrintDocument printDoc = new PrintDocument(); 
                printDoc.PrinterSettings.PrinterName = printerName;
                if (!printDoc.PrinterSettings.IsValid)
                {
                    string msg = String.Format("Can't find printer \"{0}\".", printerName);
                    Console.WriteLine(msg);
                    return;
                }
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                printDoc.Print();
            }

            private void PrintPage(object sender, PrintPageEventArgs ev)
            {
                Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);
                ev.Graphics.DrawImage(pageImage, 0, 0);

                m_currentPageIndex++;
                ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
            }

            public void Dispose()
            {
                if (m_streams != null)
                {
                    foreach (Stream stream in m_streams)
                        stream.Close();
                }
            }

            //public static void Main(string[] args) 
            //{
            //    using (Demo demo = new Demo())
            //    {
            //        demo.Run();
            //    }
            //}
        }
    }
}
