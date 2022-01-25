using UnityEngine;
using System.Collections.Generic;

public static class CustomExtentions
{
    public static T RandElement<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}