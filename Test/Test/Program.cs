using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Test
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    public class LinkedList<T> : IEnumerable<T>  // односвязный список
    {
        Node<T> head; // головной/первый элемент
        Node<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        // удаление элемента
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        // очистка списка
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        // содержит ли список элемент
        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        // добвление в начало
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public void FindCenter()
        {
            Node<T> one = head; 
            Node<T> two = head;
            while (two != null)
            {
                two = two?.Next?.Next;
                if (two == null) break;
                one = one.Next;                
            }
            Console.WriteLine(one.Data);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            // добавление элементов
            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("Bob");
            linkedList.Add("Sam");
            linkedList.Add("Danyil");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            linkedList.FindCenter();

            char[] array = { 'a', 'c', 'a', 'b', 'k', 'c' };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        char temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int counter = 1;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " - ");
                while (i + 1 < array.Length && array[i] == array[i + 1])
                {
                    counter++;
                    i++;
                }                
                Console.WriteLine(counter);
                counter = 1;
            }

            //MyStack stack = new MyStack();
            //for (int i = 0; i < 10; i++)
            //{
            //    stack.Push(i);
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //Бульбашкове сортування
            //int[] mas = { 8, 4, 23, 1, 0, 1 };
            //int temp;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    for (int j = i + 1; j < mas.Length; j++)
            //    {
            //        if(mas[i] > mas[j])
            //        {
            //            temp = mas[i];
            //            mas[i] = mas[j];
            //            mas[j] = temp;
            //        }
            //    }
            //}

            //foreach (var item in mas)
            //{
            //    Console.Write(item + " ");
            //}
        }
    }
    class Item
    {
        public int Value { get; set; }
        public Item Next;
    }
    class MyStack
    {
        Item item;//елемент черги/стеку


        /*////Стек
        //Item pItem = null;//робочий вказівник для стеку

        //Черга
        Item top;//вершина для черги
        Item pItem = new Item();//робочий вказівник для черги
        bool flag = true;

        public void Push(int value)
        {
            ////Стек
            //item = new Item() { Value = value };
            //item.Next = pItem;
            //pItem = item;

            //Черга
            item = new Item() { Value = value };
            if (flag == true)
            {
                top = item;
                flag = false;
            }
            pItem.Next = item;
            pItem = item;
        }

        public int Pop()
        {
            ////Стек
            //int val = item.Value;
            //item = item.Next;

            //Черга
            int val = top.Value;
            top = top.Next;

            return val;
        }*/
    }

    
}
   


/*
            static int Fact(int n)
        {
            if (n == 1)
                return n;
            return n * Fact(n - 1);
        }
    
    class IntegerCell
    {
        public int Value;
        public IntegerCell Next;

        public static void AddAtBeginning(IntegerCell top, IntegerCell new_cell)
        {
            new_cell.Next = top.Next;
            top.Next = new_cell;
        }
    }  
//Елементарний список
//IntegerCell integer = new IntegerCell();
//integer.Value = 3;
//integer.Next = null;
//for (int i = 1; i < 3; i++)
//{
//    IntegerCell.AddAtBeginning(integer, new IntegerCell() { Value = i });
//}

//while (integer != null)
//{
//    Console.Write(integer.Value + " ");
//    integer = integer.Next;
//}
//Console.WriteLine();

//задача про перестановку двох частин масиву місцями
//int[] mas = { 7, 8, 9, 10, 20, 25, 45 };
//int m = 5;
//int temp;
//for (int i = m; i < mas.Length; i++) 
//{
//    temp = mas[mas.Length - 1];
//    for (int j = mas.Length - 1; j > 0; j--)
//        mas[j] = mas[j - 1];
//    mas[0] = temp;
//}

//foreach (var item in mas)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();

//задача про "видалення" елемента з масиву
//int[] mas1 = { 1, 2, 5, 8 };
//int n = 2;
//if (n > 0 && n < mas1.Length)
//{
//    for (int i = n - 1; i < mas1.Length - 1; i++)
//    {
//        mas1[i] = mas1[i + 1];
//    }
//}

//foreach (var item in mas1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();

//Задача про об'єднання двох відсортованих масивів
//int[] mas2 = new int[mas1.Length + mas.Length];
//int ii, jj, k;
//ii = jj = k = 0;
//while (ii < mas1.Length && jj < mas.Length)
//{
//    if (mas1[ii] < mas[jj])
//    {
//        mas2[k++] = mas1[ii++];
//    }
//    else
//        mas2[k++] = mas[jj++];
//}

//while (ii < mas1.Length)
//{
//    mas2[k++] = mas1[ii++];
//}

//while (jj < mas.Length)
//{
//    mas2[k++] = mas[jj++];
//}
//foreach (var item in mas2)
//{
//    Console.Write(item + " ");
//}
*/
