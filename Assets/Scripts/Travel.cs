using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Travel : MonoBehaviour
{
    public RectTransform r1;
    public RectTransform r2;
    void Start()
    {
        
    }

    void Update()
    {
        float xpos = Mathf.Lerp(r1.position.x, r2.position.x, 0.5f);
        transform.position = new Vector3(xpos, transform.position.y, transform.position.z); 
    }
}
