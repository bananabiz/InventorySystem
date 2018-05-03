using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public Vector2 mousePos;
    public string direction;
    //reference to inventory

    //reference to any moving cameras
    public bool quickMenu;
    public float scrW, scrH;

    void Start()
    {
        Cursor.visible = false;
    }
    
	
	// Update is called once per frame
	void Update ()
    {
        scrH = Screen.height / 9;
        scrW = Screen.width / 16;

        if (Input.GetButton("Quick Select Menu"))
        {
            quickMenu = true;
            Cursor.visible = true;
            mousePos = Input.mousePosition;
        }

        if (quickMenu)
        {
            #region KeyBoard/Controller Menu Controls
            if (direction != "Left")
            {
                if (Input.GetAxis("Horizontal") < 0)
                {
                    Debug.Log("Left");
                    direction = "Left";
                }
            }

            if (direction != "Right")
            {
                if (Input.GetAxis("Horizontal") > 0)
                {
                    Debug.Log("Right");
                    direction = "Right";
                }
            }

            if (direction != "Down")
            {
                if (Input.GetAxis("Vertical") < 0)
                {
                    Debug.Log("Down");
                    direction = "Down";
                }
            }

            if (direction != "Up")
            {
                if (Input.GetAxis("Vertical") > 0)
                {
                    Debug.Log("Up");
                    direction = "Up";
                }
            }

            if (direction != "Up Left")
            {
                if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") < 0)
                {
                    Debug.Log("Up Left");
                    direction = "Up Left";
                }
            }

            if (direction != "Up Right")
            {
                if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") > 0)
                {
                    Debug.Log("Up Right");
                    direction = "Up Right";
                }
            }

            if (direction != "Down Left")
            {
                if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") < 0)
                {
                    Debug.Log("Down Left");
                    direction = "Down Left";
                }
            }

            if (direction != "Down Right")
            {
                if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") > 0)
                {
                    Debug.Log("Down Right");
                    direction = "Down Right";
                }
            }

            #endregion

            #region Mouse Input Menu Controls
            if (mousePos.y >= scrH * 4 && mousePos.y <= scrH * 5)
            {
                if (mousePos.x >= scrW * 0 && mousePos.x <= scrW * 7.5f)
                {
                    Debug.Log("Left");
                    direction = "Left";
                }
            }

            if (mousePos.y >= scrH * 4 && mousePos.y <= scrH * 5)
            {
                if (mousePos.x >= scrW * 8.5f && mousePos.x <= scrW * 16f)
                {
                    Debug.Log("Right");
                    direction = "Right";
                }
            }
            // screen pos(0,0) starts from top left corner, mouse pos(0,0) is starts from down left corner
            if (-mousePos.y + Screen.height >= scrH * 5f && -mousePos.y + Screen.height <= scrH * 9f)
            {
                if (mousePos.x >= scrW * 7.5f && mousePos.x <= scrW * 8.5f)
                {
                    Debug.Log("Down");
                    direction = "Down";
                }
            }

            if (-mousePos.y + Screen.height >= scrH * 0 && -mousePos.y + Screen.height <= scrH * 4f)
            {
                if (mousePos.x >= scrW * 7.5f && mousePos.x <= scrW * 8.5f)
                {
                    Debug.Log("Up");
                    direction = "Up";
                }
            }

            if (-mousePos.y + Screen.height >= scrH * 5f && -mousePos.y + Screen.height <= scrH * 9f)
            {
                if (mousePos.x >= scrW * 0f && mousePos.x <= scrW * 7.5f)
                {
                    Debug.Log("Down Left");
                    direction = "Down Left";
                }
            }

            if (-mousePos.y + Screen.height >= scrH * 5f && -mousePos.y + Screen.height <= scrH * 9f)
            {
                if (mousePos.x >= scrW * 8.5f && mousePos.x <= scrW * 16f)
                {
                    Debug.Log("Down Right");
                    direction = "Down Right";
                }
            }

            if (-mousePos.y + Screen.height >= scrH * 0 && -mousePos.y + Screen.height <= scrH * 4f)
            {
                if (mousePos.x >= scrW * 0f && mousePos.x <= scrW * 7.5f)
                {
                    Debug.Log("Up Left");
                    direction = "Up Left";
                }
            }

            if (-mousePos.y + Screen.height >= scrH * 0 && -mousePos.y + Screen.height <= scrH * 4f)
            {
                if (mousePos.x >= scrW * 8.5f && mousePos.x <= scrW * 16f)
                {
                    Debug.Log("Up Right");
                    direction = "Up Right";
                }
            }
            #endregion
        }
        else
        {
            quickMenu = false;
        }
    }

    void OnGUI()
    {
        if (quickMenu)
        {
            GUI.Box(new Rect(scrW * 0, scrH * 4, scrW * 7.5f, scrH), "Left");
            GUI.Box(new Rect(scrW * 8.5f, scrH * 4, scrW * 7.5f, scrH), "Right");
            GUI.Box(new Rect(scrW * 7.5f, scrH * 0, scrW, scrH * 4), "Up");
            GUI.Box(new Rect(scrW * 7.5f, scrH * 5, scrW, scrH * 4), "Down");
        }
    }
}
