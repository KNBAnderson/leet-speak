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
      else if (letter == 'o' || letter == 'O')
      {
        return '0';
      }
      else if (letter == 'I')
      {
        return '1';
      }
      else if (letter == 't' || letter == 'T')
      {
        return '7';
      }
      else if (letter == 's' || letter == 'S')
      {
        return 'Z';
      }
      return letter;
    }

    public string AssessWord(string word)
    {
      string newWord = "";
      char[] charArray = word.ToCharArray();
      for (int index = 0; index <= charArray.Length - 1; index++)
      {
        if (index == 0 && (charArray[index] == 's' || charArray[index] == 'S'))
        {
          newWord += charArray[index].ToString();
        }
        else
        {
          newWord += MakeLeetSpeak(charArray[index]).ToString();
        }
      }
      return newWord;
    }

    public string BreakApartString(string words)
    {
      string stupidWords = "";
      string[] wordArray = words.Split(' ');

      foreach (string word in wordArray)
      {
        stupidWords += AssessWord(word);
      }
        return stupidWords;
    }
  }

}





//char[] chars = word.ToCharArray();
//for loop through chars.lenght

//  if i == 0 && chars[i] == 's' || 'S'
//     return chars[0]
//  else
//  MakeLeetSpeak(chars[i])
