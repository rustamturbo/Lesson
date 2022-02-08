using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectbleObjectCheker : MonoBehaviour
{
    public static GameObject currentObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UsingObject")
        {
            currentObject = collision.gameObject;
            collision.GetComponent<SpriteOutline>().OutlineColor = new Color(255, 255, 255, 255);
            ChekerUsingObj.ChekerUseObj = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UsingObject")
        {
            currentObject = collision.gameObject;
            collision.GetComponent<SpriteOutline>().OutlineColor = new Color(255, 255, 255, 0);
            ChekerUsingObj.ChekerUseObj = false;
        }
    }
}
