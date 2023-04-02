using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        
    }

    public static void QuitGame() //Quit Game
    {
        Debug.Log("Program Ended.");
        Application.Quit();
    } 
    
    public static void QuitGame(string errorMessage) //Throw Error
    {
        throw new System.Exception(errorMessage);
    }
}
