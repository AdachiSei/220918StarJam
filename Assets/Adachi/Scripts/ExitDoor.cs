using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    [SerializeField]
    [Header("���͉�ʂ�UI")]
    GameObject _inputScreen;

    void OnTriggerEnter(Collider other)
    {
        _inputScreen.gameObject.SetActive(true);    
    }

    void OnTriggerExit(Collider other)
    {
        _inputScreen.gameObject.SetActive(false);
    }
}
