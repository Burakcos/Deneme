using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Document
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _documentId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _documentTypeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _fromLocationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _deliveryLocationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _ınvoiceDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _purchaseDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _customerId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _locationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _currencyId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amount;
        
        public Document()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? InvoiceDate
        {
            get
            {
                return _ınvoiceDate;
            }
            set
            {
                _ınvoiceDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? PurchaseDate
        {
            get
            {
                return _purchaseDate;
            }
            set
            {
                _purchaseDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? TransferId
        {
            get
            {
                return _transferId;
            }
            set
            {
                _transferId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public decimal? Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.Document> Select(int? documentId, int? documentTypeId, int? fromLocationsId, int? deliveryLocationsId, DateTime? ınvoiceDate, DateTime? purchaseDate, int? transferId, int? customerId, int? locationsId, int? currencyId, decimal? amount)
        {
            return new DocumentFactory().Select(documentId, documentTypeId, fromLocationsId, deliveryLocationsId, ınvoiceDate, purchaseDate, transferId, customerId, locationsId, currencyId, amount);
        }
        
        public static List<AssetManagment.Data.Objects.Document> Select(AssetManagment.Data.Objects.Document qbe)
        {
            return new DocumentFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.Document> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new DocumentFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Document> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new DocumentFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Document> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new DocumentFactory().Select(filter, sort, DocumentFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Document> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new DocumentFactory().Select(filter, sort, DocumentFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Document> Select(string filter, BusinessObjectParameters parameters)
        {
            return new DocumentFactory().Select(filter, null, DocumentFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Document> Select(string filter, params FieldValue[] parameters)
        {
            return new DocumentFactory().Select(filter, null, DocumentFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Document SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new DocumentFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.Document SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new DocumentFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Document SelectSingle(int? documentId)
        {
            return new DocumentFactory().SelectSingle(documentId);
        }
        
        public int Insert()
        {
            return new DocumentFactory().Insert(this);
        }
        
        public int Update()
        {
            return new DocumentFactory().Update(this);
        }
        
        public int Delete()
        {
            return new DocumentFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("DocumentId: {0}", this.DocumentId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class DocumentFactory
    {
        
        public DocumentFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Document");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Document");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Document");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Document");
            }
        }
        
        public static DocumentFactory Create()
        {
            return new DocumentFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? documentId, int? documentTypeId, int? fromLocationsId, int? deliveryLocationsId, DateTime? ınvoiceDate, DateTime? purchaseDate, int? transferId, int? customerId, int? locationsId, int? currencyId, decimal? amount, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (documentId.HasValue)
            	filter.Add(("DocumentId:=" + documentId.Value.ToString()));
            if (documentTypeId.HasValue)
            	filter.Add(("DocumentTypeId:=" + documentTypeId.Value.ToString()));
            if (fromLocationsId.HasValue)
            	filter.Add(("FromLocationsId:=" + fromLocationsId.Value.ToString()));
            if (deliveryLocationsId.HasValue)
            	filter.Add(("DeliveryLocationsId:=" + deliveryLocationsId.Value.ToString()));
            if (ınvoiceDate.HasValue)
            	filter.Add(("InvoiceDate:=" + ınvoiceDate.Value.ToString()));
            if (purchaseDate.HasValue)
            	filter.Add(("PurchaseDate:=" + purchaseDate.Value.ToString()));
            if (transferId.HasValue)
            	filter.Add(("TransferId:=" + transferId.Value.ToString()));
            if (customerId.HasValue)
            	filter.Add(("CustomerId:=" + customerId.Value.ToString()));
            if (locationsId.HasValue)
            	filter.Add(("LocationsId:=" + locationsId.Value.ToString()));
            if (currencyId.HasValue)
            	filter.Add(("CurrencyId:=" + currencyId.Value.ToString()));
            if (amount.HasValue)
            	filter.Add(("Amount:=" + amount.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.Document> Select(int? documentId, int? documentTypeId, int? fromLocationsId, int? deliveryLocationsId, DateTime? ınvoiceDate, DateTime? purchaseDate, int? transferId, int? customerId, int? locationsId, int? currencyId, decimal? amount, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(documentId, documentTypeId, fromLocationsId, deliveryLocationsId, ınvoiceDate, purchaseDate, transferId, customerId, locationsId, currencyId, amount, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Document", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Document>();
        }
        
        public List<AssetManagment.Data.Objects.Document> Select(AssetManagment.Data.Objects.Document qbe)
        {
            return Select(qbe.DocumentId, qbe.DocumentTypeId, qbe.FromLocationsId, qbe.DeliveryLocationsId, qbe.InvoiceDate, qbe.PurchaseDate, qbe.TransferId, qbe.CustomerId, qbe.LocationsId, qbe.CurrencyId, qbe.Amount);
        }
        
        public int SelectCount(int? documentId, int? documentTypeId, int? fromLocationsId, int? deliveryLocationsId, DateTime? ınvoiceDate, DateTime? purchaseDate, int? transferId, int? customerId, int? locationsId, int? currencyId, decimal? amount, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(documentId, documentTypeId, fromLocationsId, deliveryLocationsId, ınvoiceDate, purchaseDate, transferId, customerId, locationsId, currencyId, amount, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Document", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.Document> Select(int? documentId, int? documentTypeId, int? fromLocationsId, int? deliveryLocationsId, DateTime? ınvoiceDate, DateTime? purchaseDate, int? transferId, int? customerId, int? locationsId, int? currencyId, decimal? amount)
        {
            return Select(documentId, documentTypeId, fromLocationsId, deliveryLocationsId, ınvoiceDate, purchaseDate, transferId, customerId, locationsId, currencyId, amount, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.Document SelectSingle(int? documentId)
        {
            List<AssetManagment.Data.Objects.Document> list = Select(documentId, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.Document> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Document", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Document>();
        }
        
        public List<AssetManagment.Data.Objects.Document> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.Document> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.Document SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.Document> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.Document theDocument, AssetManagment.Data.Objects.Document original_Document)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("DocumentId", original_Document.DocumentId, theDocument.DocumentId));
            values.Add(new FieldValue("DocumentTypeId", original_Document.DocumentTypeId, theDocument.DocumentTypeId));
            values.Add(new FieldValue("FromLocationsId", original_Document.FromLocationsId, theDocument.FromLocationsId));
            values.Add(new FieldValue("DeliveryLocationsId", original_Document.DeliveryLocationsId, theDocument.DeliveryLocationsId));
            values.Add(new FieldValue("InvoiceDate", original_Document.InvoiceDate, theDocument.InvoiceDate));
            values.Add(new FieldValue("PurchaseDate", original_Document.PurchaseDate, theDocument.PurchaseDate));
            values.Add(new FieldValue("TransferId", original_Document.TransferId, theDocument.TransferId));
            values.Add(new FieldValue("CustomerId", original_Document.CustomerId, theDocument.CustomerId));
            values.Add(new FieldValue("LocationsId", original_Document.LocationsId, theDocument.LocationsId));
            values.Add(new FieldValue("CurrencyId", original_Document.CurrencyId, theDocument.CurrencyId));
            values.Add(new FieldValue("Amount", original_Document.Amount, theDocument.Amount));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.Document theDocument, AssetManagment.Data.Objects.Document original_Document, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Document";
            args.View = dataView;
            args.Values = CreateFieldValues(theDocument, original_Document);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Document", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theDocument);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.Document theDocument, AssetManagment.Data.Objects.Document original_Document)
        {
            return ExecuteAction(theDocument, original_Document, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.Document theDocument)
        {
            return Update(theDocument, SelectSingle(theDocument.DocumentId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.Document theDocument)
        {
            return ExecuteAction(theDocument, new Document(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.Document theDocument)
        {
            return ExecuteAction(theDocument, theDocument, "Select", "Delete", DeleteView);
        }
    }
}
