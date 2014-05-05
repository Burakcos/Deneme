using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Employee
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _employeeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _employeeCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _employeeName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _departmentId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _departmentDepartmentCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _addressId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addressAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addressAddrressTypeAddressCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _locationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationsLocationsCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationsAddressAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationsAddressAddrressTypeAddressCode;
        
        public Employee()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? EmployeeId
        {
            get
            {
                return _employeeId;
            }
            set
            {
                _employeeId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EmployeeCode
        {
            get
            {
                return _employeeCode;
            }
            set
            {
                _employeeCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EmployeeName
        {
            get
            {
                return _employeeName;
            }
            set
            {
                _employeeName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? DepartmentId
        {
            get
            {
                return _departmentId;
            }
            set
            {
                _departmentId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DepartmentDepartmentCode
        {
            get
            {
                return _departmentDepartmentCode;
            }
            set
            {
                _departmentDepartmentCode = value;
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
        
        public static List<AssetManagment.Data.Objects.Employee> Select(int? employeeId, string employeeCode, string employeeName, int? departmentId, string departmentDepartmentCode, int? addressId, string addressAddress, string addressAddrressTypeAddressCode, int? locationsId, string locationsLocationsCode, string locationsAddressAddress, string locationsAddressAddrressTypeAddressCode)
        {
            return new EmployeeFactory().Select(employeeId, employeeCode, employeeName, departmentId, departmentDepartmentCode, addressId, addressAddress, addressAddrressTypeAddressCode, locationsId, locationsLocationsCode, locationsAddressAddress, locationsAddressAddrressTypeAddressCode);
        }
        
        public static List<AssetManagment.Data.Objects.Employee> Select(AssetManagment.Data.Objects.Employee qbe)
        {
            return new EmployeeFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.Employee> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new EmployeeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Employee> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new EmployeeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Employee> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new EmployeeFactory().Select(filter, sort, EmployeeFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Employee> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new EmployeeFactory().Select(filter, sort, EmployeeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Employee> Select(string filter, BusinessObjectParameters parameters)
        {
            return new EmployeeFactory().Select(filter, null, EmployeeFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Employee> Select(string filter, params FieldValue[] parameters)
        {
            return new EmployeeFactory().Select(filter, null, EmployeeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Employee SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new EmployeeFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.Employee SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new EmployeeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Employee SelectSingle(int? employeeId)
        {
            return new EmployeeFactory().SelectSingle(employeeId);
        }
        
        public int Insert()
        {
            return new EmployeeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new EmployeeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new EmployeeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("EmployeeId: {0}", this.EmployeeId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class EmployeeFactory
    {
        
        public EmployeeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Employee");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Employee");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Employee");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Employee");
            }
        }
        
        public static EmployeeFactory Create()
        {
            return new EmployeeFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? employeeId, string employeeCode, string employeeName, int? departmentId, string departmentDepartmentCode, int? addressId, string addressAddress, string addressAddrressTypeAddressCode, int? locationsId, string locationsLocationsCode, string locationsAddressAddress, string locationsAddressAddrressTypeAddressCode, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (employeeId.HasValue)
            	filter.Add(("EmployeeId:=" + employeeId.Value.ToString()));
            if (!(String.IsNullOrEmpty(employeeCode)))
            	filter.Add(("EmployeeCode:*" + employeeCode));
            if (!(String.IsNullOrEmpty(employeeName)))
            	filter.Add(("EmployeeName:*" + employeeName));
            if (departmentId.HasValue)
            	filter.Add(("DepartmentId:=" + departmentId.Value.ToString()));
            if (!(String.IsNullOrEmpty(departmentDepartmentCode)))
            	filter.Add(("DepartmentDepartmentCode:*" + departmentDepartmentCode));
            if (addressId.HasValue)
            	filter.Add(("AddressId:=" + addressId.Value.ToString()));
            if (!(String.IsNullOrEmpty(addressAddress)))
            	filter.Add(("AddressAddress:*" + addressAddress));
            if (!(String.IsNullOrEmpty(addressAddrressTypeAddressCode)))
            	filter.Add(("AddressAddrressTypeAddressCode:*" + addressAddrressTypeAddressCode));
            if (locationsId.HasValue)
            	filter.Add(("LocationsId:=" + locationsId.Value.ToString()));
            if (!(String.IsNullOrEmpty(locationsLocationsCode)))
            	filter.Add(("LocationsLocationsCode:*" + locationsLocationsCode));
            if (!(String.IsNullOrEmpty(locationsAddressAddress)))
            	filter.Add(("LocationsAddressAddress:*" + locationsAddressAddress));
            if (!(String.IsNullOrEmpty(locationsAddressAddrressTypeAddressCode)))
            	filter.Add(("LocationsAddressAddrressTypeAddressCode:*" + locationsAddressAddrressTypeAddressCode));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.Employee> Select(
                    int? employeeId, 
                    string employeeCode, 
                    string employeeName, 
                    int? departmentId, 
                    string departmentDepartmentCode, 
                    int? addressId, 
                    string addressAddress, 
                    string addressAddrressTypeAddressCode, 
                    int? locationsId, 
                    string locationsLocationsCode, 
                    string locationsAddressAddress, 
                    string locationsAddressAddrressTypeAddressCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(employeeId, employeeCode, employeeName, departmentId, departmentDepartmentCode, addressId, addressAddress, addressAddrressTypeAddressCode, locationsId, locationsLocationsCode, locationsAddressAddress, locationsAddressAddrressTypeAddressCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Employee", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Employee>();
        }
        
        public List<AssetManagment.Data.Objects.Employee> Select(AssetManagment.Data.Objects.Employee qbe)
        {
            return Select(qbe.EmployeeId, qbe.EmployeeCode, qbe.EmployeeName, qbe.DepartmentId, qbe.DepartmentDepartmentCode, qbe.AddressId, qbe.AddressAddress, qbe.AddressAddrressTypeAddressCode, qbe.LocationsId, qbe.LocationsLocationsCode, qbe.LocationsAddressAddress, qbe.LocationsAddressAddrressTypeAddressCode);
        }
        
        public int SelectCount(
                    int? employeeId, 
                    string employeeCode, 
                    string employeeName, 
                    int? departmentId, 
                    string departmentDepartmentCode, 
                    int? addressId, 
                    string addressAddress, 
                    string addressAddrressTypeAddressCode, 
                    int? locationsId, 
                    string locationsLocationsCode, 
                    string locationsAddressAddress, 
                    string locationsAddressAddrressTypeAddressCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(employeeId, employeeCode, employeeName, departmentId, departmentDepartmentCode, addressId, addressAddress, addressAddrressTypeAddressCode, locationsId, locationsLocationsCode, locationsAddressAddress, locationsAddressAddrressTypeAddressCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Employee", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.Employee> Select(int? employeeId, string employeeCode, string employeeName, int? departmentId, string departmentDepartmentCode, int? addressId, string addressAddress, string addressAddrressTypeAddressCode, int? locationsId, string locationsLocationsCode, string locationsAddressAddress, string locationsAddressAddrressTypeAddressCode)
        {
            return Select(employeeId, employeeCode, employeeName, departmentId, departmentDepartmentCode, addressId, addressAddress, addressAddrressTypeAddressCode, locationsId, locationsLocationsCode, locationsAddressAddress, locationsAddressAddrressTypeAddressCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.Employee SelectSingle(int? employeeId)
        {
            List<AssetManagment.Data.Objects.Employee> list = Select(employeeId, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.Employee> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Employee", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Employee>();
        }
        
        public List<AssetManagment.Data.Objects.Employee> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.Employee> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.Employee SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.Employee> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.Employee theEmployee, AssetManagment.Data.Objects.Employee original_Employee)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("EmployeeId", original_Employee.EmployeeId, theEmployee.EmployeeId));
            values.Add(new FieldValue("EmployeeCode", original_Employee.EmployeeCode, theEmployee.EmployeeCode));
            values.Add(new FieldValue("EmployeeName", original_Employee.EmployeeName, theEmployee.EmployeeName));
            values.Add(new FieldValue("DepartmentId", original_Employee.DepartmentId, theEmployee.DepartmentId));
            values.Add(new FieldValue("DepartmentDepartmentCode", original_Employee.DepartmentDepartmentCode, theEmployee.DepartmentDepartmentCode, true));
            values.Add(new FieldValue("AddressId", original_Employee.AddressId, theEmployee.AddressId));
            values.Add(new FieldValue("AddressAddress", original_Employee.AddressAddress, theEmployee.AddressAddress, true));
            values.Add(new FieldValue("AddressAddrressTypeAddressCode", original_Employee.AddressAddrressTypeAddressCode, theEmployee.AddressAddrressTypeAddressCode, true));
            values.Add(new FieldValue("LocationsId", original_Employee.LocationsId, theEmployee.LocationsId));
            values.Add(new FieldValue("LocationsLocationsCode", original_Employee.LocationsLocationsCode, theEmployee.LocationsLocationsCode, true));
            values.Add(new FieldValue("LocationsAddressAddress", original_Employee.LocationsAddressAddress, theEmployee.LocationsAddressAddress, true));
            values.Add(new FieldValue("LocationsAddressAddrressTypeAddressCode", original_Employee.LocationsAddressAddrressTypeAddressCode, theEmployee.LocationsAddressAddrressTypeAddressCode, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.Employee theEmployee, AssetManagment.Data.Objects.Employee original_Employee, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Employee";
            args.View = dataView;
            args.Values = CreateFieldValues(theEmployee, original_Employee);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Employee", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theEmployee);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.Employee theEmployee, AssetManagment.Data.Objects.Employee original_Employee)
        {
            return ExecuteAction(theEmployee, original_Employee, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.Employee theEmployee)
        {
            return Update(theEmployee, SelectSingle(theEmployee.EmployeeId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.Employee theEmployee)
        {
            return ExecuteAction(theEmployee, new Employee(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.Employee theEmployee)
        {
            return ExecuteAction(theEmployee, theEmployee, "Select", "Delete", DeleteView);
        }
    }
}
