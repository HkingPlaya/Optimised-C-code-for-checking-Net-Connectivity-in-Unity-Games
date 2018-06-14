using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class netConnectivity : MonoBehaviour {


    public float call_after_every=.3f;
    private bool isInternet;
    public Text get;
    IEnumerator abc()
    {
        Debug.Log("abc");
        WWW itemsData = new WWW("www.google.com");
        yield return itemsData;
        if (itemsData.error != null)
        {
            isInternet = false;// get.text = "Not Connected";
        }    
        else
        {
            isInternet = true; //get.text = "Connected";
        }
            
        string itemsDataString = itemsData.text;
      //  Debug.Log(itemsDataString);//print (itemsDataString);
       // items = itemsDataString.Split(';');
     //   t.text = GetDataValue(items[0], key);
        //print(GetDataValue(items[0], "Cost:"));
    }
    private void Start()
    {
        StartCoroutine(start1());
    }
    IEnumerator start1()
    {
        while(true)
        {
            Debug.Log("start1");
            StartCoroutine(abc());
            if (isInternet)
            {
                get.text = "Connected";
            }
            else
            {
                get.text = "Not Connected";
            }
            yield return new WaitForSeconds(call_after_every);
        }
        
    }
    private void Update()
    {
      /*  if (isInternet)
        {
            get.text = "Connected";
        }
        else
        {
            get.text = "Not Connected";
        }*/
    }
    /*  WWW itemsData;
    private bool isInternet;
    public Text get;
    // Use this for initialization
    void Start () {
     //   itemsData = new WWW("https://www.google.com");
      //  StartCoroutine(Start1());
    }
	
	// Update is called once per frame
	void Update () {
       // itemsData = new WWW("https://www.google.com");
        StartCoroutine(Start1());
       // itemsDataString = itemsData.text;
        get.text = itemsDataString;
        if (itemsDataString == null)
        {
            isInternet = false;
            T.text = "net chala gya";
        }
        else
        {
            isInternet = true;
            T.text = "hai net";
            itemsDataString = null;
        }
    }
    string itemsDataString;
    public Text T;int k=0;
    IEnumerator Start1()
    {
        Debug.Log("k" + k++);
        while (true)
        {
            itemsData = new WWW("https://www.google.com");
            yield return itemsData;
            itemsDataString = itemsData.text;
        }
    }*/
}
