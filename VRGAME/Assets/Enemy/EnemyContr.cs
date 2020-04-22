using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyContr : MonoBehaviour
{
    public GameObject player;
    private bool Dead = false;
    public GameObject gun;
    public Text Score;
    Collider m_Collider;




    // Start is called before the first frame update
    void Start()
    {
        setRigidbodyState(true);
        setColliderState(false);
        GetComponent<Animator>().enabled = true;
        GetComponent<EnemyShoot>().enabled = false;
        m_Collider = GetComponent<Collider>();

    }


    void Update()
    {
        if (!Dead)
        {
            gun.transform.LookAt(player.transform);

            RaycastHit detection;

            if (Physics.Raycast(gun.transform.position, gun.transform.forward, out detection))
            {
                if (detection.collider.tag == "player")
                {
                    if (detection.distance <= 17)
                    {
                        GetComponent<EnemyShoot>().enabled = true;
                    }
                    else
                    {
                        GetComponent<EnemyShoot>().enabled = false;
                    }
                }
                else
                {
                    GetComponent<EnemyShoot>().enabled = false;
                }
            }
            transform.forward = Vector3.ProjectOnPlane(((player.transform.position) - transform.position), Vector3.up).normalized;
        }
        else
        {
            m_Collider.enabled = !m_Collider.enabled;
            GetComponent<EnemyShoot>().enabled = false;
        }
    }


    public void die()
    {

        GetComponent<Animator>().enabled = false;
        GetComponent<EnemyShoot>().enabled = false;
        setRigidbodyState(false);
        setColliderState(true);
    }

    void setRigidbodyState(bool state)
    {

        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }

        GetComponent<Rigidbody>().isKinematic = !state;

    }

    void OnCollisionEnter(Collision collision)
    {

        if (!(collision.gameObject.tag == "NoDamage"))
        {
            string x = Score.text;

            Score.text = Convert.ToString(Convert.ToInt32(x) + 100);

            Dead = true;
            die();
        }
    }


    void setColliderState(bool state)
    {

        Collider[] colliders = GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }

        GetComponent<Collider>().enabled = !state;

    }
}
