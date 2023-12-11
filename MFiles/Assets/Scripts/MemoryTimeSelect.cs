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
        MemoryManagement.GetComponent<MemoryManagement>().MemoryCode=null;
        for(int j=0;j<MemoryOverview.transform.childCount;j++){
        MemoryOverview.transform.GetChild(j).GetComponent<Image>().sprite=MemoryOverview.transform.GetChild(j).GetComponent<MemoryOverview>().NoSignal;
        }

        }
    }

    }
    public void CheckIn(){
    string[] MemoryCodes=MemoryManagement.GetComponent<MemoryManagement>().MemoryCodes;
    Sprite[] MemoryOverviews=MemoryManagement.GetComponent<MemoryManagement>().MemoryOverview;
    string MemoryCode=Month.ToString()+"."+Day.ToString();
    if(transform.GetChild(0).GetComponent<Text>().text==""){
       gameObject.GetComponent<Image>().sprite=MemoryManagement.GetComponent<MemoryManagement>().DateOverview;
       gameObject.GetComponent<Image>().color=new Color (1,1,1,0);
       Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);

    }
    else{
        Cursor.SetCursor(gameObject.GetComponent<CursorControl>().clickIcon, Vector2.zero, CursorMode.Auto);
    for(int i=0; i<MemoryCodes.Length;i++){
        if(MemoryCode==MemoryCodes[i]){
        gameObject.GetComponent<Image>().sprite=MemoryOverviews[i];
        gameObject.GetComponent<Image>().color=Color.white;
        }
        else{
        gameObject.GetComponent<Image>().sprite=MemoryManagement.GetComponent<MemoryManagement>().NoSignal;
        gameObject.GetComponent<Image>().color=Color.white;
        }
    }
    }

    }
    public void CheckOut(){
        gameObject.GetComponent<Image>().sprite=MemoryManagement.GetComponent<MemoryManagement>().DateOverview;
        gameObject.GetComponent<Image>().color=new Color (1,1,1,0);
   // gameObject.GetComponent<Image>().sprite=MemoryManagement.GetComponent<MemoryManagement>().NoSignal;
    }
}
