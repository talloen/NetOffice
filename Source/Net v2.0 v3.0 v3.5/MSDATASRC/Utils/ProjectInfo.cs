﻿//Generated by LateBindingApi.CodeGenerator
using System;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using LateBindingApi.Core;

namespace MSDATASRCApi.Utils
{
	#pragma warning disable
    /// <summary>
    /// necessary factory info, used from LateBindingApi.Core.Factory while Initialize()
    /// </summary>
    public class ProjectInfo : IFactoryInfo
    {
        #region Field

        private string   _namespace     = "LateBindingApi.MSDATASRCApi";
        private Guid     _componentGuid = new Guid("7C0FFAB0-CD84-11D0-949A-00A0C91110ED");
        private Assembly _assembly;

        #endregion

        #region Construction

        public ProjectInfo()
        {
            _assembly = Assembly.GetExecutingAssembly();
        }

        #endregion

        #region IFactoryInfo Members

        public string Namespace
        {
            get
            {
                return _namespace;
            }
        }

        public Guid ComponentGuid
        {
            get
            {
                return _componentGuid;
            }
        }

        public Assembly Assembly
        {
            get
            {
                return _assembly;
            }
        }

        #endregion
    }
    #pragma warning restore
}