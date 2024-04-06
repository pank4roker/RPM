using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12pr
{
    public class DocumentStorageException : Exception
    {
        public DocumentStorageException(string message) : base(message)
        {
        }
    }

    public class OfficeWorker
    {
        private int deskCapacity;
        private int drawerCapacity;
        private List<string> deskDocuments = new List<string>();
        private List<string> drawerDocuments = new List<string>();
        private List<string> archiveDocuments = new List<string>();

        public OfficeWorker(int deskCapacity, int drawerCapacity)
        {
            this.deskCapacity = deskCapacity;
            this.drawerCapacity = drawerCapacity;
        }

        public void SendDocument(string document)
        {
            deskDocuments.Add(document);

            if (deskDocuments.Count > deskCapacity)
            {
                MoveDeskDocumentsToDrawer();
            }

            if (drawerDocuments.Count > drawerCapacity)
            {
                ArchiveDocuments();
            }
        }

        private void MoveDeskDocumentsToDrawer()
        {
            Console.WriteLine($"Перенос всех документов со стола в ящик стола.");
            foreach (var doc in deskDocuments)
            {
                drawerDocuments.Add(doc);
            }
            deskDocuments.Clear();
        }

        private void ArchiveDocuments()
        {
            Console.WriteLine($"Архивирование {drawerDocuments.Count} документов из ящика стола.");
            foreach (var doc in drawerDocuments)
            {
                archiveDocuments.Add(doc);
            }
            drawerDocuments.Clear();
        }

        public void ClearDeskAndDrawer()
        {
            deskDocuments.Clear();
            drawerDocuments.Clear();
            Console.WriteLine("");
        }

        public void Dismissal()
        {
            ClearDeskAndDrawer();
            Console.WriteLine("Сотрудник уволен. Все документы удалены со стола и из ящика стола.");
        }

        public void DisplayDeskDocuments()
        {
            Console.WriteLine("Документы на столе:");
            foreach (var doc in deskDocuments)
            {
                Console.WriteLine(doc);
            }
        }

        public void DisplayDrawerDocuments()
        {
            Console.WriteLine("Документы в ящике стола:");
            foreach (var doc in drawerDocuments)
            {
                Console.WriteLine(doc);
            }
        }

        public void DisplayArchiveDocuments()
        {
            Console.WriteLine("Документы в архиве:");
            foreach (var doc in archiveDocuments)
            {
                Console.WriteLine(doc);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вместимость стола (n):");
            int deskCapacity = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вместимость ящика стола (m):");
            int drawerCapacity = int.Parse(Console.ReadLine());

            OfficeWorker worker = new OfficeWorker(deskCapacity, drawerCapacity);

            while (true)
            {
                Console.WriteLine("Введите команду ('send' для отправки документа, 'dismissal' для увольнения сотрудника, 'info' для вывода информации, 'exit' для выхода):");
                string command = Console.ReadLine();

                if (command == "exit")
                {
                    break;
                }
                else if (command == "dismissal")
                {
                    worker.Dismissal();
                    continue;
                }
                else if (command == "info")
                {
                    worker.DisplayDeskDocuments();
                    worker.DisplayDrawerDocuments();
                    worker.DisplayArchiveDocuments();
                    continue;
                }
                else if (command == "send")
                {
                    Console.WriteLine("Введите название документа:");
                    string document = Console.ReadLine();

                    try
                    {
                        worker.SendDocument(document);
                    }
                    catch (DocumentStorageException ex)
                    {
                        Console.WriteLine("Ошибка: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Неверная команда. Попробуйте еще раз.");
                }
            }
        }
    }
}

