using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRot : MonoBehaviour
{

    public GameObject cam;

    // Update is called once per frame
    void Update()
    {
        Head();
    }

    void Head(){
        cam.transform.eulerAngles = new Vector3(0,0,0);
    }
}
