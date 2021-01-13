using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CButtonP : MonoBehaviour
{
    public static bool GamePaused = true;
    [SerializeField] 
    GameObject PauseMenuUI;
    [SerializeField]
    GameObject ButtonRight;
    [SerializeField]
    GameObject ButtonLeft;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Pause();
    }
    void Pause()
    {
        Time.timeScale = 0F;
        PauseMenuUI.SetActive(true);
        ButtonRight.SetActive(false);
        ButtonLeft.SetActive(false);
        gameObject.SetActive(false);
        GamePaused = true;
    }
    public void Resume()
    {
        Time.timeScale = 1F;
        PauseMenuUI.SetActive(false);
        ButtonRight.SetActive(true);
        ButtonLeft.SetActive(true);
        gameObject.SetActive(true);
        GamePaused = false;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1F;
    }
}
