using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour,IDestroy
{
    public ItemType Type => _type;

    [SerializeField]
    [Header("�A�C�e��")]
    ItemType _type;

    public void OnDestroy()
    {
        Destroy(gameObject);    
    }
}
