namespace Leet
{
  public class LeetSpeak
  {
    public char MakeLeetSpeak(char letter)
    {
      if (letter == 'e' || letter == 'E')
      {
        return '3';
      }
      return letter;
    }
  }
}
