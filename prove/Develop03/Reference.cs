using System;
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _VerseStart;
    private int _VerseEnd;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _VerseStart = verseStart;
        _VerseEnd = verseEnd;
    }

    public string DisplayReference()
    {
        if (_VerseStart == _VerseEnd)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_VerseStart}-{_VerseEnd}";
        }

    }
}