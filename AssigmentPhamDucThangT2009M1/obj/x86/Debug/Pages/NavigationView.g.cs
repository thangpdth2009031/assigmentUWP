﻿#pragma checksum "C:\Users\trieu\source\repos\AssigmentPhamDucThangT2009M1\AssigmentPhamDucThangT2009M1\Pages\NavigationView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "95695A038D234ECABA1B7CA680E95653599249BE145726A0C054DFFB56E563A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssigmentPhamDucThangT2009M1.Pages
{
    partial class NavigationView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\NavigationView.xaml line 13
                {
                    this.ContainerStack = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Pages\NavigationView.xaml line 14
                {
                    this.nvSample = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.nvSample).SelectionChanged += this.NavigationView_SelectionChanged;
                }
                break;
            case 4: // Pages\NavigationView.xaml line 44
                {
                    this.PaneHyperlink = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 5: // Pages\NavigationView.xaml line 50
                {
                    this.contentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
