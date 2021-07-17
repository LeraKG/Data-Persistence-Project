using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartUI : MonoBehaviour
{

    public GameObject inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        StartMenu.Instance.username = inputField.GetComponent<TMP_InputField>().text;
        StartMenu.Instance.StartNew();
    }
}
