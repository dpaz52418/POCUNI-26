using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightOscillation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // oscillation between value 1 to 6.7
        float lightIntensity = 1f + Mathf.PingPong(Time.time * 13f, 6.7f);
        GetComponent<Light2D>().intensity = lightIntensity;
    }
}
