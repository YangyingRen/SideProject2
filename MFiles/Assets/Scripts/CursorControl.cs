using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorControl : MonoBehaviour
{   public Texture2D clickIcon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HoverIn(){
    Cursor.SetCursor(clickIcon, Vector2.zero, CursorMode.Auto);
    }
    public void HoverOut(){
    Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

}
