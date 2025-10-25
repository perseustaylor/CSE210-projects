using System;
class Word
{
    private string _Text;
    private int _WordLength;
    private bool _hiddenState;
    public Word(string text)
    {
        _Text = text;
        _WordLength = text.Length;
        _hiddenState = false;
    }
    public void HideWord()
    {
        _hiddenState = true;
    }

    public bool IsHidden()
    {
        return _hiddenState;
    }

    public string GetDisplay()
    {
        if (_hiddenState == true)
        {
            return new string('_', _WordLength);
        }
        else
        {
            return _Text;
        }
    }

   

}