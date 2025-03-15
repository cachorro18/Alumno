﻿using eschool;

using System.Data;

Dictionary<string, string> diccionario = new Dictionary<string, string>();

Profesor p = new Profesor();
Console.WriteLine("Bienvenido!, Ingrese su nombre: ");
p.Nombre = Console.ReadLine();
p.capturarDatosAlumno();
p.capturarMaterias();
p.capturarCalificaciones();

Console.WriteLine("\nMostrando datos...");
Console.WriteLine("==================");
Console.WriteLine("Nombre profesor: " +  p.Nombre);
Console.WriteLine("\n===Datos alumno:=== ");
Console.WriteLine("NL alumno: " + p.Alumno1.Nl);
Console.WriteLine("Nombre alumno: " + p.Alumno1.Nombre);
Console.WriteLine("\n===Materias===");


for (int i= 0;i<p.Alumno1.Materias.Count;i++)
{
    diccionario.Add(p.Alumno1.Materias[i].ToString(), p.Alumno1.Calificaciones[i].ToString());
}
   
foreach(var elementos in diccionario) 
    Console.WriteLine(elementos.ToString());

foreach(string clave in diccionario.Keys)
{ 
    Console.WriteLine(clave); 
}

foreach (string valor in diccionario.Values)
{ 
    Console.WriteLine(valor); 
}