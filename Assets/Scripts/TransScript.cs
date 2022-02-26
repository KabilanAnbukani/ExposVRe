using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("med_horror");
    }

    IEnumerator Example1()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("easy_horror");
    }
    IEnumerator Example2()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("med_height");
    }
    IEnumerator Example3()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("med_spider");
    }


    // Update is called once per frame
    void Update()
    {
        if (HorrorControl.sc == 1){
            print("SWITCHING TO MEDIUM");
            HorrorControl.counter = 0;
            HorrorControl.flag = false;
            StartCoroutine(Example());
            
        }
        else if (HorrorControlMed.sc1 == 1){
            print("SWITCHING TO EASY");
            HorrorControlMed.counter1 = 0;
            HorrorControlMed.flag1 = false;
            StartCoroutine(Example1());
            
        }
        else if (heightsscript.sun_height == 1){
            print("SWITCHING TO med");
            
            StartCoroutine(Example2());
            
        }
        else if (spiderscript.sun_spider == 1){
            print("SWITCHING TO med");
            
            StartCoroutine(Example3());
            
        }
    }
}
