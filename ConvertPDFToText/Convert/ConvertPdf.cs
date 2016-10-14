using System;
using TikaOnDotNet.TextExtraction;
using System.Text.RegularExpressions;
using TikaOnDotNet;
using System.Diagnostics;

namespace ConvertPDFToText.Convert
{
    public class ConvertPdf
    {
        public void GetString()
        {
            string folder = @"C:\Users\lester.xu\Desktop\New folder\";
            string inFile = "test2.pdf";
            string outFile = inFile.Remove(0, inFile.Length - 4) + ".txt";

            

            var text = new TextExtractor().Extract(folder+inFile).Text;

            string resultString = Regex.Replace(text, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();

            Debug.WriteLine(resultString);

            //string fileName = GetBetween(resultString, "File Name:", "File").Remove(0,1);
            //string fileSize = GetBetween(resultString, "File Size:", "Created").Remove(0, 1);
            //string fileDate = GetBetween(resultString, "Created Date:", "File").Remove(0, 1);
            //string fileContent = GetLastString(resultString, "File Content: ");

            //string filecontent2 = Regex.Replace(fileContent, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();

            //Console.WriteLine(fileName);
            //Console.WriteLine(fileSize);
            //Console.WriteLine(fileDate);
            //Console.WriteLine(filecontent2);
            //Console.WriteLine(resultString);
        }

        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);

                return strSource.Substring(Start, End - Start);
            }
            else { return ""; }
        }

        public static string GetLastString(string strSource, string strStart)
        {
            int Start;
            if (strSource.Contains(strStart))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                
                return strSource.Remove(0,Start);
            }
            else { return ""; }
        }
    }
}
