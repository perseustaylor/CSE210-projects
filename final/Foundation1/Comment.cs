public class Comment
{
  public string _Commenter;
  public string _Text;

  public Comment(string Commenter, string Text)
  {
    _Commenter = Commenter;
    _Text = Text;
  }

  public void DisplayComment()
    {
        Console.WriteLine($"{_Commenter}: {_Text}");
    } 
}