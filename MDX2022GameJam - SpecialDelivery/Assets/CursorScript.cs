using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CursorScript : MonoBehaviour
{
    void OnGUI()
{
Cursor.lockState = CursorLockMode.None;
Cursor.visible = true;
}
}
