using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    static int targetsHit;
    public ChangeText changeTextScript;
    public FireBulletOnActivate fireBulletOnActivateScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            Vector3 randomSpawnPosition = new Vector3(-5, Random.Range(1, 4), Random.Range(-4, 4));
            Destroy(this.gameObject);
            Instantiate(targetPrefab, randomSpawnPosition, Quaternion.identity);
            AddScore();
        }
    }

   public void AddScore()
    {
        targetsHit = targetsHit + 1;
        changeTextScript.updateScore(targetsHit);
        fireBulletOnActivateScript.CalculateAccuracySquare(targetsHit);
    }
}
