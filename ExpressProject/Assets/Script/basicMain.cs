using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class basicMain : MonoBehaviour
{
    public Button Hello; // Hello 버튼 선언
    public string host; //주소 변수 선언
    public int port; //포트 번호 선언 (0~25000)

    void Start()
    {
        this.Hello.onClick.AddListener(() =>
        {
            var url = string.Format("{0}:{1}/", host, port);
            Debug.Log(url);
            StartCoroutine(this.GetBasic(url, (raw) =>
            {
                Debug.LogFormat("{0}", raw);
            }));
        });
    }

    private IEnumerator GetBasic(string url, System.Action<string> callback)
    {
        var webRequset = UnityWebRequest.Get(url); //Get에 대한 웹 요청 URL 함수
        yield return webRequset.SendWebRequest(); //요청한 것이 돌아올 때까지 대기

        Debug.Log("----->" + webRequset.downloadHandler.text);

        if (webRequset.result == UnityWebRequest.Result.ConnectionError
            || webRequset.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log("네트워크 환경이 좋지 않아 통신 불가능");
        }
        else
        {
            callback(webRequset.downloadHandler.text);
        }
    }
}