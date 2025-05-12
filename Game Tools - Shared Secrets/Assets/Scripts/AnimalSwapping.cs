using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSwapping : MonoBehaviour
{
    [SerializeField] private Transform tiger;
    [SerializeField] private Transform unicorn;
    [SerializeField] private Transform deer;
    [SerializeField] private Transform hippo;
    [SerializeField] private Camera cam;

    private Transform object1;
    private Transform object2;
    private Vector3 position1;
    private Vector3 position2;

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
                object1 = hit.transform;
                position1 = object1.position;
            }
            if(Physics.Raycast(ray, out hit) && position1 != null)
            {
                object2 = hit.transform;
                position2 = object2.position;
                object1.position = position2;
                object2.position = position1;
            }
        }
    }
}
