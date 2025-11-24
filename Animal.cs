using System;
using System.Collections.Generic;

namespace _7pr
{
    public class Animal
{
    private string name;
    private string species;

    public Animal(string name, string species)
    {
        this.name = name;
        this.species = species;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Species
    {
        get { return species; }
        set { species = value; }
    }

    public override string ToString()
    {
        return $"{Name} ({Species})";
    }
}

public class GenericList<T> where T : Animal
{
    private class Node
    {
        private Node next;
        private T data;

        public Node(T t)
        {
            next = null;
            data = t;
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }

    private Node head;

    public GenericList()
    {
        head = null;
    }

    public void AddHead(T t)
    {
        Node n = new Node(t);
        n.Next = head;
        head = n;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    public T FindFirstOccurrence(string name)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data.Name == name)
            {
                return current.Data;
            }
            current = current.Next;
        }
        return null;
    }
}