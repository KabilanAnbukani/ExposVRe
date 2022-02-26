using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainCheckEH : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HorrorControl.flag == true){
            print("TRUE");
            HorrorControlMed.sc1 = 0;
            heightsscript.sun_height = 0;
            spiderscript.sun_spider = 0;
            SceneManager.LoadScene("TransScene");

        }
    }
}
