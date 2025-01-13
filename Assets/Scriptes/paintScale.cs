using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintScale : MonoBehaviour
{
    [SerializeField] private Texture2D painting;
    private float _widthP;
    private float _heightP;
    private Vector3 scaleChange;
    [SerializeField] private int div;
    [SerializeField] GameObject Peinture;

    private void Start()
    {
        _widthP = painting.width;
        _heightP = painting.height;
        scaleChange = new Vector3(10f, _heightP, _widthP);
        Peinture.transform.localScale = scaleChange / div;
    }
}
