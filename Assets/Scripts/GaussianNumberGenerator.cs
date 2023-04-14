using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GaussianNumberGenerator
{
    public static float GetGaussian(float mean, float dev) {
        float A = Random.value;
        float B = Random.value;

        float r2 = -2f * Mathf.Log(A);
        float phi = 2f * Mathf.PI * B;

        float r = Mathf.Sqrt(r2);
        float outNum = mean + dev * r * Mathf.Cos(phi);

        return outNum;
    }
}
