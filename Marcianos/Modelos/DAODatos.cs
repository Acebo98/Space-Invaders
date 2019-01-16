using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Marcianos
{
    //----------------------------------------------------
    //Acceso a la carpeta donde se encuentran los datos
    //Autor: Sergio Acebal
    //Fecha: 16/01/2019
    //----------------------------------------------------
    class DAODatos
    {
        //Obtenemos la puntuación
        public int ObtenerPuntuacion(string ruta, ref bool exit)
        {
            FileStream fs = null;
            StreamReader sr = null;
            string lectura;
            int retorno = 0;

            try
            {
                fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                if ((lectura = sr.ReadLine()) != null)
                {
                    retorno = Convert.ToInt32(lectura);
                }
                else
                {
                    retorno = 0;
                }
            }
            catch (Exception)
            {
                exit = false;               
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

            return retorno;
        }

        //Guardamos la puntuacióx máxima
        public bool GuardarPuntuacion(int score, string ruta)
        {
            StreamWriter sr = null;
            bool exito = true;

            try
            {
                sr = new StreamWriter(ruta, false);
                sr.Write(score);
            }
            catch (Exception e)
            {
                exito = false;
            }
            finally
            {
                if (sr != null) sr.Close();
            }

            return exito;
        }
    }
}
