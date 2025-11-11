using System;
using System.Diagnostics;
using System.Security.Cryptography;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the Best part of your day? ",
        "What was the Most enlightening part of your day? ",
        "What was the Best or most important, thing you learned/realized today? ",
        "What is a kindness shown to you today? ",
        "How have you seen the hand of God in your life today? ",
        "How have you felt God's love for you today? ",
        "What is a goal you acheived or got closser to acheiving today? ",
        "What is a goal you feel you should set for yourself today? ",
        "What is a goal you want to acheive? "
    };


    public string GetRandomPrompt()
    {
        Random RandomGenerator = new Random();
        int randomNumber = RandomGenerator.Next(1, 5);
        
        return _prompts[randomNumber];
    }
    
}
 
