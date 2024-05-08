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

    public void HideRandomWords(int numberOfWordsToHide)
    {
        // First we create a list of indexes, and here we will have only unhidden words indexes
        List<int> indexesOfUnhiddenWords = this._words
            .Select((word, index) => new {word, index})
            .Where(x => !x.word.IsHidden())
            .Select(y => y.index)
            .ToList();

        // If there is less or equal to "numberOfWordsToHide" unhidden words, we will hide all of them
        // For example, if there are only 2 unhidden words and we want to hide 3, we will hide all of them without random picking
        if(indexesOfUnhiddenWords.Count <= numberOfWordsToHide) 
        {
            foreach (int index in indexesOfUnhiddenWords)
            {
                this._words[index].Hide();
            }

            return;
        }

        

        // This is another list that will contain the random indexes of indexesOfUnhiddenWords
        // We will use this list to pick up random unhidden words (indexesOfUnhiddenWords)
        List<int> rdmIndexes = new List<int>();

        while (rdmIndexes.Count < numberOfWordsToHide)
        {
            int randomIndex = _randomGen.Next(0, indexesOfUnhiddenWords.Count);

            // We do this to avoid duplicates random indexes
            while (rdmIndexes.Contains(randomIndex))
            {
                randomIndex = _randomGen.Next(0, indexesOfUnhiddenWords.Count);
            }
            
            rdmIndexes.Add(randomIndex);
            
        }

        // Use the rdmIndexes list to hide the corresponding words
        foreach (int index in rdmIndexes)
        {
            int realIndexToBeHidden = indexesOfUnhiddenWords[index];
            this._words[realIndexToBeHidden].Hide();
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

    public bool IsCompleteHidden()
    {
        return this._words.All(word => word.IsHidden());
    }
}