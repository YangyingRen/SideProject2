using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class MemorySystem : MonoBehaviour
{
    public Flowchart flowchart;
    public int sceneNum,rounds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RoundsControl(){
    if(rounds<10){
    rounds+=1;
    }
    else{
    rounds=0;
    }
    flowchart.SetIntegerVariable("Round",rounds);

    }
    public void nextFrame(){
     if(sceneNum<4){
     sceneNum+=1;
     flowchart.SetIntegerVariable("SceneNum",sceneNum);
    }
    }
    public void previewsFrame(){
    if(sceneNum>0){
     sceneNum-=1;
     flowchart.SetIntegerVariable("SceneNum",sceneNum);
    }
    }

}
