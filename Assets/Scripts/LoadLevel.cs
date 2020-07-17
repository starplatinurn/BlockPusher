using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public AudioSource select;
    public Button button;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(Mouse_Click);
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Mouse_Click()
    {
        select.Play();
        Invoke("ChangeLevel", 0.75f);
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene(text.text);
    }
}
