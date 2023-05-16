using System;

class Program {
  public static void Main (string[] args) {
    int r;
    int.TryParse(Console.ReadLine(), out r);
    int val = 1, i, j;
    if (r < 0){
      Console.Write("Invalid Pascal’s triangle row number.");
      return;
    }
    for(i = 0; i <= r; i++) {
        for(j = 0; j <= i; j++) {
          if (j == 0||i == 0)
             val = 1;
          else
             val = val*(i-j+1)/j;
             Console.Write(val + " ");
          }
        Console.WriteLine();
    }
  }
}