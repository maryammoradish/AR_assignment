using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class load_scene : MonoBehaviour
{
    public Button load_Button;
    // Start is called before the first frame update
    void Start()
    {
        load_Button.onClick.AddListener(OnButton);
    }

    public void OnButton()
    {
        Debug.Log("Button was pressed!");
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}