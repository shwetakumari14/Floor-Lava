using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTranform : MonoBehaviour
{
    public Vector3 scaleChange;
    public float changeSpeed = 0.1f;
    public float maxScale = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale += scaleChange * changeSpeed * Time.deltaTime;
        // Calculate the new scale with changeSpeed and Time.deltaTime
        Vector3 newScale = transform.localScale + scaleChange * changeSpeed * Time.deltaTime;

        // Check if the new scale exceeds the maxScale
        if (newScale.x <= maxScale && newScale.y <= maxScale && newScale.z <= maxScale)
        {
            // Apply the new scale
            transform.localScale = newScale;
        }
    }
}
