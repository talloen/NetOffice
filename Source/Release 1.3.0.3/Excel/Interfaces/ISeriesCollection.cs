//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface ISeriesCollection SupportByLibraryAttribute Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISeriesCollection : COMObject ,IEnumerable<NetOffice.ExcelApi.Series>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ISeriesCollection);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="Rowcol">NetOffice.ExcelApi.Enums.XlRowCol Rowcol</param>
		/// <param name="SeriesLabels">optional object SeriesLabels</param>
		/// <param name="CategoryLabels">optional object CategoryLabels</param>
		/// <param name="Replace">optional object Replace</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Series Add(object source, NetOffice.ExcelApi.Enums.XlRowCol rowcol, object seriesLabels, object categoryLabels, object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol, seriesLabels, categoryLabels, replace);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Series newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="Rowcol">NetOffice.ExcelApi.Enums.XlRowCol Rowcol</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Series Add(object source, NetOffice.ExcelApi.Enums.XlRowCol rowcol)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Series newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="Rowcol">NetOffice.ExcelApi.Enums.XlRowCol Rowcol</param>
		/// <param name="SeriesLabels">optional object SeriesLabels</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Series Add(object source, NetOffice.ExcelApi.Enums.XlRowCol rowcol, object seriesLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol, seriesLabels);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Series newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="Rowcol">NetOffice.ExcelApi.Enums.XlRowCol Rowcol</param>
		/// <param name="SeriesLabels">optional object SeriesLabels</param>
		/// <param name="CategoryLabels">optional object CategoryLabels</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Series Add(object source, NetOffice.ExcelApi.Enums.XlRowCol rowcol, object seriesLabels, object categoryLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol, seriesLabels, categoryLabels);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Series newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="Rowcol">optional object Rowcol</param>
		/// <param name="CategoryLabels">optional object CategoryLabels</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public object Extend(object source, object rowcol, object categoryLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol, categoryLabels);
			object returnItem = Invoker.MethodReturn(this, "Extend", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Source">object Source</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public object Extend(object source)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source);
			object returnItem = Invoker.MethodReturn(this, "Extend", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="Rowcol">optional object Rowcol</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public object Extend(object source, object rowcol)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol);
			object returnItem = Invoker.MethodReturn(this, "Extend", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.Series this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.ExcelApi.Series newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Rowcol">NetOffice.ExcelApi.Enums.XlRowCol Rowcol</param>
		/// <param name="SeriesLabels">optional object SeriesLabels</param>
		/// <param name="CategoryLabels">optional object CategoryLabels</param>
		/// <param name="Replace">optional object Replace</param>
		/// <param name="NewSeries">optional object NewSeries</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public object Paste(NetOffice.ExcelApi.Enums.XlRowCol rowcol, object seriesLabels, object categoryLabels, object replace, object newSeries)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol, seriesLabels, categoryLabels, replace, newSeries);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Rowcol">NetOffice.ExcelApi.Enums.XlRowCol Rowcol</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public object Paste(NetOffice.ExcelApi.Enums.XlRowCol rowcol)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Rowcol">NetOffice.ExcelApi.Enums.XlRowCol Rowcol</param>
		/// <param name="SeriesLabels">optional object SeriesLabels</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public object Paste(NetOffice.ExcelApi.Enums.XlRowCol rowcol, object seriesLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol, seriesLabels);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Rowcol">NetOffice.ExcelApi.Enums.XlRowCol Rowcol</param>
		/// <param name="SeriesLabels">optional object SeriesLabels</param>
		/// <param name="CategoryLabels">optional object CategoryLabels</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public object Paste(NetOffice.ExcelApi.Enums.XlRowCol rowcol, object seriesLabels, object categoryLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol, seriesLabels, categoryLabels);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Rowcol">NetOffice.ExcelApi.Enums.XlRowCol Rowcol</param>
		/// <param name="SeriesLabels">optional object SeriesLabels</param>
		/// <param name="CategoryLabels">optional object CategoryLabels</param>
		/// <param name="Replace">optional object Replace</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public object Paste(NetOffice.ExcelApi.Enums.XlRowCol rowcol, object seriesLabels, object categoryLabels, object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol, seriesLabels, categoryLabels, replace);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Series NewSeries()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NewSeries", paramsArray);
			NetOffice.ExcelApi.Series newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.Series _Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "_Default", paramsArray);
			NetOffice.ExcelApi.Series newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		#endregion

        #region IEnumerable<NetOffice.ExcelApi.Series> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Excel, 9,10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
        public IEnumerator<NetOffice.ExcelApi.Series> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.Series item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Excel, 9,10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}