using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyQueue
{
    int[] myQueue;

    public int count { get; private set; }

    int front;
    int rear;

    public MyQueue(int idx)
    {
        myQueue = new int[idx];
    }

    public void Enqueue(int a)
    {
        myQueue[rear] = a;
        count++;
        rear++;
    }

    public int Dequeue()
    {
        if (front == rear)
        {
            Debug.Log("큐가 비어있습니다.");
            front = 0;
            rear = 0;
            return 0;
        }
        else
            count--;
            return myQueue[front++];
    }
}
