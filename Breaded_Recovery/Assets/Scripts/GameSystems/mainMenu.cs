// author sam howard

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    [SerializeField] GameObject _CharacterSelection;

    // Start is called before the first frame update
    public void startButton()
    {
        _CharacterSelection.SetActive(true);
        gameObject.SetActive(false);
        
    }

    public void exitButton()
    {
        Application.Quit();
    }

    #region selectCharacter
    public void selectCruiser()
    {
        playerStats.shipType = "cruiser";
        loadLevel();
    }

    public void selectFighter()
    {
        playerStats.shipType = "fighter";
        loadLevel();
    }

    public void selectRacer()
    {
        playerStats.shipType = "racer";
        loadLevel();
    }

    public void selectBehemoth()
    {
        playerStats.shipType = "behemoth";
        loadLevel();
    }

    public void selectDestroyer()
    {
        playerStats.shipType = "destroyer";
        loadLevel();
    }
    #endregion selectCharacter
    private void loadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
