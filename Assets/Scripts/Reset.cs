using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private float startTime = 0f;
    private float timer = 0f;
    public float holdTime = 1.0f;
    private bool held = false;
    public string key = "r";
    public GameObject End;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            startTime = Time.time;
            timer = startTime;
        }
        if (Input.GetKey(key) && held == false)
        {
            timer += Time.deltaTime;
            if (timer > (startTime + holdTime))
            {
                held = true;
                Instantiate(End, transform.position, transform.rotation);
                Invoke("Reload", 1);
            }
        }
    }

    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
