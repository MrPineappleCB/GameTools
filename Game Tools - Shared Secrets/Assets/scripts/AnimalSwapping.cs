using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSwapping : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform position1;
    [SerializeField] private Transform position2;
    [SerializeField] private Transform position3;
    [SerializeField] private Transform position4;
    [SerializeField] private Transform tiger;
    [SerializeField] private Transform Hippo;
    [SerializeField] private Transform deer;
    [SerializeField] private Transform unicorn;
    [SerializeField] private Transform tiger2;
    [SerializeField] private Transform Hippo2;
    [SerializeField] private Transform deer2;
    [SerializeField] private Transform unicorn2;
    [SerializeField] private GameObject key;
    private Vector3 _originalPos;
    private bool halfkey1 = false;
    private bool halfkey2 = false;
    private int counter;
    private int push;

    void Awake()
    {
        _originalPos = transform.position;
        if (_originalPos == position1.position)
        {
            counter = 1;
        }
        if (_originalPos == position2.position)
        {
            counter = 2;
        }
        if (_originalPos == position3.position)
        {
            counter = 3;
        }
        if (_originalPos == position4.position)
        {
            counter = 4;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            counter += 1;
            push = -1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            counter -= 1;
            push = 1;
        }
        if (counter == 1)
        {
            transform.position = position1.position;
        }
        if (counter == 2)
        {
            transform.position = position2.position;
        }
        if (counter == 3)
        {
            transform.position = position3.position;
        }
        if (counter == 4)
        {
            transform.position = position4.position;
        }

         if (unicorn.position == position1.position && deer.position == position2.position && tiger.position == position3.position && Hippo.position == position4.position)
        {
            halfkey1 = true;
        }
        
        if (unicorn2.position == position4.position && deer2.position == position1.position && tiger2.position == position2.position && Hippo2.position == position3.position)
        {
            halfkey2 = true;
        }

        if (halfkey1 == true && halfkey2 == true)
        {
            key.SetActive(true);
        }
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Statue"))
        {
            other.gameObject.GetComponent<AnimalSwapping>().Overlap();
        }
    }

    void Overlap()
    {
        counter += push;
    }

}
