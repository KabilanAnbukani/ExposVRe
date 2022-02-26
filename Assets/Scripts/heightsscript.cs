using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heightsscript : MonoBehaviour
{
    public static int  sun_height = 1;
    IEnumerator Example()
    {           

        yield return new WaitForSeconds(20);
        print("SWITCHING TO MEDIUM");
        HorrorControlMed.sc1 = 0;
        HorrorControl.sc = 0;
        spiderscript.sun_spider = 0;
        SceneManager.LoadScene("TransScene");

    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {
    
    }
        
        
    
}
