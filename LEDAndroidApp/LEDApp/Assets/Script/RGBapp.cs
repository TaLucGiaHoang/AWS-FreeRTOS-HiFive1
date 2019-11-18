using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class RGBapp : MonoBehaviour
{
    public void  Red_request()
    {
        StartCoroutine(redLED());
    }
    IEnumerator redLED()
    {
        byte[] myData = System.Text.Encoding.UTF8.GetBytes("LEDR");
        UnityWebRequest www = UnityWebRequest.Put("http://hifivedemo.s3-ap-southeast-1.amazonaws.com/data.txt", myData);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Request LED red");
        }
        www.Dispose();

    }

    public void Green_request()
    {
        StartCoroutine(greenLED());
    }
    IEnumerator greenLED()
    {
        byte[] myData = System.Text.Encoding.UTF8.GetBytes("LEDG");
        UnityWebRequest www = UnityWebRequest.Put("http://hifivedemo.s3-ap-southeast-1.amazonaws.com/data.txt", myData);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Request LED green");
        }
        www.Dispose();

    }
    public void Blue_request()
    {
        StartCoroutine(blueLED());
    }
    IEnumerator blueLED()
    {
        byte[] myData = System.Text.Encoding.UTF8.GetBytes("LEDB");
        UnityWebRequest www = UnityWebRequest.Put("http://hifivedemo.s3-ap-southeast-1.amazonaws.com/data.txt", myData);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Request LED blue");
        }
        www.Dispose();

    }
}
