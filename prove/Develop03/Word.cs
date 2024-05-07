class Word 
{
    private string _text;
    private bool _isHidden; 
    public Word(string text)
    {
        this._text = text;
        this._isHidden = false;
    }

    public void Hide()
    {
        this._isHidden = true;
    }

    public void Show()
    {
        this._isHidden = false;
    }

    public bool IsHidden()
    {
        return this._isHidden;
    }


    // Displays the text depending on the state (hidden or not hidden)
    public string GetDisplayText()
    {
        if (this._isHidden)
        {
            return new string ('_', this._text.Length);
        } else
        {
            return this._text;
        }
    }

}