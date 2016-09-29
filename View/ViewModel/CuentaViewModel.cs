using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ViewModel
{
    public class CuentaViewModel
    {
        //Comentario insertado vía Web
        public String var1;
        public int campo { get; set; }

        public CuentaViewModel(string p)
        {
            //Asignamos un valor editando la clase desde vía web.
            var1 = p;
        }
       
      public CuentaViewModel()
        {

        }

    }

}
