using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class basicMain : MonoBehaviour
{
    public Button Hello; // Hello ��ư ����
    public string host; //�ּ� ���� ����
    public int port; //��Ʈ ��ȣ ���� (0~25000)

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
        var webRequset = UnityWebRequest.Get(url); //Get�� ���� �� ��û URL �Լ�
        yield return webRequset.SendWebRequest(); //��û�� ���� ���ƿ� ������ ���

        Debug.Log("----->" + webRequset.downloadHandler.text);

        if (webRequset.result == UnityWebRequest.Result.ConnectionError
            || webRequset.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log("��Ʈ��ũ ȯ���� ���� �ʾ� ��� �Ұ���");
        }
        else
        {
            callback(webRequset.downloadHandler.text);
        }
    }
}