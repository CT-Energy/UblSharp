// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UblSharp.CommonAggregateComponents;
    using UblSharp.UnqualifiedDataTypes;
    using UblSharp.CommonExtensionComponents;
    
    
    /// <summary>
    /// A wrapper that allows a document of any kind to be packaged with the UBL document that references it.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Attached Document. Details
    /// <para />ObjectClass: Attached Document
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AttachedDocument", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:AttachedDocument-2")]
    [System.Xml.Serialization.XmlRootAttribute("AttachedDocument", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:AttachedDocument-2", IsNullable=false)]
    public partial class AttachedDocumentType : BaseDocument, IBaseDocument
    {
        
        private System.Collections.Generic.List<UBLExtensionType> _uBLExtensions;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] @__UBLExtensions
        {
            get
            {
                return _uBLExtensions?.ToArray();
            }
            set
            {
                _uBLExtensions = value == null ? null : new System.Collections.Generic.List<UBLExtensionType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public IdentifierType @__UBLVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IdentifierType @__CustomizationID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public IdentifierType @__ProfileID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public IdentifierType @__ProfileExecutionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public TimeType @__IssueTime;
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public TextType[] @__Note
        {
            get
            {
                return _note?.ToArray();
            }
            set
            {
                _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public CodeType @__DocumentTypeCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public TextType @__DocumentType;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ParentDocumentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public IdentifierType @__ParentDocumentID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ParentDocumentTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public CodeType @__ParentDocumentTypeCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ParentDocumentVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
        public IdentifierType @__ParentDocumentVersionID;
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=15)]
        public SignatureType[] @__Signature
        {
            get
            {
                return _signature?.ToArray();
            }
            set
            {
                _signature = value == null ? null : new System.Collections.Generic.List<SignatureType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=16)]
        public PartyType @__SenderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public AttachmentType @__Attachment;
        
        private System.Collections.Generic.List<LineReferenceType> _parentDocumentLineReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ParentDocumentLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public LineReferenceType[] @__ParentDocumentLineReference
        {
            get
            {
                return _parentDocumentLineReference?.ToArray();
            }
            set
            {
                _parentDocumentLineReference = value == null ? null : new System.Collections.Generic.List<LineReferenceType>(value);
            }
        }
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<UBLExtensionType> IBaseDocument.UBLExtensions
        {
            get { return _uBLExtensions ?? (_uBLExtensions = new System.Collections.Generic.List<UBLExtensionType>()); }
            set { _uBLExtensions = value; }
        }

        
        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
            set { _note = value; }
        }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Attached Document. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<SignatureType> IBaseDocument.Signature
        {
            get { return _signature ?? (_signature = new System.Collections.Generic.List<SignatureType>()); }
            set { _signature = value; }
        }

        
        /// <summary>
        /// A reference to a line in the attached document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Attached Document. Parent Document_ Line Reference. Line Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTermQualifier: Parent Document
        /// <para />PropertyTerm: Line Reference
        /// <para />AssociatedObjectClass: Line Reference
        /// <para />RepresentationTerm: Line Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<LineReferenceType> ParentDocumentLineReference
        {
            get { return _parentDocumentLineReference ?? (_parentDocumentLineReference = new System.Collections.Generic.List<LineReferenceType>()); }
            set { _parentDocumentLineReference = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>2.0.5</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UBLVersionID
        {
            get
            {
                if (__UBLVersionID == null) { __UBLVersionID = new IdentifierType(); }
                return __UBLVersionID;
            }
            set
            {
                __UBLVersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>NES</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.CustomizationID
        {
            get
            {
                if (__CustomizationID == null) { __CustomizationID = new IdentifierType(); }
                return __CustomizationID;
            }
            set
            {
                __CustomizationID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined profile of the customization of UBL being used.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BasicProcurementProcess</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileID
        {
            get
            {
                if (__ProfileID == null) { __ProfileID = new IdentifierType(); }
                return __ProfileID;
            }
            set
            {
                __ProfileID = value;
            }
        }

        
        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileExecutionID
        {
            get
            {
                if (__ProfileExecutionID == null) { __ProfileExecutionID = new IdentifierType(); }
                return __ProfileExecutionID;
            }
            set
            {
                __ProfileExecutionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ID
        {
            get
            {
                if (__ID == null) { __ID = new IdentifierType(); }
                return __ID;
            }
            set
            {
                __ID = value;
            }
        }

        
        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UUID
        {
            get
            {
                if (__UUID == null) { __UUID = new IdentifierType(); }
                return __UUID;
            }
            set
            {
                __UUID = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        
        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        
        /// <summary>
        /// A code signifying the type of document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Document Type Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Document Type Code
        /// <para />RepresentationTerm: Code
        /// <para />DataType: Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType DocumentTypeCode
        {
            get
            {
                if (__DocumentTypeCode == null) { __DocumentTypeCode = new CodeType(); }
                return __DocumentTypeCode;
            }
            set
            {
                __DocumentTypeCode = value;
            }
        }

        
        /// <summary>
        /// Text specifying the type of document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Document Type. Text
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Document Type
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TextType DocumentType
        {
            get
            {
                if (__DocumentType == null) { __DocumentType = new TextType(); }
                return __DocumentType;
            }
            set
            {
                __DocumentType = value;
            }
        }

        
        /// <summary>
        /// The Identifier of the parent document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Parent_ Document Identifier. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTermQualifier: Parent
        /// <para />PropertyTerm: Document Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ParentDocumentID
        {
            get
            {
                if (__ParentDocumentID == null) { __ParentDocumentID = new IdentifierType(); }
                return __ParentDocumentID;
            }
            set
            {
                __ParentDocumentID = value;
            }
        }

        
        /// <summary>
        /// A code signifying the type of parent document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Parent_ Document Type Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTermQualifier: Parent
        /// <para />PropertyTerm: Document Type Code
        /// <para />RepresentationTerm: Code
        /// <para />DataType: Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType ParentDocumentTypeCode
        {
            get
            {
                if (__ParentDocumentTypeCode == null) { __ParentDocumentTypeCode = new CodeType(); }
                return __ParentDocumentTypeCode;
            }
            set
            {
                __ParentDocumentTypeCode = value;
            }
        }

        
        /// <summary>
        /// Indicates the current version of the referred document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Attached Document. Parent Document_ Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTermQualifier: Parent Document
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>1.1</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ParentDocumentVersionID
        {
            get
            {
                if (__ParentDocumentVersionID == null) { __ParentDocumentVersionID = new IdentifierType(); }
                return __ParentDocumentVersionID;
            }
            set
            {
                __ParentDocumentVersionID = value;
            }
        }

        
        /// <summary>
        /// The party sending this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Attached Document. Sender_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTermQualifier: Sender
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType SenderParty
        {
            get
            {
                if (__SenderParty == null) { __SenderParty = new PartyType(); }
                return __SenderParty;
            }
            set
            {
                __SenderParty = value;
            }
        }

        
        /// <summary>
        /// The party receiving this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Attached Document. Receiver_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTermQualifier: Receiver
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ReceiverParty
        {
            get
            {
                if (__ReceiverParty == null) { __ReceiverParty = new PartyType(); }
                return __ReceiverParty;
            }
            set
            {
                __ReceiverParty = value;
            }
        }

        
        /// <summary>
        /// An attachment containing the document content.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Attached Document. Attachment
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Attached Document
        /// <para />PropertyTerm: Attachment
        /// <para />AssociatedObjectClass: Attachment
        /// <para />RepresentationTerm: Attachment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public AttachmentType Attachment
        {
            get
            {
                if (__Attachment == null) { __Attachment = new AttachmentType(); }
                return __Attachment;
            }
            set
            {
                __Attachment = value;
            }
        }

    }
}
