using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelPath : MonoBehaviour
{
    [SerializeField] List<Transform> path;
    List<Vector2> pathVecs = new List<Vector2>();

    void createPathVecs()
    {
        pathVecs.Clear();
        foreach (Transform t in path)
        {
            pathVecs.Add(new Vector2(t.position.x, t.position.z));
        }
    }

    public List<Vector2> GetPath() 
    { 
        createPathVecs();
        return new List<Vector2>(pathVecs);
    }

    public Vector2 GetNode(int index)
    {
        Transform t = path[index];
        return new Vector2(t.position.x, t.position.z);
    }

    public int GetPathLenght()
    {
        return path.Count;
    }
}