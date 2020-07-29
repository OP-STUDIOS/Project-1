using System.Collections;
using System.Collections.Generic;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Camera;
using UnityEngine;
using Opsive.UltimateCharacterController.Camera.ViewTypes;
using Opsive.UltimateCharacterController.Demo.Objects;

public class Pistol_Shoot_Behaviour : MonoBehaviour
{
    public float bulletSpeed = 30f;
    public float bulletLifeTime = 5f;

    public GameObject bullet;
    public Transform bulletSpawnPoint;
    public Transform cameraTransform;

    public bool startWithThirdPersonPerspective = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireBullet();
        }

        if (Input.GetButtonDown("Toggle Perspective"))
        {
            if (startWithThirdPersonPerspective)
            {
                startWithThirdPersonPerspective = false;
            }
            else
            {
                startWithThirdPersonPerspective = true;
            }
        }
    }

    private void FireBullet()
    {
       /* if (startWithThirdPersonPerspective)
        {
            GameObject mbullet = Instantiate(bullet);
            //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), bulletSpawnPoint.parent.GetComponent<Collider>());
            mbullet.transform.position = new Vector3 (bulletSpawnPoint.position.x + 0.25f, bulletSpawnPoint.position.y + 0.22f, bulletSpawnPoint.position.z);
            Vector3 rotation = bullet.transform.rotation.eulerAngles;
            mbullet.transform.rotation = Quaternion.Euler(rotation.x, bullet.transform.eulerAngles.y, rotation.z);
            mbullet.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * bulletSpeed, ForceMode.Impulse);

            StartCoroutine(DestroyBulletTimer(mbullet));
        }
        else
        {
            GameObject mbullet = Instantiate(bullet);
            //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), bulletSpawnPoint.parent.GetComponent<Collider>());
            mbullet.transform.position = bulletSpawnPoint.position;
            Vector3 rotation = bullet.transform.rotation.eulerAngles;
            mbullet.transform.rotation = Quaternion.Euler(rotation.x, bullet.transform.eulerAngles.y, rotation.z);
            mbullet.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * bulletSpeed, ForceMode.Impulse);

            StartCoroutine(DestroyBulletTimer(mbullet));
        }
        */
        GameObject mbullet = Instantiate(bullet);
        //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), bulletSpawnPoint.parent.GetComponent<Collider>());
        mbullet.transform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y, cameraTransform.position.z);
        Vector3 rotation = bullet.transform.rotation.eulerAngles;
        mbullet.transform.rotation = Quaternion.Euler(rotation.x, bullet.transform.eulerAngles.y, rotation.z);
        mbullet.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * bulletSpeed, ForceMode.Impulse);

        StartCoroutine(DestroyBulletTimer(mbullet));
    }

    IEnumerator DestroyBulletTimer(GameObject bullet)
    {
        yield return new WaitForSeconds(bulletLifeTime);
        Destroy(bullet);
    }
}
