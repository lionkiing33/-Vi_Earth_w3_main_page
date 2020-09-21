using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class virusScript : MonoBehaviour
{
    //y축의 최소, 최대값 지정.
    public float minY, maxY;
    //x축의 위치 변수 지정.
    public float positionX;
    //이동 속도 지정.
    public float moveSpeed;
    //moving시작 시간 지정.
    public float startTime;
    //이동 방향 변수 지정
    public int sign=-1;
    // Update is called once per frame
    void Update()
    {
        if(Time.time>startTime)
        {
            Vector3 target = new Vector3(positionX, maxY, 0);
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime * sign, 0);
            if (transform.position.y < minY)
            {
                transform.position = target;
            }
        }
        
    }
}
