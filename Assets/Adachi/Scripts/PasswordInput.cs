using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PasswordInput : MonoBehaviour
{
    [SerializeField]
    [Header("入力画面のUI")]
    GameObject _inputScreen;

    [SerializeField]
    [Header("数字のボタン")]
    NumberButton[] _nunberButton;

    [SerializeField]
    [Header("入力したパスワードのテキスト")]
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
        [Tooltip("入力される数字")]
        string _number;

        [SerializeField]
        [Tooltip("入力される数字")]
        ButtonType _numberType;

        [SerializeField]
        [Tooltip("入力ボタン")]
        Button _inputButton;
    }
}
