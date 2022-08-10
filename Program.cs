void CreateNewString(string[] args)
{
  
  string[] animals = { "cat", "dog", "cow", "goat","elefante", "pig"};
  for (int i =0; i< animals.Length; i++)
  Console.Write(animals [i] +" "); 
  Console.WriteLine(); 
  int count = 0;
  string[] animalsnew = new string [count];
  string [] animalstemp;
  for (int k =0; k< animals.Length; k++)
  {
  char[] arr;
  arr = animals [k].ToCharArray();
    {
    if (arr.Length <= 3)
    {
    count++;
    string Str = new string(arr);
    animalstemp = new string [count];
    for (int l = 0; l < animalstemp.Length -1; l++)
      animalstemp[l] = animalsnew[l];
    animalstemp[count -1] = Str;
    animalsnew = animalstemp;
    }
    }
  }
  for (int j = 0; j < animalsnew.Length; j++)
      Console.Write(animalsnew [j] + " ");
 Console.WriteLine(); 
   
}
CreateNewString (args); 