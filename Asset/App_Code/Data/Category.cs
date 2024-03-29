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
	public class Category
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _id;
        
        private int _index;
        
        private string _headerText;
        
        private string _description;
        
        private bool _newColumn;
        
        private string _tab;
        
        private string _template;
        
        private bool _floating;
        
        private bool _collapsed;
        
        public Category()
        {
        }
        
        public Category(XPathNavigator category, IXmlNamespaceResolver resolver)
        {
            this.Id = category.GetAttribute("id", String.Empty);
            this._index = Convert.ToInt32(category.Evaluate("count(preceding-sibling::c:category)", resolver));
            this._headerText = ((string)(category.GetAttribute("headerText", String.Empty)));
            this._description = ((string)(category.Evaluate("string(c:description)", resolver))).Trim();
            _tab = category.GetAttribute("tab", String.Empty);
            _newColumn = (category.GetAttribute("newColumn", String.Empty) == "true");
            _template = ((string)(category.Evaluate("string(c:template)", resolver)));
            _floating = (category.GetAttribute("floating", String.Empty) == "true");
            _collapsed = (category.GetAttribute("collapsed", String.Empty) == "true");
        }
        
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        public int Index
        {
            get
            {
                return _index;
            }
        }
        
        public string HeaderText
        {
            get
            {
                return _headerText;
            }
        }
        
        public string Description
        {
            get
            {
                return _description;
            }
        }
        
        public bool NewColumn
        {
            get
            {
                return _newColumn;
            }
            set
            {
                _newColumn = value;
            }
        }
        
        public string Tab
        {
            get
            {
                return _tab;
            }
            set
            {
                _tab = value;
            }
        }
        
        public string Template
        {
            get
            {
                return _template;
            }
            set
            {
                _template = value;
            }
        }
        
        public bool Floating
        {
            get
            {
                return _floating;
            }
            set
            {
                _floating = value;
            }
        }
        
        public bool Collapsed
        {
            get
            {
                return _collapsed;
            }
            set
            {
                _collapsed = value;
            }
        }
    }
}
