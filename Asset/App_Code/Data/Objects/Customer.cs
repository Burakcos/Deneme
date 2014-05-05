using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Customer
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _parrentId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentCustomerCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentAddressAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentAddressAddrressTypeAddressCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentLocationsLocationsCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentLocationsAddressAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _customerId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customerCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customerName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _locationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationsLocationsCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationsAddressAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationsAddressAddrressTypeAddressCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _addressId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addressAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addressAddrressTypeAddressCode;
        
        public Customer()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ParrentId
        {
            get
            {
                return _parrentId;
            }
            set
            {
                _parrentId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParrentCustomerCode
        {
            get
            {
                return _parrentCustomerCode;
            }
            set
            {
                _parrentCustomerCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParrentAddressAddress
        {
            get
            {
                return _parrentAddressAddress;
            }
            set
            {
                _parrentAddressAddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParrentAddressAddrressTypeAddressCode
        {
            get
            {
                return _parrentAddressAddrressTypeAddressCode;
            }
            set
            {
                _parrentAddressAddrressTypeAddressCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParrentLocationsLocationsCode
        {
            get
            {
                return _parrentLocationsLocationsCode;
            }
            set
            {
                _parrentLocationsLocationsCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParrentLocationsAddressAddress
        {
            get
            {
                return _parrentLocationsAddressAddress;
            }
            set
            {
                _parrentLocationsAddressAddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? CustomerId
        {
            get
            {
                return _customerId;
            }
            set
            {
                _customerId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CustomerCode
        {
            get
            {
                return _customerCode;
            }
            set
            {
                _customerCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CustomerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? LocationsId
        {
            get
            {
                return _locationsId;
            }
            set
            {
                _locationsId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LocationsLocationsCode
        {
            get
            {
                return _locationsLocationsCode;
            }
            set
            {
                _locationsLocationsCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LocationsAddressAddress
        {
            get
            {
                return _locationsAddressAddress;
            }
            set
            {
                _locationsAddressAddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LocationsAddressAddrressTypeAddressCode
        {
            get
            {
                return _locationsAddressAddrressTypeAddressCode;
            }
            set
            {
                _locationsAddressAddrressTypeAddressCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public string AddressAddress
        {
            get
            {
                return _addressAddress;
            }
            set
            {
                _addressAddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AddressAddrressTypeAddressCode
        {
            get
            {
                return _addressAddrressTypeAddressCode;
            }
            set
            {
                _addressAddrressTypeAddressCode = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.Customer> Select(
                    int? parrentId, 
                    string parrentCustomerCode, 
                    string parrentAddressAddress, 
                    string parrentAddressAddrressTypeAddressCode, 
                    string parrentLocationsLocationsCode, 
                    string parrentLocationsAddressAddress, 
                    int? customerId, 
                    string customerCode, 
                    string customerName, 
                    int? locationsId, 
                    string locationsLocationsCode, 
                    string locationsAddressAddress, 
                    string locationsAddressAddrressTypeAddressCode, 
                    int? addressId, 
                    string addressAddress, 
                    string addressAddrressTypeAddressCode)
        {
            return new CustomerFactory().Select(parrentId, parrentCustomerCode, parrentAddressAddress, parrentAddressAddrressTypeAddressCode, parrentLocationsLocationsCode, parrentLocationsAddressAddress, customerId, customerCode, customerName, locationsId, locationsLocationsCode, locationsAddressAddress, locationsAddressAddrressTypeAddressCode, addressId, addressAddress, addressAddrressTypeAddressCode);
        }
        
        public static List<AssetManagment.Data.Objects.Customer> Select(AssetManagment.Data.Objects.Customer qbe)
        {
            return new CustomerFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.Customer> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CustomerFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Customer> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CustomerFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Customer> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CustomerFactory().Select(filter, sort, CustomerFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Customer> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CustomerFactory().Select(filter, sort, CustomerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Customer> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CustomerFactory().Select(filter, null, CustomerFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Customer> Select(string filter, params FieldValue[] parameters)
        {
            return new CustomerFactory().Select(filter, null, CustomerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Customer SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CustomerFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.Customer SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CustomerFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Customer SelectSingle(int? customerId)
        {
            return new CustomerFactory().SelectSingle(customerId);
        }
        
        public int Insert()
        {
            return new CustomerFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CustomerFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CustomerFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CustomerId: {0}", this.CustomerId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CustomerFactory
    {
        
        public CustomerFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Customer");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Customer");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Customer");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Customer");
            }
        }
        
        public static CustomerFactory Create()
        {
            return new CustomerFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? parrentId, 
                    string parrentCustomerCode, 
                    string parrentAddressAddress, 
                    string parrentAddressAddrressTypeAddressCode, 
                    string parrentLocationsLocationsCode, 
                    string parrentLocationsAddressAddress, 
                    int? customerId, 
                    string customerCode, 
                    string customerName, 
                    int? locationsId, 
                    string locationsLocationsCode, 
                    string locationsAddressAddress, 
                    string locationsAddressAddrressTypeAddressCode, 
                    int? addressId, 
                    string addressAddress, 
                    string addressAddrressTypeAddressCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (parrentId.HasValue)
            	filter.Add(("ParrentId:=" + parrentId.Value.ToString()));
            if (!(String.IsNullOrEmpty(parrentCustomerCode)))
            	filter.Add(("ParrentCustomerCode:*" + parrentCustomerCode));
            if (!(String.IsNullOrEmpty(parrentAddressAddress)))
            	filter.Add(("ParrentAddressAddress:*" + parrentAddressAddress));
            if (!(String.IsNullOrEmpty(parrentAddressAddrressTypeAddressCode)))
            	filter.Add(("ParrentAddressAddrressTypeAddressCode:*" + parrentAddressAddrressTypeAddressCode));
            if (!(String.IsNullOrEmpty(parrentLocationsLocationsCode)))
            	filter.Add(("ParrentLocationsLocationsCode:*" + parrentLocationsLocationsCode));
            if (!(String.IsNullOrEmpty(parrentLocationsAddressAddress)))
            	filter.Add(("ParrentLocationsAddressAddress:*" + parrentLocationsAddressAddress));
            if (customerId.HasValue)
            	filter.Add(("CustomerId:=" + customerId.Value.ToString()));
            if (!(String.IsNullOrEmpty(customerCode)))
            	filter.Add(("CustomerCode:*" + customerCode));
            if (!(String.IsNullOrEmpty(customerName)))
            	filter.Add(("CustomerName:*" + customerName));
            if (locationsId.HasValue)
            	filter.Add(("LocationsId:=" + locationsId.Value.ToString()));
            if (!(String.IsNullOrEmpty(locationsLocationsCode)))
            	filter.Add(("LocationsLocationsCode:*" + locationsLocationsCode));
            if (!(String.IsNullOrEmpty(locationsAddressAddress)))
            	filter.Add(("LocationsAddressAddress:*" + locationsAddressAddress));
            if (!(String.IsNullOrEmpty(locationsAddressAddrressTypeAddressCode)))
            	filter.Add(("LocationsAddressAddrressTypeAddressCode:*" + locationsAddressAddrressTypeAddressCode));
            if (addressId.HasValue)
            	filter.Add(("AddressId:=" + addressId.Value.ToString()));
            if (!(String.IsNullOrEmpty(addressAddress)))
            	filter.Add(("AddressAddress:*" + addressAddress));
            if (!(String.IsNullOrEmpty(addressAddrressTypeAddressCode)))
            	filter.Add(("AddressAddrressTypeAddressCode:*" + addressAddrressTypeAddressCode));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.Customer> Select(
                    int? parrentId, 
                    string parrentCustomerCode, 
                    string parrentAddressAddress, 
                    string parrentAddressAddrressTypeAddressCode, 
                    string parrentLocationsLocationsCode, 
                    string parrentLocationsAddressAddress, 
                    int? customerId, 
                    string customerCode, 
                    string customerName, 
                    int? locationsId, 
                    string locationsLocationsCode, 
                    string locationsAddressAddress, 
                    string locationsAddressAddrressTypeAddressCode, 
                    int? addressId, 
                    string addressAddress, 
                    string addressAddrressTypeAddressCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(parrentId, parrentCustomerCode, parrentAddressAddress, parrentAddressAddrressTypeAddressCode, parrentLocationsLocationsCode, parrentLocationsAddressAddress, customerId, customerCode, customerName, locationsId, locationsLocationsCode, locationsAddressAddress, locationsAddressAddrressTypeAddressCode, addressId, addressAddress, addressAddrressTypeAddressCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Customer", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Customer>();
        }
        
        public List<AssetManagment.Data.Objects.Customer> Select(AssetManagment.Data.Objects.Customer qbe)
        {
            return Select(qbe.ParrentId, qbe.ParrentCustomerCode, qbe.ParrentAddressAddress, qbe.ParrentAddressAddrressTypeAddressCode, qbe.ParrentLocationsLocationsCode, qbe.ParrentLocationsAddressAddress, qbe.CustomerId, qbe.CustomerCode, qbe.CustomerName, qbe.LocationsId, qbe.LocationsLocationsCode, qbe.LocationsAddressAddress, qbe.LocationsAddressAddrressTypeAddressCode, qbe.AddressId, qbe.AddressAddress, qbe.AddressAddrressTypeAddressCode);
        }
        
        public int SelectCount(
                    int? parrentId, 
                    string parrentCustomerCode, 
                    string parrentAddressAddress, 
                    string parrentAddressAddrressTypeAddressCode, 
                    string parrentLocationsLocationsCode, 
                    string parrentLocationsAddressAddress, 
                    int? customerId, 
                    string customerCode, 
                    string customerName, 
                    int? locationsId, 
                    string locationsLocationsCode, 
                    string locationsAddressAddress, 
                    string locationsAddressAddrressTypeAddressCode, 
                    int? addressId, 
                    string addressAddress, 
                    string addressAddrressTypeAddressCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(parrentId, parrentCustomerCode, parrentAddressAddress, parrentAddressAddrressTypeAddressCode, parrentLocationsLocationsCode, parrentLocationsAddressAddress, customerId, customerCode, customerName, locationsId, locationsLocationsCode, locationsAddressAddress, locationsAddressAddrressTypeAddressCode, addressId, addressAddress, addressAddrressTypeAddressCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Customer", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.Customer> Select(
                    int? parrentId, 
                    string parrentCustomerCode, 
                    string parrentAddressAddress, 
                    string parrentAddressAddrressTypeAddressCode, 
                    string parrentLocationsLocationsCode, 
                    string parrentLocationsAddressAddress, 
                    int? customerId, 
                    string customerCode, 
                    string customerName, 
                    int? locationsId, 
                    string locationsLocationsCode, 
                    string locationsAddressAddress, 
                    string locationsAddressAddrressTypeAddressCode, 
                    int? addressId, 
                    string addressAddress, 
                    string addressAddrressTypeAddressCode)
        {
            return Select(parrentId, parrentCustomerCode, parrentAddressAddress, parrentAddressAddrressTypeAddressCode, parrentLocationsLocationsCode, parrentLocationsAddressAddress, customerId, customerCode, customerName, locationsId, locationsLocationsCode, locationsAddressAddress, locationsAddressAddrressTypeAddressCode, addressId, addressAddress, addressAddrressTypeAddressCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.Customer SelectSingle(int? customerId)
        {
            List<AssetManagment.Data.Objects.Customer> list = Select(null, null, null, null, null, null, customerId, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.Customer> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Customer", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Customer>();
        }
        
        public List<AssetManagment.Data.Objects.Customer> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.Customer> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.Customer SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.Customer> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.Customer theCustomer, AssetManagment.Data.Objects.Customer original_Customer)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ParrentId", original_Customer.ParrentId, theCustomer.ParrentId));
            values.Add(new FieldValue("ParrentCustomerCode", original_Customer.ParrentCustomerCode, theCustomer.ParrentCustomerCode, true));
            values.Add(new FieldValue("ParrentAddressAddress", original_Customer.ParrentAddressAddress, theCustomer.ParrentAddressAddress, true));
            values.Add(new FieldValue("ParrentAddressAddrressTypeAddressCode", original_Customer.ParrentAddressAddrressTypeAddressCode, theCustomer.ParrentAddressAddrressTypeAddressCode, true));
            values.Add(new FieldValue("ParrentLocationsLocationsCode", original_Customer.ParrentLocationsLocationsCode, theCustomer.ParrentLocationsLocationsCode, true));
            values.Add(new FieldValue("ParrentLocationsAddressAddress", original_Customer.ParrentLocationsAddressAddress, theCustomer.ParrentLocationsAddressAddress, true));
            values.Add(new FieldValue("CustomerId", original_Customer.CustomerId, theCustomer.CustomerId));
            values.Add(new FieldValue("CustomerCode", original_Customer.CustomerCode, theCustomer.CustomerCode));
            values.Add(new FieldValue("CustomerName", original_Customer.CustomerName, theCustomer.CustomerName));
            values.Add(new FieldValue("LocationsId", original_Customer.LocationsId, theCustomer.LocationsId));
            values.Add(new FieldValue("LocationsLocationsCode", original_Customer.LocationsLocationsCode, theCustomer.LocationsLocationsCode, true));
            values.Add(new FieldValue("LocationsAddressAddress", original_Customer.LocationsAddressAddress, theCustomer.LocationsAddressAddress, true));
            values.Add(new FieldValue("LocationsAddressAddrressTypeAddressCode", original_Customer.LocationsAddressAddrressTypeAddressCode, theCustomer.LocationsAddressAddrressTypeAddressCode, true));
            values.Add(new FieldValue("AddressId", original_Customer.AddressId, theCustomer.AddressId));
            values.Add(new FieldValue("AddressAddress", original_Customer.AddressAddress, theCustomer.AddressAddress, true));
            values.Add(new FieldValue("AddressAddrressTypeAddressCode", original_Customer.AddressAddrressTypeAddressCode, theCustomer.AddressAddrressTypeAddressCode, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.Customer theCustomer, AssetManagment.Data.Objects.Customer original_Customer, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Customer";
            args.View = dataView;
            args.Values = CreateFieldValues(theCustomer, original_Customer);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Customer", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCustomer);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.Customer theCustomer, AssetManagment.Data.Objects.Customer original_Customer)
        {
            return ExecuteAction(theCustomer, original_Customer, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.Customer theCustomer)
        {
            return Update(theCustomer, SelectSingle(theCustomer.CustomerId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.Customer theCustomer)
        {
            return ExecuteAction(theCustomer, new Customer(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.Customer theCustomer)
        {
            return ExecuteAction(theCustomer, theCustomer, "Select", "Delete", DeleteView);
        }
    }
}
