using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FearScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            Debug.Log("Q");
            SceneManager.LoadScene("easy_horror");
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            SceneManager.LoadScene("easy_heights");
            Debug.Log("W");
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            SceneManager.LoadScene("easy_sppider");
            Debug.Log("A");
        }
    }
}
