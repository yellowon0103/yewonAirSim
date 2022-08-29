using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

using Debug = UnityEngine.Debug;

//맵터치하여 좌표 구하기 
// 예원 22.08.29

public class MapClick : MonoBehaviour
{
    public RectTransform rectTransform;

    public float panelMapX, panelMapY;

    public void OnClick_Map()
    {
        rectTransform = GetComponent<RectTransform>();
        //Debug.Log("맵 이미지 사이즈: " + rectTransform.rect.size);

        //rectTransform = GetComponent<RectTransform>();
        //Debug.Log("왼쪽하단모서리 맵 좌표: " + rectTransform.offsetMin);

        Vector2 mouseClickedPosition = Input.mousePosition;
        //Debug.Log("마우스클릭 맵 좌표: " + mouseClickedPosition);
        //Debug.Log("화면높이: " + Screen.height + "화면 너비 : " + Screen.width);

        int mapMinX = Screen.width / 2 - 200;
        int mapMinY = Screen.height / 2 - 200;

        // 맵 이미지가 400*400 이고 그거에 맞춘 좌표
        Debug.Log(( mouseClickedPosition.x - mapMinX - 200 ) + " 하하 " + ( mouseClickedPosition.y - mapMinY - 200));
        //맵이미지 왼하단이 -200, -200 이라하고, 패널창 맵 을 그 좌표에 맞추기
        panelMapX = mouseClickedPosition.x - mapMinX - 200;
        panelMapY = mouseClickedPosition.y - mapMinY - 200;

        // (400*400) 2d 맵 이미지상 panelMapX , panelMapY 는
        // (900*900) 실제 맵에서는 panelMapX -250 , 0 , panelMapY -250 좌표이다
        // 근데 직접 클릭해보니까 y를 0 이 아니라 0.3으로 맵마우스클릭이동때 나영님꺼에서 하더라 
        // 그러니까 y축은 0이 아닌 0.3으로 해주자
    }

}
