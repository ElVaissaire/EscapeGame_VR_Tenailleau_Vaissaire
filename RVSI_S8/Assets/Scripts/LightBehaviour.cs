using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    private Light light;


    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();

        StartCoroutine(LightCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LightCoroutine()
    {
        while (enabled)
        {
            //T
            light.enabled = true;
            yield return new WaitForSeconds(1.5f);
            light.enabled = false;

            //changement lettre
            yield return new WaitForSeconds(1.5f);

            //I
            light.enabled = true;
            yield return new WaitForSeconds(0.5f);
            light.enabled = false;
            yield return new WaitForSeconds(0.5f);
            light.enabled = true;
            yield return new WaitForSeconds(0.5f);
            light.enabled = false;

            //changement lettre
            yield return new WaitForSeconds(1.5f);

            //M
            light.enabled = true;
            yield return new WaitForSeconds(0.5f);
            light.enabled = false;
            yield return new WaitForSeconds(0.5f);
            light.enabled = true;
            yield return new WaitForSeconds(0.5f);
            light.enabled = false;

            //changement de lettre
            yield return new WaitForSeconds(1.5f);

            //E
            light.enabled = true;
            yield return new WaitForSeconds(0.5f);
            light.enabled = false;

            //Reset
            yield return new WaitForSeconds(3.0f);

        }
    }
}
