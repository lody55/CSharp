using UnityEngine;
namespace Inheritance05
{
    public class My : Car
    {
        public My() : this("나의 자동차")
        {

        }
        public My(string _name) : base(_name)
        {
            
        }
    }
}