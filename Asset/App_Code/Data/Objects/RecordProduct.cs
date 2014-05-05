using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class RecordProduct
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _recordProductId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _parrentId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _productId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _employeeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _locationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _documentId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _departmentId;
        
        public RecordProduct()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? RecordProductId
        {
            get
            {
                return _recordProductId;
            }
            set
            {
                _recordProductId = value;
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
        public int? ProductId
        {
            get
            {
                return _productId;
            }
            set
            {
                _productId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public int? DocumentId
        {
            get
            {
                return _documentId;
            }
            set
            {
                _documentId = value;
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
        
        public static List<AssetManagment.Data.Objects.RecordProduct> Select(int? recordProductId, int? parrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId)
        {
            return new RecordProductFactory().Select(recordProductId, parrentId, productId, employeeId, locationsId, documentId, departmentId);
        }
        
        public static List<AssetManagment.Data.Objects.RecordProduct> Select(AssetManagment.Data.Objects.RecordProduct qbe)
        {
            return new RecordProductFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.RecordProduct> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new RecordProductFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.RecordProduct> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new RecordProductFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.RecordProduct> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new RecordProductFactory().Select(filter, sort, RecordProductFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.RecordProduct> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new RecordProductFactory().Select(filter, sort, RecordProductFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.RecordProduct> Select(string filter, BusinessObjectParameters parameters)
        {
            return new RecordProductFactory().Select(filter, null, RecordProductFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.RecordProduct> Select(string filter, params FieldValue[] parameters)
        {
            return new RecordProductFactory().Select(filter, null, RecordProductFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.RecordProduct SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new RecordProductFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.RecordProduct SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new RecordProductFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.RecordProduct SelectSingle(int? recordProductId)
        {
            return new RecordProductFactory().SelectSingle(recordProductId);
        }
        
        public int Insert()
        {
            return new RecordProductFactory().Insert(this);
        }
        
        public int Update()
        {
            return new RecordProductFactory().Update(this);
        }
        
        public int Delete()
        {
            return new RecordProductFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("RecordProductId: {0}", this.RecordProductId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class RecordProductFactory
    {
        
        public RecordProductFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("RecordProduct");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("RecordProduct");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("RecordProduct");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("RecordProduct");
            }
        }
        
        public static RecordProductFactory Create()
        {
            return new RecordProductFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? recordProductId, int? parrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (recordProductId.HasValue)
            	filter.Add(("RecordProductId:=" + recordProductId.Value.ToString()));
            if (parrentId.HasValue)
            	filter.Add(("ParrentId:=" + parrentId.Value.ToString()));
            if (productId.HasValue)
            	filter.Add(("ProductId:=" + productId.Value.ToString()));
            if (employeeId.HasValue)
            	filter.Add(("EmployeeId:=" + employeeId.Value.ToString()));
            if (locationsId.HasValue)
            	filter.Add(("LocationsId:=" + locationsId.Value.ToString()));
            if (documentId.HasValue)
            	filter.Add(("DocumentId:=" + documentId.Value.ToString()));
            if (departmentId.HasValue)
            	filter.Add(("DepartmentId:=" + departmentId.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.RecordProduct> Select(int? recordProductId, int? parrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(recordProductId, parrentId, productId, employeeId, locationsId, documentId, departmentId, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("RecordProduct", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.RecordProduct>();
        }
        
        public List<AssetManagment.Data.Objects.RecordProduct> Select(AssetManagment.Data.Objects.RecordProduct qbe)
        {
            return Select(qbe.RecordProductId, qbe.ParrentId, qbe.ProductId, qbe.EmployeeId, qbe.LocationsId, qbe.DocumentId, qbe.DepartmentId);
        }
        
        public int SelectCount(int? recordProductId, int? parrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(recordProductId, parrentId, productId, employeeId, locationsId, documentId, departmentId, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("RecordProduct", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.RecordProduct> Select(int? recordProductId, int? parrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId)
        {
            return Select(recordProductId, parrentId, productId, employeeId, locationsId, documentId, departmentId, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.RecordProduct SelectSingle(int? recordProductId)
        {
            List<AssetManagment.Data.Objects.RecordProduct> list = Select(recordProductId, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.RecordProduct> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("RecordProduct", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.RecordProduct>();
        }
        
        public List<AssetManagment.Data.Objects.RecordProduct> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.RecordProduct> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.RecordProduct SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.RecordProduct> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.RecordProduct theRecordProduct, AssetManagment.Data.Objects.RecordProduct original_RecordProduct)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("RecordProductId", original_RecordProduct.RecordProductId, theRecordProduct.RecordProductId));
            values.Add(new FieldValue("ParrentId", original_RecordProduct.ParrentId, theRecordProduct.ParrentId));
            values.Add(new FieldValue("ProductId", original_RecordProduct.ProductId, theRecordProduct.ProductId));
            values.Add(new FieldValue("EmployeeId", original_RecordProduct.EmployeeId, theRecordProduct.EmployeeId));
            values.Add(new FieldValue("LocationsId", original_RecordProduct.LocationsId, theRecordProduct.LocationsId));
            values.Add(new FieldValue("DocumentId", original_RecordProduct.DocumentId, theRecordProduct.DocumentId));
            values.Add(new FieldValue("DepartmentId", original_RecordProduct.DepartmentId, theRecordProduct.DepartmentId));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.RecordProduct theRecordProduct, AssetManagment.Data.Objects.RecordProduct original_RecordProduct, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "RecordProduct";
            args.View = dataView;
            args.Values = CreateFieldValues(theRecordProduct, original_RecordProduct);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("RecordProduct", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theRecordProduct);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.RecordProduct theRecordProduct, AssetManagment.Data.Objects.RecordProduct original_RecordProduct)
        {
            return ExecuteAction(theRecordProduct, original_RecordProduct, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.RecordProduct theRecordProduct)
        {
            return Update(theRecordProduct, SelectSingle(theRecordProduct.RecordProductId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.RecordProduct theRecordProduct)
        {
            return ExecuteAction(theRecordProduct, new RecordProduct(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.RecordProduct theRecordProduct)
        {
            return ExecuteAction(theRecordProduct, theRecordProduct, "Select", "Delete", DeleteView);
        }
    }
}
