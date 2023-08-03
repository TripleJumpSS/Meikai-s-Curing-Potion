using UnityEngine;
using UnityEngine.UI;

public class colourpumpkinui : MonoBehaviour
{
    RawImage m_RawImage;
    //Select a Texture in the Inspector to change to
    public Texture m_Texture;

    public void Collected()
    {
        //Fetch the RawImage component from the GameObject
        m_RawImage = GetComponent<RawImage>();
        //Change the Texture to be the one you define in the Inspector
        m_RawImage.texture = m_Texture;
    }
}