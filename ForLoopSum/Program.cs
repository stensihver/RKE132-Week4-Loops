﻿


int sum = 0;

for(int i = 3; i < 0; i++) 
{
   Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;
}


Console.WriteLine($"Final total {sum}");