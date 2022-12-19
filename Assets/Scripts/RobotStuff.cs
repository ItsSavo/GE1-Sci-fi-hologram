using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotStuff : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject LightToSetActive;
    public GameObject RobotEyes;
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("LOL");
            LightToSetActive.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("LOL");
            RobotEyes.SetActive(true);
        }
    }
}
