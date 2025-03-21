using UnityEngine;
namespace Delegate
{
    public class CarDriver
    {
        public static void GoForward()
        {
            Debug.Log("직진");
        }

        public static void GeLeft()
        {
            Debug.Log("좌회전");
        }

        public static void GeRight()
        {
            Debug.Log("우회전");
        }

        public void Hello() => Debug.Log("Hello");
        public void Hi()
        {
            Debug.Log("Hi");
        }
        delegate void say();
    }
}