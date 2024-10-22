
public class Rootobject
{
    public Result[] results { get; set; }
}

public class Result
{
    public int age { get; set; }
    public string dominant_emotion { get; set; }
    public string dominant_gender { get; set; }
    public string dominant_race { get; set; }
    public Emotion emotion { get; set; }
    public float face_confidence { get; set; }
    public Gender gender { get; set; }
    public Race race { get; set; }
    public Region region { get; set; }
}

public class Emotion
{
    public float angry { get; set; }
    public float disgust { get; set; }
    public float fear { get; set; }
    public float happy { get; set; }
    public float neutral { get; set; }
    public float sad { get; set; }
    public float surprise { get; set; }
}

public class Gender
{
    public float Man { get; set; }
    public float Woman { get; set; }
}

public class Race
{
    public float asian { get; set; }
    public float black { get; set; }
    public float indian { get; set; }
    public float latinohispanic { get; set; }
    public float middleeastern { get; set; }
    public float white { get; set; }
}

public class Region
{
    public int h { get; set; }
    public int[] left_eye { get; set; }
    public int[] right_eye { get; set; }
    public int w { get; set; }
    public int x { get; set; }
    public int y { get; set; }
}
