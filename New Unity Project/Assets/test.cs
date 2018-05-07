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
        int[] m = { 0, 1, 2 };
        int n;
        Abcde abcde = new Abcde();
        Vector2 o = new Vector2(2.0f, 1.0f);
        Vector2 p = new Vector2(8.0f, 5.0f);
        Vector2 q = p - o;
        float r=q.magnitude;

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
        if (b == 0)
        {
            Debug.Log("b=0");
        }
        else
            Debug.Log("b!=0");
        if (c <= 0)
        {
            Debug.Log("c<=0");
        }
        else if (c >= 0)
            Debug.Log("c>=0");
        else
            Debug.Log("ありえねぇ");
        for (; ; )
        {
            break;
        }
        for (int ijk = 0; ijk < 3; ijk++)
        {
            Debug.Log(m[ijk]);
        }
        Abc();
        n = Def(a, e);
        Debug.Log(n);
        abcde.Atk();
        abcde.Dmg(30);
        Debug.Log(q);
        Debug.Log(r);

    }
    void Abc()
    {
        Debug.Log("関数やつ");
    }
    int Def(int a, int b)
    {
        return a + b;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
public class Abcde
{
    private int hp = 100;
    private int at = 50;

    public void Atk()
    {
        Debug.Log(at + "ダメージ！");
    }
    public void Dmg(int dmg)
    {
        hp -= dmg;
        Debug.Log(dmg + "ダメージ！いたい！");
    }
}