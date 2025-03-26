using System;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeUser> uploadedVideos;
    public string Username;

    public SayaTubeUser(string Username)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.uploadedVideos = new List<SayaTubeUser>();
        this.Username = Username;
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;

        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            total += uploadedVideos[i].;
        }

        return total;
    }

    public void printAllVideoPlayCount()
    {
        Console.WriteLine("User :" + Username );
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine(uploadedVideos[i]);
        }
    }
}

class SayaTubeVideo 
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo (string title)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video Details: ");
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }

    public int getPlayCount()
    {
        return playCount;
    }
}

class program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Khalish");
        SayaTubeVideo video = new SayaTubeVideo("title 1");
        video.IncreasePlayCount(10);
        video.PrintVideoDetails();
    }
}
