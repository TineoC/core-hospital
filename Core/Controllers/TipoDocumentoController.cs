﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//??? Para Hacer Operaciones
//Funciona 
namespace Core.Controllers
{
   internal  class TipoDocumentoController
    {
        static hospitalEntities hospital = new hospitalEntities();

        public static void MostrarInformacion(TipoDocumento tipoDocumento)
        {
            
            Console.WriteLine($"Descripcion del tipo de Documento: {tipoDocumento.TipoDocumento_Descripcion}");
            Console.WriteLine($"Fecha de creacion: { tipoDocumento.TipoDocumento_FechaCreacion}");
            Console.WriteLine($"Id Usuario Creador: { tipoDocumento.TipoDocumento_IdUsuarioCreador}");
            Console.WriteLine($"Vigencia: { tipoDocumento.TipoDocumento_Vigencia}");
        }

        public static void Crear()
        {
            var Logger = NLog.LogManager.GetCurrentClassLogger();

            Console.Clear();

            try
            {
                Console.Write("Escribe la descripcion de tipo de Documento: ");
                string descripcion = Console.ReadLine();



                hospital.TipoDocumento.Add(new TipoDocumento()
                {
                    TipoDocumento_Descripcion = descripcion
                });


                Logger.Info($"Se ha creado el tipo de Documento correctamente: {descripcion}");


                hospital.SaveChanges();
            }
            catch (Exception e)
            {
                Logger.Error(e, "Ha ocurrido un error inesperado");
                throw;
            }
        }

        public static void Mostrar()
        {
            bool exists = false;
            int TipoDocumento;
            var Logger = NLog.LogManager.GetCurrentClassLogger();

            do
            {
                Console.Write("Escribe la identificacion del tipo de Documento: ");
                TipoDocumento = Int32.Parse(Console.ReadLine());

                Console.Clear();

                exists = hospital.TipoDocumento.Any(tipoDoc => tipoDoc.TipoDocumento_Id == TipoDocumento);

                if (!exists)
                {
                    Console.WriteLine("No existen tipos de Documentos con esa identificacion");

                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (!exists);

            Console.Clear();

            TipoDocumento tipoDocumento = hospital.TipoDocumento
                            .Where(
                                tipoDoc => tipoDoc.TipoDocumento_Id == TipoDocumento
                            )
                            .FirstOrDefault();

            MostrarInformacion(tipoDocumento);
        }
        public static void MostrarTodos()
        {
            int index = 1;
            foreach (TipoDocumento tipoDocumento in hospital.TipoDocumento.ToList())
            {
                Console.Clear();
                Console.WriteLine($"TipoDocumento: {index}");

                MostrarInformacion(tipoDocumento);

                index++;
            }
        }
        public static void Actualizar()
        {
            bool exists = false;
            int TipoDocumento;
            var Logger = NLog.LogManager.GetCurrentClassLogger();

            do
            {
                Console.Write("Escribe la descripcion del tipo de Documento  a actualizar: ");
                TipoDocumento = Int32.Parse(Console.ReadLine());

                Console.Clear();

                exists = hospital.TipoDocumento.Any(tipoDoc => tipoDoc.TipoDocumento_Id == TipoDocumento);

                if (!exists)
                {
                    Console.WriteLine("No existen tipos de Documentos con esa identificacion");

                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (!exists);

            Console.Write("Escribe la descripcion del Documento (actualizado): ");
            string descripcion = Console.ReadLine();


            TipoDocumento nuevoTipoDocumento = hospital.TipoDocumento.Where(
                    tipoDoc => tipoDoc.TipoDocumento_Id == TipoDocumento
                ).First();

            nuevoTipoDocumento.TipoDocumento_Descripcion = descripcion;


            Logger.Info($"El tipo de Documento con la identificacion {TipoDocumento} ha sido actualizado.");

            hospital.SaveChanges();
        }
        public static void Eliminar()
        {
            var Logger = NLog.LogManager.GetCurrentClassLogger();

            try
            {
                bool exists = false;
                int TipoDocumento;

                do
                {
                    Console.Write("Escribe la identifiacion del tipo de Documento a eliminar: ");
                    TipoDocumento = Int32.Parse(Console.ReadLine());

                    Console.Clear();

                    exists = hospital.TipoDocumento.Any(tipoDoc => tipoDoc.TipoDocumento_Id == TipoDocumento);

                    if (!exists)
                    {
                        Console.WriteLine("No existen tipos de Documentos con esa identifiacion");

                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                    }
                } while (!exists);

                hospital.TipoDocumento.Remove(hospital.TipoDocumento.Where(
                        tipoDoc => tipoDoc.TipoDocumento_Id == TipoDocumento
                    ).First()
                );

                hospital.SaveChanges();

                Logger.Info($"El tipo de Documento con la identifiacion {TipoDocumento} ha sido eliminado.");
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, "Ha ocurrido un error inesperado");
                throw;
            }
        }
    }
}
