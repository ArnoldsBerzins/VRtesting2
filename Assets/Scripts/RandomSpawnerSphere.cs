using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawnerSphere : MonoBehaviour
{
    public GameObject targetPrefab;
    static int targetsHit;
    public ChangeText changeTextScript;
    public FireBulletOnActivate fireBulletOnActivateScript;
    public MovingTargets script;
    private void Start()
    {
        script = GetComponent<MovingTargets>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(1, 9), 4, -93);
            gameObject.transform.position = randomSpawnPosition;
            script.enabled = true;
            AddScore();
            gameObject.SetActive(true);
        }
    }

    public void AddScore()
    {
        targetsHit++;
        changeTextScript.updateScore(targetsHit);
        fireBulletOnActivateScript.CalculateAccuracySphere(targetsHit);
    }
}
