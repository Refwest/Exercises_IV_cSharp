using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesI;

class Program
{
    static void Main(string[] args)
    {
        ////// !Exercise nr 1
        //Console.WriteLine("Exercise nr 1 \n");
        //int[] zipCodeArray = new int[10] { 30, 32, 31, 33, 38, 35, 39, 37, 34, 36 };

        //Console.WriteLine("Enter zip code to check");
        //int zipAnswer = int.Parse(Console.ReadLine());

        //for (int i = 0; i < zipCodeArray.Length; i++)
        //{
        //    if (zipAnswer == zipCodeArray[i])
        //    {
        //        Console.WriteLine("Code {0} is on the list", zipAnswer);
        //        break;
        //    }
        //    else if (i == zipCodeArray.Length - 1)
        //    {
        //        Console.WriteLine("On the list there is not this zip code");
        //    }
        //}


        ////// !Exercise nr 2
        //Console.WriteLine("Exercise nr 2 \n");


        //Console.WriteLine("Enter amount of students");
        //int amountStudents = int.Parse(Console.ReadLine());

        //string[] studentsArray = new string[amountStudents];
        //int[] gradeArray = new int[amountStudents];
        //double avarageScore = 0;
        //double highestgrade = 0;
        //string topStudent = "";

        //for (int i = 0; i < studentsArray.Length; i++)
        //{
        //    Console.WriteLine("There is {0} students, enter name of {1} student", amountStudents, (i+1));
        //    studentsArray[i] = Console.ReadLine();

        //    Console.WriteLine("Enter final score of " + studentsArray[i]);
        //    gradeArray[i] = int.Parse(Console.ReadLine());
        //    avarageScore += gradeArray[i];
        //    if (gradeArray[i] > highestgrade)
        //    {
        //        highestgrade = gradeArray[i];
        //        topStudent = studentsArray[i];
        //    }
        //}
        //int[] sortedGradesArray = gradeArray;
        //Array.Sort(sortedGradesArray);
        //Console.WriteLine("Highest final score was {0}", sortedGradesArray[sortedGradesArray.Length - 1]);
        //Console.WriteLine("Highest final score get {0} and it was {1}", topStudent, highestgrade);
        //Console.WriteLine("Avarage score is {0}", avarageScore/gradeArray.Length);


        ////// !Exercise nr 3
        ///
        //Console.WriteLine("Exercise nr 3 \n");

        //string words = "Any word";
        //if (words.Contains("Any"))
        //{
        // Console.WriteLine("It contains");
        //}

        //words = words.Remove(1,1);
        //Console.WriteLine(words);

        //words = words.Insert(1, "n");
        //Console.WriteLine(words);


        ////// !Exercise nr 4 - Hangman

        Console.WriteLine("Exercise nr 4 \n");

        string[] Words = new string[8] {"atlas", "biology", "conduct", "desorb", "effect", "frightening", "Goteborg", "hamster"};

        Random bigRandom = new Random();
        int randomNumber = bigRandom.Next(0, 7);

        string hiddenWord = Words[randomNumber];
        string asteriskWord = hiddenWord;
        //Console.WriteLine(shotWord);
        
        for (int i = 0; i < hiddenWord.Length; i++)
        {
            asteriskWord = asteriskWord.Replace(hiddenWord[i], '*');
        }
        //Console.WriteLine(shotWord);

        Console.WriteLine("Hi, let's start hangman game!");

        while (hiddenWord != asteriskWord)
        {
            Console.WriteLine("The word is: {0}. Take guess of letter:", asteriskWord);
            char shot = char.Parse(Console.ReadLine());
            if (hiddenWord.Contains(shot))
            {
                for (int j = 0; j < hiddenWord.Length; j++)
                {
                    if (hiddenWord[j] == shot)
                    {
                        string shot2 = char.ToString(shot);
                        asteriskWord = asteriskWord.Remove(j,1);
                        asteriskWord = asteriskWord.Insert(j, shot2);
                    }
                }
                Console.WriteLine("Good job, your guess is correct.");
            }
            else
            {
                Console.WriteLine("Your guess is incorect, try again");
            }
        }
        Console.WriteLine("Congratulation you correctly guessed the word \"{0}\", You win.", asteriskWord);


    }
}
