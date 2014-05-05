using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class TransferType
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferTypeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferTypeCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferTypeName;
        
        public TransferType()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? TransferTypeId
        {
            get
            {
                return _transferTypeId;
            }
            set
            {
                _transferTypeId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TransferTypeCode
        {
            get
            {
                return _transferTypeCode;
            }
            set
            {
                _transferTypeCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TransferTypeName
        {
            get
            {
                return _transferTypeName;
            }
            set
            {
                _transferTypeName = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.TransferType> Select(int? transferTypeId, string transferTypeCode, string transferTypeName)
        {
            return new TransferTypeFactory().Select(transferTypeId, transferTypeCode, transferTypeName);
        }
        
        public static List<AssetManagment.Data.Objects.TransferType> Select(AssetManagment.Data.Objects.TransferType qbe)
        {
            return new TransferTypeFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.TransferType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new TransferTypeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.TransferType> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new TransferTypeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.TransferType> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new TransferTypeFactory().Select(filter, sort, TransferTypeFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.TransferType> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new TransferTypeFactory().Select(filter, sort, TransferTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.TransferType> Select(string filter, BusinessObjectParameters parameters)
        {
            return new TransferTypeFactory().Select(filter, null, TransferTypeFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.TransferType> Select(string filter, params FieldValue[] parameters)
        {
            return new TransferTypeFactory().Select(filter, null, TransferTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.TransferType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new TransferTypeFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.TransferType SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new TransferTypeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.TransferType SelectSingle(int? transferTypeId)
        {
            return new TransferTypeFactory().SelectSingle(transferTypeId);
        }
        
        public int Insert()
        {
            return new TransferTypeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new TransferTypeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new TransferTypeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TransferTypeId: {0}", this.TransferTypeId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class TransferTypeFactory
    {
        
        public TransferTypeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TransferType");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TransferType");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TransferType");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TransferType");
            }
        }
        
        public static TransferTypeFactory Create()
        {
            return new TransferTypeFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? transferTypeId, string transferTypeCode, string transferTypeName, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (transferTypeId.HasValue)
            	filter.Add(("TransferTypeId:=" + transferTypeId.Value.ToString()));
            if (!(String.IsNullOrEmpty(transferTypeCode)))
            	filter.Add(("TransferTypeCode:*" + transferTypeCode));
            if (!(String.IsNullOrEmpty(transferTypeName)))
            	filter.Add(("TransferTypeName:*" + transferTypeName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.TransferType> Select(int? transferTypeId, string transferTypeCode, string transferTypeName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(transferTypeId, transferTypeCode, transferTypeName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TransferType", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.TransferType>();
        }
        
        public List<AssetManagment.Data.Objects.TransferType> Select(AssetManagment.Data.Objects.TransferType qbe)
        {
            return Select(qbe.TransferTypeId, qbe.TransferTypeCode, qbe.TransferTypeName);
        }
        
        public int SelectCount(int? transferTypeId, string transferTypeCode, string transferTypeName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(transferTypeId, transferTypeCode, transferTypeName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TransferType", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.TransferType> Select(int? transferTypeId, string transferTypeCode, string transferTypeName)
        {
            return Select(transferTypeId, transferTypeCode, transferTypeName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.TransferType SelectSingle(int? transferTypeId)
        {
            string emptyTransferTypeCode = null;
            string emptyTransferTypeName = null;
            List<AssetManagment.Data.Objects.TransferType> list = Select(transferTypeId, emptyTransferTypeCode, emptyTransferTypeName);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.TransferType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("TransferType", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.TransferType>();
        }
        
        public List<AssetManagment.Data.Objects.TransferType> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.TransferType> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.TransferType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.TransferType> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.TransferType theTransferType, AssetManagment.Data.Objects.TransferType original_TransferType)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TransferTypeId", original_TransferType.TransferTypeId, theTransferType.TransferTypeId));
            values.Add(new FieldValue("TransferTypeCode", original_TransferType.TransferTypeCode, theTransferType.TransferTypeCode));
            values.Add(new FieldValue("TransferTypeName", original_TransferType.TransferTypeName, theTransferType.TransferTypeName));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.TransferType theTransferType, AssetManagment.Data.Objects.TransferType original_TransferType, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "TransferType";
            args.View = dataView;
            args.Values = CreateFieldValues(theTransferType, original_TransferType);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("TransferType", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTransferType);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.TransferType theTransferType, AssetManagment.Data.Objects.TransferType original_TransferType)
        {
            return ExecuteAction(theTransferType, original_TransferType, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.TransferType theTransferType)
        {
            return Update(theTransferType, SelectSingle(theTransferType.TransferTypeId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.TransferType theTransferType)
        {
            return ExecuteAction(theTransferType, new TransferType(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.TransferType theTransferType)
        {
            return ExecuteAction(theTransferType, theTransferType, "Select", "Delete", DeleteView);
        }
    }
}
