using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFuncs : MonoBehaviour
{
   
    public void RestartCurLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public IEnumerator FirstLevelRoutine()
    {
        AudioManager.a_Instance.PlaythisIsNotADream();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level1");
    }
    public void MainMenu()
    { 
        SceneManager.LoadScene(0);
    }
    public void PlayFirstLevel()
    {
        StartCoroutine(FirstLevelRoutine());
    }

}
