[33mcommit 8f2eea58ddc5e19c1943a11a28bafd6fb8f3cb89[m[33m ([m[1;36mHEAD[m[33m -> [m[1;32mfeature/etiquetas-tareas[m[33m, [m[1;31morigin/feature/etiquetas-tareas[m[33m)[m
Author: JoseCrack101112 <josmedizq@alu.edu.gva.es>
Date:   Tue Apr 21 16:20:21 2026 +0200

    Añadida funcionalidad de etiquetas para tareas

[1mdiff --git a/GestorTareasGUI1/Class1.cs b/GestorTareasGUI1/Class1.cs[m
[1mindex a55904e..df472d4 100644[m
[1m--- a/GestorTareasGUI1/Class1.cs[m
[1m+++ b/GestorTareasGUI1/Class1.cs[m
[36m@@ -20,6 +20,7 @@[m [mnamespace GestorTareasGUI1[m
                 string estado = Completada ? "Sí" : "No";[m
                 return $"{Nombre} | {Descripcion} | {Fecha.ToShortDateString()} | Completada: {estado}";[m
             }[m
[32m+[m		[32m public List<string> Etiquetas { get; set; } = new List<string>();[m
         }[m
     }[m
 }[m

[33mcommit 7c5331ab0672b9eac896fb7963b93340dae194c7[m[33m ([m[1;31morigin/master[m[33m, [m[1;31morigin/feature/chkPrioridadAlta[m[33m, [m[1;31morigin/HEAD[m[33m, [m[1;32mmaster[m[33m)[m
Author: JoseCrack101112 <josmedizq@alu.edu.gva.es>
Date:   Mon Mar 16 17:34:57 2026 +0100

    Actualización del proyecto

[1mdiff --git a/GestorTareasGUI1/Class1.cs b/GestorTareasGUI1/Class1.cs[m
[1mindex b066c32..a55904e 100644[m
[1m--- a/GestorTareasGUI1/Class1.cs[m
[1m+++ b/GestorTareasGUI1/Class1.cs[m
[36m@@ -17,7 +17,8 @@[m [mnamespace GestorTareasGUI1[m
 [m
             public override string ToString()[m
             {[m
[31m-                return $"{Nombre} - {Fecha.ToShortDateString()} {(Completada ? "[✔]" : "[ ]")}";[m
[32m+[m[32m                string estado = Completada ? "Sí" : "No";[m
[32m+[m[32m                return $"{Nombre} | {Descripcion} | {Fecha.ToShortDateString()} | Completada: {estado}";[m
             }[m
         }[m
     }[m

[33mcommit 667d07c2359bf7d7ed8fd579de544aa8fd7a4fcc[m
Author: JoseCrack101112 <josmedizq@alu.edu.gva.es>
Date:   Mon Mar 9 19:37:52 2026 +0100

    Versión inicial del proyecto

[1mdiff --git a/GestorTareasGUI1/Class1.cs b/GestorTareasGUI1/Class1.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..b066c32[m
[1m--- /dev/null[m
[1m+++ b/GestorTareasGUI1/Class1.cs[m
[36m@@ -0,0 +1,24 @@[m
[32m+[m[32m﻿using System;[m
[32m+[m[32musing System.Collections.Generic;[m
[32m+[m[32musing System.Linq;[m
[32m+[m[32musing System.Text;[m
[32m+[m[32musing System.Threading.Tasks;[m
[32m+[m
[32m+[m[32mnamespace GestorTareasGUI1[m
[32m+[m[32m{[m
[32m+[m[32m    internal class Class1[m
[32m+[m[32m    {[m
[32m+[m[32m        public class Tarea[m
[32m+[m[32m        {[m
[32m+[m[32m            public string Nombre { get; set; }[m
[32m+[m[32m            public string Descripcion { get; set; }[m
[32m+[m[32m            public DateTime Fecha { get; set; }[m
[32m+[m[32m            public bool Completada { get; set; }[m
[32m+[m
[32m+[m[32m            public override string ToString()[m
[32m+[m[32m            {[m
[32m+[m[32m                return $"{Nombre} - {Fecha.ToShortDateString()} {(Completada ? "[✔]" : "[ ]")}";[m
[32m+[m[32m            }[m
[32m+[m[32m        }[m
[32m+[m[32m    }[m
[32m+[m[32m}[m
