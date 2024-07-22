// See https://aka.ms/new-console-template for more information


// for(int i = 0; i < 256; i++){
//     Console.WriteLine(i);
// }

Random rand = new Random();
int result = 0;
for(int i = 1; i <= 5; i++){
    result += rand.Next(10,21);
}
Console.WriteLine(result);

for(int i = 1; i <= 100; i++){    
    if(i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if(i % 3 == 0){
        Console.WriteLine("Fizz");
    }
    else if(i % 5 == 0){
        Console.WriteLine("Buzz");
    }
    else{
        Console.WriteLine(i);
    }
}
