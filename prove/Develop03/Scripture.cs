class Scripture {
    private Reference _reference; 
    private List<Word> _words = new List<Word>();
    private Random _randomGen = new Random();


    public Scripture(Reference reference, string text) 
    {
        this._reference = reference;
        this.ConvertTextToWords(text);
    }

    private void ConvertTextToWords(string text)
    {
        this._words = new List<Word>();
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            this._words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        
        List<int> rdmIndexes = new List<int>();

        while (rdmIndexes.Count < 3)
        {
            int randomIndex = _randomGen.Next(0, this._words.Count);
            if (!rdmIndexes.Contains(randomIndex))
            {
                rdmIndexes.Add(randomIndex);
            }

        }

        // Use the rdmIndexes list to hide the corresponding words
        foreach (int index in rdmIndexes)
        {
            this._words[index].Hide();
        }	
    }

    public string GetDisplayText()
    {
        string listOfWordsAsString = "";
        foreach (Word word in this._words)
        {
            listOfWordsAsString += word.GetDisplayText() + " ";
        
        }
        listOfWordsAsString = listOfWordsAsString.TrimEnd();

        return $"{this._reference.GetDisplayText()} {listOfWordsAsString}";
        
    }
}