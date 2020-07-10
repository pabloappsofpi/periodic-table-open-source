using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTable : MonoBehaviour
{
    public string[] alkaliMetalsA = {"3", "11", "19", "37", "55", "87"};
    public string[] alkalineEarthMetalsA = {"4", "12", "20", "38", "56", "88"};
    public Button e1;
    public Button e2;
    public Button e3;

    public Button generic;
    

    // Start is called before the first frame update
    void Start()
    {
        //set alkalimetals
        for (int io=0; io<alkaliMetalsA.Length; io++){
         generic = GameObject.Find(alkaliMetalsA[io]).GetComponent<Button>();
         generic.GetComponent<Image>().color = new Color32(255, 152,0, 222);


        }
        //set alkaliearthmetals
         for (int io=0; io<alkalineEarthMetalsA.Length; io++){
         generic = GameObject.Find(alkalineEarthMetalsA[io]).GetComponent<Button>();
         generic.GetComponent<Image>().color = new Color32(243, 250,84, 255);

        // "#FF9800";

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
