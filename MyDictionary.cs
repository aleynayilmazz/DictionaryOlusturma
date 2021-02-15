using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOlusturma
{
 
    class MyDictionary<T>
    {
        //ürün dizimiz ve elemanları geçici olarak tutacagımız dizi olusturulur.
        T[] productArray;
        T[] tempArray;

        public MyDictionary()
        {
            //ekleme yapabilmek için, referans tip olduğu için bir array in new lenme zorunluluğu var..
          
            productArray = new T[0];//Sıfır elemanlı olarak dizi oluşturulur.
        }

        public void Add(T product) 
        {
            tempArray = productArray;//Elimizdeki ürünleri geçici olarak bir diziye aktarıyoruz.
            productArray = new T[productArray.Length+1];//eleman sayısı 1 arttı.ama bu şekilde yaparsak referans adresi kayboluyor.
            //bunun için geçiçi dizi yapılır.

            for (int i = 0; i < tempArray.Length; i++)
            {
                productArray[i] = tempArray[i];//geçici diziye aktardığımız ürünleri alıyoruz.
            }
            productArray[productArray.Length - 1] = product;//aslında eklenmek istenen urun eklenmiş oldu..
        }

        public T[] Products
        {
            get { return productArray; }
        }



    }

}
