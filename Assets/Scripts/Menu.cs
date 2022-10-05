using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    public Transform menu;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(menu.gameObject.activeSelf){
                menu.gameObject.SetActive(false);
            }else{
                menu.gameObject.SetActive(true);
            }
        }
    }
}
