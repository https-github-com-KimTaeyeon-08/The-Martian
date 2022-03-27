using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float Power;
    public float ShakeTime;

    private Vector3 cameraPosition = new Vector3(980f, 547.3f, -583f);

    public void ShakeForTime(float time) => ShakeTime = time;

    private void Update()
    {
        if (ShakeTime > 0)
        {
            transform.position = Random.insideUnitSphere * Power + cameraPosition;

            ShakeTime -= Time.deltaTime;
        }
        else
        {
            ShakeTime = 0.0f;
            transform.position = cameraPosition;
        }
    }
}
