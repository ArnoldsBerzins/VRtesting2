using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public static int shotBulletSquare;
    public GameObject pistol;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pistol")
        {
            Physics.IgnoreCollision(collision.collider, collision.collider, true);
        }
        if (collision.collider.CompareTag("SquareWall") || collision.collider.CompareTag("Square"))
        {
            shotBulletSquare++;
            Debug.Log(shotBulletSquare);
        }
        Destroy(this.gameObject);
    }

}
