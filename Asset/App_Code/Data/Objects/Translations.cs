using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Translations
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _translationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _recordProductId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _recordProductParrentId;
        
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
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _fromLocationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _deliveryLocationsId;
        
        public Translations()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? TranslationsId
        {
            get
            {
                return _translationsId;
            }
            set
            {
                _translationsId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public int? RecordProductParrentId
        {
            get
            {
                return _recordProductParrentId;
            }
            set
            {
                _recordProductParrentId = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? FromLocationsId
        {
            get
            {
                return _fromLocationsId;
            }
            set
            {
                _fromLocationsId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? DeliveryLocationsId
        {
            get
            {
                return _deliveryLocationsId;
            }
            set
            {
                _deliveryLocationsId = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.Translations> Select(int? translationsId, int? recordProductId, int? recordProductParrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId, int? fromLocationsId, int? deliveryLocationsId)
        {
            return new TranslationsFactory().Select(translationsId, recordProductId, recordProductParrentId, productId, employeeId, locationsId, documentId, departmentId, fromLocationsId, deliveryLocationsId);
        }
        
        public static List<AssetManagment.Data.Objects.Translations> Select(AssetManagment.Data.Objects.Translations qbe)
        {
            return new TranslationsFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.Translations> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new TranslationsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Translations> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new TranslationsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Translations> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new TranslationsFactory().Select(filter, sort, TranslationsFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Translations> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new TranslationsFactory().Select(filter, sort, TranslationsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Translations> Select(string filter, BusinessObjectParameters parameters)
        {
            return new TranslationsFactory().Select(filter, null, TranslationsFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Translations> Select(string filter, params FieldValue[] parameters)
        {
            return new TranslationsFactory().Select(filter, null, TranslationsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Translations SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new TranslationsFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.Translations SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new TranslationsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Translations SelectSingle(int? translationsId)
        {
            return new TranslationsFactory().SelectSingle(translationsId);
        }
        
        public int Insert()
        {
            return new TranslationsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new TranslationsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new TranslationsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TranslationsId: {0}", this.TranslationsId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class TranslationsFactory
    {
        
        public TranslationsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Translations");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Translations");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Translations");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Translations");
            }
        }
        
        public static TranslationsFactory Create()
        {
            return new TranslationsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? translationsId, int? recordProductId, int? recordProductParrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId, int? fromLocationsId, int? deliveryLocationsId, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (translationsId.HasValue)
            	filter.Add(("TranslationsId:=" + translationsId.Value.ToString()));
            if (recordProductId.HasValue)
            	filter.Add(("RecordProductId:=" + recordProductId.Value.ToString()));
            if (recordProductParrentId.HasValue)
            	filter.Add(("RecordProductParrentId:=" + recordProductParrentId.Value.ToString()));
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
            if (fromLocationsId.HasValue)
            	filter.Add(("FromLocationsId:=" + fromLocationsId.Value.ToString()));
            if (deliveryLocationsId.HasValue)
            	filter.Add(("DeliveryLocationsId:=" + deliveryLocationsId.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.Translations> Select(int? translationsId, int? recordProductId, int? recordProductParrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId, int? fromLocationsId, int? deliveryLocationsId, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(translationsId, recordProductId, recordProductParrentId, productId, employeeId, locationsId, documentId, departmentId, fromLocationsId, deliveryLocationsId, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Translations", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Translations>();
        }
        
        public List<AssetManagment.Data.Objects.Translations> Select(AssetManagment.Data.Objects.Translations qbe)
        {
            return Select(qbe.TranslationsId, qbe.RecordProductId, qbe.RecordProductParrentId, qbe.ProductId, qbe.EmployeeId, qbe.LocationsId, qbe.DocumentId, qbe.DepartmentId, qbe.FromLocationsId, qbe.DeliveryLocationsId);
        }
        
        public int SelectCount(int? translationsId, int? recordProductId, int? recordProductParrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId, int? fromLocationsId, int? deliveryLocationsId, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(translationsId, recordProductId, recordProductParrentId, productId, employeeId, locationsId, documentId, departmentId, fromLocationsId, deliveryLocationsId, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Translations", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.Translations> Select(int? translationsId, int? recordProductId, int? recordProductParrentId, int? productId, int? employeeId, int? locationsId, int? documentId, int? departmentId, int? fromLocationsId, int? deliveryLocationsId)
        {
            return Select(translationsId, recordProductId, recordProductParrentId, productId, employeeId, locationsId, documentId, departmentId, fromLocationsId, deliveryLocationsId, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.Translations SelectSingle(int? translationsId)
        {
            List<AssetManagment.Data.Objects.Translations> list = Select(translationsId, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.Translations> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Translations", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Translations>();
        }
        
        public List<AssetManagment.Data.Objects.Translations> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.Translations> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.Translations SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.Translations> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.Translations theTranslations, AssetManagment.Data.Objects.Translations original_Translations)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TranslationsId", original_Translations.TranslationsId, theTranslations.TranslationsId));
            values.Add(new FieldValue("RecordProductId", original_Translations.RecordProductId, theTranslations.RecordProductId));
            values.Add(new FieldValue("RecordProductParrentId", original_Translations.RecordProductParrentId, theTranslations.RecordProductParrentId));
            values.Add(new FieldValue("ProductId", original_Translations.ProductId, theTranslations.ProductId));
            values.Add(new FieldValue("EmployeeId", original_Translations.EmployeeId, theTranslations.EmployeeId));
            values.Add(new FieldValue("LocationsId", original_Translations.LocationsId, theTranslations.LocationsId));
            values.Add(new FieldValue("DocumentId", original_Translations.DocumentId, theTranslations.DocumentId));
            values.Add(new FieldValue("DepartmentId", original_Translations.DepartmentId, theTranslations.DepartmentId));
            values.Add(new FieldValue("FromLocationsId", original_Translations.FromLocationsId, theTranslations.FromLocationsId));
            values.Add(new FieldValue("DeliveryLocationsId", original_Translations.DeliveryLocationsId, theTranslations.DeliveryLocationsId));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.Translations theTranslations, AssetManagment.Data.Objects.Translations original_Translations, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Translations";
            args.View = dataView;
            args.Values = CreateFieldValues(theTranslations, original_Translations);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Translations", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTranslations);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.Translations theTranslations, AssetManagment.Data.Objects.Translations original_Translations)
        {
            return ExecuteAction(theTranslations, original_Translations, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.Translations theTranslations)
        {
            return Update(theTranslations, SelectSingle(theTranslations.TranslationsId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.Translations theTranslations)
        {
            return ExecuteAction(theTranslations, new Translations(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.Translations theTranslations)
        {
            return ExecuteAction(theTranslations, theTranslations, "Select", "Delete", DeleteView);
        }
    }
}
