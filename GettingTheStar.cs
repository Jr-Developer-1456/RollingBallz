using UnityEngine;
using UnityEngine.UI;

public class StarCounter : MonoBehaviour
{
    public GameObject gameObject;
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
