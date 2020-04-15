using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ApplyDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public float LifeDecay = 5.0f;

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SendMessageUpwards("ApplyDamage", SendMessageOptions.DontRequireReceiver);
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, LifeDecay);
    }
}
