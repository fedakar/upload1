﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace fileUpload_mvc.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ResimDataEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ResimDataEntities object using the connection string found in the 'ResimDataEntities' section of the application configuration file.
        /// </summary>
        public ResimDataEntities() : base("name=ResimDataEntities", "ResimDataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ResimDataEntities object.
        /// </summary>
        public ResimDataEntities(string connectionString) : base(connectionString, "ResimDataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ResimDataEntities object.
        /// </summary>
        public ResimDataEntities(EntityConnection connection) : base(connection, "ResimDataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ResimYukle> ResimYukle
        {
            get
            {
                if ((_ResimYukle == null))
                {
                    _ResimYukle = base.CreateObjectSet<ResimYukle>("ResimYukle");
                }
                return _ResimYukle;
            }
        }
        private ObjectSet<ResimYukle> _ResimYukle;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ResimYukle EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToResimYukle(ResimYukle resimYukle)
        {
            base.AddObject("ResimYukle", resimYukle);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ResimDataModel", Name="ResimYukle")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ResimYukle : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ResimYukle object.
        /// </summary>
        /// <param name="resimId">Initial value of the resimId property.</param>
        public static ResimYukle CreateResimYukle(global::System.Int32 resimId)
        {
            ResimYukle resimYukle = new ResimYukle();
            resimYukle.resimId = resimId;
            return resimYukle;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 resimId
        {
            get
            {
                return _resimId;
            }
            set
            {
                if (_resimId != value)
                {
                    OnresimIdChanging(value);
                    ReportPropertyChanging("resimId");
                    _resimId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("resimId");
                    OnresimIdChanged();
                }
            }
        }
        private global::System.Int32 _resimId;
        partial void OnresimIdChanging(global::System.Int32 value);
        partial void OnresimIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String resimAdi
        {
            get
            {
                return _resimAdi;
            }
            set
            {
                OnresimAdiChanging(value);
                ReportPropertyChanging("resimAdi");
                _resimAdi = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("resimAdi");
                OnresimAdiChanged();
            }
        }
        private global::System.String _resimAdi;
        partial void OnresimAdiChanging(global::System.String value);
        partial void OnresimAdiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String resimUzanti
        {
            get
            {
                return _resimUzanti;
            }
            set
            {
                OnresimUzantiChanging(value);
                ReportPropertyChanging("resimUzanti");
                _resimUzanti = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("resimUzanti");
                OnresimUzantiChanged();
            }
        }
        private global::System.String _resimUzanti;
        partial void OnresimUzantiChanging(global::System.String value);
        partial void OnresimUzantiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String resimTuru
        {
            get
            {
                return _resimTuru;
            }
            set
            {
                OnresimTuruChanging(value);
                ReportPropertyChanging("resimTuru");
                _resimTuru = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("resimTuru");
                OnresimTuruChanged();
            }
        }
        private global::System.String _resimTuru;
        partial void OnresimTuruChanging(global::System.String value);
        partial void OnresimTuruChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String resimBoyutu
        {
            get
            {
                return _resimBoyutu;
            }
            set
            {
                OnresimBoyutuChanging(value);
                ReportPropertyChanging("resimBoyutu");
                _resimBoyutu = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("resimBoyutu");
                OnresimBoyutuChanged();
            }
        }
        private global::System.String _resimBoyutu;
        partial void OnresimBoyutuChanging(global::System.String value);
        partial void OnresimBoyutuChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String resimAciklama
        {
            get
            {
                return _resimAciklama;
            }
            set
            {
                OnresimAciklamaChanging(value);
                ReportPropertyChanging("resimAciklama");
                _resimAciklama = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("resimAciklama");
                OnresimAciklamaChanged();
            }
        }
        private global::System.String _resimAciklama;
        partial void OnresimAciklamaChanging(global::System.String value);
        partial void OnresimAciklamaChanged();

        #endregion

    
    }

    #endregion

    
}
