using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Methods : MonoBehaviour
{
    //Random code I did don't take it too serious
    float Count = 0f;
    Vector3 TargetPos = Vector3.zero;
    Vector3 TargetRot = Vector3.zero;
    void StringN(int n, string msg)
    {
        for (int i = 0; i < n; i++)
        {
            Debug.Log(msg);
        }
    }

    int CalculateDiff(int num1, int num2)
    {
        int sum = num1 + num2;
        int product = num1 * num2;
        return (product - sum);
    }

    void SetPosObj(float num1, float num2, float num3)
    {
        transform.position = new Vector3(num1, num2, num3);
    }

    void SetPosObj(Vector3 Position)
    {
        transform.position = Vector3.Lerp(transform.position, Position, 0.005f);
    }
    void SetRotObj(Vector3 Rot)
    {
        //transform.rotation = Quaternion.Euler(Rot);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Rot), 0.005f);
    }
    // Start is called before the first frame update
    void Start()
    {
        StringN(5, "Hello World!");
        Debug.Log(CalculateDiff(10, 20));
        SetPosObj(new Vector3(0.5f, 10.5f, 6.1f));
    }

    // Update is called once per frame
    void Update()
    {
        SetPosObj(TargetPos);
        SetRotObj(TargetRot);
        if (Count >= 1)
        {
            TargetPos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
            TargetRot = new Vector3(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
            Count = 0f;
        }
        else
        {
            Count += Time.deltaTime;
        }
        
    }
}
