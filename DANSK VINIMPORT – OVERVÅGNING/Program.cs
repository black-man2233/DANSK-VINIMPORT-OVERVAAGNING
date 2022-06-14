using static System.Console;
SetWindowSize(80, 40);

//funtktioner
static void WL(string? value)
{
    Console.WriteLine( value);
}


//variabler og deres væredier
DateTime dkTid = DateTime.Now;
var kobenhavnTid = dkTid.ToString("HH.mm:ss");
var newYordTid = dkTid.AddHours(-6).ToString("HH:mm:ss");
var londonTid = dkTid.AddHours(-1).ToString("HH:mm:ss");
var HongKongTid = dkTid.AddHours(6).ToString("HH:mm:ss");




WL("  DANSK VINIMPORT – OVERVÅGNING \n" +
          "------------------------------------");

WL($"Verdens Ur \n" +
   $"-----------\n" +
   $"København = {kobenhavnTid} \n" +
   $"New York = {newYordTid} \n" +
   $"London = {londonTid}   \n" +
   $"HongKong = {HongKongTid} ");





/*
Lagerstatus | Temperatur & fugtighed
------------ | -----------------------
            |
*/







