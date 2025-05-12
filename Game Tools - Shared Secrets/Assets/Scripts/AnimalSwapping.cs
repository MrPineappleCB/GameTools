using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSwapping : MonoBehaviour
{
    [SerializeField] private Camera cam;

    private Transform object1;
    private Transform object2;
    private Transform savedobject;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)) 
            {
                if (counter < 1)
                {
                    object1 = hit.transform;
                    counter++;
                }
                else
                {
                    object2 = hit.transform;
                    SwapSelections();
                    counter = 0;
                }
            }
        }
    }

    void SwapSelections()
    {
        savedobject = object1;
        object1 = object2;

        object2 = savedobject;
    }
}
