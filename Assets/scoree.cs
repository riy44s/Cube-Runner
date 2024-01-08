using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoree : MonoBehaviour
{
    public TextMeshProUGUI adding;

    public int count = 0;

    public void add()
    {
        count++;
        adding.text=count.ToString();
        Debug.Log(count);
    }
    public void min()
    {
        count--;
        adding.text = count.ToString();
        Debug.Log(count);
    }
}
