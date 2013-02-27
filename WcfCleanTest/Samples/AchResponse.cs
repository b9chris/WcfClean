using System.Linq;
using System.Text;

namespace WcfCleanTest.Samples.AchResponseSample
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
    public partial class AchResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        private string[] noteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
            }
        }

		private bool messageSpecifiedField;

		public bool MessageSpecified {
            get {
                return this.messageSpecifiedField;
            }
            set {
                this.messageSpecifiedField = value;
            }
        }

        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Order=1)]
        public string[] Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
                this.RaisePropertyChanged("Note");
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
}
