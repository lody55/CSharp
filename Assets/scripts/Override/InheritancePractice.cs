using UnityEngine;
namespace Override
{
    public class InheritancePractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //HyunDai 클래스의 객체 생성
            HyunDai hd = new HyunDai();
            Debug.Log($"{hd.Style}");
            hd.Go();
            hd.Back();
            hd.Left();
            HyunDai hde = new HyunDai(CarType.전기);
            Debug.Log(hde.Style);
            hde.Go();

            //Tesla 클래스 객체 생성
            Tesla ts = new Tesla();
            Debug.Log(ts.Style);
            ts.Go();
            ts.Back();
            ts.Left();

            //mirae 클래스 객체 생성
            Mirea mr = new Mirea();
            Debug.Log(mr.Style);
            mr.Go();
            mr.Back();
            mr.Left();


        }


    }
}