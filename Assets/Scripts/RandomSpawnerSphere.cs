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
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-4, 5), 2, -5);
            Destroy(this.gameObject);
            script.enabled = true;
            Instantiate(targetPrefab, randomSpawnPosition, Quaternion.identity);
            AddScore();
            gameObject.SetActive(true);
        }
    }

    public void AddScore()
    {
        targetsHit = targetsHit + 1;
        changeTextScript.updateScore(targetsHit);
        fireBulletOnActivateScript.CalculateAccuracy(targetsHit);
    }
}
