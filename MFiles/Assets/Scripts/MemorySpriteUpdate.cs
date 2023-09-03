using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class MemorySpriteUpdate : MonoBehaviour
{
    public int Fresh,memorySprite;
    public Flowchart flowchart;
    public Animator anim;
    public string FungusVarName,MemoryStage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Fresh=flowchart.GetIntegerVariable(FungusVarName);
    int round= flowchart.GetIntegerVariable("Round");
    if((round-Fresh)<0){
     memorySprite= 0;
    }
    else{
     memorySprite=round-Fresh ;
    }
    anim.SetInteger("FreshStage",memorySprite);
    flowchart.SetIntegerVariable(MemoryStage,memorySprite);
}
    }
   
