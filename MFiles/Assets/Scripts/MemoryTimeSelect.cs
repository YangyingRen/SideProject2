using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MemoryTimeSelect : MonoBehaviour
{
    public GameObject Calendar,MemoryOverview,MemoryManagement;
    public int Month,Day;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Month=Calendar.GetComponent<Calendar>().currDate.Month;
    string currDay=transform.GetChild(0).gameObject.GetComponent<Text>().text;
    if(currDay!=""){
    Day=int.Parse(transform.GetChild(0).gameObject.GetComponent<Text>().text);
    }
    else{
    Day=-1;
    }
    
        
    }

    public void CheckMemory(){
    string[] MemoryCodes=MemoryManagement.GetComponent<MemoryManagement>().MemoryCodes;
    Sprite[] MemoryOverviews=MemoryManagement.GetComponent<MemoryManagement>().MemoryOverview;
    string MemoryCode=Month.ToString()+"."+Day.ToString();
    for(int i=0; i<MemoryCodes.Length;i++){
        if(MemoryCode==MemoryCodes[i]){
        MemoryOverview.GetComponent<Image>().sprite=MemoryOverviews[i];
        Debug.Log("work");
        MemoryManagement.GetComponent<MemoryManagement>().MemoryCode=MemoryCode;
        for(int j=0;j<MemoryOverview.transform.childCount;j++){
        MemoryOverview.transform.GetChild(j).GetComponent<Image>().sprite=MemoryOverview.transform.GetChild(j).GetComponent<MemoryOverview>().OverviewPicture[i];
        }
        }
        else{
        MemoryOverview.GetComponent<Image>().sprite=MemoryManagement.GetComponent<MemoryManagement>().NoSignal;
        for(int j=0;j<MemoryOverview.transform.childCount;j++){
        MemoryOverview.transform.GetChild(j).GetComponent<Image>().sprite=MemoryOverview.transform.GetChild(j).GetComponent<MemoryOverview>().NoSignal;
        }

        }
    }

    }
}
