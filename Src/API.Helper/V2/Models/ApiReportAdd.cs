﻿namespace Syncfusion.Report.Server.API.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Report details
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiReportAdd
    {
        /// <summary>
        /// Report name
        /// </summary>
        [DataMember]
        [Required]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Report description
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Category ID
        /// </summary>
        [DataMember]
        [Required]
        public Guid CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// Specify the relative Path of the item
        /// </summary>
        [DataMember]
        public string ServerPath
        {
            get;
            set;
        }

        /// <summary>
        /// Specify true to set the item as a public
        /// </summary>
        [DataMember]
        public bool IsPublic
        {
            get;
            set;
        }

        /// <summary>
        /// Mapping information of dataset
        /// </summary>
        [DataMember]
        public List<DataSetMappingInfo> DataSetMappingInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Mapping information of datasource
        /// </summary>
        [DataMember]
        public List<DataSourceMappingInfo> DataSourceMappingInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Provide items in an array of bytes
        /// </summary>
        [DataMember]
        [Required]
        public byte[] ItemContent
        {
            get;
            set;
        }
    }
}
