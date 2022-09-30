using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointText : MonoBehaviour
{
    public float currentPoint = 0f;
    private float startingPoint= 0f;

    public Text Point;
    private CharacterScript playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        currentPoint = startingPoint;
        playerControllerScript = GameObject.FindWithTag("Player").GetComponent<CharacterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(playerControllerScript.gameOver == false)
        {
            Point.text = currentPoint.ToString("0");
        }
        
        
    }
}
