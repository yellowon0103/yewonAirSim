using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Diagnostics;

using Debug = UnityEngine.Debug;

public class ArduinoManager : MonoBehaviour
{

    //�ø��� ��Ʈ
    SerialPort serial;

    void Start()
    {
        serial = new SerialPort("COM11", 9600);
        serial.Open();
    }

    void OnDestroy()
    {
        serial.Close();
    }

    public void Angle(float angle)
    {
        if (angle > 1)
        {
            Debug.Log(angle);
            serial.Write(angle.ToString());
        }
    }

    void Update()
    {
        //  �� ��� �ּ�
        //���� �׽�Ʈ �ڵ�
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //	//�Ƶ��̳����� 1�� ������.
        //	serial.Write("1");
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //	//�Ƶ��̳����� 2�� ������.
        //	serial.Write("2");
        //}
    }
}
