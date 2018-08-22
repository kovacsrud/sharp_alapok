/*
 * Készítette a SharpDevelop.
 * Felhasználó: razgon
 * Dátum: 2018. 08. 22.
 * Idő: 17:51
 * 
 * A sablon megváltoztatásához használja az Eszközök | Beállítások | Kódolás | Szabvány Fejlécek Szerkesztését.
 */
using System;

namespace nap_1b
{
	class Program
	{
		//felsorolt típus deklarálása
		enum autok { Audi , Volvo, Citroen };
		
		public static void Main(string[] args)
		{
			//összetettebb adatszerkezetek
			//tömb
			//10 elemű tömb, int típusú elemekkel
			int[] tomb1=new int[10];
			
			//20 elemű, karaktereket tartalmazó tömb
			char[] tomb2=new char[20];
			
			//értékadás
			tomb1[0]=118;
			tomb2[0]='g';
			
			//felsorolt típus használata
			autok auto=autok.Audi;
			Console.WriteLine(auto);
			
			Console.ReadLine();
		}
	}
}