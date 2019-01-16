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
            catch (Exception)
            {
                exito = false;
            }
            finally
            {
                if (sr != null) sr.Close();
            }

            return exito;
        }

        //Guardamos la skin (numero)
        public bool GuardarSkin(int skin, string ruta)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            bool exito = true;

            try
            {
                using (fs = new FileStream(ruta, FileMode.Create, FileAccess.Write))
                using (sw = new StreamWriter(fs))
                {
                    sw.Write(skin);
                }
            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }

        //Obtenemos la skin
        public int ObtenerSkin(string ruta, ref bool exito)
        {
            FileStream fs = null;
            StreamReader sr = null;
            int lectura = 0;

            try
            {
                using (fs = new FileStream(ruta, FileMode.Create, FileAccess.Write))
                using (sr = new StreamReader(fs))
                {
                    lectura = Convert.ToInt32(sr.ReadLine());
                }
            }
            catch (Exception)
            {
                exito = false;
            }

            return lectura;
        }
    }
}
