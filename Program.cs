using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz {
    class Program {
        static void Main(string[] args) {
            
            //create list of questions
            string[] questions={
                "Co wyroslo z brzydkiego kaczatka?",
                "Akcja Dziewczynki z zapalkami rozgrywa sie podczas wyjatkowego dnia. Co to za dzien?",
                "Slynna zguba Kopcuszka to:"
            };

            //Create Answers
            string[] answers = {
                "A.Piekna kaczka \nB.Czarna kaczka \nC.Czarny labedz \nD.Piekny labedz",
                "A.wigilia Nowego Roku \nB.wigilia Bozego Narodzenia \nC.Wszystkich Swietych \nD.swieto zakochanych",
                "A.Chusteczka \nB.Pierscionek \nC.Pantofelek \nD.Broszka"
            };

            // index of correct answer
            int[] correctAnswers = {
                3,
                1,
                2
            };
            int score= 0;

            Console.WriteLine("Witaj w quiz-ie na temat bajek i legend.");
            for(int i=0; i<questions.Length; i++) {
                Console.WriteLine("\nPytanie " + i);
                Console.WriteLine(questions[i]);
                Console.WriteLine(answers[i]);
                Console.Write("Wybierz odpowiedz ('A', 'B', 'C' czy 'D'): ");
                string playerAnswer= Console.ReadLine();

                //sprawdzanie odpowiedzi
                if (string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0) { //sprawdza czy odpowiedz gracza jest A (ignoruje wielkosc liter) i czy odpowiedz zgadza sie z indeksem poprawnych odpowiedzi
                    score++;
                }else if(string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 1) {
                    score++;
                }else if(string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 2) {
                    score++;
                }else if(string.Equals(playerAnswer, "D", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 3) {
                    score++;
                }
            }

            // Drukujemy wynik quizu
            Console.WriteLine("Brawo! ukonczyles gre!");
            Console.WriteLine($"Twoj wynik to {score} z " + questions.Length);
            Console.ReadKey();
            

        }

    }
}
