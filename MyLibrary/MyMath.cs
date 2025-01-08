namespace MyLibrary
{
    public class MyMath
    {
        public static string SecondsToTime(int totalSeconds)
        {
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return $"{hours} hores {minutes} minuts {seconds} segons";
        }
    }
}
