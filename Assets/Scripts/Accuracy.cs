using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accuracy : MonoBehaviour
{
    public GameObject pistol;
    public Text currentAccuracy;

    // Start is called before the first frame update
    void Start()
    {
        currentAccuracy.text = "Accuracy: 100%";
    }

    public void UpdateAccuracy(double accuracy)
    {
        currentAccuracy.text = "Accuracy: " + accuracy.ToString() + "%";
    }
}
