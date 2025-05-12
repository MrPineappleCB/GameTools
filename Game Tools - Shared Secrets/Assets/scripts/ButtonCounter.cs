using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI button;
    public int button_number = 1;
    
    public void Increase()
    {
        button_number += 1;
        button.text = button_number.ToString();
        if (button_number > 8)
        {
            button_number = 0;
        }
    }
}
