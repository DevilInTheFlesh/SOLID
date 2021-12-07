using System;

namespace Task_1
{
    class Program
    {
        /*Задача №2.
        Известны следующие параметры, используемые в алгоритме Диффи–Хеллмана: m = 54311; q = 50131; x = 34101; y = 12904:
        Определите секретный ключ k.

        решение уравнения a^m = b (mod c), m - неизвестно*/
        static int task_2_1(int a, int b, int c)
        {
            long modA = a % c;
            long modB = b % c;
            long goal = modA;

            if ((1 - b) % c == 0) return 0;
            if ((a - b) % c == 0) return 1;

            for (int x = 2; x < c; ++x)
            {
                goal = goal * modA % c;
                if (goal == modB)
                    return x;
            }
            return -1;
        }
        //возвращает значение y = a^b (mod c)
        static int task_2_2(int a, int b, int c)
        {
            int x = 1;
            for (int i = 1; i <= b; ++i)
            {
                x *= a;
                x %= c;
            }
            return x;
        }

        //найти a и b, с помощью них k1 и k2
        static int task2(int m = 41903, int q = 10109, int x = 5671, int y = 12457)
        {
            int a = task_2_1(q, x, m);
            int b = task_2_1(q, y, m);
            int k1 = task_2_2(y, a, m);
            int k2 = task_2_2(x, b, m);
            if (k1 == k2)
                return k1;
            else return -1;
        }

        /*Задача №3.
       Найти подпись Q с помощью схемы Эль-Гамаля. Известны (p, g, y) = (99013, 10112, 4748), k = 28973, x = 20008, Q = 54098
        */

        //Находим обратное k: 1 = k * k^(-1)(mod p)
        // Этот метод может пригодиться, но пока совершенно не нужен, это и есть ненужная сложность
        static int inverse_k(int k, int p)
        {
            for (int i = 1; i < p - 1; i++)
            {
                if ((k * i) % (p - 1) == 1)
                    return i;
            }
            return -1;
        }

        //Находим s: s=(Q - xr)k^(-1)(mod p - 1)
        // Здесь мы видим, что кусок кода из предыдушего метода используется с некоторыми доработками, когда мы могли бы внести изменения в метод и использовать его, это и есть ненужная повторяемость
        static int get_s(int Q, int x, int r, int k, int p)
        {
            int k1 = -1;
            for (int i = 1; i < p - 1; i++)
            {
                if ((k * i) % (p - 1) == 1)
                    k1 = i;
            }
            return ((k1 * (Q - (x * r) % (p - 1)) % (p - 1)));
        }

        static void Main(string[] args)
        {
            //2
            int k = task2();
            if (k != -1)
                Console.WriteLine("Ответ на 2 задачу:" + k);
            //3
            int r = task_2_2(10112, 28973, 99013);
            Console.WriteLine("Ответ на 3 задачу: r = " + r + "\n                   s = " + get_s(54098, 20008, r, 28973, 99013));
            Console.ReadKey();
        }
    }
}
