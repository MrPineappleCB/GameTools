using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultCode : MonoBehaviour
{
    [SerializeField] private ButtonCounter red_button;
    [SerializeField] private ButtonCounter purple_button;
    [SerializeField] private ButtonCounter yellow_button;
    [SerializeField] private ButtonCounter blue_button;
    [SerializeField] private GameObject key;


    void Update()
    {
        if (red_button.button_number == 5 && purple_button.button_number == 4 && blue_button.button_number == 8 && yellow_button.button_number == 1)
        {
            if (key != null)
                key.SetActive(true);
        }
    }
}
