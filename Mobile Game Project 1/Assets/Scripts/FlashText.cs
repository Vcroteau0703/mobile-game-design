using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlashText : MonoBehaviour
{
    TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        StartCoroutine(TextFlash());
    }

    private IEnumerator TextFlash()
    {
        while (true)
        {
            // Opaque to Transparent
            for (float i = 1; i >= 0; i -= Time.unscaledDeltaTime)
            {
                text.color = new Color(text.color.r, text.color.g, text.color.b, i);
                yield return null;
            }
            // Transparent to Opaque
            for (float i = 0; i <= 1; i += Time.unscaledDeltaTime)
            {
                text.color = new Color(text.color.r, text.color.g, text.color.b, i);
                yield return null;
            }

        }

    }
}
