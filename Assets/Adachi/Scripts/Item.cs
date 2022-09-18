using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour,IDestroy
{
    public void OnDestroy()
    {
        Destroy(gameObject);    
    }
}
