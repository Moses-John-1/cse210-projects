using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Top Stocks to Buy in 2025", "InvestSmart", 750);
        video1.AddComment("Michael", "Apple stock is a safe bet, but I think Tesla has more upside.");
        video1.AddComment("Sarah", "Anyone looking at Nvidia? AI stocks are the future!");
        video1.AddComment("David", "I'm bullish on Palantir. Great data analytics company.");

        Video video2 = new Video("Stock Market Crash Incoming?", "FinanceToday", 600);
        video2.AddComment("John", "I think the Fed's rate decisions will be crucial.");
        video2.AddComment("Emily", "Tech stocks are too overvalued, a correction is overdue.");
        video2.AddComment("Robert", "Energy stocks might be the safest play right now.");

        Video video3 = new Video("How to Build a Million-Dollar Portfolio", "WealthBuilder", 800);
        video3.AddComment("Linda", "Diversification is key! Can't go all-in on one sector.");
        video3.AddComment("Chris", "Dividend stocks are underrated for long-term growth.");
        video3.AddComment("James", "I wish I started investing in my 20s!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
