using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class clickBubble : MonoBehaviour
{
    // Start is called before the first frame update
    public int BubbleCount;
    public TextMeshProUGUI BubbleDisplay;
    void Start()
    {
        BubbleCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BubbleCount++;
        }
        BubbleDisplay.text=("Bubble Bucks: " + BubbleCount);
    }
}
