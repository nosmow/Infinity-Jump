using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlickerText : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    TextMeshProUGUI flickerText;
    string text;
    string textBlank = "";

    bool isFlicker = true;

    void Start()
    {
        flickerText = GetComponent<TextMeshProUGUI>();
        text = flickerText.text;

        StartCoroutine(TextoParpadeo());
    }

    public IEnumerator TextoParpadeo()
    {
        while (isFlicker)
        {
            flickerText.text = textBlank;
            yield return new WaitForSeconds(.5f);

            flickerText.text = text;
            yield return new WaitForSeconds(.5f);
        }
    }


    void Update()
    {
        if (canvas.enabled == false)
        {
            isFlicker = true;
        }
        else
        {
            isFlicker = true;
        }
    }
}