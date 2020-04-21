using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= 90)
        {
            transform.position += Time.deltaTime * new Vector3(0, 0, speed );
        }
        else
        {
            transform.position =  new Vector3(0, 0, 0);
        }
    }


    void OnCollisionEnter(Collider other)
    {
        //if player is on a gameObject with the tag "DeathZone", substract 1 health per frame 
        if (other.gameObject.tag == "DeathZone")
        {
            Debug.Log("DONE");
        }
    }
}
