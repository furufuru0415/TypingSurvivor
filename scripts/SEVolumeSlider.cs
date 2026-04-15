using UnityEngine;
using UnityEngine.UI;

public class SEVolumeSlider : MonoBehaviour
{
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();

        // スライダー初期値を AudioManager から取得
        slider.value = AudioManager.Instance.GetSEVolume();

        // 値が変わったときの処理を登録
        slider.onValueChanged.AddListener(OnValueChanged);
    }

    private void OnValueChanged(float value)
    {
        // AudioManager に反映
        AudioManager.Instance.SetSEVolume(value);
    }
}
