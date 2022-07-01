using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitButton(){
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void StartGame(){
        SceneManager.LoadScene("Game");
    }
}
