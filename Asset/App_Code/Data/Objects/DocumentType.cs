using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class DocumentType
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _documentTypeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _documentTypeCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _documentTypeName;
        
        public DocumentType()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? DocumentTypeId
        {
            get
            {
                return _documentTypeId;
            }
            set
            {
                _documentTypeId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DocumentTypeCode
        {
            get
            {
                return _documentTypeCode;
            }
            set
            {
                _documentTypeCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DocumentTypeName
        {
            get
            {
                return _documentTypeName;
            }
            set
            {
                _documentTypeName = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.DocumentType> Select(int? documentTypeId, string documentTypeCode, string documentTypeName)
        {
            return new DocumentTypeFactory().Select(documentTypeId, documentTypeCode, documentTypeName);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentType> Select(AssetManagment.Data.Objects.DocumentType qbe)
        {
            return new DocumentTypeFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new DocumentTypeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentType> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new DocumentTypeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.DocumentType> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new DocumentTypeFactory().Select(filter, sort, DocumentTypeFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentType> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new DocumentTypeFactory().Select(filter, sort, DocumentTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.DocumentType> Select(string filter, BusinessObjectParameters parameters)
        {
            return new DocumentTypeFactory().Select(filter, null, DocumentTypeFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentType> Select(string filter, params FieldValue[] parameters)
        {
            return new DocumentTypeFactory().Select(filter, null, DocumentTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.DocumentType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new DocumentTypeFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.DocumentType SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new DocumentTypeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.DocumentType SelectSingle(int? documentTypeId)
        {
            return new DocumentTypeFactory().SelectSingle(documentTypeId);
        }
        
        public int Insert()
        {
            return new DocumentTypeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new DocumentTypeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new DocumentTypeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("DocumentTypeId: {0}", this.DocumentTypeId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class DocumentTypeFactory
    {
        
        public DocumentTypeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("DocumentType");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("DocumentType");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("DocumentType");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("DocumentType");
            }
        }
        
        public static DocumentTypeFactory Create()
        {
            return new DocumentTypeFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? documentTypeId, string documentTypeCode, string documentTypeName, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (documentTypeId.HasValue)
            	filter.Add(("DocumentTypeId:=" + documentTypeId.Value.ToString()));
            if (!(String.IsNullOrEmpty(documentTypeCode)))
            	filter.Add(("DocumentTypeCode:*" + documentTypeCode));
            if (!(String.IsNullOrEmpty(documentTypeName)))
            	filter.Add(("DocumentTypeName:*" + documentTypeName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.DocumentType> Select(int? documentTypeId, string documentTypeCode, string documentTypeName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(documentTypeId, documentTypeCode, documentTypeName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DocumentType", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.DocumentType>();
        }
        
        public List<AssetManagment.Data.Objects.DocumentType> Select(AssetManagment.Data.Objects.DocumentType qbe)
        {
            return Select(qbe.DocumentTypeId, qbe.DocumentTypeCode, qbe.DocumentTypeName);
        }
        
        public int SelectCount(int? documentTypeId, string documentTypeCode, string documentTypeName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(documentTypeId, documentTypeCode, documentTypeName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DocumentType", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.DocumentType> Select(int? documentTypeId, string documentTypeCode, string documentTypeName)
        {
            return Select(documentTypeId, documentTypeCode, documentTypeName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.DocumentType SelectSingle(int? documentTypeId)
        {
            string emptyDocumentTypeCode = null;
            string emptyDocumentTypeName = null;
            List<AssetManagment.Data.Objects.DocumentType> list = Select(documentTypeId, emptyDocumentTypeCode, emptyDocumentTypeName);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.DocumentType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("DocumentType", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.DocumentType>();
        }
        
        public List<AssetManagment.Data.Objects.DocumentType> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.DocumentType> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.DocumentType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.DocumentType> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.DocumentType theDocumentType, AssetManagment.Data.Objects.DocumentType original_DocumentType)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("DocumentTypeId", original_DocumentType.DocumentTypeId, theDocumentType.DocumentTypeId));
            values.Add(new FieldValue("DocumentTypeCode", original_DocumentType.DocumentTypeCode, theDocumentType.DocumentTypeCode));
            values.Add(new FieldValue("DocumentTypeName", original_DocumentType.DocumentTypeName, theDocumentType.DocumentTypeName));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.DocumentType theDocumentType, AssetManagment.Data.Objects.DocumentType original_DocumentType, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "DocumentType";
            args.View = dataView;
            args.Values = CreateFieldValues(theDocumentType, original_DocumentType);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("DocumentType", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theDocumentType);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.DocumentType theDocumentType, AssetManagment.Data.Objects.DocumentType original_DocumentType)
        {
            return ExecuteAction(theDocumentType, original_DocumentType, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.DocumentType theDocumentType)
        {
            return Update(theDocumentType, SelectSingle(theDocumentType.DocumentTypeId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.DocumentType theDocumentType)
        {
            return ExecuteAction(theDocumentType, new DocumentType(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.DocumentType theDocumentType)
        {
            return ExecuteAction(theDocumentType, theDocumentType, "Select", "Delete", DeleteView);
        }
    }
}
