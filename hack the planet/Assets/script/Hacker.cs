using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    string currentScreen = "MainMenu";
    private readonly string selectedLevel;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Welcome to the Game");
    }

    void ShowMainMenu(string greeting)
    {
        Terminal.WriteLine("Hello Hacker!");
        Terminal.WriteLine(" press 1 to hack a plane");
        Terminal.WriteLine(" press 2 to hack a a moblie phone");
    }
    void onUserInput(string input)
    {
        if (currentScreen == "MainMenu")
        {
            //set level
            Setlevel(input);
        }
        else if (currentScreen == "Password")
        {
            // check input
        }
        else if(selectedLevel == "2")
        {
            level = 2;
        }
        else
        {
            Terminal.WriteLine("Wrong input, enter a valied number");
        }
        print(level);
    }

    private void Setlevel(string selectedLevel)
    {
        if (selectedLevel == "1")
            level = 1;
    }
}
