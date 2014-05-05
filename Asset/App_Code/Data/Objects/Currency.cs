using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Currency
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _currencyId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currencyShortName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currencyName;
        
        public Currency()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? CurrencyId
        {
            get
            {
                return _currencyId;
            }
            set
            {
                _currencyId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrencyShortName
        {
            get
            {
                return _currencyShortName;
            }
            set
            {
                _currencyShortName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrencyName
        {
            get
            {
                return _currencyName;
            }
            set
            {
                _currencyName = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.Currency> Select(int? currencyId, string currencyShortName, string currencyName)
        {
            return new CurrencyFactory().Select(currencyId, currencyShortName, currencyName);
        }
        
        public static List<AssetManagment.Data.Objects.Currency> Select(AssetManagment.Data.Objects.Currency qbe)
        {
            return new CurrencyFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.Currency> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CurrencyFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Currency> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CurrencyFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Currency> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CurrencyFactory().Select(filter, sort, CurrencyFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Currency> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CurrencyFactory().Select(filter, sort, CurrencyFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Currency> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CurrencyFactory().Select(filter, null, CurrencyFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Currency> Select(string filter, params FieldValue[] parameters)
        {
            return new CurrencyFactory().Select(filter, null, CurrencyFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Currency SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CurrencyFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.Currency SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CurrencyFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Currency SelectSingle(int? currencyId)
        {
            return new CurrencyFactory().SelectSingle(currencyId);
        }
        
        public int Insert()
        {
            return new CurrencyFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CurrencyFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CurrencyFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CurrencyId: {0}", this.CurrencyId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CurrencyFactory
    {
        
        public CurrencyFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Currency");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Currency");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Currency");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Currency");
            }
        }
        
        public static CurrencyFactory Create()
        {
            return new CurrencyFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? currencyId, string currencyShortName, string currencyName, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (currencyId.HasValue)
            	filter.Add(("CurrencyId:=" + currencyId.Value.ToString()));
            if (!(String.IsNullOrEmpty(currencyShortName)))
            	filter.Add(("CurrencyShortName:*" + currencyShortName));
            if (!(String.IsNullOrEmpty(currencyName)))
            	filter.Add(("CurrencyName:*" + currencyName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.Currency> Select(int? currencyId, string currencyShortName, string currencyName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(currencyId, currencyShortName, currencyName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Currency", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Currency>();
        }
        
        public List<AssetManagment.Data.Objects.Currency> Select(AssetManagment.Data.Objects.Currency qbe)
        {
            return Select(qbe.CurrencyId, qbe.CurrencyShortName, qbe.CurrencyName);
        }
        
        public int SelectCount(int? currencyId, string currencyShortName, string currencyName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(currencyId, currencyShortName, currencyName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Currency", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.Currency> Select(int? currencyId, string currencyShortName, string currencyName)
        {
            return Select(currencyId, currencyShortName, currencyName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.Currency SelectSingle(int? currencyId)
        {
            string emptyCurrencyShortName = null;
            string emptyCurrencyName = null;
            List<AssetManagment.Data.Objects.Currency> list = Select(currencyId, emptyCurrencyShortName, emptyCurrencyName);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.Currency> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Currency", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Currency>();
        }
        
        public List<AssetManagment.Data.Objects.Currency> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.Currency> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.Currency SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.Currency> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.Currency theCurrency, AssetManagment.Data.Objects.Currency original_Currency)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CurrencyId", original_Currency.CurrencyId, theCurrency.CurrencyId));
            values.Add(new FieldValue("CurrencyShortName", original_Currency.CurrencyShortName, theCurrency.CurrencyShortName));
            values.Add(new FieldValue("CurrencyName", original_Currency.CurrencyName, theCurrency.CurrencyName));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.Currency theCurrency, AssetManagment.Data.Objects.Currency original_Currency, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Currency";
            args.View = dataView;
            args.Values = CreateFieldValues(theCurrency, original_Currency);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Currency", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCurrency);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.Currency theCurrency, AssetManagment.Data.Objects.Currency original_Currency)
        {
            return ExecuteAction(theCurrency, original_Currency, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.Currency theCurrency)
        {
            return Update(theCurrency, SelectSingle(theCurrency.CurrencyId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.Currency theCurrency)
        {
            return ExecuteAction(theCurrency, new Currency(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.Currency theCurrency)
        {
            return ExecuteAction(theCurrency, theCurrency, "Select", "Delete", DeleteView);
        }
    }
}
