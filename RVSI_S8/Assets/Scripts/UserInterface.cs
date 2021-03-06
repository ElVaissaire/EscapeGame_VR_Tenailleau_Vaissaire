using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UserInterface : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private Button resume;
    [SerializeField] private Button menuPrincipal;
 
    
    // Start is called before the first frame update
    void Start()
    {
        pauseScreen.SetActive(false);
        resume.onClick.AddListener(OnButtonPressed);
        menuPrincipal.onClick.AddListener(OnOtherButtonPressed);
    }

    // Update is called once per frame
    void Update()
    {
        pause();
    }

    void pause()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void OnButtonPressed()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnOtherButtonPressed()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal");
    }
}
