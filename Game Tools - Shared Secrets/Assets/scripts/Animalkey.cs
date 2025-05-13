using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animalkey : MonoBehaviour
{
    public List<GameObject> statues = new List<GameObject>();
    public int counter;
    public GameObject key;

    private void Update()
    {
        foreach(GameObject animal in statues)
        {
            if(animal.GetComponent<AnimalSwapping>().inCorrectSlot)
            {
                counter += 1;
            }
        }

        if (counter == 2)
        {
            key.SetActive(true);
        }
    }
}
