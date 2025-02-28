using UnityEngine;

public class SingnedIngeger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SignedIngeger
        sbyte isByte = 127; // 8비트 부호가 있는 정수형 변수 선언 및 초기화
        short iInt16 = 32767; //16비트 부호가 있는 정수형 변수 선언 및 초기화
        int iInt32 = 2147483647; // 32비트 부호가 있는 정수형 변수 선언 및 초기화
        long iInt64 = 9223372036854775807; //64비트 부호가 있는 정수형 변수 선언 및 초기화

        Debug.Log("sbyte :" + isByte);
        Debug.Log("short :" + iInt16);
        Debug.Log("sbyte :" + iInt32);
        Debug.Log("sbyte :" + iInt64);

        //UnSignedIngeger

        byte iByte = 255;// 8비트 부호가 없는 정수형 변수 선언 및 초기화
        ushort iUInt16 = 65535; //16비트 부호가 없는 정수형 변수 선언 및 초기화
        uint iUInt32 = 4294967295; //32비트 부호가 없는 정수형 변수 선언 및 초기화
        ulong iUInt64 = 18446744073709551615; // 64비트 부호가 없는 정수형 변수 선언 및 초기화

        Debug.Log("byte :" + iByte);
        Debug.Log("ushort :" + iUInt16);
            Debug.Log("iUInt32 :" + iUInt32);
            Debug.Log("iUInt64 :" + iUInt64);




    }


}
/*
1 Bit 0과1만 안다

1 Byte : 8 Bit
0000 0000 > 0
0000 0001 > 1
0000 0010 > 2
0000 0011 > 3
0000 0100 > 4등등.. 총 256가지 경우의수 표현(2진수)


8Bit
(+,-. 0)
sbyte: -128 ~ 127

(+,0)
byte : 0 ~ 255
 */

/*
 
 SignedIngeger(+,-) 부호가 있는 정수형 데이터 형식(타입)
sByte isByte = 127

un SignedIngeger(+,-) 부호가 없는 정수형 데이터 형식(타입)

 */