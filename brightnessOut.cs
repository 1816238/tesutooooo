using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class brightnessOut : MonoBehaviour
{
    //モードセレクトマネージャーを取得
    GameObject TitelMabger;
    titleCon title;


    //カラー情報の取得
    float r;
    float g;
    float b;
    public float brightA;//明るさ
    public float brightAAutoSpeed = 0.1F;//明るさ
    public float darkA = 0.5f;

    public bool brightFlag;


    //明るさ変更のフラグ
    public bool brightnessFlag;

    // Start is called before the first frame update
    void Start()
    {
        TitelMabger = GameObject.Find("TitelMabger");
        r = GetComponent<Image>().color.r;
        g = GetComponent<Image>().color.g;
        b = GetComponent<Image>().color.b;
        brightFlag = false;
        brightA = 1.0F;
    }

    // Update is called once per frame
    void Update()
    {
        title = TitelMabger.GetComponent<titleCon>();
        //MSMscript = modeSelectManager.GetComponent<modeSelectManager>();
        brightFlag = title.brightFlag;
        //MSMscript = modeSelectManager.GetComponent<modeSelectManager>();
        //brightnessFlag = MSMscript.numberFlag;
        if (brightFlag == false)
        {
            if (brightA > 0)
            {
                brightA -= brightAAutoSpeed;
                GetComponent<Image>().color = new Color(r, g, b, brightA);
            }
            if(brightA<0)
            {
                brightA = 0;
            }
        }
        else
        {
            if (brightA < 1.0)
            {
                brightA += brightAAutoSpeed;
                GetComponent<Image>().color = new Color(r, g, b, brightA);
            }
            if (brightA > 1.0)
            {
                brightA = 1.0F;
            }
        }
        //if (brightnessFlag==false)
        //{
        //    GetComponent<Image>().color = new Color(r, g, b, brightA);
        //}
        //else
        //{
        //    GetComponent<Image>().color = new Color(r, g, b, darkA);
        //}
    }


}
