using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    public class FileOperations
    {
        public string FilePath { get; set; }
        public string? StringToSearch { get; set; }

        public FileOperations(string filePath)
        {
            FilePath = filePath;
        }

        public string[] ReadText()
        {
            if (File.Exists(FilePath))
            {
                return File.ReadAllLines(FilePath);
            }
            else
            {
                throw new FileNotFoundException($"Nie znaleziono pliku{FilePath}");
            }
        }

        public (string, int) SearchString(string text)
        {
            string output = "";
            int count = 0;
            string[] Lines = ReadText();
            int LineNum = 0;

            foreach (string line in Lines) {
                for (int j = 0; j <= line.Length - text.Length; j++)
                {
                    if (line.Substring(j, text.Length) == text)
                    {
                        output += $"Znaleziono '{text}' na w linijce {LineNum} \n";
                        count++;
                    }
                }
                LineNum++;
            }

            if (count == 0) output = "Nie znaleziono tekstu"; 

            return (output, count);
        }

        public (string,int)SearchStringSensitive(string text)
        { 
            text = text.ToUpper();

            string output = "";
            int count = 0;
            string[] Lines = ReadText();
            int LineNum = 0;

            foreach (string line in Lines)
            {
                for (int j = 0; j <= line.Length - text.Length; j++)
                {
                    if (line.ToUpper().Substring(j, text.Length) == text)
                    {
                        output += $"Znaleziono '{text}' na w linijce {LineNum} \n";
                        count++;
                    }
                }
                LineNum++;
            }

            if (count == 0) output = "Nie znaleziono tekstu";

            return (output, count);

        }
    }
}
