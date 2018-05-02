using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int a;
        float b, c;
        string d;
        int e;
        int f;
        int g;
        int h = 0;
        int i = 0;
        string j, k;
        string l;

        a = 30;
        b = 160.5f;
        c = b;
        d = "abc";
        e = 1 + 2;
        f = 1 + 2 - 3 * 4 / 5;
        g = a + e;
        h += 1;
        i++;
        j = "def";
        k = d + j;
        l = d + a;

        Debug.Log("はろおわあるど");
        Debug.Log(a);
        Debug.Log(c);
        Debug.Log(d);
        Debug.Log(e);
        Debug.Log(f);
        Debug.Log(g);
        Debug.Log(h);
        Debug.Log(i);
        Debug.Log(j);
        Debug.Log(l);
        if (a == 30)
            Debug.Log("a=30");
        if (b == 0) {
            Debug.Log("b=0");
        }
       else
            Debug.Log("b!=0");
        if (c <= 0)
        {
            Debug.Log("c<=0");
        }
        else if(c >= 0)
            Debug.Log("c>=0");
        else
            Debug.Log("ありえねぇ");
        for(; ; ) {
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
