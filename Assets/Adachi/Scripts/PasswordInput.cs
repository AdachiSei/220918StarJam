using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PasswordInput : MonoBehaviour
{
    [SerializeField]
    [Header("���͉�ʂ�UI")]
    GameObject _inputScreen;

    [SerializeField]
    [Header("�����̃{�^��")]
    NumberButton[] _nunberButton;

    [SerializeField]
    [Header("���͂����p�X���[�h�̃e�L�X�g")]
    Text _passwordText;

    void Awake()
    {
        
    }

    void Update()
    {
        
    }

    void InputScreen()
    {
        
    }

    [System.Serializable]
    public class NumberButton
    {
        public ButtonType NumberType => _numberType;
        public Button InputButton => _inputButton;

        [SerializeField]
        [Tooltip("���͂���鐔��")]
        string _number;

        [SerializeField]
        [Tooltip("���͂���鐔��")]
        ButtonType _numberType;

        [SerializeField]
        [Tooltip("���̓{�^��")]
        Button _inputButton;
    }
}
