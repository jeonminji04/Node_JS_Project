using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bassicProtocols : MonoBehaviour
{
    //전송 1개의 단위를 Packets 이라고 클래스 선언
   public class Packets
    {
        //Packet 안의 res_scores 선언
        public class res_scores
        {
            public string message;
        }
    }
}
