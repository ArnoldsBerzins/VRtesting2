using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accuracy : MonoBehaviour
{
    public GameObject pistol;
    public Text currentAccuracy1;
    public Text currentAccuracy2;

    // Start is called before the first frame update
    void Start()
    {
        currentAccuracy1.text = "Accuracy: 100%";
        currentAccuracy2.text = "Accuracy: 100%";
    }

    public void UpdateAccuracy1(double accuracy)
    {
        currentAccuracy1.text = "Accuracy: " + accuracy.ToString() + "%";
    }
    public void UpdateAccuracy2(double accuracy)
    {
        currentAccuracy2.text = "Accuracy: " + accuracy.ToString() + "%";
    }
}
