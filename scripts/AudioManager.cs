using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private float bgmVolume = 1f;
    private float seVolume = 1f;

    void Awake()
    {
        // シングルトン＋破棄防止
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ==== 音量設定 ====
    public void SetBGMVolume(float value)
    {
        bgmVolume = value;
    }

    public void SetSEVolume(float value)
    {
        seVolume = value;
    }

    public float GetBGMVolume() => bgmVolume;
    public float GetSEVolume() => seVolume;
}