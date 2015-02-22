using System;
using System.Runtime.InteropServices;     // DLL support

namespace WriteHiCScode
{
	class MainClass
	{
		[DllImport("libwriteHi.so")]
		public static extern void DisplayHiFromDLL ();

		public static void Main (string[] args)
		{
			Console.WriteLine ("This is Hi from the C# program");
			DisplayHiFromDLL ();
		}
	}
}
