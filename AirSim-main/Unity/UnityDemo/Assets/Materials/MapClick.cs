using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

using Debug = UnityEngine.Debug;

//����ġ�Ͽ� ��ǥ ���ϱ� 
// ���� 22.08.29

public class MapClick : MonoBehaviour
{
    public RectTransform rectTransform;

    public float panelMapX, panelMapY;

    public void OnClick_Map()
    {
        rectTransform = GetComponent<RectTransform>();
        //Debug.Log("�� �̹��� ������: " + rectTransform.rect.size);

        //rectTransform = GetComponent<RectTransform>();
        //Debug.Log("�����ϴܸ𼭸� �� ��ǥ: " + rectTransform.offsetMin);

        Vector2 mouseClickedPosition = Input.mousePosition;
        //Debug.Log("���콺Ŭ�� �� ��ǥ: " + mouseClickedPosition);
        //Debug.Log("ȭ�����: " + Screen.height + "ȭ�� �ʺ� : " + Screen.width);

        int mapMinX = Screen.width / 2 - 200;
        int mapMinY = Screen.height / 2 - 200;

        // �� �̹����� 400*400 �̰� �װſ� ���� ��ǥ
        Debug.Log(( mouseClickedPosition.x - mapMinX - 200 ) + " ���� " + ( mouseClickedPosition.y - mapMinY - 200));
        //���̹��� ���ϴ��� -200, -200 �̶��ϰ�, �г�â �� �� �� ��ǥ�� ���߱�
        panelMapX = mouseClickedPosition.x - mapMinX - 200;
        panelMapY = mouseClickedPosition.y - mapMinY - 200;

        // (400*400) 2d �� �̹����� panelMapX , panelMapY ��
        // (900*900) ���� �ʿ����� panelMapX -250 , 0 , panelMapY -250 ��ǥ�̴�
        // �ٵ� ���� Ŭ���غ��ϱ� y�� 0 �� �ƴ϶� 0.3���� �ʸ��콺Ŭ���̵��� �����Բ����� �ϴ��� 
        // �׷��ϱ� y���� 0�� �ƴ� 0.3���� ������
    }

}
