using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public static bool InputEnabled = true;
    public GameObject End;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D()
    {
        Instantiate(End, transform.position, transform.rotation);
        InputEnabled = false;
        Invoke("SceneTransition", 1);
        InputEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SceneTransition()
    {
        Scene a_Scene = SceneManager.GetActiveScene();
        if (a_Scene.name == "Lvl0.0")
        {
            SceneManager.LoadScene("IntroLvl0.1");
        }
        else if (a_Scene.name == "Lvl0.1")
        {
            SceneManager.LoadScene("IntroLvl0.2");
        }
        else if (a_Scene.name == "Lvl0.2")
        {
            SceneManager.LoadScene("IntroLvl1.0");
        }
        else if (a_Scene.name == "Lvl1.0")
        {
            SceneManager.LoadScene("IntroLvl1.1");
        }
        else if (a_Scene.name == "Lvl1.1")
        {
            SceneManager.LoadScene("IntroLvl1.2");
        }
        else if (a_Scene.name == "Lvl1.2")
        {
            SceneManager.LoadScene("IntroLvl2.0");
        }
        else if (a_Scene.name == "Lvl2.0")
        {
            SceneManager.LoadScene("IntroLvl2.1");
        }
        else if (a_Scene.name == "Lvl2.1")
        {
            SceneManager.LoadScene("IntroLvl2.2");
        }
        else if (a_Scene.name == "Lvl2.2")
        {
            SceneManager.LoadScene("IntroLvl3.0");
        }
        else if (a_Scene.name == "Lvl3.0")
        {
            SceneManager.LoadScene("IntroLvl3.1");
        }
        else if (a_Scene.name == "Lvl3.1")
        {
            SceneManager.LoadScene("IntroLvl3.2");
        }
        else if (a_Scene.name == "Lvl3.2")
        {
            SceneManager.LoadScene("UltimateScreen");
        }
    }
}
