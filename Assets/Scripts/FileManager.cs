using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class FileManager : MonoBehaviour
{
    public RawImage rawImage;
    public string path;
    public void OpenFileExplorer()
    {
       // path = EditorUtility.OpenFilePanel("Show all images (.png) ", "", "png");
//
        StartCoroutine(GetTexture());
    }

    IEnumerator GetTexture()
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture("file:///" + path);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);

        }
        else
        {
            Texture myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            rawImage.texture = myTexture;
            rawImage.GetComponent<RectTransform>().sizeDelta = new Vector2(myTexture.width, myTexture.height);
            Debug.Log(myTexture.height);
        }
    }
}
