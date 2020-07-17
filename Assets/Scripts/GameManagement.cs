using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    private float QuitStartTime = 0f;
    private float QuitTimer = 0f;
    public float QuitHoldTime = 1.0f;
    private bool QuitHeld = false;
    public string QuitKey = "escape";
    private float MenuStartTime = 0f;
    private float MenuTimer = 0f;
    public float MenuHoldTime = 1.0f;
    private bool MenuHeld = false;
    public string MenuKey = "backspace";
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        //Quit
        if (Input.GetKeyDown(QuitKey))
        {
            QuitStartTime = Time.time;
            QuitTimer = QuitStartTime;
        }
        if (Input.GetKey(QuitKey) && QuitHeld == false)
        {
            QuitTimer += Time.deltaTime;
            if (QuitTimer > (QuitStartTime + QuitHoldTime))
            {
                QuitHeld = true;
                Application.Quit();
            }
        }
        //Menu
        if (Input.GetKeyDown(MenuKey))
        {
            MenuStartTime = Time.time;
            MenuTimer = MenuStartTime;
        }
        if (Input.GetKey(MenuKey) && MenuHeld == false)
        {
            MenuTimer += Time.deltaTime;
            if (MenuTimer > (MenuStartTime + MenuHoldTime))
            {
                MenuHeld = true;
                if (SceneManager.GetActiveScene().name != "MainMenu")
                {
                    SceneManager.LoadScene("MainMenu");
                }
            }
        }
    }
}
