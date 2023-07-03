// See https://aka.ms/new-console-template for more information

using ares;


IStudent student1 = new Student();
student1.SayMyName();
IStudent studentEduard = new StudentEduard();
studentEduard.SayMyName();
var studentDarius = new StudentDarius();
studentDarius.SayMyName();

Console.WriteLine("Entry Point");

IStudent student = new Student1();
student.SayMyName();
