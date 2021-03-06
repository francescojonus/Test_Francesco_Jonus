﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Codice generato da un modello.
//
//    Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//    Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace MvcApplication2.Views.Home
{
    #region Contesti
    
    /// <summary>
    /// Nessuna documentazione sui metadati disponibile.
    /// </summary>
    public partial class Database1Entities : ObjectContext
    {
        #region Costruttori
    
        /// <summary>
        /// Inizializza un nuovo oggetto Database1Entities utilizzando la stringa di connessione trovata nella sezione 'Database1Entities' del file di configurazione dell'applicazione.
        /// </summary>
        public Database1Entities() : base("name=Database1Entities", "Database1Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inizializzare un nuovo oggetto Database1Entities.
        /// </summary>
        public Database1Entities(string connectionString) : base(connectionString, "Database1Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inizializzare un nuovo oggetto Database1Entities.
        /// </summary>
        public Database1Entities(EntityConnection connection) : base(connection, "Database1Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Metodi parziali
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Proprietà ObjectSet
    
        /// <summary>
        /// Nessuna documentazione sui metadati disponibile.
        /// </summary>
        public ObjectSet<DatiVari> DatiVaris
        {
            get
            {
                if ((_DatiVaris == null))
                {
                    _DatiVaris = base.CreateObjectSet<DatiVari>("DatiVaris");
                }
                return _DatiVaris;
            }
        }
        private ObjectSet<DatiVari> _DatiVaris;

        #endregion
        #region Metodi AddTo
    
        /// <summary>
        /// Metodo deprecato per l'aggiunta di un nuovo oggetto all'elemento EntitySet DatiVaris. Utilizzare il metodo .Add della proprietà associata ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToDatiVaris(DatiVari datiVari)
        {
            base.AddObject("DatiVaris", datiVari);
        }

        #endregion
    }
    

    #endregion
    
    #region Entità
    
    /// <summary>
    /// Nessuna documentazione sui metadati disponibile.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Database1Model", Name="DatiVari")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class DatiVari : EntityObject
    {
        #region Metodo factory
    
        /// <summary>
        /// Creare un nuovo oggetto DatiVari.
        /// </summary>
        /// <param name="idRiga">Valore iniziale della proprietà IdRiga.</param>
        public static DatiVari CreateDatiVari(global::System.Int32 idRiga)
        {
            DatiVari datiVari = new DatiVari();
            datiVari.IdRiga = idRiga;
            return datiVari;
        }

        #endregion
        #region Proprietà primitive
    
        /// <summary>
        /// Nessuna documentazione sui metadati disponibile.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdRiga
        {
            get
            {
                return _IdRiga;
            }
            set
            {
                if (_IdRiga != value)
                {
                    OnIdRigaChanging(value);
                    ReportPropertyChanging("IdRiga");
                    _IdRiga = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdRiga");
                    OnIdRigaChanged();
                }
            }
        }
        private global::System.Int32 _IdRiga;
        partial void OnIdRigaChanging(global::System.Int32 value);
        partial void OnIdRigaChanged();
    
        /// <summary>
        /// Nessuna documentazione sui metadati disponibile.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
        /// <summary>
        /// Nessuna documentazione sui metadati disponibile.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Cognome
        {
            get
            {
                return _Cognome;
            }
            set
            {
                OnCognomeChanging(value);
                ReportPropertyChanging("Cognome");
                _Cognome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Cognome");
                OnCognomeChanged();
            }
        }
        private global::System.String _Cognome;
        partial void OnCognomeChanging(global::System.String value);
        partial void OnCognomeChanged();

        #endregion
    
    }

    #endregion
    
}
