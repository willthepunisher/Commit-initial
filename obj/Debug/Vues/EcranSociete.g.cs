﻿#pragma checksum "..\..\..\Vues\EcranSociete.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D68BABEE16F8B55B89B0A8FABEE4E65BA1FEC388C20C67922F4524E874E3EA5E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Bourses.Vues;
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


namespace Bourses.Vues {
    
    
    /// <summary>
    /// EcranSociete
    /// </summary>
    public partial class EcranSociete : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\Vues\EcranSociete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRaisonSociale;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Vues\EcranSociete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDateCreation;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Vues\EcranSociete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNbAction;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Vues\EcranSociete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtValeurUnitaire;
        
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
            System.Uri resourceLocater = new System.Uri("/Bourses;component/vues/ecransociete.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vues\EcranSociete.xaml"
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
            this.txtRaisonSociale = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtDateCreation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtNbAction = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtValeurUnitaire = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 65 "..\..\..\Vues\EcranSociete.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdAjouterSociete);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 66 "..\..\..\Vues\EcranSociete.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdModifierSociete);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 67 "..\..\..\Vues\EcranSociete.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdSupprimerSociete);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 68 "..\..\..\Vues\EcranSociete.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdViderSociete);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
