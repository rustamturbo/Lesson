using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChekerUsingObj.ChekerUseObj == true && Input.GetKeyDown(KeyCode.Space))
        {
            SelectbleObjectCheker.currentObject.GetComponent<BoxCollider2D>().isTrigger = true;
            SelectbleObjectCheker.currentObject.GetComponent<Animator>().SetBool("DoorOpen", true);
        }
        if (SelectbleObjectCheker.currentObject.GetComponent<BoxCollider2D>().isTrigger == true && Input.GetKeyDown(KeyCode.Space))
        {
            SelectbleObjectCheker.currentObject.GetComponent<BoxCollider2D>().isTrigger = false;
            SelectbleObjectCheker.currentObject.GetComponent<Animator>().SetBool("DoorOpen", false);
        }
    }
}
