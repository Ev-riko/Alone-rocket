using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    
    [SerializeField] private Text _scoreText;
    private Rocket _rocket;

    private void Awake()
    {
        _rocket = FindAnyObjectByType<Rocket>();
    }

    private void Update()
    {
        _scoreText.text = _rocket.GetScore().ToString();
    }
}
