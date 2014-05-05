using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AssetManagment.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Locations
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _locationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationsName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationsCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentLocationsLocationsName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _parrentLocationsId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentLocationsAddressAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parrentLocationsAddressAddrressTypeAddressCode;
        
        public Locations()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string LocationsName
        {
            get
            {
                return _locationsName;
            }
            set
            {
                _locationsName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LocationsCode
        {
            get
            {
                return _locationsCode;
            }
            set
            {
                _locationsCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParrentLocationsLocationsName
        {
            get
            {
                return _parrentLocationsLocationsName;
            }
            set
            {
                _parrentLocationsLocationsName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ParrentLocationsId
        {
            get
            {
                return _parrentLocationsId;
            }
            set
            {
                _parrentLocationsId = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ParrentLocationsAddressAddrressTypeAddressCode
        {
            get
            {
                return _parrentLocationsAddressAddrressTypeAddressCode;
            }
            set
            {
                _parrentLocationsAddressAddrressTypeAddressCode = value;
            }
        }
        
        public static List<AssetManagment.Data.Objects.Locations> Select(int? locationsId, string locationsName, string locationsCode, string parrentLocationsLocationsName, int? parrentLocationsId, string parrentLocationsAddressAddress, string parrentLocationsAddressAddrressTypeAddressCode)
        {
            return new LocationsFactory().Select(locationsId, locationsName, locationsCode, parrentLocationsLocationsName, parrentLocationsId, parrentLocationsAddressAddress, parrentLocationsAddressAddrressTypeAddressCode);
        }
        
        public static List<AssetManagment.Data.Objects.Locations> Select(AssetManagment.Data.Objects.Locations qbe)
        {
            return new LocationsFactory().Select(qbe);
        }
        
        public static List<AssetManagment.Data.Objects.Locations> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new LocationsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Locations> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new LocationsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Locations> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new LocationsFactory().Select(filter, sort, LocationsFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Locations> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new LocationsFactory().Select(filter, sort, LocationsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<AssetManagment.Data.Objects.Locations> Select(string filter, BusinessObjectParameters parameters)
        {
            return new LocationsFactory().Select(filter, null, LocationsFactory.SelectView, parameters);
        }
        
        public static List<AssetManagment.Data.Objects.Locations> Select(string filter, params FieldValue[] parameters)
        {
            return new LocationsFactory().Select(filter, null, LocationsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Locations SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new LocationsFactory().SelectSingle(filter, parameters);
        }
        
        public static AssetManagment.Data.Objects.Locations SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new LocationsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static AssetManagment.Data.Objects.Locations SelectSingle(int? locationsId)
        {
            return new LocationsFactory().SelectSingle(locationsId);
        }
        
        public int Insert()
        {
            return new LocationsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new LocationsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new LocationsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("LocationsId: {0}", this.LocationsId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class LocationsFactory
    {
        
        public LocationsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Locations");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Locations");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Locations");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Locations");
            }
        }
        
        public static LocationsFactory Create()
        {
            return new LocationsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? locationsId, string locationsName, string locationsCode, string parrentLocationsLocationsName, int? parrentLocationsId, string parrentLocationsAddressAddress, string parrentLocationsAddressAddrressTypeAddressCode, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (locationsId.HasValue)
            	filter.Add(("LocationsId:=" + locationsId.Value.ToString()));
            if (!(String.IsNullOrEmpty(locationsName)))
            	filter.Add(("LocationsName:*" + locationsName));
            if (!(String.IsNullOrEmpty(locationsCode)))
            	filter.Add(("LocationsCode:*" + locationsCode));
            if (!(String.IsNullOrEmpty(parrentLocationsLocationsName)))
            	filter.Add(("ParrentLocationsLocationsName:*" + parrentLocationsLocationsName));
            if (parrentLocationsId.HasValue)
            	filter.Add(("ParrentLocationsId:=" + parrentLocationsId.Value.ToString()));
            if (!(String.IsNullOrEmpty(parrentLocationsAddressAddress)))
            	filter.Add(("ParrentLocationsAddressAddress:*" + parrentLocationsAddressAddress));
            if (!(String.IsNullOrEmpty(parrentLocationsAddressAddrressTypeAddressCode)))
            	filter.Add(("ParrentLocationsAddressAddrressTypeAddressCode:*" + parrentLocationsAddressAddrressTypeAddressCode));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<AssetManagment.Data.Objects.Locations> Select(int? locationsId, string locationsName, string locationsCode, string parrentLocationsLocationsName, int? parrentLocationsId, string parrentLocationsAddressAddress, string parrentLocationsAddressAddrressTypeAddressCode, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(locationsId, locationsName, locationsCode, parrentLocationsLocationsName, parrentLocationsId, parrentLocationsAddressAddress, parrentLocationsAddressAddrressTypeAddressCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Locations", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Locations>();
        }
        
        public List<AssetManagment.Data.Objects.Locations> Select(AssetManagment.Data.Objects.Locations qbe)
        {
            return Select(qbe.LocationsId, qbe.LocationsName, qbe.LocationsCode, qbe.ParrentLocationsLocationsName, qbe.ParrentLocationsId, qbe.ParrentLocationsAddressAddress, qbe.ParrentLocationsAddressAddrressTypeAddressCode);
        }
        
        public int SelectCount(int? locationsId, string locationsName, string locationsCode, string parrentLocationsLocationsName, int? parrentLocationsId, string parrentLocationsAddressAddress, string parrentLocationsAddressAddrressTypeAddressCode, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(locationsId, locationsName, locationsCode, parrentLocationsLocationsName, parrentLocationsId, parrentLocationsAddressAddress, parrentLocationsAddressAddrressTypeAddressCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Locations", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<AssetManagment.Data.Objects.Locations> Select(int? locationsId, string locationsName, string locationsCode, string parrentLocationsLocationsName, int? parrentLocationsId, string parrentLocationsAddressAddress, string parrentLocationsAddressAddrressTypeAddressCode)
        {
            return Select(locationsId, locationsName, locationsCode, parrentLocationsLocationsName, parrentLocationsId, parrentLocationsAddressAddress, parrentLocationsAddressAddrressTypeAddressCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public AssetManagment.Data.Objects.Locations SelectSingle(int? locationsId)
        {
            List<AssetManagment.Data.Objects.Locations> list = Select(locationsId, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<AssetManagment.Data.Objects.Locations> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Locations", dataView, request);
            return page.ToList<AssetManagment.Data.Objects.Locations>();
        }
        
        public List<AssetManagment.Data.Objects.Locations> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<AssetManagment.Data.Objects.Locations> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public AssetManagment.Data.Objects.Locations SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<AssetManagment.Data.Objects.Locations> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(AssetManagment.Data.Objects.Locations theLocations, AssetManagment.Data.Objects.Locations original_Locations)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("LocationsId", original_Locations.LocationsId, theLocations.LocationsId, true));
            values.Add(new FieldValue("LocationsName", original_Locations.LocationsName, theLocations.LocationsName));
            values.Add(new FieldValue("LocationsCode", original_Locations.LocationsCode, theLocations.LocationsCode));
            values.Add(new FieldValue("ParrentLocationsLocationsName", original_Locations.ParrentLocationsLocationsName, theLocations.ParrentLocationsLocationsName, true));
            values.Add(new FieldValue("ParrentLocationsId", original_Locations.ParrentLocationsId, theLocations.ParrentLocationsId));
            values.Add(new FieldValue("ParrentLocationsAddressAddress", original_Locations.ParrentLocationsAddressAddress, theLocations.ParrentLocationsAddressAddress, true));
            values.Add(new FieldValue("ParrentLocationsAddressAddrressTypeAddressCode", original_Locations.ParrentLocationsAddressAddrressTypeAddressCode, theLocations.ParrentLocationsAddressAddrressTypeAddressCode, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(AssetManagment.Data.Objects.Locations theLocations, AssetManagment.Data.Objects.Locations original_Locations, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Locations";
            args.View = dataView;
            args.Values = CreateFieldValues(theLocations, original_Locations);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Locations", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theLocations);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(AssetManagment.Data.Objects.Locations theLocations, AssetManagment.Data.Objects.Locations original_Locations)
        {
            return ExecuteAction(theLocations, original_Locations, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(AssetManagment.Data.Objects.Locations theLocations)
        {
            return Update(theLocations, SelectSingle(theLocations.LocationsId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(AssetManagment.Data.Objects.Locations theLocations)
        {
            return ExecuteAction(theLocations, new Locations(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(AssetManagment.Data.Objects.Locations theLocations)
        {
            return ExecuteAction(theLocations, theLocations, "Select", "Delete", DeleteView);
        }
    }
}
