public class Video 
{
   public string _title;
   public string _author;
   private int _length; 

   public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetInfo()
    {
        return $"Title: {_title}, Author: {_author}, Length: {_length} seconds";
    }

}