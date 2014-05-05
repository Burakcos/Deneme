using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Product
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _productId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _parrentId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentProductCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productName;
        
        public Product()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string ParrentProductCode
        {
            get
            {
                return _parrentProductCode;
            }
            set
            {
                _parrentProductCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ProductCode
        {
            get
            {
                return _productCode;
            }
            set
            {
                _productCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.Product> Select(int? productId, int? parrentId, string parrentProductCode, string productCode, string productName)
        {
            return new ProductFactory().Select(productId, parrentId, parrentProductCode, productCode, productName);
        }
        
        public static List<AssetManagment.Data.Objects.Product> Select(AssetManagment.Data.Objects.Product qbe)
        {
            return new ProductFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.Product> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ProductFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Product> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ProductFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Product> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ProductFactory().Select(filter, sort, ProductFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Product> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ProductFactory().Select(filter, sort, ProductFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Product> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ProductFactory().Select(filter, null, ProductFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Product> Select(string filter, params FieldValue[] parameters)
        {
            return new ProductFactory().Select(filter, null, ProductFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Product SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ProductFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.Product SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ProductFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Product SelectSingle(int? productId)
        {
            return new ProductFactory().SelectSingle(productId);
        }
        
        public int Insert()
        {
            return new ProductFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ProductFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ProductFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ProductId: {0}", this.ProductId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ProductFactory
    {
        
        public ProductFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Product");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Product");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Product");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Product");
            }
        }
        
        public static ProductFactory Create()
        {
            return new ProductFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? productId, int? parrentId, string parrentProductCode, string productCode, string productName, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (productId.HasValue)
            	filter.Add(("ProductId:=" + productId.Value.ToString()));
            if (parrentId.HasValue)
            	filter.Add(("ParrentId:=" + parrentId.Value.ToString()));
            if (!(String.IsNullOrEmpty(parrentProductCode)))
            	filter.Add(("ParrentProductCode:*" + parrentProductCode));
            if (!(String.IsNullOrEmpty(productCode)))
            	filter.Add(("ProductCode:*" + productCode));
            if (!(String.IsNullOrEmpty(productName)))
            	filter.Add(("ProductName:*" + productName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.Product> Select(int? productId, int? parrentId, string parrentProductCode, string productCode, string productName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(productId, parrentId, parrentProductCode, productCode, productName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Product", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Product>();
        }
        
        public List<AssetManagment.Data.Objects.Product> Select(AssetManagment.Data.Objects.Product qbe)
        {
            return Select(qbe.ProductId, qbe.ParrentId, qbe.ParrentProductCode, qbe.ProductCode, qbe.ProductName);
        }
        
        public int SelectCount(int? productId, int? parrentId, string parrentProductCode, string productCode, string productName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(productId, parrentId, parrentProductCode, productCode, productName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Product", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.Product> Select(int? productId, int? parrentId, string parrentProductCode, string productCode, string productName)
        {
            return Select(productId, parrentId, parrentProductCode, productCode, productName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.Product SelectSingle(int? productId)
        {
            List<AssetManagment.Data.Objects.Product> list = Select(productId, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.Product> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Product", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Product>();
        }
        
        public List<AssetManagment.Data.Objects.Product> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.Product> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.Product SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.Product> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.Product theProduct, AssetManagment.Data.Objects.Product original_Product)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ProductId", original_Product.ProductId, theProduct.ProductId, true));
            values.Add(new FieldValue("ParrentId", original_Product.ParrentId, theProduct.ParrentId));
            values.Add(new FieldValue("ParrentProductCode", original_Product.ParrentProductCode, theProduct.ParrentProductCode, true));
            values.Add(new FieldValue("ProductCode", original_Product.ProductCode, theProduct.ProductCode));
            values.Add(new FieldValue("ProductName", original_Product.ProductName, theProduct.ProductName));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.Product theProduct, AssetManagment.Data.Objects.Product original_Product, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Product";
            args.View = dataView;
            args.Values = CreateFieldValues(theProduct, original_Product);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Product", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theProduct);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.Product theProduct, AssetManagment.Data.Objects.Product original_Product)
        {
            return ExecuteAction(theProduct, original_Product, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.Product theProduct)
        {
            return Update(theProduct, SelectSingle(theProduct.ProductId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.Product theProduct)
        {
            return ExecuteAction(theProduct, new Product(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.Product theProduct)
        {
            return ExecuteAction(theProduct, theProduct, "Select", "Delete", DeleteView);
        }
    }
}
