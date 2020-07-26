using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Country.Segmentation
{

    public class Segmentacion
    {
        public List<string> Provincias = new List<string>();
        public List<Municipio> Municipios = new List<Municipio>();

        /// <summary>
        /// Segmentacion del pais, el CultureInfo class determina cual usará
        /// </summary>
        /// <param name="culture"></param>
        public Segmentacion(CultureInfo culture)
        {
            switch (culture.Name)
            {
                case "es-DO":
                    var type = typeof(Provincia);
                    FieldInfo[] provincias = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

                    foreach (var p in provincias)
                    {
                        Provincias.Add(p.GetValue(null).ToString());
                    }

                    var municipioType = typeof(Municipios);
                    FieldInfo[] municipios = municipioType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
                    //var listaProps = typeof(Municipios).GetProperties();

                    foreach (var m in municipios)
                    {
                        var obj = (Municipio)m.GetValue(this);

                        Municipios.Add(new Municipio(obj.Name, obj.Provincia));
                    }
                    break;
                default:
                    break;
            }
            
        }

        
    }


}
