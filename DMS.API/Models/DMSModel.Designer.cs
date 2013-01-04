﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace DMS.API.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DefectManagementSystemEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DefectManagementSystemEntities object using the connection string found in the 'DefectManagementSystemEntities' section of the application configuration file.
        /// </summary>
        public DefectManagementSystemEntities() : base("name=DefectManagementSystemEntities", "DefectManagementSystemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DefectManagementSystemEntities object.
        /// </summary>
        public DefectManagementSystemEntities(string connectionString) : base(connectionString, "DefectManagementSystemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DefectManagementSystemEntities object.
        /// </summary>
        public DefectManagementSystemEntities(EntityConnection connection) : base(connection, "DefectManagementSystemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<WorkItem> WorkItems
        {
            get
            {
                if ((_WorkItems == null))
                {
                    _WorkItems = base.CreateObjectSet<WorkItem>("WorkItems");
                }
                return _WorkItems;
            }
        }
        private ObjectSet<WorkItem> _WorkItems;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the WorkItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWorkItems(WorkItem workItem)
        {
            base.AddObject("WorkItems", workItem);
        }

        #endregion

        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="firstName">No Metadata Documentation available.</param>
        /// <param name="lastName">No Metadata Documentation available.</param>
        /// <param name="loginId">No Metadata Documentation available.</param>
        /// <param name="password">No Metadata Documentation available.</param>
        public int sp_CreateUser(global::System.String firstName, global::System.String lastName, global::System.String loginId, global::System.String password)
        {
            ObjectParameter firstNameParameter;
            if (firstName != null)
            {
                firstNameParameter = new ObjectParameter("FirstName", firstName);
            }
            else
            {
                firstNameParameter = new ObjectParameter("FirstName", typeof(global::System.String));
            }
    
            ObjectParameter lastNameParameter;
            if (lastName != null)
            {
                lastNameParameter = new ObjectParameter("LastName", lastName);
            }
            else
            {
                lastNameParameter = new ObjectParameter("LastName", typeof(global::System.String));
            }
    
            ObjectParameter loginIdParameter;
            if (loginId != null)
            {
                loginIdParameter = new ObjectParameter("LoginId", loginId);
            }
            else
            {
                loginIdParameter = new ObjectParameter("LoginId", typeof(global::System.String));
            }
    
            ObjectParameter passwordParameter;
            if (password != null)
            {
                passwordParameter = new ObjectParameter("Password", password);
            }
            else
            {
                passwordParameter = new ObjectParameter("Password", typeof(global::System.String));
            }
    
            return base.ExecuteFunction("sp_CreateUser", firstNameParameter, lastNameParameter, loginIdParameter, passwordParameter);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DefectManagementSystemModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="login_Id">Initial value of the Login_Id property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        /// <param name="role">Initial value of the Role property.</param>
        public static User CreateUser(global::System.Int32 id, global::System.String login_Id, global::System.String password, global::System.Int32 role)
        {
            User user = new User();
            user.ID = id;
            user.Login_Id = login_Id;
            user.Password = password;
            user.Role = role;
            return user;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String First_Name
        {
            get
            {
                return _First_Name;
            }
            set
            {
                OnFirst_NameChanging(value);
                ReportPropertyChanging("First_Name");
                _First_Name = StructuralObject.SetValidValue(value, true, "First_Name");
                ReportPropertyChanged("First_Name");
                OnFirst_NameChanged();
            }
        }
        private global::System.String _First_Name;
        partial void OnFirst_NameChanging(global::System.String value);
        partial void OnFirst_NameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Last_Name
        {
            get
            {
                return _Last_Name;
            }
            set
            {
                OnLast_NameChanging(value);
                ReportPropertyChanging("Last_Name");
                _Last_Name = StructuralObject.SetValidValue(value, true, "Last_Name");
                ReportPropertyChanged("Last_Name");
                OnLast_NameChanged();
            }
        }
        private global::System.String _Last_Name;
        partial void OnLast_NameChanging(global::System.String value);
        partial void OnLast_NameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Login_Id
        {
            get
            {
                return _Login_Id;
            }
            set
            {
                OnLogin_IdChanging(value);
                ReportPropertyChanging("Login_Id");
                _Login_Id = StructuralObject.SetValidValue(value, false, "Login_Id");
                ReportPropertyChanged("Login_Id");
                OnLogin_IdChanged();
            }
        }
        private global::System.String _Login_Id;
        partial void OnLogin_IdChanging(global::System.String value);
        partial void OnLogin_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, false, "Password");
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Role
        {
            get
            {
                return _Role;
            }
            set
            {
                OnRoleChanging(value);
                ReportPropertyChanging("Role");
                _Role = StructuralObject.SetValidValue(value, "Role");
                ReportPropertyChanged("Role");
                OnRoleChanged();
            }
        }
        private global::System.Int32 _Role;
        partial void OnRoleChanging(global::System.Int32 value);
        partial void OnRoleChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DefectManagementSystemModel", Name="WorkItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WorkItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new WorkItem object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="type">Initial value of the Type property.</param>
        /// <param name="status">Initial value of the Status property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="priority">Initial value of the Priority property.</param>
        /// <param name="severity">Initial value of the Severity property.</param>
        /// <param name="assignTo">Initial value of the AssignTo property.</param>
        /// <param name="openedBy">Initial value of the OpenedBy property.</param>
        /// <param name="areaPath">Initial value of the AreaPath property.</param>
        public static WorkItem CreateWorkItem(global::System.Int32 id, global::System.Int32 type, global::System.Int32 status, global::System.String title, global::System.Int32 priority, global::System.Int32 severity, global::System.Int32 assignTo, global::System.Int32 openedBy, global::System.String areaPath)
        {
            WorkItem workItem = new WorkItem();
            workItem.ID = id;
            workItem.Type = type;
            workItem.Status = status;
            workItem.Title = title;
            workItem.Priority = priority;
            workItem.Severity = severity;
            workItem.AssignTo = assignTo;
            workItem.OpenedBy = openedBy;
            workItem.AreaPath = areaPath;
            return workItem;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Type
        {
            get
            {
                return _Type;
            }
            set
            {
                OnTypeChanging(value);
                ReportPropertyChanging("Type");
                _Type = StructuralObject.SetValidValue(value, "Type");
                ReportPropertyChanged("Type");
                OnTypeChanged();
            }
        }
        private global::System.Int32 _Type;
        partial void OnTypeChanging(global::System.Int32 value);
        partial void OnTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, "Status");
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.Int32 _Status;
        partial void OnStatusChanging(global::System.Int32 value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false, "Title");
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true, "Description");
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Priority
        {
            get
            {
                return _Priority;
            }
            set
            {
                OnPriorityChanging(value);
                ReportPropertyChanging("Priority");
                _Priority = StructuralObject.SetValidValue(value, "Priority");
                ReportPropertyChanged("Priority");
                OnPriorityChanged();
            }
        }
        private global::System.Int32 _Priority;
        partial void OnPriorityChanging(global::System.Int32 value);
        partial void OnPriorityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Severity
        {
            get
            {
                return _Severity;
            }
            set
            {
                OnSeverityChanging(value);
                ReportPropertyChanging("Severity");
                _Severity = StructuralObject.SetValidValue(value, "Severity");
                ReportPropertyChanged("Severity");
                OnSeverityChanged();
            }
        }
        private global::System.Int32 _Severity;
        partial void OnSeverityChanging(global::System.Int32 value);
        partial void OnSeverityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Environment
        {
            get
            {
                return _Environment;
            }
            set
            {
                OnEnvironmentChanging(value);
                ReportPropertyChanging("Environment");
                _Environment = StructuralObject.SetValidValue(value, true, "Environment");
                ReportPropertyChanged("Environment");
                OnEnvironmentChanged();
            }
        }
        private global::System.String _Environment;
        partial void OnEnvironmentChanging(global::System.String value);
        partial void OnEnvironmentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String OS
        {
            get
            {
                return _OS;
            }
            set
            {
                OnOSChanging(value);
                ReportPropertyChanging("OS");
                _OS = StructuralObject.SetValidValue(value, true, "OS");
                ReportPropertyChanged("OS");
                OnOSChanged();
            }
        }
        private global::System.String _OS;
        partial void OnOSChanging(global::System.String value);
        partial void OnOSChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Browser
        {
            get
            {
                return _Browser;
            }
            set
            {
                OnBrowserChanging(value);
                ReportPropertyChanging("Browser");
                _Browser = StructuralObject.SetValidValue(value, true, "Browser");
                ReportPropertyChanged("Browser");
                OnBrowserChanged();
            }
        }
        private global::System.String _Browser;
        partial void OnBrowserChanging(global::System.String value);
        partial void OnBrowserChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Resolution
        {
            get
            {
                return _Resolution;
            }
            set
            {
                OnResolutionChanging(value);
                ReportPropertyChanging("Resolution");
                _Resolution = StructuralObject.SetValidValue(value, "Resolution");
                ReportPropertyChanged("Resolution");
                OnResolutionChanged();
            }
        }
        private Nullable<global::System.Int32> _Resolution;
        partial void OnResolutionChanging(Nullable<global::System.Int32> value);
        partial void OnResolutionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Build
        {
            get
            {
                return _Build;
            }
            set
            {
                OnBuildChanging(value);
                ReportPropertyChanging("Build");
                _Build = StructuralObject.SetValidValue(value, "Build");
                ReportPropertyChanged("Build");
                OnBuildChanged();
            }
        }
        private Nullable<global::System.Int32> _Build;
        partial void OnBuildChanging(Nullable<global::System.Int32> value);
        partial void OnBuildChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AssignTo
        {
            get
            {
                return _AssignTo;
            }
            set
            {
                OnAssignToChanging(value);
                ReportPropertyChanging("AssignTo");
                _AssignTo = StructuralObject.SetValidValue(value, "AssignTo");
                ReportPropertyChanged("AssignTo");
                OnAssignToChanged();
            }
        }
        private global::System.Int32 _AssignTo;
        partial void OnAssignToChanging(global::System.Int32 value);
        partial void OnAssignToChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OpenedBy
        {
            get
            {
                return _OpenedBy;
            }
            set
            {
                OnOpenedByChanging(value);
                ReportPropertyChanging("OpenedBy");
                _OpenedBy = StructuralObject.SetValidValue(value, "OpenedBy");
                ReportPropertyChanged("OpenedBy");
                OnOpenedByChanged();
            }
        }
        private global::System.Int32 _OpenedBy;
        partial void OnOpenedByChanging(global::System.Int32 value);
        partial void OnOpenedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ActivatedBy
        {
            get
            {
                return _ActivatedBy;
            }
            set
            {
                OnActivatedByChanging(value);
                ReportPropertyChanging("ActivatedBy");
                _ActivatedBy = StructuralObject.SetValidValue(value, "ActivatedBy");
                ReportPropertyChanged("ActivatedBy");
                OnActivatedByChanged();
            }
        }
        private Nullable<global::System.Int32> _ActivatedBy;
        partial void OnActivatedByChanging(Nullable<global::System.Int32> value);
        partial void OnActivatedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ClosedBy
        {
            get
            {
                return _ClosedBy;
            }
            set
            {
                OnClosedByChanging(value);
                ReportPropertyChanging("ClosedBy");
                _ClosedBy = StructuralObject.SetValidValue(value, "ClosedBy");
                ReportPropertyChanged("ClosedBy");
                OnClosedByChanged();
            }
        }
        private Nullable<global::System.Int32> _ClosedBy;
        partial void OnClosedByChanging(Nullable<global::System.Int32> value);
        partial void OnClosedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AreaPath
        {
            get
            {
                return _AreaPath;
            }
            set
            {
                OnAreaPathChanging(value);
                ReportPropertyChanging("AreaPath");
                _AreaPath = StructuralObject.SetValidValue(value, false, "AreaPath");
                ReportPropertyChanged("AreaPath");
                OnAreaPathChanged();
            }
        }
        private global::System.String _AreaPath;
        partial void OnAreaPathChanging(global::System.String value);
        partial void OnAreaPathChanged();

        #endregion

    }

    #endregion

}
