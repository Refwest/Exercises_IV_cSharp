﻿using System;
using System.Collections.Generic;
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

        ////// !Exercise nr 4
        Console.WriteLine("Exercise nr 4 \n");

        string[] Words = new string[8] {"atlas", "biology", "conduct", "desorb", "effect", "frightening", "Goteborg", "hamster"};

        Random bigRandom = new Random();
        int randomNumber = bigRandom.Next(0, 7);

        string hiddenWord = Words[randomNumber];
        Console.WriteLine(hiddenWord);
        Console.WriteLine(hiddenWord.Length);

        string shotWord = hiddenWord;
        Console.WriteLine(shotWord);
        
        for (int i = 0; i < hiddenWord.Length; i++)
        {
            
            shotWord = shotWord.Replace(hiddenWord[i], '*');
            
        }
        Console.WriteLine(shotWord);


    }
}
