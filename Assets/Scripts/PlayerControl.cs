using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //1 - ����������� �������, 2 - ��� ������, 3 - ��� ����������
    public float speedCar = 10;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speedCar);
        
    }
}
