using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.ComponentModel;

namespace View.ViewModel
{ 
    public class ArticuloViewModel : INotifyPropertyChanged
    {
        ARTICULO Model;

        public ArticuloViewModel() {
        }

        #region Propiedades Model

        public int ID_ARTUCULO {
            get
            {
                return Model.ID_ARTICULO;
            }
            set
            {
                Model.ID_ARTICULO = value;
                NotifyChange("ID_ARTICULO");
            }
        }
        #endregion

        void NotifyChange(params string[] ids)
        {
            if (PropertyChanged != null)
                foreach (var id in ids)
                    PropertyChanged(this, new PropertyChangedEventArgs(id));
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}