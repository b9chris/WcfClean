using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Diagnostics;
using System;
using System.CodeDom.Compiler;

namespace WcfCleanTest.Samples.AchResponseSample
{
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class AchResponse : object, System.ComponentModel.INotifyPropertyChanged 
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected string _Message;

        [XmlElementAttribute(Order=0)]
		public string Message
		{
			get { return _Message; }
			set {
				_Message = value;
				MessageSpecified = true;
			}
		}


		public bool MessageSpecified { get; set; }

        [XmlElementAttribute("Note", Order=1)]
		public string[] Note { get; set; }
	}
}
