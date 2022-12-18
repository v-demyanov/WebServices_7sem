﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 18.12.2022 16:22:59
namespace WsDvrModel
{
    
    /// <summary>
    /// There are no comments for WsDvrEntities in the schema.
    /// </summary>
    public partial class WsDvrEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new WsDvrEntities object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public WsDvrEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Marks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Marks> Marks
        {
            get
            {
                if ((this._Marks == null))
                {
                    this._Marks = base.CreateQuery<Marks>("Marks");
                }
                return this._Marks;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Marks> _Marks;
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Students> Students
        {
            get
            {
                if ((this._Students == null))
                {
                    this._Students = base.CreateQuery<Students>("Students");
                }
                return this._Students;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Students> _Students;
        /// <summary>
        /// There are no comments for Marks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToMarks(Marks marks)
        {
            base.AddObject("Marks", marks);
        }
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToStudents(Students students)
        {
            base.AddObject("Students", students);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = "<edmx:Edmx Version=\"1.0\" xmlns:edmx=\"http://schemas.microsoft.com/ado/2007/06/edm" +
                "x\"><edmx:DataServices m:DataServiceVersion=\"1.0\" m:MaxDataServiceVersion=\"3.0\" x" +
                "mlns:m=\"http://schemas.microsoft.com/ado/2007/08/dataservices/metadata\"><Schema " +
                "Namespace=\"WsDvrModel\" xmlns=\"http://schemas.microsoft.com/ado/2009/11/edm\"><Ent" +
                "ityType Name=\"Marks\"><Key><PropertyRef Name=\"Id\" /></Key><Property Name=\"Id\" Typ" +
                "e=\"Edm.Int32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"htt" +
                "p://schemas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"Subject\"" +
                " Type=\"Edm.String\" Nullable=\"false\" MaxLength=\"300\" FixedLength=\"false\" Unicode=" +
                "\"true\" /><Property Name=\"StudentId\" Type=\"Edm.Int32\" Nullable=\"false\" /><Propert" +
                "y Name=\"Value\" Type=\"Edm.Int32\" Nullable=\"false\" /><NavigationProperty Name=\"Stu" +
                "dents\" Relationship=\"WsDvrModel.FK__Marks__StudentId__267ABA7A\" ToRole=\"Students" +
                "\" FromRole=\"Marks\" /></EntityType><EntityType Name=\"Students\"><Key><PropertyRef " +
                "Name=\"Id\" /></Key><Property Name=\"Id\" Type=\"Edm.Int32\" Nullable=\"false\" p6:Store" +
                "GeneratedPattern=\"Identity\" xmlns:p6=\"http://schemas.microsoft.com/ado/2009/02/e" +
                "dm/annotation\" /><Property Name=\"Name\" Type=\"Edm.String\" Nullable=\"false\" MaxLen" +
                "gth=\"300\" FixedLength=\"false\" Unicode=\"true\" /><NavigationProperty Name=\"Marks\" " +
                "Relationship=\"WsDvrModel.FK__Marks__StudentId__267ABA7A\" ToRole=\"Marks\" FromRole" +
                "=\"Students\" /></EntityType><Association Name=\"FK__Marks__StudentId__267ABA7A\"><E" +
                "nd Type=\"WsDvrModel.Students\" Role=\"Students\" Multiplicity=\"1\"><OnDelete Action=" +
                "\"Cascade\" /></End><End Type=\"WsDvrModel.Marks\" Role=\"Marks\" Multiplicity=\"*\" /><" +
                "ReferentialConstraint><Principal Role=\"Students\"><PropertyRef Name=\"Id\" /></Prin" +
                "cipal><Dependent Role=\"Marks\"><PropertyRef Name=\"StudentId\" /></Dependent></Refe" +
                "rentialConstraint></Association></Schema><Schema Namespace=\"Lab6.WebServices.Dat" +
                "abase\" xmlns=\"http://schemas.microsoft.com/ado/2009/11/edm\"><EntityContainer Nam" +
                "e=\"WsDvrEntities\" m:IsDefaultEntityContainer=\"true\"><EntitySet Name=\"Marks\" Enti" +
                "tyType=\"WsDvrModel.Marks\" /><EntitySet Name=\"Students\" EntityType=\"WsDvrModel.St" +
                "udents\" /><FunctionImport Name=\"AddStudent\" ReturnType=\"WsDvrModel.Students\" Ent" +
                "itySet=\"Students\" m:HttpMethod=\"GET\"><Parameter Name=\"name\" Type=\"Edm.String\" />" +
                "</FunctionImport><FunctionImport Name=\"UpdateStudent\" ReturnType=\"WsDvrModel.Stu" +
                "dents\" EntitySet=\"Students\" m:HttpMethod=\"GET\"><Parameter Name=\"id\" Type=\"Edm.In" +
                "t32\" Nullable=\"false\" /><Parameter Name=\"name\" Type=\"Edm.String\" /></FunctionImp" +
                "ort><AssociationSet Name=\"FK__Marks__StudentId__267ABA7A\" Association=\"WsDvrMode" +
                "l.FK__Marks__StudentId__267ABA7A\"><End Role=\"Marks\" EntitySet=\"Marks\" /><End Rol" +
                "e=\"Students\" EntitySet=\"Students\" /></AssociationSet></EntityContainer></Schema>" +
                "</edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for WsDvrModel.Marks in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Marks")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Marks : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Marks object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="subject">Initial value of Subject.</param>
        /// <param name="studentId">Initial value of StudentId.</param>
        /// <param name="value">Initial value of Value.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Marks CreateMarks(int ID, string subject, int studentId, int value)
        {
            Marks marks = new Marks();
            marks.Id = ID;
            marks.Subject = subject;
            marks.StudentId = studentId;
            marks.Value = value;
            return marks;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Subject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Subject
        {
            get
            {
                return this._Subject;
            }
            set
            {
                this.OnSubjectChanging(value);
                this._Subject = value;
                this.OnSubjectChanged();
                this.OnPropertyChanged("Subject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Subject;
        partial void OnSubjectChanging(string value);
        partial void OnSubjectChanged();
        /// <summary>
        /// There are no comments for Property StudentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int StudentId
        {
            get
            {
                return this._StudentId;
            }
            set
            {
                this.OnStudentIdChanging(value);
                this._StudentId = value;
                this.OnStudentIdChanged();
                this.OnPropertyChanged("StudentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _StudentId;
        partial void OnStudentIdChanging(int value);
        partial void OnStudentIdChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Value;
        partial void OnValueChanging(int value);
        partial void OnValueChanged();
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Students Students
        {
            get
            {
                return this._Students;
            }
            set
            {
                this._Students = value;
                this.OnPropertyChanged("Students");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Students _Students;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for WsDvrModel.Students in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Students")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Students : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Students object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Students CreateStudents(int ID, string name)
        {
            Students students = new Students();
            students.Id = ID;
            students.Name = name;
            return students;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Marks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Marks> Marks
        {
            get
            {
                return this._Marks;
            }
            set
            {
                this._Marks = value;
                this.OnPropertyChanged("Marks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Marks> _Marks = new global::System.Data.Services.Client.DataServiceCollection<Marks>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
