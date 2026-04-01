public class Program
{
    public static string NameShuffle(string str)
    {
        var array = str.Split(' ');
        return array[1] + ' ' + array[0];
    }
}