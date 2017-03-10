open System
open System.Collections.Generic

let InputList = new List<string>()
let mutable ok= true
let mutable flag = true
let mutable result = 0
while ok do
Console.WriteLine("************welcome************")
Console.WriteLine("please enter numbers you want to add in this calculator ")
//Console.WriteLine("0.zero number\n 1.only one\n 2.two numbers ")

while flag do
   let input = Console.ReadLine()
   if input = "" then
     InputList.Add("0")
   
     else
     InputList.Add(  input)

   //result <- result + (int32 input)
   Console.WriteLine("do you want to add another number yes/ no")
   let res = Console.ReadLine()
   if res = "no" then
   flag <- false
   else if res = "yes" then
   flag <- true
//   else printfn "yes"
        
  



for i in InputList do 
    printfn "%s" i
    

//let Add1 InputList = 
//   for i in InputList do 
//     result <- result + int32 i
//   printfn "The result = %d " result   
//
//Add1 InputList 

Console.WriteLine("whould you want to use this calculator again yes/ no")
let res =Console.ReadLine()
if res = "no"  then 
ok <- false
else 
Console.Clear()
InputList.Clear()
flag <- true
result <- 0
