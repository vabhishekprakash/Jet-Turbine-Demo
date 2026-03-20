using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject Turbinobject;
    private bool isActive = true;
    // Start is called before the first frame update
    public void toggle()
    {
        if (isActive)
        {
            Turbinobject.SetActive(false);
            isActive = false;
        }
        else
        {
            Turbinobject.SetActive(true);
            isActive = true;
        }

    }
}