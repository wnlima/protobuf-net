﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3031
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.NWind
{
    using System.Runtime.Serialization;
    using System;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "OrderSet", Namespace = "http://schemas.datacontract.org/2004/07/WcfServer")]
    [System.SerializableAttribute()]
    public partial class OrderSet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WcfClient.NWind.Order> OrdersField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.Collections.Generic.List<WcfClient.NWind.Order> Orders
        {
            get
            {
                return this.OrdersField;
            }
            set
            {
                if ((object.ReferenceEquals(this.OrdersField, value) != true))
                {
                    this.OrdersField = value;
                    this.RaisePropertyChanged("Orders");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Order", Namespace = "http://schemas.datacontract.org/2004/07/WcfServer")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIDField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerIDField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> EmployeeIDField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> OrderDateField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> RequiredDateField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ShippedDateField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ShipViaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> FreightField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipNameField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipAddressField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipCityField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipRegionField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipPostalCodeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipCountryField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WcfClient.NWind.Order_Detail> Order_DetailsField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int OrderID
        {
            get
            {
                return this.OrderIDField;
            }
            set
            {
                if ((this.OrderIDField.Equals(value) != true))
                {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public string CustomerID
        {
            get
            {
                return this.CustomerIDField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CustomerIDField, value) != true))
                {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
        public System.Nullable<int> EmployeeID
        {
            get
            {
                return this.EmployeeIDField;
            }
            set
            {
                if ((this.EmployeeIDField.Equals(value) != true))
                {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public System.Nullable<System.DateTime> OrderDate
        {
            get
            {
                return this.OrderDateField;
            }
            set
            {
                if ((this.OrderDateField.Equals(value) != true))
                {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
        public System.Nullable<System.DateTime> RequiredDate
        {
            get
            {
                return this.RequiredDateField;
            }
            set
            {
                if ((this.RequiredDateField.Equals(value) != true))
                {
                    this.RequiredDateField = value;
                    this.RaisePropertyChanged("RequiredDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
        public System.Nullable<System.DateTime> ShippedDate
        {
            get
            {
                return this.ShippedDateField;
            }
            set
            {
                if ((this.ShippedDateField.Equals(value) != true))
                {
                    this.ShippedDateField = value;
                    this.RaisePropertyChanged("ShippedDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
        public System.Nullable<int> ShipVia
        {
            get
            {
                return this.ShipViaField;
            }
            set
            {
                if ((this.ShipViaField.Equals(value) != true))
                {
                    this.ShipViaField = value;
                    this.RaisePropertyChanged("ShipVia");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
        public System.Nullable<decimal> Freight
        {
            get
            {
                return this.FreightField;
            }
            set
            {
                if ((this.FreightField.Equals(value) != true))
                {
                    this.FreightField = value;
                    this.RaisePropertyChanged("Freight");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
        public string ShipName
        {
            get
            {
                return this.ShipNameField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ShipNameField, value) != true))
                {
                    this.ShipNameField = value;
                    this.RaisePropertyChanged("ShipName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 10)]
        public string ShipAddress
        {
            get
            {
                return this.ShipAddressField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ShipAddressField, value) != true))
                {
                    this.ShipAddressField = value;
                    this.RaisePropertyChanged("ShipAddress");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 11)]
        public string ShipCity
        {
            get
            {
                return this.ShipCityField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ShipCityField, value) != true))
                {
                    this.ShipCityField = value;
                    this.RaisePropertyChanged("ShipCity");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 12)]
        public string ShipRegion
        {
            get
            {
                return this.ShipRegionField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ShipRegionField, value) != true))
                {
                    this.ShipRegionField = value;
                    this.RaisePropertyChanged("ShipRegion");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 13)]
        public string ShipPostalCode
        {
            get
            {
                return this.ShipPostalCodeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ShipPostalCodeField, value) != true))
                {
                    this.ShipPostalCodeField = value;
                    this.RaisePropertyChanged("ShipPostalCode");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 14)]
        public string ShipCountry
        {
            get
            {
                return this.ShipCountryField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ShipCountryField, value) != true))
                {
                    this.ShipCountryField = value;
                    this.RaisePropertyChanged("ShipCountry");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 15)]
        public System.Collections.Generic.List<WcfClient.NWind.Order_Detail> Order_Details
        {
            get
            {
                return this.Order_DetailsField;
            }
            set
            {
                if ((object.ReferenceEquals(this.Order_DetailsField, value) != true))
                {
                    this.Order_DetailsField = value;
                    this.RaisePropertyChanged("Order_Details");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Order_Detail", Namespace = "http://schemas.datacontract.org/2004/07/WcfServer")]
    [System.SerializableAttribute()]
    public partial class Order_Detail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIDField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnitPriceField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short QuantityField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float DiscountField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int OrderID
        {
            get
            {
                return this.OrderIDField;
            }
            set
            {
                if ((this.OrderIDField.Equals(value) != true))
                {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int ProductID
        {
            get
            {
                return this.ProductIDField;
            }
            set
            {
                if ((this.ProductIDField.Equals(value) != true))
                {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public decimal UnitPrice
        {
            get
            {
                return this.UnitPriceField;
            }
            set
            {
                if ((this.UnitPriceField.Equals(value) != true))
                {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public short Quantity
        {
            get
            {
                return this.QuantityField;
            }
            set
            {
                if ((this.QuantityField.Equals(value) != true))
                {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
        public float Discount
        {
            get
            {
                return this.DiscountField;
            }
            set
            {
                if ((this.DiscountField.Equals(value) != true))
                {
                    this.DiscountField = value;
                    this.RaisePropertyChanged("Discount");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "NWind.INWindService")]
    public interface INWindService
    {

        [System.ServiceModel.OperationContract]
        OrderSet LoadFoo();

        [System.ServiceModel.OperationContract]
        [ProtoBuf.ServiceModel.ProtoBehavior]
        OrderSet LoadBar();

        [System.ServiceModel.OperationContract]
        OrderSet RoundTripFoo(OrderSet set);

        [System.ServiceModel.OperationContract]
        [ProtoBuf.ServiceModel.ProtoBehavior]
        OrderSet RoundTripBar(OrderSet set);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface INWindServiceChannel : WcfClient.NWind.INWindService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class NWindServiceClient : System.ServiceModel.ClientBase<WcfClient.NWind.INWindService>, WcfClient.NWind.INWindService
    {

        public NWindServiceClient()
        {
        }

        public NWindServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public NWindServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public NWindServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public NWindServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public WcfClient.NWind.OrderSet LoadFoo()
        {
            return base.Channel.LoadFoo();
        }

        public WcfClient.NWind.OrderSet LoadBar()
        {
            return base.Channel.LoadBar();
        }

        public WcfClient.NWind.OrderSet RoundTripFoo(WcfClient.NWind.OrderSet set)
        {
            return base.Channel.RoundTripFoo(set);
        }

        public WcfClient.NWind.OrderSet RoundTripBar(WcfClient.NWind.OrderSet set)
        {
            return base.Channel.RoundTripBar(set);
        }
    }
}