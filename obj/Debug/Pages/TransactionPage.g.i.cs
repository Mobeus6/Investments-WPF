// Updated by XamlIntelliSenseFileGenerator 10/10/2022 4:20:25 PM
#pragma checksum "..\..\..\Pages\TransactionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9102F126A22182D9A49752E82BAEF958A1BF6F84B3E9DC25392643B9718209B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using LiveCharts.Wpf;
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
using WPFInvestment.Pages;
using WPFInvestment.User_Controls;


namespace WPFInvestment.Pages
{


    /// <summary>
    /// TransactionPage
    /// </summary>
    public partial class TransactionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 44 "..\..\..\Pages\TransactionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dateOfTransaction;

#line default
#line hidden


#line 46 "..\..\..\Pages\TransactionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tokenName;

#line default
#line hidden


#line 48 "..\..\..\Pages\TransactionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tokenQuantity;

#line default
#line hidden


#line 50 "..\..\..\Pages\TransactionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;

#line default
#line hidden


#line 60 "..\..\..\Pages\TransactionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SdateOfTransaction;

#line default
#line hidden


#line 62 "..\..\..\Pages\TransactionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StokenName;

#line default
#line hidden


#line 64 "..\..\..\Pages\TransactionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StokenQuantity;

#line default
#line hidden


#line 66 "..\..\..\Pages\TransactionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sprice;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFInvestment;component/pages/transactionpage.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Pages\TransactionPage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.homePage = ((WPFInvestment.Pages.TransactionPage)(target));
                    return;
                case 2:
                    this.dateOfTransaction = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.tokenName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.tokenQuantity = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.price = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.SdateOfTransaction = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.StokenName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.StokenQuantity = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 9:
                    this.Sprice = ((System.Windows.Controls.TextBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Page homePage;
        internal System.Windows.Controls.Button addBuyTransactionBtn;
        internal System.Windows.Controls.Button addSellTransactionBtn;
    }
}

