

public class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text) {
        _reference = reference;

        foreach (string i in text.Split(" ")) {
            Word word = new Word(i);
            _words.Add(word);

        }

    }

    public void HideRandomWords(int numberToHide) {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++) {
            bool word = false;
            do {int access = random.Next(0,_words.Count());
            if (IsCompletelyHidden()) {
                break;
            }
            else if (_words[access].IsHidden()) {
                word = true;
            }
            
            else {
                word = false;
            _words[access].Hide();
            }
            
             } while (word);

        }

    }
    
    public string GetDisplayText() {
        string text = "";
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
            text += word.GetDisplayText() + " ";}
            else {
                text += "___ ";}

            
        }
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden() {
        bool isHidden = true;
        foreach (Word word in _words) {
            if (word.IsHidden() == false) {
                return false;
            }
        }
        return isHidden;
    }

}