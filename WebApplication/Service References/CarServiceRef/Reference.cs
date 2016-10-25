﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.CarServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/WcfServices")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BodyTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DoorNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReleaseYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SeriesField;

        public Car(string brand, string series, int releaseYear, int doorNum, string color, string bodyType)
        {
            Brand = brand;
            Series = series;
            ReleaseYear = releaseYear;
            DoorNum = doorNum;
            Color = color;
            BodyType = bodyType;
        }

        public Car(string id, string brand, string series, int releaseYear, int doorNum, string color, string bodyType)
        {
            Id = id;
            Brand = brand;
            Series = series;
            ReleaseYear = releaseYear;
            DoorNum = doorNum;
            Color = color;
            BodyType = bodyType;
        }

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BodyType {
            get {
                return this.BodyTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.BodyTypeField, value) != true)) {
                    this.BodyTypeField = value;
                    this.RaisePropertyChanged("BodyType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DoorNum {
            get {
                return this.DoorNumField;
            }
            set {
                if ((this.DoorNumField.Equals(value) != true)) {
                    this.DoorNumField = value;
                    this.RaisePropertyChanged("DoorNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReleaseYear {
            get {
                return this.ReleaseYearField;
            }
            set {
                if ((this.ReleaseYearField.Equals(value) != true)) {
                    this.ReleaseYearField = value;
                    this.RaisePropertyChanged("ReleaseYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Series {
            get {
                return this.SeriesField;
            }
            set {
                if ((object.ReferenceEquals(this.SeriesField, value) != true)) {
                    this.SeriesField = value;
                    this.RaisePropertyChanged("Series");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarServiceRef.ICarService")]
    public interface ICarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/getAllCars", ReplyAction="http://tempuri.org/ICarService/getAllCarsResponse")]
        WebApplication.CarServiceRef.Car[] getAllCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/getAllCars", ReplyAction="http://tempuri.org/ICarService/getAllCarsResponse")]
        System.Threading.Tasks.Task<WebApplication.CarServiceRef.Car[]> getAllCarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/getCar", ReplyAction="http://tempuri.org/ICarService/getCarResponse")]
        WebApplication.CarServiceRef.Car getCar(string carId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/getCar", ReplyAction="http://tempuri.org/ICarService/getCarResponse")]
        System.Threading.Tasks.Task<WebApplication.CarServiceRef.Car> getCarAsync(string carId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/addCar", ReplyAction="http://tempuri.org/ICarService/addCarResponse")]
        void addCar(WebApplication.CarServiceRef.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/addCar", ReplyAction="http://tempuri.org/ICarService/addCarResponse")]
        System.Threading.Tasks.Task addCarAsync(WebApplication.CarServiceRef.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/updateCar", ReplyAction="http://tempuri.org/ICarService/updateCarResponse")]
        void updateCar(WebApplication.CarServiceRef.Car updatedCar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/updateCar", ReplyAction="http://tempuri.org/ICarService/updateCarResponse")]
        System.Threading.Tasks.Task updateCarAsync(WebApplication.CarServiceRef.Car updatedCar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/deleteCar", ReplyAction="http://tempuri.org/ICarService/deleteCarResponse")]
        void deleteCar(string carId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/deleteCar", ReplyAction="http://tempuri.org/ICarService/deleteCarResponse")]
        System.Threading.Tasks.Task deleteCarAsync(string carId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarServiceChannel : WebApplication.CarServiceRef.ICarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarServiceClient : System.ServiceModel.ClientBase<WebApplication.CarServiceRef.ICarService>, WebApplication.CarServiceRef.ICarService {
        
        public CarServiceClient() {
        }
        
        public CarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication.CarServiceRef.Car[] getAllCars() {
            return base.Channel.getAllCars();
        }
        
        public System.Threading.Tasks.Task<WebApplication.CarServiceRef.Car[]> getAllCarsAsync() {
            return base.Channel.getAllCarsAsync();
        }
        
        public WebApplication.CarServiceRef.Car getCar(string carId) {
            return base.Channel.getCar(carId);
        }
        
        public System.Threading.Tasks.Task<WebApplication.CarServiceRef.Car> getCarAsync(string carId) {
            return base.Channel.getCarAsync(carId);
        }
        
        public void addCar(WebApplication.CarServiceRef.Car car) {
            base.Channel.addCar(car);
        }
        
        public System.Threading.Tasks.Task addCarAsync(WebApplication.CarServiceRef.Car car) {
            return base.Channel.addCarAsync(car);
        }
        
        public void updateCar(WebApplication.CarServiceRef.Car updatedCar) {
            base.Channel.updateCar(updatedCar);
        }
        
        public System.Threading.Tasks.Task updateCarAsync(WebApplication.CarServiceRef.Car updatedCar) {
            return base.Channel.updateCarAsync(updatedCar);
        }
        
        public void deleteCar(string carId) {
            base.Channel.deleteCar(carId);
        }
        
        public System.Threading.Tasks.Task deleteCarAsync(string carId) {
            return base.Channel.deleteCarAsync(carId);
        }
    }
}