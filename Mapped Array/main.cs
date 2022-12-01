using System;
using System.IO;

class MappedArray
{
  string[,] ArrayGrid; // Initialize 2D Array
  
  public MappedArray(string[] input)
  {
    // Set dimensions of array (X)
    ArrayGrid = new string[input[0].Length, input.Length];

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
  public string GetElementAt (int xCoord, int yCoord)
  {
      return ArrayGrid[xCoord, yCoord];
  }
    
  // Change element at given X,Y index
  public void SetElementAt (int xCoord, int yCoord, string newElement)
  {
      ArrayGrid[xCoord, yCoord] = newElement;
  }
}

class Program {
  public static void Main (string[] args) {
    
    string[] InputArray = File.ReadAllLines(@"Input.txt");
    
    // Initialize test MappedArray
    MappedArray myMappedArray = new(InputArray);

    // Get element from MappedArray
    Console.WriteLine("Element at X:3 Y:3 is " + myMappedArray.GetElementAt(3,3));

    // Change element in MappedArray
    Console.WriteLine("\nChanging element at X:3 Y:3 to 6");
    myMappedArray.SetElementAt(3,3, "6");
    
    Console.WriteLine("\nElement at X:3 Y:3 is " + myMappedArray.GetElementAt(3,3));
  }
}