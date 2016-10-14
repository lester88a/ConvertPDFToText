using ConvertPDFToText.Convert;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConvertPDFToText
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertPdf crv = new ConvertPdf();
            crv.GetString();

            #region
            //// create an instance of the pdfparser class
            //PDFParser pdfParser = new PDFParser();

            //string folder = @"C:\Users\lester.xu\Desktop\New folder\";
            //string inFile = "test2.pdf";
            //string outFile = inFile.Substring(0, inFile.Length - 4) + "New.txt";

            ////Console.WriteLine(outFile);

            //// Create a reader for the given PDF file
            //PdfReader reader = new PdfReader(folder + inFile);

            //string result = pdfParser.ExtractTextFromPDFBytes(reader.GetPageContent(1));

            //Debug.WriteLine(result);


            ////// extract the text
            //bool result = pdfParser.ExtractText(folder + inFile, folder + outFile);
            //Console.WriteLine("\nRe: "+result);
            #endregion

            // gb2312 (codepage 936) :
            //System.Text.Encoding.GetEncoding(936);

            //TextWriter tw = new StreamWriter(folder+outFile);
            //TextReader tr = new StreamReader(folder+inFile, Encoding.GetEncoding("utf-8"));

            //string tNoteString = tr.ReadLine();
            //while (tNoteString != null)
            //{
            //    tw.WriteLine(tNoteString);
            //    tNoteString = tr.ReadLine();

            //}
            //tw.Close();
            //tr.Close();
            //System.IO.File.Delete(folder+inFile);
            //System.IO.File.Copy(folder + outFile, folder + inFile);


            //string contents = File.ReadAllText(folder+inFile);

            //Console.WriteLine(contents);





            //using (StreamReader sr = new StreamReader(folder+inFile, System.Text.Encoding.GetEncoding("utf-8")))
            //{
            //    string result = "";
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        // ...
            //        result += line;

            //    }
            //    Console.OutputEncoding = Encoding.UTF8;
            //    Console.WriteLine(result);
            //}




            Console.ReadKey();
        }
    }
}
