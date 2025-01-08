int n = int.Parse(Console.ReadLine());

char[,] matrix = fillMatrix(n);

char symbolToSearch = char.Parse(Console.ReadLine());

string result = searchArray(matrix, symbolToSearch);

Console.WriteLine(result);

char[,] fillMatrix(int n)
{
    char[,] result = new char[n, n];

    for (int row = 0; row < n; row++)
    {
        string? values = Console.ReadLine();        
        for (int col = 0; col < n; col++)
        {
            result[row, col] = values[col]; 
        }
    }

    return result;
}

string searchArray(char[,] arr, char symbolToSearch)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] == symbolToSearch)
            {
                return $"({i}, {j})";
            }
        }
    }

    return $"{symbolToSearch} does not occur in the matrix";
}