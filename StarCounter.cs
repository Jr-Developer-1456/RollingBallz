using UnityEngine;
using UnityEngine.UI;

public class Star_Counter : MonoBehaviour
{
    [Header("Star_Counter")]
    public GameObject parentObject; 
    public Text ScoreText;

    void Update()
    {
        AnotherThing();
    }

    public void AnotherThing(){
        int childCount = parentObject.transform.childCount;
        if (parentObject != null)
        {
            
            ScoreText.text = "Left Stars: "+childCount.ToString();
        }
        if(childCount == 0){
            ScoreText.text = "You Won!";
        }
    }
}
