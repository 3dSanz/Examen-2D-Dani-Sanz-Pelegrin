using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    GameManager _gm;
    Text _text;

    void Awake()
    {
        _gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        _text = GetComponent<Text>();
    }


    void Update()
    {
        _text.text="" + _gm._coin;
    }
}
