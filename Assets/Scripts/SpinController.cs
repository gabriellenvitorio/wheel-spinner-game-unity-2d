using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpinController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float speed;
    public GameObject spin;
    public bool buttonPressed;
    public int number;
    public AudioSource audioSourceSpin;
    public AudioClip spinMusic;

    public void OnPointerDown(PointerEventData eventData){
        buttonPressed = true;
    }
 
    public void OnPointerUp(PointerEventData eventData){
        buttonPressed = false;
    }

    void Start()
    {
        this.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if(buttonPressed == true){
            number = Random.Range(1,20);
            this.speed = 10000*number;

            AudioClip spinWheelMusic = spinMusic;
            audioSourceSpin.clip = spinWheelMusic;
            audioSourceSpin.Play();

        }

        spin.transform.Rotate(0,0, this.speed);
        this.speed *= 0.96f;
    }
}
