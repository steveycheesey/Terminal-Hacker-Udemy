using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hacker : MonoBehaviour
{
    // Game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello Cheese");
    }

    void ShowMainMenu(string greeting)
    {
        currentScreen = Screen.MainMenu;
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

    void OnUserInput(string input) // only decides how to handle user input
    {
        if (input == "menu")
        {
            Start();
            currentScreen = Screen.MainMenu;
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)  // block that will determine what will happen based on user input
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
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

    void StartGame() // method that performs functions once game actually starts
    {
        currentScreen = Screen.Password; // changes state to password from menu
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }
}
