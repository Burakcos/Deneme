﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;
using System.Web;
using System.Web.Caching;
using System.Web.Configuration;
using System.Web.Security;

namespace AssetManagment.Data
{
	public enum DataFieldMaskType
    {
        
        None,
        
        Date,
        
        Number,
        
        Time,
        
        DateTime,
    }
    
    public enum DataFieldAggregate
    {
        
        None,
        
        Sum,
        
        Count,
        
        Average,
        
        Max,
        
        Min,
    }
    
    public enum OnDemandDisplayStyle
    {
        
        Thumbnail,
        
        Link,
    }
    
    public enum TextInputMode
    {
        
        Text,
        
        Password,
        
        RichText,
        
        Note,
        
        Static,
    }
    
    public enum FieldSearchMode
    {
        
        Default,
        
        Required,
        
        Suggested,
        
        Allowed,
        
        Forbidden,
    }
    
    public class DataField
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _aliasName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tag;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _type;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int _len;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _label;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _isPrimaryKey;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _readOnly;
        
        private string _defaultValue;
        
        private string _headerText;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _footerText;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _toolTip;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _watermark;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _hidden;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _allowQBE;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _allowSorting;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _allowLEV;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dataFormatString;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _copy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _hyperlinkFormatString;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _formatOnClient;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sourceFields;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int _categoryIndex;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _allowNulls;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int _columns;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int _rows;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _onDemand;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private FieldSearchMode _search;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _searchOptions;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ıtemsDataController;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ıtemsDataView;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ıtemsDataValueField;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ıtemsDataTextField;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ıtemsStyle;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int _ıtemsPageSize;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ıtemsNewDataView;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _ıtemsLetters;
        
        private List<object[]> _items;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DataFieldAggregate _aggregate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _onDemandHandler;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private OnDemandDisplayStyle _onDemandStyle;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private TextInputMode _textMode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DataFieldMaskType _maskType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mask;
        
        private string _contextFields;
        
        private string _selectExpression;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formula;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _showInSummary;
        
        private bool _isMirror;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _htmlEncode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int _autoCompletePrefixLength;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _calculated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _configuration;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _editor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _autoSelect;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool _searchOnStart;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ıtemsDescription;
        
        public DataField()
        {
            _items = new List<object[]>();
            _formatOnClient = true;
        }
        
        public DataField(XPathNavigator field, IXmlNamespaceResolver nm) : 
                this()
        {
            this._name = field.GetAttribute("name", String.Empty);
            this._type = field.GetAttribute("type", String.Empty);
            string l = field.GetAttribute("length", String.Empty);
            if (!(String.IsNullOrEmpty(l)))
            	_len = Convert.ToInt32(l);
            this._label = field.GetAttribute("label", String.Empty);
            this._isPrimaryKey = (field.GetAttribute("isPrimaryKey", String.Empty) == "true");
            this._readOnly = (field.GetAttribute("readOnly", String.Empty) == "true");
            this._onDemand = (field.GetAttribute("onDemand", String.Empty) == "true");
            this._defaultValue = field.GetAttribute("default", String.Empty);
            this._allowNulls = !((field.GetAttribute("allowNulls", String.Empty) == "false"));
            this._hidden = (field.GetAttribute("hidden", String.Empty) == "true");
            this._allowQBE = !((field.GetAttribute("allowQBE", String.Empty) == "false"));
            this._allowLEV = (field.GetAttribute("allowLEV", String.Empty) == "true");
            this._allowSorting = !((field.GetAttribute("allowSorting", String.Empty) == "false"));
            this._sourceFields = field.GetAttribute("sourceFields", String.Empty);
            if (field.GetAttribute("onDemandStyle", String.Empty) == "Link")
            	this._onDemandStyle = OnDemandDisplayStyle.Link;
            this._onDemandHandler = field.GetAttribute("onDemandHandler", String.Empty);
            this._contextFields = field.GetAttribute("contextFields", String.Empty);
            this._selectExpression = field.GetAttribute("select", String.Empty);
            bool computed = (field.GetAttribute("computed", String.Empty) == "true");
            if (computed)
            {
                _formula = ((string)(field.Evaluate("string(self::c:field/c:formula)", nm)));
                if (String.IsNullOrEmpty(_formula))
                	_formula = "null";
            }
            this._showInSummary = (field.GetAttribute("showInSummary", String.Empty) == "true");
            this._htmlEncode = !((field.GetAttribute("htmlEncode", String.Empty) == "false"));
            _calculated = (field.GetAttribute("calculated", String.Empty) == "true");
            this._configuration = ((string)(field.Evaluate("string(self::c:field/c:configuration)", nm)));
            this._dataFormatString = field.GetAttribute("dataFormatString", String.Empty);
            _formatOnClient = !((field.GetAttribute("formatOnClient", String.Empty) == "false"));
            string editor = field.GetAttribute("editor", String.Empty);
            if (!(String.IsNullOrEmpty(editor)))
            	_editor = editor;
        }
        
        public DataField(XPathNavigator field, IXmlNamespaceResolver nm, bool hidden) : 
                this(field, nm)
        {
            this._hidden = hidden;
        }
        
        public DataField(DataField field) : 
                this()
        {
            this._isMirror = true;
            this._name = (field.Name + "_Mirror");
            this._type = field.Type;
            this._len = field.Len;
            this._label = field.Label;
            this._readOnly = true;
            this._allowNulls = field.AllowNulls;
            this._allowQBE = field.AllowQBE;
            this._allowSorting = field.AllowSorting;
            this._allowLEV = field.AllowLEV;
            this._dataFormatString = field.DataFormatString;
            this._aggregate = field.Aggregate;
            if (!(this._dataFormatString.Contains("{")))
            	this._dataFormatString = String.Format("{{0:{0}}}", this._dataFormatString);
            field._aliasName = this._name;
            this.FormatOnClient = false;
            field.FormatOnClient = true;
            field.DataFormatString = String.Empty;
            this._hidden = true;
        }
        
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public string AliasName
        {
            get
            {
                return this._aliasName;
            }
            set
            {
                this._aliasName = value;
            }
        }
        
        public string Tag
        {
            get
            {
                return this._tag;
            }
            set
            {
                this._tag = value;
            }
        }
        
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        public int Len
        {
            get
            {
                return this._len;
            }
            set
            {
                this._len = value;
            }
        }
        
        public string Label
        {
            get
            {
                return this._label;
            }
            set
            {
                this._label = value;
            }
        }
        
        public bool IsPrimaryKey
        {
            get
            {
                return this._isPrimaryKey;
            }
            set
            {
                this._isPrimaryKey = value;
            }
        }
        
        public bool ReadOnly
        {
            get
            {
                return this._readOnly;
            }
            set
            {
                this._readOnly = value;
            }
        }
        
        public string DefaultValue
        {
            get
            {
                return _defaultValue;
            }
        }
        
        public bool HasDefaultValue
        {
            get
            {
                return !(String.IsNullOrEmpty(_defaultValue));
            }
        }
        
        public string HeaderText
        {
            get
            {
                return _headerText;
            }
            set
            {
                _headerText = value;
                if (!(String.IsNullOrEmpty(value)) && String.IsNullOrEmpty(_label))
                	_label = value;
            }
        }
        
        public string FooterText
        {
            get
            {
                return this._footerText;
            }
            set
            {
                this._footerText = value;
            }
        }
        
        public string ToolTip
        {
            get
            {
                return this._toolTip;
            }
            set
            {
                this._toolTip = value;
            }
        }
        
        public string Watermark
        {
            get
            {
                return this._watermark;
            }
            set
            {
                this._watermark = value;
            }
        }
        
        public bool Hidden
        {
            get
            {
                return this._hidden;
            }
            set
            {
                this._hidden = value;
            }
        }
        
        public bool AllowQBE
        {
            get
            {
                return this._allowQBE;
            }
            set
            {
                this._allowQBE = value;
            }
        }
        
        public bool AllowSorting
        {
            get
            {
                return this._allowSorting;
            }
            set
            {
                this._allowSorting = value;
            }
        }
        
        public bool AllowLEV
        {
            get
            {
                return this._allowLEV;
            }
            set
            {
                this._allowLEV = value;
            }
        }
        
        public string DataFormatString
        {
            get
            {
                return this._dataFormatString;
            }
            set
            {
                this._dataFormatString = value;
            }
        }
        
        public string Copy
        {
            get
            {
                return this._copy;
            }
            set
            {
                this._copy = value;
            }
        }
        
        public string HyperlinkFormatString
        {
            get
            {
                return this._hyperlinkFormatString;
            }
            set
            {
                this._hyperlinkFormatString = value;
            }
        }
        
        public bool FormatOnClient
        {
            get
            {
                return this._formatOnClient;
            }
            set
            {
                this._formatOnClient = value;
            }
        }
        
        public string SourceFields
        {
            get
            {
                return this._sourceFields;
            }
            set
            {
                this._sourceFields = value;
            }
        }
        
        public int CategoryIndex
        {
            get
            {
                return this._categoryIndex;
            }
            set
            {
                this._categoryIndex = value;
            }
        }
        
        public bool AllowNulls
        {
            get
            {
                return this._allowNulls;
            }
            set
            {
                this._allowNulls = value;
            }
        }
        
        public int Columns
        {
            get
            {
                return this._columns;
            }
            set
            {
                this._columns = value;
            }
        }
        
        public int Rows
        {
            get
            {
                return this._rows;
            }
            set
            {
                this._rows = value;
            }
        }
        
        public bool OnDemand
        {
            get
            {
                return this._onDemand;
            }
            set
            {
                this._onDemand = value;
            }
        }
        
        public FieldSearchMode Search
        {
            get
            {
                return this._search;
            }
            set
            {
                this._search = value;
            }
        }
        
        public virtual string SearchOptions
        {
            get
            {
                return this._searchOptions;
            }
            set
            {
                this._searchOptions = value;
            }
        }
        
        public string ItemsDataController
        {
            get
            {
                return this._ıtemsDataController;
            }
            set
            {
                this._ıtemsDataController = value;
            }
        }
        
        public string ItemsDataView
        {
            get
            {
                return this._ıtemsDataView;
            }
            set
            {
                this._ıtemsDataView = value;
            }
        }
        
        public string ItemsDataValueField
        {
            get
            {
                return this._ıtemsDataValueField;
            }
            set
            {
                this._ıtemsDataValueField = value;
            }
        }
        
        public string ItemsDataTextField
        {
            get
            {
                return this._ıtemsDataTextField;
            }
            set
            {
                this._ıtemsDataTextField = value;
            }
        }
        
        public string ItemsStyle
        {
            get
            {
                return this._ıtemsStyle;
            }
            set
            {
                this._ıtemsStyle = value;
            }
        }
        
        public int ItemsPageSize
        {
            get
            {
                return this._ıtemsPageSize;
            }
            set
            {
                this._ıtemsPageSize = value;
            }
        }
        
        public string ItemsNewDataView
        {
            get
            {
                return this._ıtemsNewDataView;
            }
            set
            {
                this._ıtemsNewDataView = value;
            }
        }
        
        public bool ItemsLetters
        {
            get
            {
                return this._ıtemsLetters;
            }
            set
            {
                this._ıtemsLetters = value;
            }
        }
        
        public List<object[]> Items
        {
            get
            {
                return _items;
            }
        }
        
        public DataFieldAggregate Aggregate
        {
            get
            {
                return this._aggregate;
            }
            set
            {
                this._aggregate = value;
            }
        }
        
        public string OnDemandHandler
        {
            get
            {
                return this._onDemandHandler;
            }
            set
            {
                this._onDemandHandler = value;
            }
        }
        
        public OnDemandDisplayStyle OnDemandStyle
        {
            get
            {
                return this._onDemandStyle;
            }
            set
            {
                this._onDemandStyle = value;
            }
        }
        
        public TextInputMode TextMode
        {
            get
            {
                return this._textMode;
            }
            set
            {
                this._textMode = value;
            }
        }
        
        public DataFieldMaskType MaskType
        {
            get
            {
                return this._maskType;
            }
            set
            {
                this._maskType = value;
            }
        }
        
        public string Mask
        {
            get
            {
                return this._mask;
            }
            set
            {
                this._mask = value;
            }
        }
        
        public string ContextFields
        {
            get
            {
                return _contextFields;
            }
        }
        
        public string Formula
        {
            get
            {
                return this._formula;
            }
            set
            {
                this._formula = value;
            }
        }
        
        public bool ShowInSummary
        {
            get
            {
                return this._showInSummary;
            }
            set
            {
                this._showInSummary = value;
            }
        }
        
        public bool IsMirror
        {
            get
            {
                return _isMirror;
            }
        }
        
        public bool HtmlEncode
        {
            get
            {
                return this._htmlEncode;
            }
            set
            {
                this._htmlEncode = value;
            }
        }
        
        public int AutoCompletePrefixLength
        {
            get
            {
                return this._autoCompletePrefixLength;
            }
            set
            {
                this._autoCompletePrefixLength = value;
            }
        }
        
        public bool Calculated
        {
            get
            {
                return this._calculated;
            }
            set
            {
                this._calculated = value;
            }
        }
        
        public string Configuration
        {
            get
            {
                return this._configuration;
            }
            set
            {
                this._configuration = value;
            }
        }
        
        public string Editor
        {
            get
            {
                return this._editor;
            }
            set
            {
                this._editor = value;
            }
        }
        
        public bool AutoSelect
        {
            get
            {
                return this._autoSelect;
            }
            set
            {
                this._autoSelect = value;
            }
        }
        
        public bool SearchOnStart
        {
            get
            {
                return this._searchOnStart;
            }
            set
            {
                this._searchOnStart = value;
            }
        }
        
        public string ItemsDescription
        {
            get
            {
                return this._ıtemsDescription;
            }
            set
            {
                this._ıtemsDescription = value;
            }
        }
        
        public string SelectExpression()
        {
            return _selectExpression;
        }
        
        public void NormalizeDataFormatString()
        {
            if (!(String.IsNullOrEmpty(_dataFormatString)))
            {
                string fmt = _dataFormatString;
                if (!(fmt.Contains("{")))
                	_dataFormatString = String.Format("{{0:{0}}}", fmt);
            }
            else
            	if (_type == "DateTime")
                	_dataFormatString = "{0:d}";
        }
        
        public string ExpressionName()
        {
            if (IsMirror)
            	return Name.Substring(0, (Name.Length - "_Mirror".Length));
            return Name;
        }
        
        public bool SupportsStaticItems()
        {
            return (!(String.IsNullOrEmpty(ItemsDataController)) && !(((ItemsStyle == "AutoComplete") || (ItemsStyle == "Lookup"))));
        }
        
        public override string ToString()
        {
            if (!(String.IsNullOrEmpty(Formula)))
            	return String.Format("{0} as {1}; SQL: {2}", Name, Type, Formula);
            else
            	return String.Format("{0} as {1}", Name, Type);
        }
        
        public bool IsTagged(string tag)
        {
            if (String.IsNullOrEmpty(this.Tag))
            	return false;
            return this.Tag.Contains(tag);
        }
    }
}
