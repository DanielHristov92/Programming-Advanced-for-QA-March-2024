﻿using System;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] studentData = input.Split();
            string firstName = studentData[0];
            string lastName = studentData[1];
            int age = int.Parse(studentData[2]);
            string homeTown = studentData[3];
            students.Add(new Student(firstName, lastName, age, homeTown));
        }

        string city = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.HomeTown == city)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
