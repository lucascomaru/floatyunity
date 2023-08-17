using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorPartida : MonoBehaviour
{

    private bool partidaIniciada;

    private void Awake()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (partidaIniciada) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            partidaIniciada = true;
            Time.timeScale = 1;
        }
    }
}
