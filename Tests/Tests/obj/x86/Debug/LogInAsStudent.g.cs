﻿#pragma checksum "..\..\..\LogInAsStudent.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "49DA82D6895F1D702849BAACB8CF9A22"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tests;


namespace Tests {
    
    
    /// <summary>
    /// LogInAsStudent
    /// </summary>
    public partial class LogInAsStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\LogInAsStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogIn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\LogInAsStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Name;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\LogInAsStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Group;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\LogInAsStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GroupBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\LogInAsStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Student;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\LogInAsStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StudentBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\LogInAsStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tests;component/loginasstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LogInAsStudent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LogIn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\LogInAsStudent.xaml"
            this.LogIn.Click += new System.Windows.RoutedEventHandler(this.LogIn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Name = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Group = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.GroupBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Student = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.StudentBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\LogInAsStudent.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

