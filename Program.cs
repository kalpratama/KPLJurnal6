using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random rnd = new Random();
        id = rnd.Next(10000, 99999);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (title == null || title.Length > 100)
        {
            throw new ArgumentException("Judul video harus memiliki panjang maksimal 100 karakter dan tidak null.");
        }

        if (count < 0 || count > 25000000)
        {
            throw new ArgumentOutOfRangeException("Jumlah penambahan play count harus antara 0 dan 25.000.000.");
        }

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Overflow terjadi saat menambahkan play count.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> UploadedVideos;
    public string userName;
    private string title;

    public SayaTubeUser(string userName)
    {
        userName = ("Kal_El");
    }

    public static void GetTotalVideoPlayCount(int count)
    {
        if (userName == null || username.Length > 100)
        {
            throw new ArgumentException("User Name harus memiliki panjang maksimal 100 karakter dan tidak null.");
        }

        if (count < 0 || count > 25000000)
        {
            throw new ArgumentOutOfRangeException("Jumlah penambahan play count harus antara 0 dan 25.000.000.");
        }

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Overflow terjadi saat menambahkan play count.");
        }
    }

    public void AddVideo(SayaTubeVideo video)
    {
        UploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount(SayaTubeVideo video)
    {
        Console.WriteLine("User: " + userName);
        Console.WriteLine("Video 1 Judul: " + UploadedVideos);
        Console.WriteLine("Video 2 Judul: " + UploadedVideos);
    }
}

    class Program
{
    public static void Main(string[] args)
    {
        SayaTubeUser name = new SayaTubeUser("KalEl");

        SayaTubeVideo video = new SayaTubeVideo("TWICE - What Is Love M/V");

        for (int i = 0; i < 5; i++)
        {
            video.IncreasePlayCount(2000000); 
        }
        
        video.PrintVideoDetails();

        Console.WriteLine("                    ");
        Console.WriteLine("User: Kal_El");
        Console.WriteLine("Video 1 Judul: TWICE - What Is Love M/V");
        Console.WriteLine("Video 2 Judul: TWICE - Set Me Free M/V");
        Console.WriteLine("Video 3 Judul: Bohemian Rhapsody (2011 Remastered)");
        Console.WriteLine("Video 4 Judul: TWICE - Alcohol Free - Dance Practice");
        Console.WriteLine("Video 5 Judul: STAYC - Like This - Performance Video");
        Console.WriteLine("Video 6 Judul: Genius Engineering Of Porsche 911");
        Console.WriteLine("Video 7 Judul: IVE - I Am - Studio Ver");
        Console.WriteLine("Video 8 Judul: TWICE Turn It Up Lyrics Video");
        Console.WriteLine("Video 9 Judul: 100 Chaeyoung Funny Moments");
        Console.WriteLine("Video 10 Judul: Time To TWICE - S4 EP6");
    }
}