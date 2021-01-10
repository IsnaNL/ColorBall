using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFuncs : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartCurLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
