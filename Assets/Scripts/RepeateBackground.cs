using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeateBackground : MonoBehaviour
{
    private Vector2 startPos;
    private float repeateWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeateWidth = GetComponent<BoxCollider2D>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPos.x - repeateWidth)
        {
            transform.position = startPos;
        }
    }
}
