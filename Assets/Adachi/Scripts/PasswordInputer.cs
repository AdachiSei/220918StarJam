using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordInputer : MonoBehaviour
{
    [SerializeField]
    [Header("�p�X���[�h")]
    string _password;

    [SerializeField]
    [Header("���͉�ʂ�UI")]
    GameObject _inputScreen;

    [SerializeField]
    [Header("�E�o�p�̃h�A")]
    ExitDoor _exitDoor;

    [SerializeField]
    [Header("�����̃{�^��")]
    NumberButton[] _nunberButton;

    [SerializeField]
    [Header("���͂����p�X���[�h�̃e�L�X�g")]
    Text _passwordText;

    string _passwordData;

    void Awake()
    {
        _inputScreen.gameObject.SetActive(false);
        _passwordText.text = "";
        _passwordData = "";

        foreach (var i in _nunberButton)
        {
            i.InputButton.onClick.AddListener(() =>
            InputScreenButton(i.NumberType));
        }
    }

    void InputScreenButton(ButtonType type)
    {

        switch (type)
        {
            case ButtonType.Zero:
                if (_passwordData.Length < _password.Length)
                    _passwordData += "0";
                break;
            case ButtonType.One:
                if (_passwordData.Length < _password.Length)
                    _passwordData += 1;
                break;
            case ButtonType.Two:
                if (_passwordData.Length < _password.Length)
                    _passwordData += 2;
                break;
            case ButtonType.Three:
                if (_passwordData.Length < _password.Length)
                    _passwordData += 3;
                break;
            case ButtonType.Four:
                if (_passwordData.Length < _password.Length)
                    _passwordData += 4;
                break;
            case ButtonType.Five:
                if (_passwordData.Length < _password.Length)
                    _passwordData += 5;
                break;
            case ButtonType.Six:
                if (_passwordData.Length < _password.Length)
                    _passwordData += 6;
                break;
            case ButtonType.Seven:
                if (_passwordData.Length < _password.Length)
                    _passwordData += 7;
                break;
            case ButtonType.Eight:
                if (_passwordData.Length < _password.Length)
                    _passwordData += 8;
                break;
            case ButtonType.Ninth:
                if (_passwordData.Length < _password.Length)
                    _passwordData += 9;
                break;
            case ButtonType.BackSpace:
                if (_passwordData.Length != 0)
                    _passwordData = _passwordData.Remove(_passwordData.Length - 1);
                break;
            case ButtonType.Clear:
                _passwordData = "";
                break;
            case ButtonType.Enter:
                if (_passwordData == _password)
                {
                    _inputScreen.gameObject.SetActive(false);
                    Destroy(_exitDoor);
                    SceneLoader.Instance.LoadScene(SceneType.ResultScene);
                    Debug.Log("�N���A");
                }
                else _passwordData = "";
                break;
        }

        _passwordText.text = _passwordData;
    }

    [Serializable]
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
