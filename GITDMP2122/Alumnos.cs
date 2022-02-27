using System;
using System.Collections;

class Alumnos
{
    private ArrayList listaAlumnos = new ArrayList();

    // Agrega un nuevo alumno a la lista
    //        
    public void Agregar(WindowsFormsApp1.Alumno alu)
    {
        if (alu is null)
        {
            throw new ArgumentNullException(nameof(alu));
        }

        listaAlumnos.Add(alu);
    }

    // Devuelve el alumno que está en la posición num
    //
    public WindowsFormsApp1.Alumno Obtener(int num)
    {
        if (num >= 0 && num <= listaAlumnos.Count)
        {
            return ((WindowsFormsApp1.Alumno)listaAlumnos[num]);
        }
        return null;
    }

    // Devuelve la nota media de los alumnos
    //
    public float Media
    {
        get
        {
            if (listaAlumnos.Count == 0)
                return 0;
            else
            {
                float media = 0;
                for (int i = 0; i < listaAlumnos.Count; i++)
                {
                    media += ((WindowsFormsApp1.Alumno)listaAlumnos[i]).Nota;
                }
                return (media / listaAlumnos.Count);
            }
        }
    }
}
