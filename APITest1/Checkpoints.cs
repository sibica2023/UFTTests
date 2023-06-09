//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Script
{
    using System;
    using System.Xml;
    using System.Xml.Schema;
    using System.Collections.Generic;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.CheckpointFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Ext.CheckpointLogicOperators;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Ext.CheckpointRules;
    using HP.ST.Ext.CheckpointRules.ArrayCheckpoints;
    
    
    public partial class WorkFlowScript
    {
        
        private void set_StServiceCallActivity4_checkpoints(STActivityBase activity)
        {
            VTDPropertyInfoBase stracturalOutputEnvelope = new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)=\'Envelope\'][1]");
            IList<VTDPropertyInfoBase> stracturalPropsInfo = new List<VTDPropertyInfoBase>();
            CpValObj ExpectedSchema = new CpValObj("<?xml version=\"1.0\" encoding=\"utf-16\"?><xs:schema xmlns=\"http://schemas.xmlsoap.o" +
                    "rg/soap/envelope/\" xmlns:vtd=\"hp.visual_test_designer\" elementFormDefault=\"quali" +
                    "fied\" targetNamespace=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xs=\"http" +
                    "://www.w3.org/2001/XMLSchema\"><xs:import schemaLocation=\"EmbeddedResources/Fligh" +
                    "ts_SO\\webServices\\Flights_SO\\_5.xsd\" namespace=\"HP.SOAQ.SampleApp/Imports\" /><xs" +
                    ":attribute name=\"fullName\" type=\"xs:string\" /><xs:attribute name=\"group\" type=\"x" +
                    "s:string\" /><xs:attribute name=\"serialize\" type=\"xs:string\" /><xs:attribute name" +
                    "=\"argType\" type=\"xs:string\" /><xs:element name=\"Envelope\" type=\"Envelope\" /><xs:" +
                    "complexType name=\"Envelope\"><xs:sequence><xs:element minOccurs=\"0\" ref=\"Header\" " +
                    "/><xs:element minOccurs=\"1\" ref=\"Body\" /></xs:sequence><xs:anyAttribute processC" +
                    "ontents=\"lax\" /></xs:complexType><xs:element name=\"Header\" type=\"Header\" /><xs:c" +
                    "omplexType name=\"Header\"><xs:sequence xmlns=\"\"><xs:any minOccurs=\"0\" maxOccurs=\"" +
                    "unbounded\" processContents=\"lax\" /></xs:sequence><xs:anyAttribute processContent" +
                    "s=\"lax\" /></xs:complexType><xs:element name=\"Body\" type=\"Body\" /><xs:complexType" +
                    " name=\"Body\"><xs:sequence xmlns=\"\"><xs:element xmlns:q1=\"HP.SOAQ.SampleApp\" ref=" +
                    "\"q1:GetFlightOrdersResponse\" /></xs:sequence><xs:anyAttribute namespace=\"##any\" " +
                    "processContents=\"lax\"><xs:annotation><xs:documentation>Prose in the spec does no" +
                    "t specify that attributes are allowed on the Body element</xs:documentation></xs" +
                    ":annotation></xs:anyAttribute></xs:complexType><xs:attribute name=\"mustUnderstan" +
                    "d\"><xs:simpleType><xs:restriction base=\"xs:boolean\"><xs:pattern value=\"0|1\" /></" +
                    "xs:restriction></xs:simpleType></xs:attribute><xs:attribute name=\"actor\" type=\"x" +
                    "s:anyURI\" /><xs:simpleType name=\"encodingStyle\"><xs:annotation><xs:documentation" +
                    ">\'encodingStyle\' indicates any canonicalization conventions followed in the cont" +
                    "ents of the containing element.  For example, the value \'http://schemas.xmlsoap." +
                    "org/soap/encoding/\' indicates the pattern described in SOAP specification</xs:do" +
                    "cumentation></xs:annotation><xs:list itemType=\"xs:anyURI\" /></xs:simpleType><xs:" +
                    "attribute name=\"encodingStyle\" type=\"encodingStyle\" /><xs:attributeGroup name=\"e" +
                    "ncodingStyle\"><xs:attribute ref=\"encodingStyle\" /></xs:attributeGroup><xs:elemen" +
                    "t name=\"Fault\" type=\"Fault\" /><xs:complexType name=\"Fault\" final=\"extension\"><xs" +
                    ":annotation><xs:documentation>Fault reporting structure</xs:documentation></xs:a" +
                    "nnotation><xs:sequence><xs:element name=\"faultcode\" type=\"xs:QName\" /><xs:elemen" +
                    "t name=\"faultstring\" type=\"xs:string\" /><xs:element minOccurs=\"0\" name=\"faultact" +
                    "or\" type=\"xs:anyURI\" /><xs:element minOccurs=\"0\" name=\"detail\" type=\"detail\" /><" +
                    "/xs:sequence></xs:complexType><xs:complexType name=\"detail\"><xs:sequence><xs:any" +
                    " minOccurs=\"0\" maxOccurs=\"unbounded\" namespace=\"##any\" processContents=\"lax\" /><" +
                    "/xs:sequence><xs:anyAttribute namespace=\"##any\" processContents=\"lax\" /></xs:com" +
                    "plexType></xs:schema>", XmlTypeCode.None);
            stracturalPropsInfo.Add(stracturalOutputEnvelope);
            BaseCPRule StracturalRule = new StracturalRule(activity, ExpectedSchema, stracturalPropsInfo);
            activity.AddCheckpointRule(StracturalRule);

            // Checkpoint 2
            IVTDGetter actualValueGetter2 = new VTDXPathGetter(new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrdersResponse'][1]/*[local-name(.)='GetFlightOrdersResult'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='CustomerName'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter2 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection2 = new BindDirection(_flow.StServiceCallActivity4, actualValueGetter2, actualValueSetter2);
            CpValObj valueActualObject2 = new CpValObj(actualBindDirection2, XmlTypeCode.String, false);
            CpValObj valueExpectedObject2 = new CpValObj("John Smith", XmlTypeCode.String);
            ValueCPRule cpRule2 = new ValueCPRule(valueActualObject2, valueExpectedObject2, StringCP.EqualTo, "=", false);

            // Checkpoint 3
            IVTDGetter actualValueGetter3 = new VTDXPathGetter(new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrdersResponse'][1]/*[local-name(.)='GetFlightOrdersResult'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='NumberOfTickets'][1]"), XmlTypeCode.Int, false);
            IVTDSetter actualValueSetter3 = new VTDCheckpointSetter(XmlTypeCode.Int);
            BindDirection actualBindDirection3 = new BindDirection(_flow.StServiceCallActivity4, actualValueGetter3, actualValueSetter3);
            CpValObj valueActualObject3 = new CpValObj(actualBindDirection3, XmlTypeCode.Int, false);
            CpValObj valueExpectedObject3 = new CpValObj("1", XmlTypeCode.Int);
            ValueCPRule cpRule3 = new ValueCPRule(valueActualObject3, valueExpectedObject3, PrimitiveTypeCP.EqualTo, "=", false);

            ArrayElementCPRule arrayElementCPRule1 = new ArrayElementCPRule();
            ArrayBaseCPRule arrayFixedCpRule1 = new ArrayFixedCPRule("/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrdersResponse'][1]/*[local-name(.)='GetFlightOrdersResult'][1]/*[local-name(.)='FlightOrder']", HandlerType.XML);
            arrayElementCPRule1.AddRule(cpRule2);
            arrayElementCPRule1.AddRule(cpRule3);
            arrayFixedCpRule1.AddRule(arrayElementCPRule1);
            activity.AddCheckpointRule(arrayFixedCpRule1);
        }
        
        private void set_StServiceCallActivity5_checkpoints(STActivityBase activity)
        {
            VTDPropertyInfoBase stracturalOutputEnvelope = new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)=\'Envelope\'][1]");
            IList<VTDPropertyInfoBase> stracturalPropsInfo = new List<VTDPropertyInfoBase>();
            CpValObj ExpectedSchema = new CpValObj("<?xml version=\"1.0\" encoding=\"utf-16\"?><xs:schema xmlns=\"http://schemas.xmlsoap.o" +
                    "rg/soap/envelope/\" xmlns:vtd=\"hp.visual_test_designer\" elementFormDefault=\"quali" +
                    "fied\" targetNamespace=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xs=\"http" +
                    "://www.w3.org/2001/XMLSchema\"><xs:import schemaLocation=\"EmbeddedResources/Fligh" +
                    "ts_SO\\webServices\\Flights_SO\\_5.xsd\" namespace=\"HP.SOAQ.SampleApp/Imports\" /><xs" +
                    ":attribute name=\"fullName\" type=\"xs:string\" /><xs:attribute name=\"group\" type=\"x" +
                    "s:string\" /><xs:attribute name=\"serialize\" type=\"xs:string\" /><xs:attribute name" +
                    "=\"argType\" type=\"xs:string\" /><xs:element name=\"Envelope\" type=\"Envelope\" /><xs:" +
                    "complexType name=\"Envelope\"><xs:sequence><xs:element minOccurs=\"0\" ref=\"Header\" " +
                    "/><xs:element minOccurs=\"1\" ref=\"Body\" /></xs:sequence><xs:anyAttribute processC" +
                    "ontents=\"lax\" /></xs:complexType><xs:element name=\"Header\" type=\"Header\" /><xs:c" +
                    "omplexType name=\"Header\"><xs:sequence xmlns=\"\"><xs:any minOccurs=\"0\" maxOccurs=\"" +
                    "unbounded\" processContents=\"lax\" /></xs:sequence><xs:anyAttribute processContent" +
                    "s=\"lax\" /></xs:complexType><xs:element name=\"Body\" type=\"Body\" /><xs:complexType" +
                    " name=\"Body\"><xs:sequence xmlns=\"\"><xs:element xmlns:q1=\"HP.SOAQ.SampleApp\" ref=" +
                    "\"q1:UpdateFlightOrderResponse\" /></xs:sequence><xs:anyAttribute namespace=\"##any" +
                    "\" processContents=\"lax\"><xs:annotation><xs:documentation>Prose in the spec does " +
                    "not specify that attributes are allowed on the Body element</xs:documentation></" +
                    "xs:annotation></xs:anyAttribute></xs:complexType><xs:attribute name=\"mustUnderst" +
                    "and\"><xs:simpleType><xs:restriction base=\"xs:boolean\"><xs:pattern value=\"0|1\" />" +
                    "</xs:restriction></xs:simpleType></xs:attribute><xs:attribute name=\"actor\" type=" +
                    "\"xs:anyURI\" /><xs:simpleType name=\"encodingStyle\"><xs:annotation><xs:documentati" +
                    "on>\'encodingStyle\' indicates any canonicalization conventions followed in the co" +
                    "ntents of the containing element.  For example, the value \'http://schemas.xmlsoa" +
                    "p.org/soap/encoding/\' indicates the pattern described in SOAP specification</xs:" +
                    "documentation></xs:annotation><xs:list itemType=\"xs:anyURI\" /></xs:simpleType><x" +
                    "s:attribute name=\"encodingStyle\" type=\"encodingStyle\" /><xs:attributeGroup name=" +
                    "\"encodingStyle\"><xs:attribute ref=\"encodingStyle\" /></xs:attributeGroup><xs:elem" +
                    "ent name=\"Fault\" type=\"Fault\" /><xs:complexType name=\"Fault\" final=\"extension\"><" +
                    "xs:annotation><xs:documentation>Fault reporting structure</xs:documentation></xs" +
                    ":annotation><xs:sequence><xs:element name=\"faultcode\" type=\"xs:QName\" /><xs:elem" +
                    "ent name=\"faultstring\" type=\"xs:string\" /><xs:element minOccurs=\"0\" name=\"faulta" +
                    "ctor\" type=\"xs:anyURI\" /><xs:element minOccurs=\"0\" name=\"detail\" type=\"detail\" /" +
                    "></xs:sequence></xs:complexType><xs:complexType name=\"detail\"><xs:sequence><xs:a" +
                    "ny minOccurs=\"0\" maxOccurs=\"unbounded\" namespace=\"##any\" processContents=\"lax\" /" +
                    "></xs:sequence><xs:anyAttribute namespace=\"##any\" processContents=\"lax\" /></xs:c" +
                    "omplexType></xs:schema>", XmlTypeCode.None);
            stracturalPropsInfo.Add(stracturalOutputEnvelope);
            BaseCPRule StracturalRule = new StracturalRule(activity, ExpectedSchema, stracturalPropsInfo);
            activity.AddCheckpointRule(StracturalRule);

            // Checkpoint 2
            IVTDGetter actualValueGetter2 = new VTDXPathGetter(new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='UpdateFlightOrderResponse'][1]/*[local-name(.)='UpdateFlightOrderResult'][1]"), XmlTypeCode.Boolean, false);
            IVTDSetter actualValueSetter2 = new VTDCheckpointSetter(XmlTypeCode.Boolean);
            BindDirection actualBindDirection2 = new BindDirection(_flow.StServiceCallActivity5, actualValueGetter2, actualValueSetter2);
            CpValObj valueActualObject2 = new CpValObj(actualBindDirection2, XmlTypeCode.Boolean, false);
            CpValObj valueExpectedObject2 = new CpValObj("true", XmlTypeCode.Boolean);
            ValueCPRule cpRule2 = new ValueCPRule(valueActualObject2, valueExpectedObject2, PrimitiveTypeCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule2);

        }
    }
}
