 public class Scripture  
    {  
        private Reference _reference;  
        private List<Word> _words;  

        public Scripture(Reference reference, string text)  
        {  
            _reference = reference;  
            _words = new List<Word>();  
            foreach (var word in text.Split(' '))  
            {  
                _words.Add(new Word(word));  
            }  
        }  

        public void HideRandomWords(int numberToHide)  
        {  
            Random rand = new Random();  
            int hiddenCount = 0;  

            while (hiddenCount < numberToHide)  
            {  
                int index = rand.Next(_words.Count);  
                if (!_words[index].IsHidden())  
                {  
                    _words[index].Hide();  
                    hiddenCount++;  
                }  
            }  
        }  

        public string GetDisplayText()  
        {  
            string displayText = _reference.GetDisplayText() + "\n";  
            foreach (var word in _words)  
            {  
                displayText += word.GetDisplayText() + " ";  
            }  
            return displayText.Trim();  
        }  

        public bool IsCompletelyHidden()  
        {  
            foreach (var word in _words)  
            {  
                if (!word.IsHidden())  
                    return false;  
            }  
            return true;  
        }  
    }  