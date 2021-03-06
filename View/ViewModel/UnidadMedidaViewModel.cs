﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Model;

namespace View.ViewModel
{
    class UnidadMedidaViewModel : INotifyPropertyChanged
    {
        UNIDAD_MEDIDA Model;

        public UnidadMedidaViewModel()
        {

        }

        public int ID_UNIDAD_MEDIDA {
            get
            {
                return Model.ID_UNIDAD_MEDIDA;
            }

            set
            {
                Model.ID_UNIDAD_MEDIDA = value;
                NotifyChange("ID_UNIDAD_MEDIDA");
            }
        }
        public string NOMBRE {
            get
            {
                return Model.NOMBRE;
            }

            set
            {
                Model.NOMBRE = value;
                NotifyChange("NOMBRE");
            }
        }
        public Nullable<System.DateTime> FECHA_CREACION {
            get
            {
                return Model.FECHA_CREACION;
            }

            set
            {
                Model.FECHA_CREACION = value;
                NotifyChange("FECHA_CREACION");
            }
        }

        public Nullable<int> ID_USUARIO_CREACION {
            get
            {
                return Model.ID_USUARIO_CREACION;
            }

            set
            {
                Model.ID_USUARIO_CREACION = value;
                NotifyChange("ID_USUARIO_CREACION");
            }
        }
        public Nullable<System.DateTime> FECHA_ACTUALIZACION {
            get
            {
                return Model.FECHA_ACTUALIZACION;
            }

            set
            {
                Model.FECHA_ACTUALIZACION = value;
                NotifyChange("FECHA_ACTUALIZACION");
            }
        }

        public Nullable<int> ID_USUARIO_ACTUZALICION {
            get
            {
                return Model.ID_USUARIO_ACTUZALICION;
            }

            set
            {
                Model.ID_USUARIO_ACTUZALICION = value;
                NotifyChange("ID_USUARIO_ACTUZALICION");
            }
        }

        public virtual ICollection<ARTICULO> ARTICULO {
            get
            {
                return Model.ARTICULO;
            }

            set
            {
                Model.ARTICULO = value;
                NotifyChange("ARTICULO");
            }
        }

        #region Propiedades Model
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
