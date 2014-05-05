using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AddressType
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _addressTypeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addressCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addressName;
        
        public AddressType()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? AddressTypeId
        {
            get
            {
                return _addressTypeId;
            }
            set
            {
                _addressTypeId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AddressCode
        {
            get
            {
                return _addressCode;
            }
            set
            {
                _addressCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AddressName
        {
            get
            {
                return _addressName;
            }
            set
            {
                _addressName = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.AddressType> Select(int? addressTypeId, string addressCode, string addressName)
        {
            return new AddressTypeFactory().Select(addressTypeId, addressCode, addressName);
        }
        
        public static List<AssetManagment.Data.Objects.AddressType> Select(AssetManagment.Data.Objects.AddressType qbe)
        {
            return new AddressTypeFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.AddressType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AddressTypeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.AddressType> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AddressTypeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.AddressType> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AddressTypeFactory().Select(filter, sort, AddressTypeFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.AddressType> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AddressTypeFactory().Select(filter, sort, AddressTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.AddressType> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AddressTypeFactory().Select(filter, null, AddressTypeFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.AddressType> Select(string filter, params FieldValue[] parameters)
        {
            return new AddressTypeFactory().Select(filter, null, AddressTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.AddressType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AddressTypeFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.AddressType SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AddressTypeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.AddressType SelectSingle(int? addressTypeId)
        {
            return new AddressTypeFactory().SelectSingle(addressTypeId);
        }
        
        public int Insert()
        {
            return new AddressTypeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AddressTypeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AddressTypeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AddressTypeId: {0}", this.AddressTypeId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AddressTypeFactory
    {
        
        public AddressTypeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AddressType");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AddressType");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AddressType");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AddressType");
            }
        }
        
        public static AddressTypeFactory Create()
        {
            return new AddressTypeFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? addressTypeId, string addressCode, string addressName, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (addressTypeId.HasValue)
            	filter.Add(("AddressTypeId:=" + addressTypeId.Value.ToString()));
            if (!(String.IsNullOrEmpty(addressCode)))
            	filter.Add(("AddressCode:*" + addressCode));
            if (!(String.IsNullOrEmpty(addressName)))
            	filter.Add(("AddressName:*" + addressName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.AddressType> Select(int? addressTypeId, string addressCode, string addressName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(addressTypeId, addressCode, addressName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AddressType", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.AddressType>();
        }
        
        public List<AssetManagment.Data.Objects.AddressType> Select(AssetManagment.Data.Objects.AddressType qbe)
        {
            return Select(qbe.AddressTypeId, qbe.AddressCode, qbe.AddressName);
        }
        
        public int SelectCount(int? addressTypeId, string addressCode, string addressName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(addressTypeId, addressCode, addressName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AddressType", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.AddressType> Select(int? addressTypeId, string addressCode, string addressName)
        {
            return Select(addressTypeId, addressCode, addressName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.AddressType SelectSingle(int? addressTypeId)
        {
            string emptyAddressCode = null;
            string emptyAddressName = null;
            List<AssetManagment.Data.Objects.AddressType> list = Select(addressTypeId, emptyAddressCode, emptyAddressName);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.AddressType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AddressType", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.AddressType>();
        }
        
        public List<AssetManagment.Data.Objects.AddressType> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.AddressType> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.AddressType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.AddressType> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.AddressType theAddressType, AssetManagment.Data.Objects.AddressType original_AddressType)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AddressTypeId", original_AddressType.AddressTypeId, theAddressType.AddressTypeId));
            values.Add(new FieldValue("AddressCode", original_AddressType.AddressCode, theAddressType.AddressCode));
            values.Add(new FieldValue("AddressName", original_AddressType.AddressName, theAddressType.AddressName));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.AddressType theAddressType, AssetManagment.Data.Objects.AddressType original_AddressType, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AddressType";
            args.View = dataView;
            args.Values = CreateFieldValues(theAddressType, original_AddressType);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AddressType", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAddressType);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.AddressType theAddressType, AssetManagment.Data.Objects.AddressType original_AddressType)
        {
            return ExecuteAction(theAddressType, original_AddressType, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.AddressType theAddressType)
        {
            return Update(theAddressType, SelectSingle(theAddressType.AddressTypeId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.AddressType theAddressType)
        {
            return ExecuteAction(theAddressType, new AddressType(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.AddressType theAddressType)
        {
            return ExecuteAction(theAddressType, theAddressType, "Select", "Delete", DeleteView);
        }
    }
}
