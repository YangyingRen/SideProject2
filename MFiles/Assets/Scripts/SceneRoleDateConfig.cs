using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneRoleDateConfig : MonoBehaviour
{
    public string[] SceneRoleDate;
    public string Scene,Role,Date;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    char delimiterChar=char.Parse(";");
    Date=GetComponent<MemoryManagement>().MemoryCode;
    for(int i=0;i<SceneRoleDate.Length;i++){
    string[]splitSRD=SceneRoleDate[i].Split(delimiterChar);
    if(splitSRD[2]==Date){
    Scene=splitSRD[0];
    Role=splitSRD[1];
    break;
    }
    else{
    Scene="--";
    Role="--";
    }
    }
    GetComponent<MemoryManagement>().Scene.text=Scene;
    GetComponent<MemoryManagement>().Role.text=Role;
        
    }
}
