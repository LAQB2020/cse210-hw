public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture()
    {
        _reference = new Reference();
        _words = new List<Word>();
    }

    public Scripture (Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(" ");
        _words = new List<Word>();

        foreach( string item in parts)
        {
            _words.Add(new Word(item));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int position;

        for(int i = 0; i < numberToHide; i++)
        {
            position = _random.Next(0,_words.Count());
            _words[position].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text="";
        foreach (var word in _words)
        {
            text = text + word.GetDisplayText() + " ";
        }
    return _reference.GetDisplayText() + " " + text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if(word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

}