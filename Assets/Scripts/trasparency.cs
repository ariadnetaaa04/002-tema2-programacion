using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trasparency : MonoBehaviour
{
    private MeshRenderer _meshrenderer;
    private void Awake()
    {
        _meshrenderer = GetComponent<MeshRenderer>();

    }
    void Start()
    {
        StartCoroutine(FadeIn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return Color.black;
    }
    private IEnumerator FadeOut()
    {
        Color color = _meshrenderer.material.color;
        for (float i = 1; i >= 0; i -= 0.1f)
        {
            color = RandomColor();
            color = new Color(color.r, color.g, color.b, i);
            _meshrenderer.material.color = color;
            yield return new WaitForSeconds(0.2f);

        }
      
        color = new Color(color.r, color.g, color.b, 0);
        _meshrenderer.material.color = color;
        StartCoroutine(FadeIn());

    }
    private IEnumerator FadeIn()
        {
        Color color = RandomColor();
            for (float i = 0; i >= 1; i += 0.1f)
            {
                color = _meshrenderer.material.color;
                color = new Color(color.r, color.g, color.b, i);
                _meshrenderer.material.color = color;
                yield return new WaitForSeconds(0.2f);

            }
        color = new Color(color.r, color.g, color.b, 1);
        _meshrenderer.material.color = color;
        StartCoroutine(FadeOut());
    }
}