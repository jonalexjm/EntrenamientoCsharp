using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOperadores
{
    class Program
    {
        static void Main(string[] args)
        {

            List<CEstudiante> estudianteList = new List<CEstudiante>();
            List<Curso> cursoList = new List<Curso>();
            List<RelacionMateria> relacionList = new List<RelacionMateria>();

            estudianteList.Add(new CEstudiante { Id = 1, Direccion = "popayan", Nombre = "john" });
            estudianteList.Add(new CEstudiante { Id = 2, Direccion = "cali", Nombre = "jose" });
            estudianteList.Add(new CEstudiante { Id = 3, Direccion = "pasto", Nombre = "mari" });
            estudianteList.Add(new CEstudiante { Id = 4, Direccion = "bogota", Nombre = "cris" });

            cursoList.Add(new Curso { Id = 1, NombreMateria = "ciencias naturales" });
            cursoList.Add(new Curso { Id = 2, NombreMateria = "ciencias sociales" });
            cursoList.Add(new Curso { Id = 3, NombreMateria = "matematicas" });
            cursoList.Add(new Curso { Id = 4, NombreMateria = "ingles" });


            relacionList.Add(new RelacionMateria { Id = 1, IdCurso = 2, IdEstudiante = 3 });
            relacionList.Add(new RelacionMateria { Id = 2, IdCurso = 4, IdEstudiante = 2 });
            relacionList.Add(new RelacionMateria { Id = 6, IdCurso = 4, IdEstudiante = 3 });
            relacionList.Add(new RelacionMateria { Id = 3, IdCurso = 3, IdEstudiante = 4 });
            relacionList.Add(new RelacionMateria { Id = 4, IdCurso = 1, IdEstudiante = 2 });
            relacionList.Add(new RelacionMateria { Id = 5, IdCurso = 3, IdEstudiante = 1 });
            

            //linq normal
            var resultadoJoin = from r in relacionList
                                join e in estudianteList on r.IdEstudiante equals e.Id
                                //  join c in cursoList on c.Id equals r.IdCurso
                                where e.Nombre == "john"
                                select new {
                                   nombre =  e.Nombre,
                                   direccion =  e.Direccion,
                                   identificacion =  e.Id
                                };

            foreach (var item in resultadoJoin)
                Console.WriteLine(item);

            Console.WriteLine("-----------------------------------------");

            //estudiantes matriculados a la clase de ingles
            //linq normal
            var resultadoMatriculas = from r in relacionList
                                      join e in estudianteList on r.IdEstudiante equals e.Id
                                      join c in cursoList on r.IdCurso equals c.Id
                                      where r.IdCurso == 2
                                      select new
                                      {
                                          e.Id,
                                          e.Nombre
                                      };

            foreach (var item in resultadoMatriculas)
                Console.WriteLine(item);
            //linq lambda
            //    var resultadoMatriculasLambda = relacionList.Where(x => x.Id == 1).ToList();
            var resultadoMatriculasLambda = relacionList.Join(estudianteList, // the source table of the inner join
                                                               r => r.IdEstudiante,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                                                               e => e.Id,
                                                               (r, e) => new
                                                               {
                                                                   r,
                                                                   e
                                                               })
                                                          .Join(cursoList, // the source table of the inner join
                                                                 er => er.r.IdCurso,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                                                                 c => c.Id,
                                                                 (er, c) => new
                                                                 {
                                                                     er,
                                                                     c

                                                                 })

                                                         .Where(x => x.c.Id == 4)//donde id curso sea igual a 4
                                                         .Select(q => new
                                                         {
                                                             id_curso = q.c.Id,
                                                             nombre_curso = q.c.NombreMateria,
                                                             identificacion = q.er.e.Nombre,
                                                             direccion = q.er.e.Direccion,
                                                             id_relacion = q.er.r.Id



                                                         }); ;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Con lambda");
            foreach (var item in resultadoMatriculasLambda)
                Console.WriteLine("datos pedidos: codigo curso: {0}---nombre curso: {1} ---  identificacion {2} -- nombre : {3}", item.id_curso, item.nombre_curso, item.identificacion, item.identificacion);











        }
    }
}
