using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class StartMenu : MonoBehaviour
{

    public static StartMenu Instance;
    public GameObject inputField;
    public string username;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void StartNew()
    {
        StartCoroutine(StartNewCoRoutine());
    }
    IEnumerator StartNewCoRoutine()
    {
        SceneManager.LoadScene(1);
        username = inputField.GetComponent<TMP_InputField>().text;
        yield return null;
        GameObject.Find("YourName").GetComponent<TextMeshProUGUI>().text = username;


    }
}
