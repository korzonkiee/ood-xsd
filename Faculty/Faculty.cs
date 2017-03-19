namespace Xsd2 {
    using System;
    using System.Collections.Generic;
    
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/", IsNullable=false)]
    public partial class Faculty {
        
        private FacultyTeacher[] teachersField;
        
        private FacultyStudent[] studentsField;
        
        private FacultyCourse[] coursesField;
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Teacher", IsNullable=false)]
        public FacultyTeacher[] Teachers {
            get {
                return this.teachersField;
            }
            set {
                this.teachersField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Student", IsNullable=false)]
        public FacultyStudent[] Students {
            get {
                return this.studentsField;
            }
            set {
                this.studentsField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Course", IsNullable=false)]
        public FacultyCourse[] Courses {
            get {
                return this.coursesField;
            }
            set {
                this.coursesField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/")]
    public partial class FacultyTeacher {
        
        private string nameField;
        
        private string surnameField;
        
        private FacultyTeacherCoursePartReference[] classesField;
        
        private string loginField;
        
        /// <uwagi/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <uwagi/>
        public string Surname {
            get {
                return this.surnameField;
            }
            set {
                this.surnameField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CoursePartReference", IsNullable=false)]
        public FacultyTeacherCoursePartReference[] Classes {
            get {
                return this.classesField;
            }
            set {
                this.classesField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/")]
    public partial class FacultyTeacherCoursePartReference {
        
        private FacultyTeacherCoursePartReferenceStudentReference[] studentsField;
        
        private string codeField;
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlArrayItemAttribute("StudentReference", IsNullable=false)]
        public FacultyTeacherCoursePartReferenceStudentReference[] Students {
            get {
                return this.studentsField;
            }
            set {
                this.studentsField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/")]
    public partial class FacultyTeacherCoursePartReferenceStudentReference {
        
        private string loginField;
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/")]
    public partial class FacultyStudent {
        
        private string nameField;
        
        private string surnameField;
        
        private string loginField;
        
        /// <uwagi/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <uwagi/>
        public string Surname {
            get {
                return this.surnameField;
            }
            set {
                this.surnameField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/")]
    public partial class FacultyCourse {
        
        private FacultyCourseCoursePart[] coursePartField;
        
        private string nameField;
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlElementAttribute("CoursePart")]
        public FacultyCourseCoursePart[] CoursePart {
            get {
                return this.coursePartField;
            }
            set {
                this.coursePartField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/")]
    public partial class FacultyCourseCoursePart {
        
        private string codeField;
        
        private courseType typeField;
        
        private byte weekhoursField;
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public courseType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte weekhours {
            get {
                return this.weekhoursField;
            }
            set {
                this.weekhoursField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ww2.mini.pw.edu.pl/dla-studenta/plan/", IsNullable=false)]
    public enum courseType {
        
        /// <uwagi/>
        lecture,
        
        /// <uwagi/>
        exercises,
        
        /// <uwagi/>
        laboratories,
        
        /// <uwagi/>
        project,
    }
}
