using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class Gun : MonoBehaviour
{
    public SteamVR_Action_Boolean fireAction;
    public GameObject bullet;
    public Transform barrelPiviot;
    public float shootingSpeed = 1.0f;
    public GameObject muzzleFlash;

    private Animator animator;
    private Interactable interactable;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        muzzleFlash.SetActive(false);
        interactable = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions._default.InteractUI.GetStateUp(SteamVR_Input_Sources.RightHand))
        {
            Fire();
        }
    }


    void Fire()
    {
        Rigidbody bulletrb = Instantiate(bullet, barrelPiviot.position, barrelPiviot.rotation).GetComponent<Rigidbody>();
        bulletrb.velocity = barrelPiviot.forward * shootingSpeed;
        muzzleFlash.SetActive(true);
    }

}
