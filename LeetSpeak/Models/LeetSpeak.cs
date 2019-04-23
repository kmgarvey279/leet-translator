namespace LeetSpeak.Models
{
  public class LeetSpeakTranslator
  {
    public string Translate(string userInput)
    {
      char[] myArr = userInput.ToCharArray();
      for(int i = 0; i < myArr.Length; i++)
      {
        if(myArr[i]== 'e' || myArr[i]== 'E')
        {
          myArr[i]= '3';
        }
        else if(myArr[i] =='o' || myArr[i] =='O')
        {
          myArr[i] = '0';
        }
        else if(myArr[i] == 'I')
        {
          myArr[i] = '1';
        }
        else if(myArr[i] == 't' || myArr[i] == 'T')
        {
          myArr[i] = '7';
        }
        else if (myArr[i] == 's' && i != 0 || myArr[i] == 'S' && i != 0 )
        // else if(myArr[i] == 's' && myArr[i] >= 'A' && myArr[i] <= 'Z' && myArr[i] >= 'a' && myArr[i] <= 'z')
        {
          myArr[i] = 'z';
        }
      }
      return string.Join("", myArr);
    }
  }
}
