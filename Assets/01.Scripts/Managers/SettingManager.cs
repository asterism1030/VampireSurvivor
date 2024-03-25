using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
    // �����ϴ� ��⿡ ���� ������, ������ ����?? �������� �����ϱ� ���� ��������ϴ�.

    private static SettingManager _instance;

    public static SettingManager Instance
    {
        get
        {
            if (_instance == null)
                return null;

            return _instance;
        }
    }


    public Vector2 ScreenSize
    {
        get { return new Vector2(Screen.width, Screen.height); }
    }

    public int MapTextureSize
    {
        get 
        {
            if (_mapTextureSize <= 0)
                _mapTextureSize = Resources.Load<Sprite>("Maps/Test").texture.width;

            return _mapTextureSize;
        }
    }

    static int _mapTextureSize = 0;

    public int RxC_Count
    {
        get
        {
            return 32;
        }
    }



    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
}
