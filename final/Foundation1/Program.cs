using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();
        Video video4 = new Video();
        string page1 = video1.stuff();
        string page2 = video2.stuff();
        string page3 = video3.stuff();
        string page4 = video4.stuff();
        Console.WriteLine(page1);
        Console.WriteLine(page2);
        Console.WriteLine(page3);
        Console.WriteLine(page4);
        string pause = Console.ReadLine();
        Console.WriteLine(pause);
    }
}
public class Video
{
    public string stuff()
    {
        Console.WriteLine("Enter author");
        string author = Console.ReadLine();
        Console.WriteLine("Enter title");
        string title = Console.ReadLine();
        Console.WriteLine("Enter length in minutes.");
        int length = Int32.Parse(Console.ReadLine());
        Comment videocomments = new Comment();
        string commentSection = videocomments.comments();
        string sstuff = "author " + author + "\ntitle: " + title + "\nlength: " + length + "\n" + commentSection;
        return sstuff;
    }
}
public class Comment
{
    public string comments()
    {
        Console.WriteLine("Enter comment");
        string comment = Console.ReadLine();
        return comment;
    }
}