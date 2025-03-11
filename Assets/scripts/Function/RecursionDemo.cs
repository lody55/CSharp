using UnityEngine;

//���丮�� ���ϴ� �˰��� (4!)

/*
 Factorial (!)
1! = 1
2! = 1 * 2
3! = 1 * 2 * 3
4! = 1 * 2 * 3 * 4
.....
n! = 1 * 2 * 3 * 4 .......* (n-1) * n

(4! = 4 * 3 * 2 * 1
   = 4 * 3!

         3! = 3 * 2!
                  2! = 2 * 1!)

n! = n * n-1!

 */

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 4! = 1 * 2 * 3 * 4
        Debug.Log(4 * 3 * 2 * 1);
        Debug.Log(FactorialFor(4));
        Debug.Log(Factorial(4));
        Debug.Log(Factor(4));

        //For Factorial
    }

    //For�� �̿� Factorial�� ���ϱ�
    int FactorialFor(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result * i;

        }
        return result;
    }

    //3�� �����ڸ� �̿��� Factorial �����
    int Factor(int n)
    {
        //if (n <= 1)
        //    return 1;
        //return n * Factor(n - 1);
        return (n >1) ? n * Factor(n - 1) : 1;
    }

    //����Լ� �̿� Factorial �� ���ϱ�
    int Factorial(int n)
    {
        //���� ���� �κ�
        if(n == 1)
        {
            return 1;
        }
        //��� ȣ�� �κ�
        return n * Factorial(n - 1);
    }


}
    /*
        4 * Fatorial(3)
            3 * Factorial(2)
                2 * 1
                    1 * Factorial(0)
                        0 * Factorial(-1)
                            -1 * Factorial(-2)
                                -2 * Factorial(-3)
     * /



/*
 ����Լ� : �Լ��� �ڽ��� �ڵ� ��� �ȿ��� �ڱ� �ڽ��� �ٽ� ȣ��(��� ȣ��)�ϴ� �Լ�
 - ����Լ� �Ű����� : �Ű������� ���� , ������ �ȴ�
 - ����Լ� �ڵ� ��Ͼȿ��� ����Լ��� ���� �� �� �ִ� ������ �ʿ��ϴ�


 */