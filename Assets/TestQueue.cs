using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestQueue : MonoBehaviour
{
    CircleQueue cq = new CircleQueue(5);
    void Start()
    {
        cq.EnQueue(1);
        cq.EnQueue(2);
        cq.EnQueue(3);
        cq.EnQueue(4);
        cq.EnQueue(5);

        Debug.Log($"현재 카운트는 {cq.count}입니다.");

        Debug.Log(cq.DeQueue());
        Debug.Log(cq.DeQueue());
        Debug.Log(cq.DeQueue());
        Debug.Log(cq.DeQueue());
        Debug.Log(cq.DeQueue());

        Debug.Log($"현재 카운트는 {cq.count}입니다.");

        cq.EnQueue(10);
        cq.EnQueue(20);
        cq.EnQueue(30);
        cq.EnQueue(40);
        cq.EnQueue(50);

        Debug.Log(cq.DeQueue());
        Debug.Log(cq.DeQueue());
        Debug.Log(cq.DeQueue());
        Debug.Log(cq.DeQueue());
        Debug.Log(cq.DeQueue());


    }


}
