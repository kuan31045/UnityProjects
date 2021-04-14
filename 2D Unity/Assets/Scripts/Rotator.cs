using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
        //變形.旋轉(新3 維向量(0,0,45) * 時間.時間變化)
        //每秒以Z軸為中心旋轉45度

        //面對一個人的時候：
        //對方點頭 就是頭部沿著X軸再旋轉
        //對方點頭 就是頭部沿著Y軸再旋轉
        //對方擺頭頂著肩膀 就是頭部沿著Z軸在旋轉
    }
}
