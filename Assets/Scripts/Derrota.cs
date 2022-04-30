using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Derrota : MonoBehaviour
{
    public float time = 0;
    //public Text txt;

    public void Start ()
    {
        time=30;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        //txt.Text = "Tiempo = "+ time.ToString("f0");
        
        if (time <= 0)
        {
            SceneManager.LoadScene("Derrota");

        }
    }
}
