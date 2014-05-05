using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Address
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _addressId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _addrressTypeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addrressTypeAddressCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        public Address()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? AddressId
        {
            get
            {
                return _addressId;
            }
            set
            {
                _addressId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AddrressTypeId
        {
            get
            {
                return _addrressTypeId;
            }
            set
            {
                _addrressTypeId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AddrressTypeAddressCode
        {
            get
            {
                return _addrressTypeAddressCode;
            }
            set
            {
                _addrressTypeAddressCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Address_
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.Address> Select(int? addressId, int? addrressTypeId, string addrressTypeAddressCode, string address)
        {
            return new AddressFactory().Select(addressId, addrressTypeId, addrressTypeAddressCode, address);
        }
        
        public static List<AssetManagment.Data.Objects.Address> Select(AssetManagment.Data.Objects.Address qbe)
        {
            return new AddressFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.Address> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AddressFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Address> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AddressFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Address> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AddressFactory().Select(filter, sort, AddressFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Address> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AddressFactory().Select(filter, sort, AddressFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Address> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AddressFactory().Select(filter, null, AddressFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Address> Select(string filter, params FieldValue[] parameters)
        {
            return new AddressFactory().Select(filter, null, AddressFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Address SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AddressFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.Address SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AddressFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Address SelectSingle(int? addressId)
        {
            return new AddressFactory().SelectSingle(addressId);
        }
        
        public int Insert()
        {
            return new AddressFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AddressFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AddressFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AddressId: {0}", this.AddressId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AddressFactory
    {
        
        public AddressFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Address");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Address");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Address");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Address");
            }
        }
        
        public static AddressFactory Create()
        {
            return new AddressFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? addressId, int? addrressTypeId, string addrressTypeAddressCode, string address, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (addressId.HasValue)
            	filter.Add(("AddressId:=" + addressId.Value.ToString()));
            if (addrressTypeId.HasValue)
            	filter.Add(("AddrressTypeId:=" + addrressTypeId.Value.ToString()));
            if (!(String.IsNullOrEmpty(addrressTypeAddressCode)))
            	filter.Add(("AddrressTypeAddressCode:*" + addrressTypeAddressCode));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.Address> Select(int? addressId, int? addrressTypeId, string addrressTypeAddressCode, string address, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(addressId, addrressTypeId, addrressTypeAddressCode, address, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Address", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Address>();
        }
        
        public List<AssetManagment.Data.Objects.Address> Select(AssetManagment.Data.Objects.Address qbe)
        {
            return Select(qbe.AddressId, qbe.AddrressTypeId, qbe.AddrressTypeAddressCode, qbe.Address_);
        }
        
        public int SelectCount(int? addressId, int? addrressTypeId, string addrressTypeAddressCode, string address, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(addressId, addrressTypeId, addrressTypeAddressCode, address, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Address", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.Address> Select(int? addressId, int? addrressTypeId, string addrressTypeAddressCode, string address)
        {
            return Select(addressId, addrressTypeId, addrressTypeAddressCode, address, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.Address SelectSingle(int? addressId)
        {
            int? emptyAddrressTypeId = null;
            string emptyAddrressTypeAddressCode = null;
            string emptyAddress = null;
            List<AssetManagment.Data.Objects.Address> list = Select(addressId, emptyAddrressTypeId, emptyAddrressTypeAddressCode, emptyAddress);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.Address> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Address", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Address>();
        }
        
        public List<AssetManagment.Data.Objects.Address> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.Address> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.Address SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.Address> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.Address theAddress, AssetManagment.Data.Objects.Address original_Address)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AddressId", original_Address.AddressId, theAddress.AddressId, true));
            values.Add(new FieldValue("AddrressTypeId", original_Address.AddrressTypeId, theAddress.AddrressTypeId));
            values.Add(new FieldValue("AddrressTypeAddressCode", original_Address.AddrressTypeAddressCode, theAddress.AddrressTypeAddressCode, true));
            values.Add(new FieldValue("Address", original_Address.Address_, theAddress.Address_));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.Address theAddress, AssetManagment.Data.Objects.Address original_Address, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Address";
            args.View = dataView;
            args.Values = CreateFieldValues(theAddress, original_Address);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Address", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAddress);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.Address theAddress, AssetManagment.Data.Objects.Address original_Address)
        {
            return ExecuteAction(theAddress, original_Address, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.Address theAddress)
        {
            return Update(theAddress, SelectSingle(theAddress.AddressId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.Address theAddress)
        {
            return ExecuteAction(theAddress, new Address(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.Address theAddress)
        {
            return ExecuteAction(theAddress, theAddress, "Select", "Delete", DeleteView);
        }
    }
}
