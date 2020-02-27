using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    int currentIndex;
    void Start()
    {

        currentIndex = SceneManager.GetActiveScene().buildIndex;
    }

     
    public void NextScene()
    {
        
        SceneManager.LoadScene(currentIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(currentIndex);
    }
    public void LoadStart()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }
    public void QuitGame()
        {
            Application.Quit();
        }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadWinGame()
    {
        SceneManager.LoadScene("WinGame");
    }
    public void LoadDeath()
    {
        SceneManager.LoadScene("Death1");
    }
    public void LoadDeath2()
    {
        SceneManager.LoadScene("Death2");
    }
    public void LoadDeath3()
    {
        SceneManager.LoadScene("Death3");
    }
    public void LoadTururial()
    {
        SceneManager.LoadScene("Tuturial");
    }
    
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    
}
