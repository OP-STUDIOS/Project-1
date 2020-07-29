using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Items;
using Opsive.UltimateCharacterController.SurfaceSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Behaviour : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            StartCoroutine(DestroyEnemy(other.gameObject));
            //Destroy Enemy
        }
        else if (other.gameObject.tag == "Player")
        {
            //NOthing
        }
        else
        {
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyEnemy(GameObject gm)
    {
        FindObjectOfType<AudioManager>().PlayBulletImpactSound();
        FindObjectOfType<GameMaster>().AddScore();
        yield return new WaitForSeconds(0.3f);
        Destroy(gm);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
