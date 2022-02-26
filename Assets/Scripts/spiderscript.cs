using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spiderscript : MonoBehaviour
{
    public static int  sun_spider = 1;
    IEnumerator Example()
    {           

        yield return new WaitForSeconds(20);
        print("SWITCHING TO MEDIUM");
        HorrorControlMed.sc1 = 0;
        HorrorControl.sc = 0;
        heightsscript.sun_height = 0;
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
