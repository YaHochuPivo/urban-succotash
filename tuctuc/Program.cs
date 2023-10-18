// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int [] firstOctave = new int [] {262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494};
int [] secondOctave = new int[] {523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988};
int[] thirdOctave = new int[] {1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976};
ConsoleKeyInfo txt = Console.ReadKey();
Console.WriteLine(txt.Key);
int[] octava;
octava = firstOctave;

while (true)
{   
    txt = Console.ReadKey();
    if (txt.Key == ConsoleKey.F4)
    {
        octava = choiceOctava(1);
    }
    if (txt.Key == ConsoleKey.F5)
    {
        octava = choiceOctava(2);
    }
    if (txt.Key == ConsoleKey.F6)
    {
        octava = choiceOctava(3);
    }
    if (txt.Key == ConsoleKey.D)
    {
        play(octava[0]);
    }
    if (txt.Key == ConsoleKey.F)
    {
        play(octava[2]);
    }
    if (txt.Key == ConsoleKey.G)
    {
        play(octava[4]);
    }
    if (txt.Key == ConsoleKey.H)
    {
        play(octava[5]);
    }
    if (txt.Key == ConsoleKey.J)
    {
        play(octava[7]);
    }
    if (txt.Key == ConsoleKey.K)
    {
        play(octava[9]);

    }
    if (txt.Key == ConsoleKey.L)
    {
        play(octava[11]);
    }
    if (txt.Key == ConsoleKey.R)
    {
        play(octava[1]);
    }
    if (txt.Key == ConsoleKey.T)
    {
        play(octava[3]);
    }
    if (txt.Key == ConsoleKey.U)
    {
        play(octava[6]);
    }
    if (txt.Key == ConsoleKey.I)
    {
        play(octava[8]);
    }
    if (txt.Key == ConsoleKey.O)
    {
        play(octava[10]);
    }


}
void play(int note)
{
    Console.Beep(note, 300);
}
int[] choiceOctava (int num) {
    if (num == 1) {
        return firstOctave;
       
    }
    else if (num == 2)
    {

        return secondOctave;
    }
    else if (num == 3)  
    {
        return thirdOctave;
    }
    else
    {
        return firstOctave;

    }
    

}
