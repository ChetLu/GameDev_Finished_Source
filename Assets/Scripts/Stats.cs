using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public GameObject statsUI;
    public bool statsScreenOn = false;
    // Start is called before the first frame update
    void Start()
    {
        statsUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (statsScreenOn)
            {
                statsUI.SetActive(false);
                statsScreenOn = false;
            }
            else
            {
                statsUI.SetActive(true);
                statsScreenOn = true;
            }
        }
    }
}
