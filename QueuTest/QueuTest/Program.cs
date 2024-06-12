using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Queues types:
        //1.Normal Queue
        /* Queue myQueue = new Queue();

         myQueue.Enqueue("First");
         myQueue.Enqueue("Second");
         myQueue.Enqueue("Third");
         myQueue.Dequeue();
         while (myQueue.Count > 0)
         {
             Console.WriteLine(myQueue.Dequeue());
         }*/

        //2.currenr Queue
        ConcurrentQueue<int> myQueue = new ConcurrentQueue<int>();

        Parallel.For(0, 10, i =>
        {
            myQueue.Enqueue(i);
        });

        int [] item= { 1,3,4,5,8,9,2,0,6};
        for(int i = 0;i<item.Length;i++)
        {
            if (myQueue.Count < 0)
            {
                Console.WriteLine("Its empty"); 
            }
         else  
            {
                if (myQueue.TryDequeue(out item[i]))
                    Console.WriteLine("removed element is : " + item[i]);
            }
        }
            


/*
        // إنشاء طابور جديد من نوع int
        ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

            // إضافة عناصر جديدة إلى طابور Queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // عرض العناصر الموجودة في الطابور
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // التأكد من وجود عنصر وإزالته
            int result;
            if (queue.TryDequeue(out result))
            {
                Console.WriteLine("تمت إزالة العنصر: " + result);
            }

            // عرض العنصر الأول في الطابور دون إزالته
            if (queue.TryPeek(out result))
            {
                Console.WriteLine("العنصر الأول في الطابور: " + result);
            }

            // عرض عدد العناصر في الطابور
            Console.WriteLine("عدد العناصر في الطابور: " + queue.Count);*/





        //3.Pripority Queue: 

        
    
    Console.ReadKey();
    }
}