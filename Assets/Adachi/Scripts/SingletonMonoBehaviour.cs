using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    [Header("�V�[�����ړ����Ă��ێ����邩")]
    bool _isDontDestroy;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(T)) as T;

                if (_instance == null)
                {
                    Debug.LogError($"{typeof(T)}���A�^�b�`���Ă���GameObject������܂���");
                }
            }

            return _instance;
        }
    }

    static T _instance;

    virtual protected void Awake()
    {
        if (_isDontDestroy) DontDestroyOnLoad(this);

        CheckInstance();
    }

    protected bool CheckInstance()
    {
        if (_instance == null)
        {
            _instance = this as T;
            return true;
        }
        else if (_instance == this)
        {
            return true;
        }
        else
        {
            Destroy(this);
            return false;
        }
    }
}