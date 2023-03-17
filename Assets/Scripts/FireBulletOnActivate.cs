using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System;
using JetBrains.Annotations;

public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float fireSpeed = 20;
    static int shotBullets;
    public Accuracy accuracyScript;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
    }

    public void CalculateAccuracySquare(int targetsHit)
    {
        double accuracy = targetsHit * 100 / DestroyOnCollision.shotBulletSquare;
        accuracyScript.UpdateAccuracy1(Math.Round(accuracy, 2));
    }

    public void CalculateAccuracySphere(int targetsHit)
    {
        double accuracy2 = targetsHit * 100 / DestroyOnCollision.shotBulletSphere;
        accuracyScript.UpdateAccuracy2(Math.Round(accuracy2, 2));
    }
}
