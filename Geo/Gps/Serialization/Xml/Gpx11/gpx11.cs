﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 

using Geo.Gps.Serialization.Xml.GpxBase;

namespace Geo.Gps.Serialization.Xml.Gpx11 {
    using System;
    using System.CodeDom.Compiler;
    using System.Xml;
    using System.Xml.Serialization;
    
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    [XmlRoot("gpx", Namespace="http://www.topografix.com/GPX/1/1", IsNullable=false)]
    public partial class gpxType {
        public gpxType() {
            this.version = "1.1";
        }

        public metadataType metadata { get; set; }

        [XmlElement("wpt")]
        public wptType[] wpt { get; set; }

        [XmlElement("rte")]
        public rteType[] rte { get; set; }

        [XmlElement("trk")]
        public trkType[] trk { get; set; }

        //public extensionsType extensions { get; set; }

        [XmlAttribute]
        public string version { get; set; }

        [XmlAttribute]
        public string creator { get; set; }
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class metadataType : GpxMetadataBase
    {
        public personType author { get; set; }
        public copyrightType copyright { get; set; }
        [XmlElement("link")]
        public linkType[] link { get; set; }
        public boundsType bounds { get; set; }

        //public extensionsType extensions { get; set; }
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class personType {
        public string name { get; set; }

        public emailType email { get; set; }

        public linkType link { get; set; }
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class emailType {
        [XmlAttribute]
        public string id { get; set; }

        [XmlAttribute]
        public string domain { get; set; }
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class trksegType {
        [XmlElement("trkpt")]
        public wptType[] trkpt { get; set; }

        //public extensionsType extensions { get; set; }
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class wptType : GpxWaypointBase
    {
        [XmlElement("link")]
        public linkType[] link { get; set; }

        public fixType fix { get; set; }
        //public extensionsType extensions { get; set; }
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class linkType {
        public string text { get; set; }

        public string type { get; set; }

        [XmlAttribute(DataType="anyURI")]
        public string href { get; set; }
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public enum fixType {
        
        none,
        
        [XmlEnum("2d")]
        Item2d,
        
        [XmlEnum("3d")]
        Item3d,
        
        dgps,
        
        pps,
    }
    
    //[GeneratedCode("xsd", "4.0.30319.1")]
    //[XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    //public partial class extensionsType {
    //    [XmlAnyElement]
    //    public XmlElement[] Any { get; set; }
    //}
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class trkType : GpxRteTrkBase
    {
        [XmlElement("link")]
        public linkType[] link { get; set; }

        public string type { get; set; }

        //public extensionsType extensions { get; set; }

        [XmlElement("trkseg")]
        public trksegType[] trkseg { get; set; }
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class rteType : GpxRteTrkBase
    {
        [XmlElement("link")]
        public linkType[] link { get; set; }

        public string type { get; set; }

        //public extensionsType extensions { get; set; }

        [XmlElement("rtept")]
        public wptType[] rtept { get; set; }
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class boundsType : GpxBoundsBase
    {
    }
    
    [GeneratedCode("xsd", "4.0.30319.1")]
    [XmlType(Namespace="http://www.topografix.com/GPX/1/1")]
    public partial class copyrightType {
        [XmlElement(DataType="gYear")]
        public string year { get; set; }

        [XmlElement(DataType="anyURI")]
        public string license { get; set; }

        [XmlAttribute]
        public string author { get; set; }
    }
}
