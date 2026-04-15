using UnityEngine;

public class BGMSoundVolume : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // AudioManagerから音量を取得して反映
        audioSource.volume = AudioManager.Instance.GetBGMVolume();
    }

    void Update()
    {
    audioSource.volume = AudioManager.Instance.GetBGMVolume();
    }
}
