using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharJogo : MonoBehaviour
{
    public void ExitGame(){
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
