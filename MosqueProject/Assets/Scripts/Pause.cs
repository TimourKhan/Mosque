using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public static bool GameIsPaused;
    public GameObject pauseMenuUI;
    public GameObject main;
    public GameObject exit;
    [SerializeField] GameObject dimmer;



    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }else
            {
                PauseGame();
            }    
            }*/
        }

    public void ResumeGameInitialize()
    {
        LeanTween.move(pauseMenuUI.GetComponent<RectTransform>(), new Vector3(0f, 715f, 0f), .3f).setDelay(.1f).setEase(LeanTweenType.easeOutCubic).setIgnoreTimeScale(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Invoke("ResumeGame", .5f);
    }
        public void ResumeGame()
    {
        
        dimmer.SetActive(false);
        pauseMenuUI.SetActive(false);
    }

    public void PauseGame()
    {
        dimmer.SetActive(true);
        pauseMenuUI.SetActive(true);
        LeanTween.move(pauseMenuUI.GetComponent<RectTransform>(), new Vector3(0f, -598f, 0f), .3f).setDelay(.3f).setEase(LeanTweenType.easeOutCubic).setIgnoreTimeScale(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ExitToMenuDialog()
    {
        main.SetActive(false);
        exit.SetActive(true);
    }
    public void TitleScreen()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void ReturnToPause()
    {
        exit.SetActive(false);
        main.SetActive(true);
    }
}
