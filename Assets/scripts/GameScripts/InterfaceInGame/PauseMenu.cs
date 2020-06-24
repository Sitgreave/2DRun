
using UnityEngine;
using UnityEngine.SceneManagement;

    
public class PauseMenu : SaveState
{
    public GameObject pausePanel;
     bool isPaused = false;
    public void PauseGame()
    {
        if (isPaused == false)
        {
            Paused();
        }
        else
        {
            UnPaused();
        }
      
    }
  
    public void UnPauseGame()
    {
        if (isPaused == true)
        {
            UnPaused();

        }
       
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
        savePPrefs();
        UnPaused();
        Debug.Log(";");
    }
    public void OffAndOnMusic()
    {

    }
    public void BackOnMenu()
    {
        savePPrefs();
        SceneManager.LoadScene(0);
        
    }
    private void Paused()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        isPaused = true;
    }
    private void UnPaused()
    {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            isPaused = false;
    }
    public void Respawn()
    {
        

    }
    private void OnApplicationQuit()
    {
        savePPrefs();
    }
}
