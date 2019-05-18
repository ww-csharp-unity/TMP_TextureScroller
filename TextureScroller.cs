using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;

//set textures to repeat in assets

public class TextureScrollLoop : MonoBehaviour
{
    public Texture[] textures;
    private TextMeshPro m_textMeshPro;
    private System.Random rand = new System.Random();

    private void Awake()
    {
        m_textMeshPro = gameObject.GetComponent<TextMeshPro>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SwapTimer");        
    }

    IEnumerator SwapTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(30);
            TextureSwap();
        }
    }

    void TextureSwap()
    {
        int randText = rand.Next(0, textures.Length);        
        m_textMeshPro.fontSharedMaterial.SetTexture(ShaderUtilities.ID_FaceTex, textures[randText]);        
    }
}


//_FaceTex
//_FaceUVSpeedX
//_FaceUVSpeedY
//_FaceColor
//_FaceDialate
//_GlowPower
