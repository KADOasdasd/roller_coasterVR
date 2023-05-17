using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
using Color = UnityEngine.Color;
public class fade_in_out : MonoBehaviour
{
    public float FadeTime = 2f; // Fadeȿ�� ����ð�

    Image fadeImg;

    float start;

    float end;

    float time = 0f;

    bool isPlaying = false;



    void Awake()

    {

        fadeImg = GetComponent<Image>();

        InStartFadeAnim();

    }

    public void OutStartFadeAnim()

    {

        if (isPlaying == true) //�ߺ��������

        {

            return;

        }

        start = 1f;

        end = 0f;

        StartCoroutine("fadeoutplay");    //�ڷ�ƾ ����
    }
    public void InStartFadeAnim()

    {

        if (isPlaying == true) //�ߺ��������

        {

            return;

        }

        StartCoroutine("fadeIntanim");

    }
    IEnumerator fadeoutplay()

    {

        isPlaying = true;


        //UnityEngine.Color fadeColor = fadeImg.color;
        //Color fadecolor = fadeImg.color;
        //time = 0f;

        //Color.a = Mathf.Lerp(start, end, time);
        Color fadecolor = fadeImg.color;
        time = 0f;
        fadecolor.a = Mathf.Lerp(start, end, time);
        fadeImg.color = fadecolor;





        while (fadecolor.a > 0f)

        {

            time += Time.deltaTime / FadeTime;

            fadecolor.a = Mathf.Lerp(start, end, time);

            fadeImg.color = fadecolor;

            yield return null;

        }

        isPlaying = false;

    }
}



