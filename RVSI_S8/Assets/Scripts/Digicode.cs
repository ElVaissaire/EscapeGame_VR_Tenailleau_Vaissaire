using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digicode : MonoBehaviour
{
    private List<string> code = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EntryCode(string entry)
    {
        Debug.Log(code.ToString());
        code.Add(entry);
    }

    public void ResetCode()
    {
        code.Clear();
        Debug.Log("Reset");
    }

    public void CompareCode()
    {
        List<string> finalCode = new List<string>();
        finalCode.Add("0");
        finalCode.Add("3");
        finalCode.Add("4");
        finalCode.Add("7");

        int count = 0;

        Debug.Log(code);

        for(int i=0; i<4; i++)
        {
            if(code[i] == finalCode[i])
            {
                count++;
            }
            
        }
        
        if(count == 4)
        {
            Debug.Log("Bon code !");
            code.Clear();
            GameManager.instance.OuverturePorteLocker();
        }
        else
        {
            Debug.Log("Faux code");
            code.Clear();
        }
    }
}
