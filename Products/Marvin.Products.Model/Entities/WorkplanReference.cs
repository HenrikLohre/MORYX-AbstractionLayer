﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the Marvin template for generating a DbContext and Entities. 
// If you have any questions or suggestions for improvement regarding this code, contact Thomas Fuchs. I allways need feedback to improve.
// 
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Linq;
using Marvin.Model;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Marvin.Products.Model
{

    /// <summary>
    /// There are no comments for Marvin.Products.Model.WorkplanReference in the schema.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [System.Runtime.Serialization.KnownType(typeof(WorkplanEntity))]
    public partial class WorkplanReference : IEquatable<WorkplanReference>, IMergeParent, IEntity    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public WorkplanReference()
        {
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual long Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        private long _id;

    
        /// <summary>
        /// There are no comments for ReferenceType in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual int ReferenceType
        {
            get
            {
                return _referenceType;
            }
            set
            {
                if (_referenceType != value)
                {
                    _referenceType = value;
                    OnPropertyChanged("ReferenceType");
                }
            }
        }
        private int _referenceType;

    
        /// <summary>
        /// There are no comments for SourceId in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual long SourceId
        {
            get
            {
                return _sourceId;
            }
            set
            {
                if (_sourceId != value)
                {
                    _sourceId = value;
                    OnPropertyChanged("SourceId");
                }
            }
        }
        private long _sourceId;

    
        /// <summary>
        /// There are no comments for TargetId in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual long TargetId
        {
            get
            {
                return _targetId;
            }
            set
            {
                if (_targetId != value)
                {
                    _targetId = value;
                    OnPropertyChanged("TargetId");
                }
            }
        }
        private long _targetId;


        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Target in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual WorkplanEntity Target
        {
            get;
            set;
        }
    
        /// <summary>
        /// There are no comments for Source in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual WorkplanEntity Source
        {
            get;
            set;
        }

        #endregion
        #region IEquatable
        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return Equals(other as WorkplanReference); 
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The WorkplanReference to compare with the current WorkplanReference.</param>
        /// <returns><c>true</c> if the specified WorkplanReference is equal to the current WorkplanReference; otherwise, <c>false</c>.</returns>
        public bool Equals(WorkplanReference other)
        {
            if((object)other == null)
                return false;
            
            // First look for Id, then compare references
            return (Id != 0 && Id == other.Id) || object.ReferenceEquals(this, other);
        }
     
        /// <summary>
        /// Compares two WorkplanReference objects.
        /// </summary>
        /// <param name="a">The first WorkplanReference to compare</param>
        /// <param name="b">The second WorkplanReference to compare</param>
        /// <returns><c>true</c> if the specified objects are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(WorkplanReference  a, WorkplanReference  b)
        {
            if((object)a == null && (object)b == null)
                return true;
            return (object)a != null && a.Equals(b);
        }

        /// <summary>
        /// Compares two WorkplanReference objects.
        /// </summary>
        /// <param name="a">The first WorkplanReference to compare</param>
        /// <param name="b">The second WorkplanReference to compare</param>
        /// <returns><c>true</c> if the specified objects are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(WorkplanReference  a, WorkplanReference b)
        {
            return !(a == b);
        }

        #endregion
        
        /// <summary>
        /// Reference to merged child
        /// </summary>
        object IMergeParent.Child { get; set; }
    
        #region INotifyPropertyChanged Members

        /// <summary>
        /// Raised when a property value changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises a PropertyChanged event.
        /// </summary>
        protected void OnPropertyChanged(string propertyName) {

          if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

}