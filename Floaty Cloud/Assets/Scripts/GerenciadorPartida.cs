using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorPartida : MonoBehaviour
{

    private bool partidaIniciada;

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
