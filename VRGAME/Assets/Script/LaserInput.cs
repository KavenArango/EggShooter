using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class LaserInput : MonoBehaviour
{
    public static GameObject currentObject;
    int currentID;


    // Start is called before the first frame update
    void Start()
    {
        currentObject = null;
        currentID = 0;
    }


    // Update is called once per frame
    void Update()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 100.0f);
        if (SteamVR_Actions._default.InteractUI.GetStateUp(SteamVR_Input_Sources.RightHand))
        {
            for (int i = 0; i < hits.Length; i++)
            {
                RaycastHit hit = hits[i];

                int id = hit.collider.gameObject.GetInstanceID();
                currentID = id;
                currentObject = hit.collider.gameObject;

                if (currentObject.tag == "Button")
                {
                    string name = currentObject.name;
                    if (name == "Try1")
                    {
                        SceneLoader("Level 1");
                    }
                    else
                    {
                        if (name == "Exit")
                        {
                            Debug.Log("Exit");

                            Application.Quit();
                        }
                        else
                        {
                            if(name == "Western")
                            {
                                SceneLoader("Level 2");
                            }
                        }
                    }
                }
            }
        }
    }


    public void SceneLoader(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
