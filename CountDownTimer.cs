using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public Text CountDownText;
    public Text ScoreText;
    public float remaningTime=30f;
    public GameObject parentObject;
    public GameObject Obstacle;
    public GameObject Pannel;
    public GameObject Player;
    public Rigidbody PlayerRb;
    private bool isLost;
    private float childCount;

    void Start()
    {
        PlayerRb= Player.GetComponent<Rigidbody>();   
    }
    void Update()
    {
        RemaningTime();
        CheckIfWon();
    }
    public void LooseScreen(){
        Obstacle.SetActive(false);
        ScoreText.text = "You Lose!";
        Pannel.gameObject.SetActive(true);
        PlayerRb.constraints = RigidbodyConstraints.FreezeAll;
    }
    public void RemaningTime(){
        childCount = parentObject.transform.childCount;
        if(remaningTime>0f){   
            remaningTime -= Time.deltaTime;
        }   
        else if(remaningTime < 0f && childCount!=0){
            remaningTime = 0f;
            LooseScreen();
        }
        int minutes= Mathf.FloorToInt(remaningTime / 60);
        int seconds= Mathf.FloorToInt(remaningTime % 60);
        CountDownText.text=string.Format("{0:00}:{1:00}",minutes,seconds);
    }
    public void CheckIfWon(){
        childCount = parentObject.transform.childCount;
        if(childCount ==0f){
            SceneManager.LoadScene(2);
        }
    }
}