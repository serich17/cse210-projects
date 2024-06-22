using System.ComponentModel.DataAnnotations;

public class PromptGenerator {
    //add list of possible prompts
    List<string> _prompts = [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was a funny thing that happened to me?",
        "What did I accomplish today?"
    ];
    //get random object
    static Random random = new Random();


    public string GetRandomPrompt() {
        //generate random index number and return a prompt 
        int index = random.Next(_prompts.Count);  
        return _prompts[index];
    } 
}