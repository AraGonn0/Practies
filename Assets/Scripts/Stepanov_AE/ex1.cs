using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {


        string str = "������ ���������� ������ ������ ������ ��������";

        int n = 0; // ����� �,�

        int ks = 0; // ���������� ��������

        foreach (char c in str)
        {
            ks++;

            if (c.ToString().ToLower() == "�")
            {
                n++;
            }
            
        }

        Debug.Log("���������� ���� �,�=" + n);
        Debug.Log("���������� ���� = " + ks);
    }
}




