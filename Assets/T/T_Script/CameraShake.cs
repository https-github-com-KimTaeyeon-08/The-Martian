using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float power;
    public float shake_time;
   
    Vector3 position;
   public void shakefortime(float time)
    {
        shake_time = time;
    }
    private void Start()
    {
        position = new Vector3(980f, 547.3f, -583f);
    }
    private void Update()
    {
        if (shake_time > 0)
        {
            transform.position = Random.insideUnitSphere * power + position;
            
            shake_time -= Time.deltaTime;
        }
        else
        {
            shake_time = 0.0f;
            transform.position = position;
        }
    }
}
