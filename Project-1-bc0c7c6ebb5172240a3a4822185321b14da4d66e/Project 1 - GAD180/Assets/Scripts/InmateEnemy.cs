using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InmateEnemy : MonoBehaviour
{
    public GameObject target;
    public float speed = 20f;

    public void Update()
    {
        target = GameObject.FindWithTag("Player");
        transform.LookAt(target.GetComponent<Transform>());
        Quaternion rotTarget = Quaternion.LookRotation(this.transform.position - target.GetComponent<Transform>().position);
        this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, rotTarget, speed * Time.deltaTime);
    }
}
