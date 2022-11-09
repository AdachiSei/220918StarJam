using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickObject : MonoBehaviour, IDestroy
{
    public ItemType Type => _type;

    [SerializeField]
    [Header("このオブジェクトを壊せるアイテム")]
    ItemType _type;

    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
