using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Department
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _departmentId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _parrentId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentDepartmentCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _departmentCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _departmentName;
        
        public Department()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        public string ParrentDepartmentCode
        {
            get
            {
                return _parrentDepartmentCode;
            }
            set
            {
                _parrentDepartmentCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DepartmentCode
        {
            get
            {
                return _departmentCode;
            }
            set
            {
                _departmentCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DepartmentName
        {
            get
            {
                return _departmentName;
            }
            set
            {
                _departmentName = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.Department> Select(int? departmentId, int? parrentId, string parrentDepartmentCode, string departmentCode, string departmentName)
        {
            return new DepartmentFactory().Select(departmentId, parrentId, parrentDepartmentCode, departmentCode, departmentName);
        }
        
        public static List<AssetManagment.Data.Objects.Department> Select(AssetManagment.Data.Objects.Department qbe)
        {
            return new DepartmentFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.Department> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new DepartmentFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Department> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new DepartmentFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Department> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new DepartmentFactory().Select(filter, sort, DepartmentFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Department> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new DepartmentFactory().Select(filter, sort, DepartmentFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Department> Select(string filter, BusinessObjectParameters parameters)
        {
            return new DepartmentFactory().Select(filter, null, DepartmentFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Department> Select(string filter, params FieldValue[] parameters)
        {
            return new DepartmentFactory().Select(filter, null, DepartmentFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Department SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new DepartmentFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.Department SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new DepartmentFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Department SelectSingle(int? departmentId)
        {
            return new DepartmentFactory().SelectSingle(departmentId);
        }
        
        public int Insert()
        {
            return new DepartmentFactory().Insert(this);
        }
        
        public int Update()
        {
            return new DepartmentFactory().Update(this);
        }
        
        public int Delete()
        {
            return new DepartmentFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("DepartmentId: {0}", this.DepartmentId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class DepartmentFactory
    {
        
        public DepartmentFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Department");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Department");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Department");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Department");
            }
        }
        
        public static DepartmentFactory Create()
        {
            return new DepartmentFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? departmentId, int? parrentId, string parrentDepartmentCode, string departmentCode, string departmentName, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (departmentId.HasValue)
            	filter.Add(("DepartmentId:=" + departmentId.Value.ToString()));
            if (parrentId.HasValue)
            	filter.Add(("ParrentId:=" + parrentId.Value.ToString()));
            if (!(String.IsNullOrEmpty(parrentDepartmentCode)))
            	filter.Add(("ParrentDepartmentCode:*" + parrentDepartmentCode));
            if (!(String.IsNullOrEmpty(departmentCode)))
            	filter.Add(("DepartmentCode:*" + departmentCode));
            if (!(String.IsNullOrEmpty(departmentName)))
            	filter.Add(("DepartmentName:*" + departmentName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.Department> Select(int? departmentId, int? parrentId, string parrentDepartmentCode, string departmentCode, string departmentName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(departmentId, parrentId, parrentDepartmentCode, departmentCode, departmentName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Department", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Department>();
        }
        
        public List<AssetManagment.Data.Objects.Department> Select(AssetManagment.Data.Objects.Department qbe)
        {
            return Select(qbe.DepartmentId, qbe.ParrentId, qbe.ParrentDepartmentCode, qbe.DepartmentCode, qbe.DepartmentName);
        }
        
        public int SelectCount(int? departmentId, int? parrentId, string parrentDepartmentCode, string departmentCode, string departmentName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(departmentId, parrentId, parrentDepartmentCode, departmentCode, departmentName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Department", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.Department> Select(int? departmentId, int? parrentId, string parrentDepartmentCode, string departmentCode, string departmentName)
        {
            return Select(departmentId, parrentId, parrentDepartmentCode, departmentCode, departmentName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.Department SelectSingle(int? departmentId)
        {
            List<AssetManagment.Data.Objects.Department> list = Select(departmentId, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.Department> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Department", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Department>();
        }
        
        public List<AssetManagment.Data.Objects.Department> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.Department> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.Department SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.Department> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.Department theDepartment, AssetManagment.Data.Objects.Department original_Department)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("DepartmentId", original_Department.DepartmentId, theDepartment.DepartmentId));
            values.Add(new FieldValue("ParrentId", original_Department.ParrentId, theDepartment.ParrentId));
            values.Add(new FieldValue("ParrentDepartmentCode", original_Department.ParrentDepartmentCode, theDepartment.ParrentDepartmentCode, true));
            values.Add(new FieldValue("DepartmentCode", original_Department.DepartmentCode, theDepartment.DepartmentCode));
            values.Add(new FieldValue("DepartmentName", original_Department.DepartmentName, theDepartment.DepartmentName));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.Department theDepartment, AssetManagment.Data.Objects.Department original_Department, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Department";
            args.View = dataView;
            args.Values = CreateFieldValues(theDepartment, original_Department);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Department", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theDepartment);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.Department theDepartment, AssetManagment.Data.Objects.Department original_Department)
        {
            return ExecuteAction(theDepartment, original_Department, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.Department theDepartment)
        {
            return Update(theDepartment, SelectSingle(theDepartment.DepartmentId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.Department theDepartment)
        {
            return ExecuteAction(theDepartment, new Department(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.Department theDepartment)
        {
            return ExecuteAction(theDepartment, theDepartment, "Select", "Delete", DeleteView);
        }
    }
}
