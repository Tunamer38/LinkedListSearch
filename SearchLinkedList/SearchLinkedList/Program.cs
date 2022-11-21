using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchLinkedList
{
    class block
    {
        public int data;
        public block next, prev;

    }
    class LinkedList
    {
        block first;
        block last;
        public block Atama(int x)
        {
            Random rnd = new Random();
            block bl = new block();
            if (x <= 0) return null;
            else
            {              
                bl.data = rnd.Next(1,100);
                bl.next = null;
                bl.prev = last;
                if (first == null) first = bl;
                else last.next = bl;
                last = bl;
                
            }
            Atama(--x);
            return bl;
            

        }
        public void Yazdır(block pr)
        {
            block prnt = first;
            while(prnt!=null)
            {
                Console.WriteLine(prnt.data);
                prnt = prnt.next;
            }
            Console.ReadKey();
        }
        public bool Search(block first, int x)
        {

            block tmp = first;
            while (tmp != null)
            {
                if (tmp.data == x) return true;
                tmp = tmp.next;
            }
            return false;
        }
        public static void Main()
        {
            Console.Write("Listenin kapasitesini giriniz: ");
            int kap = Convert.ToInt32(Console.ReadLine());
            LinkedList l1 = new LinkedList();
            block temp = new block();
            temp=l1.Atama(kap);
            l1.Yazdır(temp);

            Console.WriteLine("Listede Aramak İstediğiniz Değeri Giriniz");
            int aranan = Convert.ToInt32(Console.ReadLine());
            if (l1.Search(l1.first, aranan)) Console.WriteLine("Aradığınız değer lisede bulundu");
            else Console.WriteLine("Aradığınız listede yokkkk");
            Console.ReadLine();

        }
    }
}
