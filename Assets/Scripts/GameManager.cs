using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pauseUI;
    [SerializeField] GameObject menuUI;
    [SerializeField] GameObject lobbyUI;

    public bool isPaused;
    static bool isMenuActive;

    private void Awake()
    {
        SetTimeScale(1.0f);
        isMenuActive = SaveData.Instance.SaveValue();
        if (isMenuActive)
        {
            menuUI.SetActive(isMenuActive);
        }
        if(!isMenuActive)
        {
            lobbyUI.SetActive(!isMenuActive);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PasueState();
        }
    }

    public void Resume()
    {
        PasueState();
    }

    public void Restart()
    {
        isMenuActive = false;
        ReloadScene(isMenuActive);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void ToMenu()
    {
        isMenuActive = true;
        ReloadScene(isMenuActive);
    }

    private void PasueState()
    {
        if (isPaused)
        {
            isPaused = false;
            SetTimeScale(1.0f);
        }
        else if (!isPaused)
        {
            isPaused = true;
            SetTimeScale(0.0f);
        }
        pauseUI.SetActive(isPaused);
    }

    private static void ReloadScene(bool data)
    {
        SaveData.Instance.SaveValue(data);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    void SetTimeScale(float value)
    {
        Time.timeScale = value;
    }
}
