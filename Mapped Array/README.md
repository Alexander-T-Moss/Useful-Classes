Class Description
--
This is just a glorification on C# 2D arrays to make them more useful

Where do I find what I want?
--
The code you probably want is in `main.cs`

Or.... you can copy the relevant code from below

```
using System;
using System.IO;

class MappedArray
{
   // Initialize 2D Array
  string[,] ArrayGrid; 
  int MappedArrayWidth, MappedArrayDepth;
   
  public MappedArray(string[] input)
  {
     // Set dimensions of array
    MappedArrayWidth = input[0].Length;
    MappedArrayDepth = input.Length;

     // Initalize array
    ArrayGrid = new string[MappedArrayWidth, MappedArrayDepth];

     // Assign values from input to respective places in 2D array
    int arrayX, arrayY = 0;
    foreach (string line in input)
    {
      arrayX = 0;
      foreach(char element in line.Trim())
      {
        ArrayGrid[arrayX, arrayY] = element.ToString();
        arrayX++; 
      }
      arrayY++; 
    }
  }

   // Return element at given X,Y index
  public string GetElementAt (int arrayX, int arrayY)
  {
      return ArrayGrid[arrayX, arrayY];
  }
    
   // Change element at given X,Y index
  public void SetElementAt (int arrayX, int arrayY, string newElement)
  {
      ArrayGrid[arrayX, arrayY] = newElement;
  }

  public string[] GetColumn(int arrayX)
  {
     // Create array to pull data to from 2D array
    string[] column = new string[MappedArrayDepth];

     // Pull data to array
    for(int arrayY = 0; arrayY < MappedArrayDepth; arrayY++)
    {
      column[arrayY] = ArrayGrid[arrayX, arrayY];
    }
    
    return column;
  }

  public string[] GetRow(int arrayY)
  {
     // Create array to pull data to from 2D array
    string[] row = new string[MappedArrayDepth];

     // Pull data to arrray
    for(int arrayX = 0; arrayX < MappedArrayDepth; arrayX++)
    {
      row[arrayX] = ArrayGrid[arrayX, arrayY];
    }
    
    return row;
  }
}

class Program {
  public static void Main (string[] args) {
    
     // Read Input.txt file to array
    string[] InputArray = File.ReadAllLines(@"Input.txt");
    
     // Initialize test MappedArray
    MappedArray myMappedArray = new(InputArray);

     // Get element from MappedArray
    Console.WriteLine("\nElement at X:4 Y:1 is " + myMappedArray.GetElementAt(4,1));

     // Change element in MappedArray
    Console.WriteLine("\nChanging element at X:4 Y:1 to 6");
    myMappedArray.SetElementAt(4,1, "6");
    Console.WriteLine("\nElement at X:4 Y:1 is " + myMappedArray.GetElementAt(4,1));

     // Barf contents of column to console
    Console.WriteLine("\nColumn 3: " + string.Join(", ", myMappedArray.GetColumn(3)));

     // Barf contents of row to console
    Console.WriteLine("\nRow 5: " + string.Join(", ", myMappedArray.GetRow(5)));
  }
}
```
