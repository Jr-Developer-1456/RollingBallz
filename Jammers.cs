using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jammers : MonoBehaviour
{
    public CountDownTimer countDownTimer;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player"){
            countDownTimer.LooseScreen();
        }
    }
    
}
