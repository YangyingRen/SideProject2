using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class MemorySystem : MonoBehaviour
{
    public Flowchart flowchart;
    public int sceneNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
