using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageGun : MonoBehaviour
{
    [Header("Gun Stats")]
    public int damage;    
    public float spread, range, reloadTime;
    // public int magSize;
    // int currentMag, bulletsShot;

    // bool shooting, readyToShoot, reloading;

    public Transform PlayerCam;
    // Start is called before the first frame update
    void Start()
    {
        // PlayerCam = Camera.main.transform;
    }

    // Update is called once per frame
    public void Shoot()
    {
        Ray gunRay = new(PlayerCam.position, PlayerCam.forward);
        if(Physics.Raycast(gunRay, out RaycastHit hitInfo, range)){
            if(hitInfo.collider.gameObject.TryGetComponent(out Entity enemy)){
                enemy.Health -= damage;
            }
        }
    }
}
