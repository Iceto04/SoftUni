﻿namespace Problem04.SinglyLinkedList
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public Node<T> Next { get; set; }
    }
}