/*
 * Készítette a SharpDevelop.
 * Felhasználó: razgon
 * Dátum: 2018. 08. 22.
 * Idő: 17:16
 * 
 * A sablon megváltoztatásához használja az Eszközök | Beállítások | Kódolás | Szabvány Fejlécek Szerkesztését.
 */
using System;

namespace nap_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello Tanfolyam!");
			//A C# szigorúan típusos nyelv
			//Primitív változók deklarálása
			//32 bites előjeles egész
			int a;
			int b;
			
			//Értékadás
			a=10;
			b=22;
			
			//A C# teljesen objektum-orientált, akár így is létre
			//lehet hozni változókat 
			Int32 c=new Int32(); //osztály példányosítása
			c=134;
			
			
			
			
			//előjel nélküli 8 bites változó
			byte bajt;
			
			//Az értékek kiíratása
			Console.WriteLine("a:{0},b:{1}",a,b);
			Console.WriteLine("a:{0},b:{1}",a,b);
			
			//változó létrehozása a var kulccsszóval
			//a fordító automatikusan a megfelelő típust fogja
			//a változóhoz rendelni
			var c2=129;
			
			//lebegőpontos változó
			
			double l2;
						
			l2=51.33;
			
			//karakter típusú változó
			char kar;
			//értékadás a karakteres változónak
			kar='e';
			
			//szöveges változó tárolása
			String szoveg="sharp-developer";

			//két lépésben is lehet
			String szoveg2;
			szoveg2="sharpdev";
			
			//logikai változó, true vagy false értéke lehet
			bool igaz;
			igaz=false; 
			
									
			Console.ReadKey(true);
		}
	}
}