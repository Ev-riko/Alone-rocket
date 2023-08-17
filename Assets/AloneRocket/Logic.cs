using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    
    [SerializeField] private Text _scoreText;
    private Rocket _rocket;

    private void Awake()
    {
        PauseGame();
        _rocket = FindAnyObjectByType<Rocket>();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        _scoreText.text = _rocket.GetScore().ToString();
    }
}
