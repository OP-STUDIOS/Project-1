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
            Destroy(other.gameObject);
            //Destroy Enemy
        }
        else if (other.gameObject.tag == "Player")
        {
            //NOthing
        }
        else
        {
            StartCoroutine(DestroyEnemy());
        }
    }

    IEnumerator DestroyEnemy()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
