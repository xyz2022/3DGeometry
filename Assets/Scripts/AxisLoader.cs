using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AxisLoader : MonoBehaviour
{
    private GameObject x_part;
    private GameObject y_part;
    private GameObject z_part;

    void Start()
    {
        x_part = Resources.Load("Prefabs/AxisLines/X") as GameObject;
        y_part = Resources.Load("Prefabs/AxisLines/Y") as GameObject;
        z_part = Resources.Load("Prefabs/AxisLines/Z") as GameObject;

        for (int i = 0; i < 10; i++)
        {
            //Setup positive axis'
            GameObject x = Instantiate(x_part);
            x.transform.position = new Vector3(i * 2, 0, 0);
            GameObject y = Instantiate(y_part);
            y.transform.position = new Vector3(0, i * 2, 0);
            GameObject z = Instantiate(z_part);
            z.transform.position = new Vector3(0, 0, i * 2);

            //Setup negative axis'
            //GameObject xneg = Instantiate(x_part);
            //xneg.transform.position = new Vector3(-2 + (i * -2), 0, 0);
            //GameObject yneg = Instantiate(y_part);
            //yneg.transform.position = new Vector3(0, -2 + (i * -2), 0);
            //GameObject zneg = Instantiate(z_part);
            //zneg.transform.position = new Vector3(0, 0, -2 + (i * -2));
        }
    }


    void Update()
    {
        
    }
}
