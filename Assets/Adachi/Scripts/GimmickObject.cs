using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickObject : MonoBehaviour, IDestroy
{
    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
