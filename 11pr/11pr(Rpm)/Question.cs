using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11pr_Rpm_
{
    class Question
    {
        // Текст вопроса
        public string Text { get; set; }

        // Список вариантов ответов
        public List<string> Options { get; set; }

        // Индекс правильного ответа в списке Options
        public int CorrectOptionIndex { get; set; }

        // Количество баллов за правильный ответ на вопрос
        public int Points { get; set; }

        // Конструктор класса Question для инициализации его свойств
        public Question(string text, List<string> options, int correctOptionIndex, int points)
        {
            Text = text;
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
            Points = points;
        }
    }

    class Answer
    {
        // Список индексов выбранных вариантов ответов
        public List<int> SelectedOptions { get; set; }

        // Конструктор класса Answer для инициализации свойства SelectedOptions
        public Answer()
        {
            SelectedOptions = new List<int>();
        }
    }

    class Test
    {
        private List<Question> questions; // Список вопросов теста
        private Answer answer; // Ответы на вопросы теста

        // Конструктор класса Test для инициализации списка вопросов и ответов
        public Test()
        {
            questions = new List<Question>();
            answer = new Answer();
        }

        // Метод для добавления нового вопроса в тест
        public void AddQuestion(string text, List<string> options, int correctOptionIndex, int points)
        {
            Question question = new Question(text, options, correctOptionIndex, points);
            questions.Add(question);
        }

        // Метод для вывода текста вопроса и вариантов ответов на экран
        public void DisplayQuestion(int questionNumber)
        {
            if (questionNumber >= 0 && questionNumber < questions.Count)
            {
                Question question = questions[questionNumber];
                Console.WriteLine("Вопрос {0}: {1}", questionNumber + 1, question.Text);
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, question.Options[i]);
                }
            }
            else
            {
                Console.WriteLine("Вопрос с номером {0} не существует.", questionNumber + 1);
            }
        }

        // Метод для выбора варианта ответа на вопрос
        public void ChooseOption(int questionNumber, int selectedOption)
        {
            if (questionNumber >= 0 && questionNumber < questions.Count)
            {
                answer.SelectedOptions.Add(selectedOption - 1);
            }
            else
            {
                Console.WriteLine("Вопрос с номером {0} не существует.", questionNumber + 1);
            }
        }

        // Метод для вывода результатов тестирования (количество правильных и неправильных ответов, количество баллов)
        public void DisplayResults()
        {
            int totalPoints = 0; // Общее количество баллов
            int correctAnswers = 0; // Количество правильных ответов

            // Перебираем все вопросы
            for (int i = 0; i < questions.Count; i++)
            {
                Question question = questions[i];
                int selectedOptionIndex = answer.SelectedOptions[i];
                // Если выбранный вариант ответа совпадает с правильным, увеличиваем счетчик правильных ответов и добавляем баллы
                if (selectedOptionIndex == question.CorrectOptionIndex)
                {
                    correctAnswers++;
                    totalPoints += question.Points;
                }
            }

            // Выводим результаты тестирования
            Console.WriteLine("Количество правильных ответов: {0}", correctAnswers);
            Console.WriteLine("Количество неправильных ответов: {0}", questions.Count - correctAnswers);
            Console.WriteLine("Набранное количество баллов: {0}", totalPoints);
        }
    }
}
