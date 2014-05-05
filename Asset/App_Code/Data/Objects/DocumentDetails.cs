using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class DocumentDetails
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _documentDetailsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _documentId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _documentNotes;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _documentAttach;
        
        public DocumentDetails()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? DocumentDetailsId
        {
            get
            {
                return _documentDetailsId;
            }
            set
            {
                _documentDetailsId = value;
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
        public string DocumentNotes
        {
            get
            {
                return _documentNotes;
            }
            set
            {
                _documentNotes = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] DocumentAttach
        {
            get
            {
                return _documentAttach;
            }
            set
            {
                _documentAttach = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.DocumentDetails> Select(int? documentDetailsId, int? documentId, string documentNotes)
        {
            return new DocumentDetailsFactory().Select(documentDetailsId, documentId, documentNotes);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentDetails> Select(AssetManagment.Data.Objects.DocumentDetails qbe)
        {
            return new DocumentDetailsFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentDetails> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new DocumentDetailsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentDetails> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new DocumentDetailsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.DocumentDetails> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new DocumentDetailsFactory().Select(filter, sort, DocumentDetailsFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentDetails> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new DocumentDetailsFactory().Select(filter, sort, DocumentDetailsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.DocumentDetails> Select(string filter, BusinessObjectParameters parameters)
        {
            return new DocumentDetailsFactory().Select(filter, null, DocumentDetailsFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.DocumentDetails> Select(string filter, params FieldValue[] parameters)
        {
            return new DocumentDetailsFactory().Select(filter, null, DocumentDetailsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.DocumentDetails SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new DocumentDetailsFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.DocumentDetails SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new DocumentDetailsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.DocumentDetails SelectSingle(int? documentDetailsId)
        {
            return new DocumentDetailsFactory().SelectSingle(documentDetailsId);
        }
        
        public int Insert()
        {
            return new DocumentDetailsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new DocumentDetailsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new DocumentDetailsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("DocumentDetailsId: {0}", this.DocumentDetailsId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class DocumentDetailsFactory
    {
        
        public DocumentDetailsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("DocumentDetails");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("DocumentDetails");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("DocumentDetails");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("DocumentDetails");
            }
        }
        
        public static DocumentDetailsFactory Create()
        {
            return new DocumentDetailsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? documentDetailsId, int? documentId, string documentNotes, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (documentDetailsId.HasValue)
            	filter.Add(("DocumentDetailsId:=" + documentDetailsId.Value.ToString()));
            if (documentId.HasValue)
            	filter.Add(("DocumentId:=" + documentId.Value.ToString()));
            if (!(String.IsNullOrEmpty(documentNotes)))
            	filter.Add(("DocumentNotes:*" + documentNotes));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.DocumentDetails> Select(int? documentDetailsId, int? documentId, string documentNotes, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(documentDetailsId, documentId, documentNotes, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DocumentDetails", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.DocumentDetails>();
        }
        
        public List<AssetManagment.Data.Objects.DocumentDetails> Select(AssetManagment.Data.Objects.DocumentDetails qbe)
        {
            return Select(qbe.DocumentDetailsId, qbe.DocumentId, qbe.DocumentNotes);
        }
        
        public int SelectCount(int? documentDetailsId, int? documentId, string documentNotes, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(documentDetailsId, documentId, documentNotes, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("DocumentDetails", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.DocumentDetails> Select(int? documentDetailsId, int? documentId, string documentNotes)
        {
            return Select(documentDetailsId, documentId, documentNotes, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.DocumentDetails SelectSingle(int? documentDetailsId)
        {
            int? emptyDocumentId = null;
            string emptyDocumentNotes = null;
            List<AssetManagment.Data.Objects.DocumentDetails> list = Select(documentDetailsId, emptyDocumentId, emptyDocumentNotes);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.DocumentDetails> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("DocumentDetails", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.DocumentDetails>();
        }
        
        public List<AssetManagment.Data.Objects.DocumentDetails> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.DocumentDetails> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.DocumentDetails SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.DocumentDetails> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.DocumentDetails theDocumentDetails, AssetManagment.Data.Objects.DocumentDetails original_DocumentDetails)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("DocumentDetailsId", original_DocumentDetails.DocumentDetailsId, theDocumentDetails.DocumentDetailsId));
            values.Add(new FieldValue("DocumentId", original_DocumentDetails.DocumentId, theDocumentDetails.DocumentId));
            values.Add(new FieldValue("DocumentNotes", original_DocumentDetails.DocumentNotes, theDocumentDetails.DocumentNotes));
            values.Add(new FieldValue("DocumentAttach", original_DocumentDetails.DocumentAttach, theDocumentDetails.DocumentAttach));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.DocumentDetails theDocumentDetails, AssetManagment.Data.Objects.DocumentDetails original_DocumentDetails, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "DocumentDetails";
            args.View = dataView;
            args.Values = CreateFieldValues(theDocumentDetails, original_DocumentDetails);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("DocumentDetails", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theDocumentDetails);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.DocumentDetails theDocumentDetails, AssetManagment.Data.Objects.DocumentDetails original_DocumentDetails)
        {
            return ExecuteAction(theDocumentDetails, original_DocumentDetails, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.DocumentDetails theDocumentDetails)
        {
            return Update(theDocumentDetails, SelectSingle(theDocumentDetails.DocumentDetailsId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.DocumentDetails theDocumentDetails)
        {
            return ExecuteAction(theDocumentDetails, new DocumentDetails(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.DocumentDetails theDocumentDetails)
        {
            return ExecuteAction(theDocumentDetails, theDocumentDetails, "Select", "Delete", DeleteView);
        }
    }
}
