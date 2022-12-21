using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleQueue
{
    public int count { get; private set; }

    int[] circleQueue;

    int size;

    int front;
    int rear;

    public CircleQueue(int a)
    {
        circleQueue = new int[a];

        size = a;

        front = 0;
        rear = 0;
    }

    public void EnQueue(int a)
    {
        //데이터가 가득 차 있는지 체크
        if ((rear + 1) % size == front)
        {
            Debug.Log("큐가 full입니다.");
            return;
        }
        else
        {
            count++;
            rear = ++rear % size;
            circleQueue[rear] = a;
        }

    }

    public int DeQueue()
    {
        // 데이터가 비어있는지 체크
        if (rear == front)
        {
            Debug.Log("큐가 비어있습니다.");
            return 0;
        }
        else
        {
            count--;
            front = ++front % size;
            return circleQueue[front];
        }

    }

}
