using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorGenerator : MonoBehaviour
{
    public Color[] colors; // indexes 0-9
    public Sprite[] fronts; // indexes 0-4
    public Sprite[] backs; // indexes 0-4
    public Sprite[] middles; // indexes 0-4

    public GameObject frameObject; // the "Frame" object to turn on
    public SpriteRenderer backgroundRenderer; // background color
    public SpriteRenderer[] children; // back = 0, middle = 1, front = 2
    
    Color selectedColor; // used to tint the background and layers
    Sprite selectedFront;
    Sprite selectedMiddle;
    Sprite selectedBack;
    

    // Start is called before the first frame update
    void Start()
    {
        // Turn on "Frame" object
        //frameObject.SetActive(true);
        
        /*
        selectedColor = colors[Random.Range(0, colors.Length)];
        selectedFront = fronts[Random.Range(0, fronts.Length)];
        selectedMiddle = middles[Random.Range(0, middles.Length)];
        selectedBack = backs[Random.Range(0, backs.Length)];
        */

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AwesomeButton()
    {
        frameObject.SetActive(true);

        selectedColor = colors[Random.Range(0, colors.Length)];
        selectedFront = fronts[Random.Range(0, fronts.Length)];
        selectedMiddle = middles[Random.Range(0, middles.Length)];
        selectedBack = backs[Random.Range(0, backs.Length)];

        backgroundRenderer.color = selectedColor;
        children[0].sprite = selectedBack;
        children[1].sprite = selectedMiddle;
        children[2].sprite = selectedFront;

        // Set Color of Children
        children[0].color = selectedColor;
        children[1].color = selectedColor;
        children[2].color = selectedColor;



        //Debug.Log("Button Pressed");
    }
}
