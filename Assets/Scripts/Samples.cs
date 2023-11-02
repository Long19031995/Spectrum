using System.Collections.Generic;
using UnityEngine;


public class Samples : MonoBehaviour
{
    public SpectrumData SpectrumData;
    public Transform Sample;
    private List<Transform> samples = new List<Transform>();

    private void Awake()
    {
        for (int i = 0; i < (int)SpectrumData.NumberSample; i++)
        {
            samples.Add(Instantiate(Sample, transform));
        }
        for (int i = 0; i < (int)SpectrumData.NumberSample; i++)
        {
            if (i % 2 == 0)
            {
                samples[i].position = Sample.position + Vector3.left * i * 0.5f;
            }
            else
            {
                samples[i].position = Sample.position + Vector3.right * (i - 1) * 0.5f;
            }
        }
        Sample.gameObject.SetActive(false);
    }

    private void Update()
    {
        for (int i = 0; i < (int)SpectrumData.NumberSample; i++)
        {
            samples[i].localScale = new Vector3(1, (SpectrumData.Left[i] + SpectrumData.Right[i]) * 200, 1);
        }
    }
}
