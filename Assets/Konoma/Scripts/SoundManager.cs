using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
    AudioSource _audioSource;

    public float bgm = 1.0f;
    public float se = 1.0f;


    [SerializeField]
    [Header("�^�C�g��")]
    AudioClip _titleBGM;

    [SerializeField]
    [Header("�Q�[��")]
    AudioClip _gameBGM;

    [SerializeField]
    [Header("�N���A")]
    AudioClip _clearBGM;

    [SerializeField]
    [Header("�A�C�e�����g��")]
    AudioClip _itemUseSFX;

    [SerializeField]
    [Header("�A�C�e���ɐG�ꂽ�Ƃ��̉�")]
    AudioClip _itemGetSFX;


    const string TITLE_SCENE_NAME = "TitleScene";
    const string GAME_SCENE_NAME = "GameScene";

    protected override void Awake()
    {
        base.Awake();

        if (TryGetComponent(out _audioSource))
        {
           Debug.Log("�I�[�f�B�I�\�[�X���Q�Ƃł���");
        }
        TitleBGM();
    }

    private void TitleBGM()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case TITLE_SCENE_NAME:
                _audioSource.clip = _titleBGM;
                break;

            case GAME_SCENE_NAME:
                _audioSource.clip = _gameBGM;
                break;
        }
        _audioSource.Play();
    }

    public void PlayBGM(BGMType type)
    {
        switch (type)
        {
            case BGMType.Title:
                _audioSource.clip = _titleBGM;
                break;

            case BGMType.Game:
                _audioSource.clip = _gameBGM;
                break;

            case BGMType.Clear:
                _audioSource.clip = _clearBGM;
                break;
        }

        _audioSource.Play();
    }
    public void PlaySFX(SFXType type)
    {
        switch (type)
        {
     
            case SFXType.Kye:
                _audioSource.PlayOneShot(_itemUseSFX);
                break;

            case SFXType.Item:
                _audioSource.PlayOneShot(_itemGetSFX);
                break;
        }
    }
}
