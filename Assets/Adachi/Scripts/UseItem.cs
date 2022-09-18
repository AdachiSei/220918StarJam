using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    bool _isUse;

    void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Item item))
        {
            _isUse = true;
            item.OnDestroy();
        }
        else if(_isUse && other.TryGetComponent(out GimmickObject gimmick))
        {
            gimmick.OnDestroy();
        }
    }
}
