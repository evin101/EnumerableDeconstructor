using System;
using System.Collections.Generic;

namespace EnumerableDeconstructor
{
    public static class EnumerableExtensions
    {
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2)
        {
            item1 = self[0];
            item2 = self[1];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
            Next(ref e, out item12);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
            item12 = self[11];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
            Next(ref e, out item12);
            Next(ref e, out item13);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
            item12 = self[11];
            item13 = self[12];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
            Next(ref e, out item12);
            Next(ref e, out item13);
            Next(ref e, out item14);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
            item12 = self[11];
            item13 = self[12];
            item14 = self[13];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
            Next(ref e, out item12);
            Next(ref e, out item13);
            Next(ref e, out item14);
            Next(ref e, out item15);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
            item12 = self[11];
            item13 = self[12];
            item14 = self[13];
            item15 = self[14];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
            Next(ref e, out item12);
            Next(ref e, out item13);
            Next(ref e, out item14);
            Next(ref e, out item15);
            Next(ref e, out item16);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
            item12 = self[11];
            item13 = self[12];
            item14 = self[13];
            item15 = self[14];
            item16 = self[15];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16, out T item17)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
            Next(ref e, out item12);
            Next(ref e, out item13);
            Next(ref e, out item14);
            Next(ref e, out item15);
            Next(ref e, out item16);
            Next(ref e, out item17);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16, out T item17)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
            item12 = self[11];
            item13 = self[12];
            item14 = self[13];
            item15 = self[14];
            item16 = self[15];
            item17 = self[16];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16, out T item17, out T item18)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
            Next(ref e, out item12);
            Next(ref e, out item13);
            Next(ref e, out item14);
            Next(ref e, out item15);
            Next(ref e, out item16);
            Next(ref e, out item17);
            Next(ref e, out item18);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16, out T item17, out T item18)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
            item12 = self[11];
            item13 = self[12];
            item14 = self[13];
            item15 = self[14];
            item16 = self[15];
            item17 = self[16];
            item18 = self[17];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16, out T item17, out T item18, out T item19)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
            Next(ref e, out item12);
            Next(ref e, out item13);
            Next(ref e, out item14);
            Next(ref e, out item15);
            Next(ref e, out item16);
            Next(ref e, out item17);
            Next(ref e, out item18);
            Next(ref e, out item19);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16, out T item17, out T item18, out T item19)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
            item12 = self[11];
            item13 = self[12];
            item14 = self[13];
            item15 = self[14];
            item16 = self[15];
            item17 = self[16];
            item18 = self[17];
            item19 = self[18];
        }
		
		public static void Deconstruct<T>(this IEnumerable<T> self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16, out T item17, out T item18, out T item19, out T item20)
        {
            var e = self.GetEnumerator();
            Next(ref e, out item1);
            Next(ref e, out item2);
            Next(ref e, out item3);
            Next(ref e, out item4);
            Next(ref e, out item5);
            Next(ref e, out item6);
            Next(ref e, out item7);
            Next(ref e, out item8);
            Next(ref e, out item9);
            Next(ref e, out item10);
            Next(ref e, out item11);
            Next(ref e, out item12);
            Next(ref e, out item13);
            Next(ref e, out item14);
            Next(ref e, out item15);
            Next(ref e, out item16);
            Next(ref e, out item17);
            Next(ref e, out item18);
            Next(ref e, out item19);
            Next(ref e, out item20);
        }


		public static void Deconstruct<T>(this T[] self, out T item1, out T item2, out T item3, out T item4, out T item5, out T item6, out T item7, out T item8, out T item9, out T item10, out T item11, out T item12, out T item13, out T item14, out T item15, out T item16, out T item17, out T item18, out T item19, out T item20)
        {
            item1 = self[0];
            item2 = self[1];
            item3 = self[2];
            item4 = self[3];
            item5 = self[4];
            item6 = self[5];
            item7 = self[6];
            item8 = self[7];
            item9 = self[8];
            item10 = self[9];
            item11 = self[10];
            item12 = self[11];
            item13 = self[12];
            item14 = self[13];
            item15 = self[14];
            item16 = self[15];
            item17 = self[16];
            item18 = self[17];
            item19 = self[18];
            item20 = self[19];
        }
		
        private static void Next<T>(ref IEnumerator<T> e, out T item)
        {
            e.MoveNext();
            item = e.Current;
        }
    }
}
