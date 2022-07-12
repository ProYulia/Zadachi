int[] array = {1, 5, 8, 3, 9, 10, 15, 6};
int pos = IndexOf(array, 4);
Console.WriteLine(pos);

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}