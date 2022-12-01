Where do I find what I want?
--
The code you probably want is in `main.cs`

Or.... you can copy the relevant code from below

```
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
```
