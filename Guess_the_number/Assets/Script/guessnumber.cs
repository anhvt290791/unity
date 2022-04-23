using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guessnumber : MonoBehaviour{
    public InputField input;
    public Text infoText;
    private int numberGuess;
    private int userGuess;
   
    void Start()
    {
      numberGuess = Random.Range(0,100);  
    }

    
    public void CheckGuess()
    {
        userGuess = int.Parse(input.text);
        if(userGuess == numberGuess){
            infoText.text = "You are the Winner";
        }else if(userGuess > numberGuess){
            infoText.text = "The number is greater than number";
        }else if(userGuess < numberGuess){
            infoText.text = "The number is smaller than number";
        }
        input.text = "";
    }
}
