using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : SaveState
{ 
    public void OnClick()
    {
        savePPrefs();
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
   
}
