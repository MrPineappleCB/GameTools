using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject HuntersKey;
    [SerializeField] private GameObject ArtistsKey;
    [SerializeField] private GameObject BankersKey;
    [SerializeField] private GameObject FinalDoor;
    public bool Hkey = false;
    public bool Akey = false;
    public bool Bkey = false;

    void Update()
    {
        if (Hkey == true && Akey == true && Bkey == true)
        {
            FinalDoor.SetActive(false);
        }
    }

    public void Hkeyget()
    {
        Hkey = true;
    }

    public void Akeyget()
    {
        Akey = true;
    }

    public void Bkeyget()
    {
        Bkey = true;
    }

}
