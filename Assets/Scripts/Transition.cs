using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public AudioSource select;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            select.Play();
            text.color = Color.yellow;
            Invoke("SceneTransition", 0.75f);
        }
    }

    void SceneTransition()
    {
        Scene a_Scene = SceneManager.GetActiveScene();
        if (a_Scene.name == "Start Menu")
        {
            SceneManager.LoadScene("IntroLvl0.0");
        }
        else if (a_Scene.name == "IntroLvl0.0")
        {
            SceneManager.LoadScene("Lvl0.0");
        }
        else if (a_Scene.name == "IntroLvl0.1")
        {
            SceneManager.LoadScene("Lvl0.1");
        }
        else if (a_Scene.name == "IntroLvl0.2")
        {
            SceneManager.LoadScene("Lvl0.2");
        }
        else if (a_Scene.name == "IntroLvl1.0")
        {
            SceneManager.LoadScene("Lvl1.0");
        }
        else if (a_Scene.name == "IntroLvl1.1")
        {
            SceneManager.LoadScene("Lvl1.1");
        }
        else if (a_Scene.name == "IntroLvl1.2")
        {
            SceneManager.LoadScene("Lvl1.2");
        }
        else if (a_Scene.name == "IntroLvl2.0")
        {
            SceneManager.LoadScene("Lvl2.0");
        }
        else if (a_Scene.name == "IntroLvl2.1")
        {
            SceneManager.LoadScene("Lvl2.1");
        }
        else if (a_Scene.name == "IntroLvl2.2")
        {
            SceneManager.LoadScene("Lvl2.2");
        }
        else if (a_Scene.name == "IntroLvl3.0")
        {
            SceneManager.LoadScene("Lvl3.0");
        }
        else if (a_Scene.name == "IntroLvl3.1")
        {
            SceneManager.LoadScene("Lvl3.1");
        }
        else if (a_Scene.name == "IntroLvl3.2")
        {
            SceneManager.LoadScene("Lvl3.2");
        }
        else if (a_Scene.name == "UltimateScreen")
        {
            SceneManager.LoadScene("Start Menu");
        }
    }
}
