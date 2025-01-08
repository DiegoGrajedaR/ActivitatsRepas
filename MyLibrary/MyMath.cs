namespace MyLibrary

public class MyMath
{
    public static string SecondsToTime(int totalSeconds)
    {
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        return $"{hours} hores {minutes} minuts {seconds} segons";
    }

    public static double CalculateTriangleArea(double baseTriangle, double heightTriangle)
    {
        if (baseTriangle <= 0 || heightTriangle <= 0)
        {
            throw new ArgumentException("La base i l'altura han de ser majors a 0.");
        }

        return (baseTriangle * heightTriangle) / 2;
    }
}
