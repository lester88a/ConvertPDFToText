using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string folder = @"C:\Users\lester.xu\Desktop\New folder\";
            string inFile = "test3.txt";
            string outFile = inFile.Substring(0, inFile.Length - 4) + "New.txt";
            string result = "";


            //first format the text file
            #region
            TextWriter tw = new StreamWriter(folder + outFile);
            TextReader tr = new StreamReader(folder + inFile, Encoding.GetEncoding("utf-8"));

            string tNoteString = tr.ReadLine();
            while (tNoteString != null)
            {
                tw.WriteLine(tNoteString);
                tNoteString = tr.ReadLine();

            }
            tw.Close();
            tr.Close();
            System.IO.File.Delete(folder + inFile);
            System.IO.File.Copy(folder + outFile, folder + inFile);
            #endregion

            //second get data
            #region
            using (StreamReader sr = new StreamReader(folder + inFile, System.Text.Encoding.GetEncoding("utf-8")))
            {
                
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // ...
                    result += line;
                }
            }
            string resultString = Regex.Replace(result, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();
            #endregion




            //assign the data
            #region
            string title1 = GetFirstTitle(resultString, "高中") + "高中";
            string title2 = GetBetweenWithOutName(resultString, "高中", "High School")+ "High School";
            string underTitle = GetBetweenWithOutName(resultString, title2, "基本信息 Basic Information");
            #endregion

            Debug.WriteLine(result);
            Debug.WriteLine(title1);
            Debug.WriteLine(title2);
            Debug.WriteLine(underTitle);
        }

        public static string GetFirstTitle(string strSource, string strEnd)
        {
            int End;
            if (strSource.Contains(strEnd))
            {
                End = strSource.IndexOf(strEnd, 0);

                return strSource.Substring(0, End - 0);
            }
            else { return ""; }
        }


        public static string GetBetweenWithName(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                //Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                Start = strSource.IndexOf(strStart, 0);
                End = strSource.IndexOf(strEnd, Start);

                return strSource.Substring(Start, End - Start);
            }
            else { return ""; }
        }

        public static string GetBetweenWithOutName(string strSource, string strStart, string strEnd)
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
                //Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                Start = strSource.IndexOf(strStart, 0);

                return strSource.Remove(0, Start);
            }
            else { return ""; }
        }
    }
}
