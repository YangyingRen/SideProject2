using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class MemoryManagement : MonoBehaviour
{
    public string[] MemoryCodes;
    public Sprite[] MemoryOverview;
    public Sprite NoSignal;
    public string MemoryCode;
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      flowchart.SetStringVariable("MemoryCode",MemoryCode);  
    }
}
