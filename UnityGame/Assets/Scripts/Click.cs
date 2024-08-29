using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour
{
    private GameObject tempObject;
    private Color blockColor;
    private Color compareColor;

    private void Start()
    {
        blockColor = Color.white;
        compareColor = Color.white;
    }

    private void Update()
    {
        
    }

    public void OnMouseDown()
    {
        blockColor = gameObject.GetComponent<Renderer>().material.color;
    
        CheckColor();
    }

    public void CheckColor()
    {
        if (compareColor != Color.white)
        {
            if (blockColor == compareColor)
            {
                Destroy(tempObject);
                Destroy(gameObject);

                ResetColor();
            }
            else
            {
                tempObject = null;

                ResetColor();
            }
        }
        else
        {
            compareColor = blockColor;
            tempObject = gameObject;

            Debug.Log("set compare");
        }
    }

    public void ResetColor()
    {
        compareColor = Color.white;
        blockColor = Color.white;

        Debug.Log("Reset");
    }
}
