using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Threading;
using TMPro;
using UnityEngine;

public class bubblewandthing : MonoBehaviour
{
    public TextMeshProUGUI Cost;
    public TextMeshProUGUI Production;
    public GameObject objectthing;
    public int costval;
    public int productval;
    public int productionval;
    int counter;
    int mark;
    public int Produced;
    public int money;
    
    // Start is called before the first frame update
    void Start()
    {
        costval = 1; productval=2;
        productionval = 0;
        mark = 3600 / productionval;
        counter = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
        counter++;
        if (Input.GetMouseButtonUp(0))
        {
            if (money > costval)
            {
                purchace();
            }
        }
        {
            money++;
            Produced++;
            counter= 0;
        }

        
    }
    void purchace()
    {
        productionval += productval;
        money = money - costval;
        costval++;
    }
}
