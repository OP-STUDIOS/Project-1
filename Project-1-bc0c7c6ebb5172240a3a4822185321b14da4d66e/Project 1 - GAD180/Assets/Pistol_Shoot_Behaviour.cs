using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol_Shoot_Behaviour : MonoBehaviour
{
    public float bulletSpeed = 30f;
    public float lifeTime = 3f;

    public GameObject bullet;
    public Transform bulletSpawnPoint;
    public Transform cameraTransform;
    public Transform mussleFlashSpawnPoint;
    public Transform bulletShellSpawnPoint;

    public GameObject mussleFlash;
    public GameObject bulletShell;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("shoot pressed");
            FireBullet();
        }
    }

    private void FireBullet()
    {
        GameObject mbullet = Instantiate(bullet);
        //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), bulletSpawnPoint.parent.GetComponent<Collider>());
        mbullet.transform.position = bulletSpawnPoint.position;
        Vector3 rotation = bullet.transform.rotation.eulerAngles;
        mbullet.transform.rotation = Quaternion.Euler(rotation.x, bullet.transform.eulerAngles.y, rotation.z);
        mbullet.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * bulletSpeed, ForceMode.Impulse);

        StartCoroutine(DestroyBulletTimer(mbullet, 0.5f));
        StartCoroutine(SpawnMussleFlash());
        StartCoroutine(SpawnShell());
    }

    IEnumerator DestroyBulletTimer(GameObject bullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }

    IEnumerator SpawnMussleFlash()
    {
        GameObject tMussleFlash = Instantiate(mussleFlash, mussleFlashSpawnPoint.transform.position, mussleFlashSpawnPoint.transform.rotation);
        yield return new WaitForSeconds(.3f);
        Destroy(tMussleFlash);
    }

    IEnumerator SpawnShell()
    {
        GameObject tBulletShell = Instantiate(bulletShell, bulletShellSpawnPoint.transform.position, bulletShellSpawnPoint.transform.rotation);
        yield return new WaitForSeconds(.3f);
        Destroy(tBulletShell);
    }
}
