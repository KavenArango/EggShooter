using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using TMPro;


public class SimpleShoot : MonoBehaviour
{
    public int maxAmmo = 10;
    private int currentAmmo;


    public GameObject bulletPrefab;
    public GameObject casingPrefab;
    public GameObject muzzleFlashPrefab;
    public Transform barrelLocation;
    public Transform casingExitLocation;
    public SteamVR_Action_Boolean trigger;
    public float shotPower = 100f; 
    public TextMeshPro text;
    public AudioSource fire;
    public AudioSource noammo;
    public AudioSource reload;
   

    void Start()
    {
        trigger = SteamVR_Actions._default.GrabPinch;
        
        text = transform.GetChild(0).GetChild(7).GetComponent<TextMeshPro>();

        currentAmmo = maxAmmo;
        if (barrelLocation == null)
            barrelLocation = transform;
    }

    void Update()
    {
        if (Vector3.Angle(transform.up, Vector3.up) > 100 && currentAmmo < maxAmmo)
        {
            Reload();
            
        }




        if (SteamVR_Actions._default.GrabPinch.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            if (currentAmmo > 0)
            {
                --currentAmmo;
                Shoot();
                CasingRelease();
                fire.Play();
            }
            else
            {
                noammo.Play();
            }
           
        }
        text.text = currentAmmo.ToString();
    }

    void Reload()
    {
        currentAmmo = maxAmmo;
        reload.Play();
    }


    void Shoot()
    {
        GameObject bullet;
        bullet = Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);

        GameObject tempFlash;
        //Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
        tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);

        Destroy(tempFlash, 0.5f);
        //Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation).GetComponent<Rigidbody>().AddForce(casingExitLocation.right * 100f);
       
    }

    void CasingRelease()
    {
        GameObject casing;
        casing = Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation) as GameObject;
        casing.GetComponent<Rigidbody>().AddExplosionForce(550f, (casingExitLocation.position - casingExitLocation.right * 0.3f - casingExitLocation.up * 0.6f), 1f);
        casing.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(100f, 500f), Random.Range(10f, 1000f)), ForceMode.Impulse);
    }


}
