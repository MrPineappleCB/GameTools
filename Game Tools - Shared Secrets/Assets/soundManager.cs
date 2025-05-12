using UnityEngine;

public class soundManager : MonoBehaviour
{

    public AudioSource walkSound;
    public int timer = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (input.magnitude > 0)
        {
            if (timer == 0)
            {
                //print("walk");
                walkSound.enabled = true;
            }

            else
            {
                walkSound.enabled = false;
            }

            timer -= 1;
            print(timer);
            if (timer < 0)
            {
                timer = 20;
            }
        }

        else
        {
            walkSound.enabled = false;
        }
    }
}
