Type.registerNamespace("Web");if(!Web)Web={};Web.DataViewResources={};Web.DataViewResources.Common={WaitHtml:'<div class="Wait"></div>'};Web.DataViewResources.Pager={ItemsPerPage:"Items per page: ",PageSizes:[10,15,20,25],ShowingItems:"Showing \u003cb\u003e{0}\u003c/b\u003e-\u003cb\u003e{1}\u003c/b\u003e of \u003cb\u003e{2}\u003c/b\u003e items",SelectionInfo:" (<b>{0}</b> selected)",Refresh:"Refresh",Next:"Next \u00bb",Previous:"\u00ab Previous",Page:"Page",PageButtonCount:10};Web.DataViewResources.ActionBar={View:"View"};Web.DataViewResources.ModalPopup={Close:"Close",MaxWidth:800,MaxHeight:600,OkButton:"OK",CancelButton:"Cancel",SaveButton:"Save",SaveAndNewButton:"Save and New"};Web.DataViewResources.Menu={SiteActions:"Site Actions",SeeAlso:"See Also",Summary:"Summary",Tasks:"Tasks",About:"About"};Web.DataViewResources.HeaderFilter={GenericSortAscending:"Smallest on Top",GenericSortDescending:"Largest on Top",StringSortAscending:"Ascending",StringSortDescending:"Descending",DateSortAscending:"Earliest on Top",DateSortDescending:"Latest on Top",EmptyValue:"(Empty)",BlankValue:"(Blank)",Loading:"Loading...",ClearFilter:"Clear Filter from {0}",SortBy:"Sort by {0}",MaxSampleTextLen:80,CustomFilterOption:"Filter..."};Web.DataViewResources.InfoBar={FilterApplied:"A filter has been applied.",ValueIs:' <span class="Highlight">{0}</span> ',Or:" or ",And:" and ",EqualTo:"is equal to ",LessThan:"is less than ",LessThanOrEqual:"is less than or equal to ",GreaterThan:"is greater than ",GreaterThanOrEqual:"is greater than or equal to ",Like:"is like ",StartsWith:"starts with ",Empty:"empty",QuickFind:" Any field contains "};Web.DataViewResources.Lookup={SelectToolTip:"Select {0}",ClearToolTip:"Clear {0}",NewToolTip:"New {0}",SelectLink:"(select)",ShowActionBar:true,DetailsToolTip:"View details for {0}",ShowDetailsInPopup:true,GenericNewToolTip:"Create New"};Web.DataViewResources.Validator={RequiredField:"This field is required.",EnforceRequiredFieldsWithDefaultValue:false,NumberIsExpected:"A number is expected.",BooleanIsExpected:"A logical value is expected.",DateIsExpected:"A date is expected."};var _mn=Sys.CultureInfo.CurrentCulture.dateTimeFormat.MonthNames;Web.DataViewResources.Data={NullValue:'<span class="NA">n/a</span>',NullValueInForms:"N/A",BooleanDefaultStyle:"DropDownList",BooleanOptionalDefaultItems:[[null,"N/A"],[false,"No"],[true,"Yes"]],BooleanDefaultItems:[[false,"No"],[true,"Yes"]],MaxReadOnlyStringLen:600,NoRecords:"No records found.",BlobHandler:"Blob.ashx",BlobDownloadLink:"download",BlobDownloadLinkReadOnly:'<span style="color:gray;">download</span>',BlobDownloadHint:"Click here to download the original file.",BatchUpdate:"update",NoteEditLabel:"edit",NoteDeleteLabel:"delete",NoteDeleteConfirm:"Delete?",UseLEV:'Paste \"{0}\"',Import:{UploadInstruction:"Please select the file to upload. The file must be in \u003cb\u003eCSV\u003c/b\u003e, \u003cb\u003eXLS\u003c/b\u003e, or \u003cb\u003eXLSX\u003c/b\u003e format.",DownloadTemplate:"Download import file template.",Uploading:"Your file is being uploaded to the server. Please wait...",MappingInstruction:"There are \u003cb\u003e{0}\u003c/b\u003e record(s) in the file \u003cb\u003e{1}\u003c/b\u003e ready to be processed.\u003cbr/\u003ePlease map the import fields from data file to the application fields and click \u003ci\u003eImport\u003c/i\u003e to start processing.",StartButton:"Import",AutoDetect:"(auto detect)",Processing:"Import file processing has been initiated. The imported data records will become available upon successful processing. You may need to refresh the relevant views/pages to see the imported records.",Email:"Send the import log to the following email addresses (optional)",EmailNotSpecified:"Recipient of the import log has not been specified. Proceed anyway?"},Filters:{Labels:{And:"and",Or:"or",Equals:"equals",Clear:"Clear",SelectAll:"(Select All)",Includes:"includes",FilterToolTip:"Change"},Number:{Text:"Number Filters",List:[{Function:"=",Text:"Equals",Prompt:true},{Function:"<>",Text:"Does Not Equal",Prompt:true},{Function:"<=",Text:"Less Than",Prompt:true},{Function:">=",Text:"Greater Than",Prompt:true},{Function:"$between",Text:"Between",Prompt:true},{Function:"$in",Text:"Includes",Prompt:true,Hidden:true},{Function:"$notin",Text:"Does Not Include",Prompt:true,Hidden:true}]},Text:{Text:"Text Filters",List:[{Function:"=",Text:"Equals",Prompt:true},{Function:"<>",Text:"Does Not Equal",Prompt:true},{Function:"$beginswith",Text:"Begins With",Prompt:true},{Function:"$doesnotbeginwith",Text:"Does Not Begin With",Prompt:true},{Function:"$contains",Text:"Contains",Prompt:true},{Function:"$doesnotcontain",Text:"Does Not Contain",Prompt:true},{Function:"$endswith",Text:"Ends With",Prompt:true},{Function:"$doesnotendwith",Text:"Does Not End With",Prompt:true},{Function:"$in",Text:"Includes",Prompt:true,Hidden:true},{Function:"$notin",Text:"Does Not Include",Prompt:true,Hidden:true}]},Boolean:{Text:"Logical Filters",List:[{Function:"$true",Text:"Yes"},{Function:"$false",Text:"No"}]},Date:{Text:"Date Filters",List:[{Function:"=",Text:"Equals",Prompt:true},{Function:"<>",Text:"Does Not Equal",Prompt:true},{Function:"<",Text:"Before",Prompt:true},{Function:">",Text:"After",Prompt:true},{Function:"$between",Text:"Between",Prompt:true},{Function:"$in",Text:"Includes",Prompt:true,Hidden:true},{Function:"$notin",Text:"Does Not Include",Prompt:true,Hidden:true},null,{Function:"$tomorrow",Text:"Tomorrow"},{Function:"$today",Text:"Today"},{Function:"$yesterday",Text:"Yesterday"},null,{Function:"$nextweek",Text:"Next Week"},{Function:"$thisweek",Text:"This Week"},{Function:"$lastweek",Text:"Last Week"},null,{Function:"$nextmonth",Text:"Next Month"},{Function:"$thismonth",Text:"This Month"},{Function:"$lastmonth",Text:"Last Month"},null,{Function:"$nextquarter",Text:"Next Quarter"},{Function:"$thisquarter",Text:"This Quarter"},{Function:"$lastquarter",Text:"Last Quarter"},null,{Function:"$nextyear",Text:"Next Year"},{Function:"$thisyear",Text:"This Year"},{Function:"$yeartodate",Text:"Year to Date"},{Function:"$lastyear",Text:"Last Year"},null,{Function:"$past",Text:"Past"},{Function:"$future",Text:"Future"},null,{Text:"All Dates in Period",List:[{Function:"$quarter1",Text:"Quarter 1"},{Function:"$quarter2",Text:"Quarter 2"},{Function:"$quarter3",Text:"Quarter 3"},{Function:"$quarter4",Text:"Quarter 4"},null,{Function:"$month1",Text:_mn[0]},{Function:"$month2",Text:_mn[1]},{Function:"$month3",Text:_mn[2]},{Function:"$month4",Text:_mn[3]},{Function:"$month5",Text:_mn[4]},{Function:"$month6",Text:_mn[5]},{Function:"$month7",Text:_mn[6]},{Function:"$month8",Text:_mn[7]},{Function:"$month9",Text:_mn[8]},{Function:"$month10",Text:_mn[9]},{Function:"$month11",Text:_mn[10]},{Function:"$month12",Text:_mn[11]}]}]}}};Web.DataViewResources.Form={ShowActionBar:true,ShowCalendarButton:true,RequiredFieldMarker:'<span class="Required">*</span>',RequiredFiledMarkerFootnote:"* - indicates a required field",SingleButtonRowFieldLimit:7,GeneralTabText:"General",Minimize:"Collapse",Maximize:"Expand"};Web.DataViewResources.Grid={InPlaceEditContextMenuEnabled:true,QuickFindText:"Quick Find",QuickFindToolTip:"Type to search the records and press Enter",ShowAdvancedSearch:"Show Advanced Search",VisibleSearchBarFields:3,DeleteSearchBarField:"(delete)",HideAdvancedSearch:"Hide Advanced Search",PerformAdvancedSearch:"Search",ResetAdvancedSearch:"Reset",NewRowLink:"Click here to create a new record.",RootNodeText:"Top Level",FlatTreeToggle:"Switch to Hierarchy",HierarchyTreeModeToggle:"Switch to Flat List",AddConditionText:"Add search condition",AddCondition:"Add Condition",RemoveCondition:"Remove Condition",ActionColumnHeaderText:"Actions",Aggregates:{None:{FmtStr:"",ToolTip:""},Sum:{FmtStr:"Sum: {0}",ToolTip:"Sum of {0}"},Count:{FmtStr:"Count: {0}",ToolTip:"Count of {0}"},Avg:{FmtStr:"Avg: {0}",ToolTip:"Average of {0}"},Max:{FmtStr:"Max: {0}",ToolTip:"Maximum of {0}"},Min:{FmtStr:"Min: {0}",ToolTip:"Minimum of {0}"}},Freeze:"Freeze",Unfreeze:"Unfreeze"};Web.DataViewResources.Views={DefaultDescriptions:{$DefaultGridViewDescription:"This is a list of {0}.",$DefaultEditViewDescription:"Please review {0} information below. Click Edit to change this record, click Delete to delete the record, or click Cancel/Close to return back.",$DefaultCreateViewDescription:"Please fill this form and click OK button to create a new {0} record. Click Cancel to return to the previous screen."},DefaultCategoryDescriptions:{$DefaultEditDescription:"These are the fields of the {0} record that can be edited.",$DefaultNewDescription:"Complete the form. Make sure to enter all required fields.",$DefaultReferenceDescription:"Additional details about {0} are provided in the reference information section."}};Web.DataViewResources.Actions={Scopes:{Grid:{Select:{HeaderText:"Select"},Edit:{HeaderText:"Edit"},Delete:{HeaderText:"Delete",Confirmation:"Delete?"},Select:{HeaderText:"Select"},Duplicate:{HeaderText:"Duplicate"},New:{HeaderText:"New"},BatchEdit:{HeaderText:"Batch Edit",CommandArgument:{editForm1:{HeaderText:"Batch Edit (Form)"}}},Open:{HeaderText:"Open"}},Form:{Edit:{HeaderText:"Edit"},Delete:{HeaderText:"Delete",Confirmation:"Delete?"},Cancel:{HeaderText:"Close",WhenLastCommandName:{Duplicate:{HeaderText:"Cancel"},Edit:{HeaderText:"Cancel"},New:{HeaderText:"Cancel"}}},Update:{HeaderText:"OK",WhenLastCommandName:{BatchEdit:{HeaderText:"Update Selection",Confirmation:"Update?"}}},Insert:{HeaderText:"OK"},Confirm:{HeaderText:"OK"}},ActionBar:{_Self:{Actions:{HeaderText:"Actions"},Report:{HeaderText:"Report"},Record:{HeaderText:"Record"}},New:{HeaderText:"New {0}",Description:"Create a new {0} record.",HeaderText2:"New",VarMaxLen:15},Edit:{HeaderText:"Edit"},Delete:{HeaderText:"Delete",Confirmation:"Delete?"},ExportCsv:{HeaderText:"Download",Description:"Download items in CSV format."},ExportRowset:{HeaderText:"Export to Spreadsheet",Description:"Analyze items with spreadsheet\u003cbr/\u003eapplication."},ExportRss:{HeaderText:"View RSS Feed",Description:"Syndicate items with an RSS reader."},Import:{HeaderText:"Import From File",Description:"Upload a CSV, XLS, or XLSX file\u003cbr/\u003eto import records."},Update:{HeaderText:"Save",Description:"Save changes to the database."},Insert:{HeaderText:"Save",Description:"Save new record to the database."},Cancel:{HeaderText:"Cancel",WhenLastCommandName:{Edit:{HeaderText:"Cancel",Description:"Cancel all record changes."},New:{HeaderText:"Cancel",Description:"Cancel new record."}}},Report:{HeaderText:"Report",Description:"Render a report in PDF format"},ReportAsPdf:{HeaderText:"PDF Document",Description:"View items as Adobe PDF document.\u003cbr/\u003eRequires a compatible reader."},ReportAsImage:{HeaderText:"Multipage Image",Description:"View items as a multipage TIFF image."},ReportAsExcel:{HeaderText:"Spreadsheet",Description:"View items in a formatted\u003cbr/\u003eMicrosoft Excel spreadsheet."},ReportAsWord:{HeaderText:"Microsoft Word",Description:"View items in a formatted\u003cbr/\u003eMicrosoft Word document."},DataSheet:{HeaderText:"Show in Data Sheet",Description:"Display items using a data sheet\u003cbr/\u003eformat."},Grid:{HeaderText:"Show in Standard View",Description:"Display items in the standard\u003cbr/\u003elist format."},Tree:{HeaderText:"Show Hierarchy",Description:"Display hierarchical relationships."},Search:{HeaderText:"Search",Description:"Search {0}"}},Row:{Update:{HeaderText:"Save",WhenLastCommandName:{BatchEdit:{HeaderText:"Update Selection",Confirmation:"Update?"}}},Insert:{HeaderText:"Insert"},Cancel:{HeaderText:"Cancel"}},ActionColumn:{Edit:{HeaderText:"Edit"},Delete:{HeaderText:"Delete",Confirmation:"Delete?"}}}};Web.DataViewResources.Editor={Undo:"Undo",Redo:"Redo",Bold:"Bold",Italic:"Italic",Underline:"Underline",Strikethrough:"Strike Through",Subscript:"Sub Script",Superscript:"Super Script",JustifyLeft:"Justify Left",JustifyCenter:"Justify Center",JustifyRight:"Justify Right",JustifyFull:"Justify Full",InsertOrderedList:"Insert Ordered List",InsertUnorderedList:"Insert Unordered List",CreateLink:"Create Link",UnLink:"Unlink",RemoveFormat:"Remove Format",SelectAll:"Select All",UnSelect:"UnSelect",Delete:"Delete",Cut:"Cut",Copy:"Copy",Paste:"Paste",BackColor:"Back Color",ForeColor:"Fore Color",FontName:"Font Name",FontSize:"Font Size",Indent:"Indent",Outdent:"Outdent",InsertHorizontalRule:"Insert Horizontal Rule",HorizontalSeparator:"Separator"};Web.DataViewResources.Mobile={UpOneLevel:"Up One Level",Back:"Back",Sort:"Sort",SortByField:"Select a field to change the sort order of \u003cb\u003e{0}\u003c/b\u003e.",SortByOptions:"Select the sort order of \u003cb\u003e{0}\u003c/b\u003e by the field \u003cb\u003e{1}\u003c/b\u003e in the list of options below.",DefaultOption:"Default",Filter:"Filter",Dock:"Dock",Undock:"Undock",List:"List",Grid:"Grid",AlternativeView:"Select an alternative view of data.",PresentationStyle:"Select a data presentation style.",LookupViewAction:"View",LookupSelectAction:"Select",LookupClearAction:"Clear",LookupNewAction:"New",LookupInstruction:"Please select \u003cb\u003e{0}\u003c/b\u003e in the list. ",LookupOriginalSelection:'The original selection is \u003cb\u003e\"{0}\"\u003c/b\u003e. '};typeof Sys!=="undefined"&&Sys.Application.notifyScriptLoaded()