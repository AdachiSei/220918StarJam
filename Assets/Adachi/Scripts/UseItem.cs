using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    bool _isUseKey;
    bool _isUseAxe;

    void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Item item))
        {
            switch (item.Type)
            {
                case ItemType.Key:
                    _isUseKey = true;
                    break;
                case ItemType.Axe:
                    _isUseAxe = true;
                    break;
            }
            item.OnDestroy();
        }
        else if(other.TryGetComponent(out GimmickObject gimmick))
        {
            if(gimmick.Type == ItemType.Key && _isUseKey)
            {
                gimmick.OnDestroy();
                SceneLoader.Instance.LoadScene(SceneType.ResultScene);
            }
            else if(gimmick.Type == ItemType.Axe && _isUseAxe)
            {
                gimmick.OnDestroy();
            }
            
        }
    }
}
