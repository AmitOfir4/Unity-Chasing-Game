using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame(){ 
        
        int selectedCharacters = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharIndex = selectedCharacters;

        SceneManager.LoadScene("Gameplay");

    }
}
