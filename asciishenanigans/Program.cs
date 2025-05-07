/*
╭────────────────────────────╮
│ program: ascii conversions │
│ creator: aster <3          │
│ dd/mm/yyyy: 06/05/2025     │
│ message: enjoy :3          │
╰────────────────────────────╯
*/
restart:;
Console.Write("mrowow meow !! mrrp ? mrow, meowow prrr ??? [welcome, how do you wish to convert ? character to code, or vice versa ? [1 and 2 respectively]]\n$ ");
var pref = Console.ReadLine();
if (pref == "1")
{
    Console.Write("meow mya nya mrrrp :3 [please enter a character !]\n$ ");
    char character = Convert.ToChar(Console.ReadLine());
    Console.WriteLine(Convert.ToUInt64(character));
}
else
{
    Console.WriteLine((pref == "2") ? "" : "NEITHER PICKED: DEFAULTING TO CODE CONVERSION");
    Console.Write("meow mya nya prrprr :3 [please enter a number !]\n$ ");
    ulong character = Convert.ToUInt64(Console.ReadLine());
    Console.WriteLine(Convert.ToChar(character));
}
Console.WriteLine("meow nya mrow mrrp :3? [do you wish to restart ? [1 if yes]]");
pref = Console.ReadLine();
if (pref == "1") { goto restart; };