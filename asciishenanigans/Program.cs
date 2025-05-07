/*
╭────────────────────────────╮
│ program: ascii conversions │
│ creator: aster <3          │
│ dd/mm/yyyy: 06/05/2025     │
│ message: enjoy :3          │
╰────────────────────────────╯
*/
restart:;
Console.Clear();
Console.Write("\e[0mmrowow meow !! mrrp ? mrow, meowow prrr ??? [welcome, how do you wish to convert ? string to code, or code to character ? [1 and 2 respectively]]\n$ ");
var pref = Console.ReadLine();
if (pref == "1")
{
	Console.Write("meow mya nya mrrrp :3 [please enter a string !]\n$ ");
	string thing = Console.ReadLine();
	foreach (int item in thing)
	{
		Console.WriteLine(item);
	}
}
else
{
	if (pref != "2")
	{
		Console.Write("\e[31mERROR: NEITHER PICKED, DEFAULTING TO CODE CONVERSION");
		int[] temp = { 1, 2, 3 };
		foreach (var item in temp)
		{
			Thread.Sleep(500);
			Console.Write(".");
			Thread.Sleep(500);
		}
		Console.WriteLine();
	}
	Console.Write("\e[0mmeow mya nya prrprr :3 [please enter a number !]\n$ ");
	ulong character = Convert.ToUInt64(Console.ReadLine());
	Console.WriteLine(Convert.ToChar(character));
}
Console.WriteLine("meow nya mrow mrrp :3? [do you wish to restart ? [1 if yes]]");
pref = Console.ReadLine();
if (pref == "1") 
{
	int[] temp = { 1, 2, 3 }; 
	Console.Write("\e[32mReloading"); 
	foreach (var item in temp) 
	{ 
		Thread.Sleep(500); 
		Console.Write("."); 
		Thread.Sleep(500); 
	}; 
	goto restart;
};