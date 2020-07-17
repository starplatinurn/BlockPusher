using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public GameObject door;
    public AudioSource doorOpen;
    public float newPosX = 11.5f, newPosY = 2f, oldPosX = 10.5f, oldPosY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        oldPosX = door.transform.position.x;
        oldPosY = door.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D()
    {
        doorOpen.Play();
    }

    void OnTriggerStay2D()
    {
        GetComponent<SpriteRenderer>().color = new Color32(220, 38, 166, 255);
        door.transform.position = new Vector3(newPosX, newPosY, 0f);
    }

    void OnTriggerExit2D()
    {
        door.transform.position = new Vector3(oldPosX, oldPosY, 0f);
        GetComponent<SpriteRenderer>().color = new Color32(150, 38, 166, 255);
    }
}
