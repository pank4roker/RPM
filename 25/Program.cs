using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "25", "first_matrices.txt");
            // Вывод содержимого файла на экран
            Console.WriteLine("Содержимое файла first_matrices.txt:");
            DisplayMatrixFromFile(filePath);
            string secondFilePath = Path.Combine(desktopPath, "25", "second_matrices.txt");

            // Вывод содержимого второго файла на экран
            Console.WriteLine("\nСодержимое файла second_matrices.txt:");
            DisplayMatrixFromFile(secondFilePath);
            Console.Read();
        }

        static void WriteMatrixToFile(string filePath, int[,] matrix)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(matrix[i, j] + " ");
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();
            }
        }

        static void DisplayMatrixFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Trim() == "") // Пропускаем пустые строки
                        continue;

                    Console.WriteLine(line);
                }
            }
        }
    }

}
