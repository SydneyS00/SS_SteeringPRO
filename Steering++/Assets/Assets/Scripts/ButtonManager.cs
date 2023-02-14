using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ButtonManager : MonoBehaviour
{
    //This is the script for the buttons 
    //Will be able to go between scenes

    [Header ("Buttons")]
    public Button seekButton;
    public Button fleeButton; 


    public void goToSeek()
    {
        SceneManager.LoadScene("SS_Seek");
        Debug.Log("You have loaded into the Seeking Scene!");
    }

    public void goToFlee()
    {
        SceneManager.LoadScene("SS_Flee");
        Debug.Log("You have loaded into the Fleeing Scene!");
    }
}
