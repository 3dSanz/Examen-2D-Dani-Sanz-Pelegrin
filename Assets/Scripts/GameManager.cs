using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    PlayerController _player;
    public int _coin;
    public string text;
    void Awake()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerController>();
        _coin = 0;
    }

    void Update()
    {
        text = "" + _coin;
    }

    public void Win()
    {
        SceneManager.LoadScene(0);
    }

}
