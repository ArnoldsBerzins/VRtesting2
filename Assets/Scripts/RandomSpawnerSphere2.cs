using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawnerSphere2 : MonoBehaviour
{
    public GameObject targetPrefab;
    static int targetsHit;
    public ChangeText changeTextScript;
    public FireBulletOnActivate fireBulletOnActivateScript;
    public MovingTargets script;
    public RandomSpawnerSphere randomSpawnerSphereScript;

    private void Start()
    {
        script = GetComponent<MovingTargets>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(1, 9), 2, -93);
            gameObject.transform.position = randomSpawnPosition;
            script.enabled = true;
            randomSpawnerSphereScript.AddScore();
            gameObject.SetActive(true);
        }
    }
}