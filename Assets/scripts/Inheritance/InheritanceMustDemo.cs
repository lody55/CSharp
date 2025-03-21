using Constructor;
using UnityEngine;
namespace Inheritance09
{

    public class InheritanceMustDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person의 객체 생성
            Person person = new Person();
            person.SayTalk();
        }

    }
}