using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void QuitGame() //Quit Game
    {
        Debug.Log("Program Ended.");
        Application.Quit();
    } 
    
    public void QuitGame(string errorMessage) //Throw Error
    {
        throw new System.Exception(errorMessage);
    }
}
