List<int> lstData = new List<int> { 5, 2, 8, 3, 1, 9, 4, 6, 7 };


//Iterar sobre los elementos de la lista:
lstData.ForEach(x => Console.WriteLine(x));

//Buscar por algun valor.
int valueSearch = 1;
bool exist = lstData.Contains(valueSearch);


//Buscar por una condicion.
List<int> lstPares = lstData.Where(w => w % 2 == 0).ToList();


//Ordena la lista en orden ascendente. / muta el arreglo
lstData.Sort((a, b) => a.CompareTo(b));


//Ordena la lista en orden descendente. / muta el arreglo
lstData.Sort((a, b) => b.CompareTo(a));


//Toma los primeros 3 elementos de la lista.
var firstThreeElement = lstData.Take(3).ToList();

//Omitir los primeros 2 elementos de la lista y tomar los siguientes 4 elementos.
var lstResult = lstData.Skip(2).Take(4).ToList();


//Verificar que todos cumplen una condicion 
var check = lstData.All(a => a > 0);

//Verificar si al menos uno cumple una condicion, en teoria corta la ejecucion en el primer match
lstData.Any(x => x == valueSearch);

//Agregar / muta el arreglo
lstData.Add(10);


//Elimina la coincidencia / muta el arreglo
lstData.Remove(1);

//Remueve todos los que cumplan una condicion / muta el arreglo
lstData.RemoveAll(a => a > 6);

//Elimina todos los elementos de la lista / muta el arreglo
lstData.Clear();


//Concatenar una lista del mismo tipo pero devuelve una nueva collecion
var newList = lstData.Concat(new List<int> { 1, 1, 1, 1 });

//Obtener el valor maximo
// si es un objeto de una clase podria pasarse una implementacion
// lstData.Max( x => x.edad );
var max = lstData.Max();