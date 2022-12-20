using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotStuff : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject LightToSetActive;
    public GameObject RobotEyes;
    public GameObject LeftEye;
    public GameObject RightEye;
    public GameObject MusicVisual;
    public GameObject Sound;
    

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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LightToSetActive.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("LOL");
            RobotEyes.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("LOL");
            RobotEyes.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("LOL");
            LeftEye.SetActive(true);
            RightEye.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("LOL");
            LeftEye.SetActive(false);
            RightEye.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("LOL");
            MusicVisual.SetActive(true);
            Sound.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            MusicVisual.SetActive(false);
            Sound.SetActive(false);
        }
    }

    
}

