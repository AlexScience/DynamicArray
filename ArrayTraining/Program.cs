using ArrayTraining;


DynamicArray<int> dynamicArray = new DynamicArray<int>();

dynamicArray.Add(1);
dynamicArray.Add(2);
dynamicArray.Add(4);
dynamicArray.Add(5);
dynamicArray.Add(6);


dynamicArray.Delete(4);

var value = dynamicArray[1];
dynamicArray[0] = 4;

foreach (var item in dynamicArray)
{
    Console.WriteLine(item);
}