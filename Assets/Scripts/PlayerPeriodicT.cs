using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPeriodicT : MonoBehaviour
{
    public string[] alkaliMetalsA = {"3", "11", "19", "37", "55", "87"};
    public string[] alkalineEarthMetalsA = {"4", "12", "20", "38", "56", "88"};
    public string[] transitionMetalsA = {"21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "72", "73", "74", "75", "76", "77", "78", "79", "80","104", "105", "106", "107", "108","112"};
    public string[] postTransitionMetalsA = {"13","31","49","50","81","82","83","84","114"};
    public string[] reactiveNonMetalsA = { "1","6", "7","8","9","15","16","17","34","35","53"};
    public string[] metalloidsA = {"5", "14", "32", "33", "51", "52", "85"};
    public string[] nobleGasesA = {"2","10","18", "36","54","86"};
    public string[] actinoids = {};
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
        }

         for (int io=0; io<transitionMetalsA.Length; io++){
         generic = GameObject.Find(transitionMetalsA[io]).GetComponent<Button>();
         generic.GetComponent<Image>().color = new Color32(255, 141,252, 255);
        }
        for (int io=0; io<postTransitionMetalsA.Length; io++){
         generic = GameObject.Find(postTransitionMetalsA[io]).GetComponent<Button>();
         generic.GetComponent<Image>().color = new Color32(109, 239, 255, 194);
        }
        for (int io=0; io<reactiveNonMetalsA.Length; io++){
         generic = GameObject.Find(reactiveNonMetalsA[io]).GetComponent<Button>();
         generic.GetComponent<Image>().color = new Color32(91, 255, 10, 255);
        }
        //nobleGasesA
        for (int io=0; io<nobleGasesA.Length; io++){
         generic = GameObject.Find(nobleGasesA[io]).GetComponent<Button>();
         generic.GetComponent<Image>().color = new Color32(35, 200, 224, 255);
        }
        for (int io=0; io<metalloidsA.Length; io++){
         generic = GameObject.Find(metalloidsA[io]).GetComponent<Button>();
         generic.GetComponent<Image>().color = new Color32(35, 224, 145, 255);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
