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
        //�����Ͱ� ���� �� �ִ��� üũ
        if ((rear + 1) % size == front)
        {
            Debug.Log("ť�� full�Դϴ�.");
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
        // �����Ͱ� ����ִ��� üũ
        if (rear == front)
        {
            Debug.Log("ť�� ����ֽ��ϴ�.");
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
