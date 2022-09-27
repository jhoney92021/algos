/* 
Write a function that takes an integer array and prints and returns the maximum value in the array. 

Your program should also work with a given array that has all negative numbers 

input:  [-3, -5, -7] 
output: -3
*/

export function For(numberArray: Array<number>)
{
    let max: number = 0;
    for(var iterator: number = 0; iterator < numberArray.length; iterator++)
    {
        const number: number = numberArray[iterator];
        if(number > max)
        {
            max = number;
        }      
    }
    console.log(`For Max of ${numberArray}: ${max}`);
}

export function ForIn(numberArray: Array<number>)
{
    let max: number = 0;
    for(let iterator in numberArray)
    {
        const number: number = numberArray[iterator];
        if(number > max)
        {
            max = number;
        }   
    }
    console.log(`For In Max of ${numberArray}: ${max}`);
}

export function ForOf(numberArray: Array<number>)
{
    let max: number = 0;
    for(let number of numberArray)
    {
        if(number > max)
        {
            max = number;
        } 
    }
    console.log(`For Of Max of ${numberArray}: ${max}`);    
}

export function While(numberArray: Array<number>)
{
    let iterator: number = 0;
    let max: number = 0;
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        if(number > max)
        {
            max = number;
        }
        iterator++;
    }    
    console.log(`While Max of ${numberArray}: ${max}`);     
}

export function DoWhile(numberArray: Array<number>)
{
    let iterator: number = 0;
    let max: number = 0;
    do{
        const number = numberArray[iterator];
        if(number > max)
        {
            max = number;
        }
        iterator++;
    }    
    while(iterator < 256)
    console.log(`Do While Max of ${numberArray}: ${max}`);     
}