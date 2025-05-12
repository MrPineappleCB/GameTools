using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    public GameObject pic;
    public bool changeGlasses;

    // AudioManager audioManager;

    // private void Awake()
    // {
    //audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    // }

    void Start()
    {
        //audioManager.PlaySFX(audioManager.Success);
        //audioManager.PlaySFX(audioManager.Success);
    }

    public void Trigger()
    {
        if (pic.activeInHierarchy == false)
        {
            pic.SetActive(true);
            //audioManager.PlaySFX(audioManager.PenClick);
        }
        else
        {
            pic.SetActive(false);
            //audioManager.PlaySFX(audioManager.PenClick);
        }
    }

    public GameObject pic2;

    public void Trigger2()
    {
        pic2.SetActive(false);
        if (pic.activeInHierarchy == false)
        {
            pic2.SetActive(true);

        }
        else
        {
            pic2.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            changeGlasses = !changeGlasses;
            print(changeGlasses);
            Trigger();
            Trigger2();
        }
    }

}
