// See https://aka.ms/new-console-template for more information
using System;
using ares;

IStudent student = new Student();
student.SayMyName();

new Alex().SayMyName();

class Alex : IStudent
        {
            public void SayMyName()
            {
                Console.WriteLine("Alex");
            }
        }