using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
public AudioSource themeSong;
public AudioSource Scream;

    void Start()
    {
        themeSong.Play();
        Scream.mute = true;
    }

    [SerializeField] private GameObject _gameOverCanvas;
    public static GameManager instance;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        Time.timeScale = 1f;
    }
    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        Scream.mute = false;
        themeSong.Stop();
        Scream.Play();

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
