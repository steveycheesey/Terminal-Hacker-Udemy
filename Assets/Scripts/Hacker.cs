using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello Cheese");
    }

    void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?\n" +
        "\n" +
        "Press 1 for the Nature Agency\n" +
        "Press 2 for the State Department\n" +
        "Press 3 for the Chemistry Lab\n" +
        "\n" +
        "Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            Start();
        }
        else if (input == "Sabrina" || input == "sabrina")
        {
            ShowMainMenu("Hello beautiful");
        }
        else if (input == "Noah" || input == "noah")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("You're too young to play this foo!");
        }
        else if (input == "Steven" || input == "steven")
        {
            ShowMainMenu("It's already your profile..");
        }
        else
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Please type a valid command. \nType \"menu\" to see options again.");
        }
    }

}
