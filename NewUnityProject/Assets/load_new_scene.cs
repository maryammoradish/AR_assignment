using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class load_new_scene : MonoBehaviour
{
    public Button load_Button;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("??????");
        load_Button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
