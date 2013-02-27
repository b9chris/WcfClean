using System.Xml.Serialization;
using System.ComponentModel;
using System.Diagnostics;
using System;
using System.CodeDom.Compiler;
using System.ServiceModel;

namespace Brass9.Transfirst.TransactionCentral
{

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/portal/soa/xsd/Faults/2009/01")]
	public class BaseFaultType : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string name { get; set; }

        [XmlElementAttribute(Order=1)]
		public string message { get; set; }

        [XmlElementAttribute(Order=2)]
		public string errorCode { get; set; }
	}

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

        [XmlElementAttribute(Order=0)]
		public string Message { get; set; }

        [XmlElementAttribute("Note", Order=1)]
		public string[] Note { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class AdditionalAmount : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public AdditionalAmountAccountType accountType { get; set; }

        [XmlElementAttribute(Order=1)]
		public AdditionalAmountAmountType amountType { get; set; }

        [XmlElementAttribute(Order=2)]
		public string currencyCode { get; set; }

        [XmlElementAttribute(Order=3)]
		public string amountSign { get; set; }

        [XmlElementAttribute(Order=4)]
		public string amount { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class AuthRsp : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string secRslt { get; set; }

        [XmlElementAttribute(Order=1)]
		public string avsRslt { get; set; }

        [XmlElementAttribute(Order=2)]
		public string aci { get; set; }

		protected AuthRspCavvRslt _cavvRslt;

        [XmlElementAttribute(Order=3)]
		public AuthRspCavvRslt cavvRslt
		{
			get { return _cavvRslt; }
			set {
				_cavvRslt = value;
				cavvRsltSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool cavvRsltSpecified { get; set; }

        [XmlElementAttribute(Order=4)]
		public string tranId { get; set; }

        [XmlElementAttribute(Order=5)]
		public string gwyTranId { get; set; }

        [XmlElementAttribute(Order=6)]
		public string issrNtwkId { get; set; }

        [XmlElementAttribute(Order=7)]
		public string valCode { get; set; }

        [XmlElementAttribute(Order=8)]
		public string comCardType { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Tax : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public int idcr { get; set; }

        [XmlElementAttribute(Order=1)]
		public string amt { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class ProdInfo : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public long prodId { get; set; }

        [XmlElementAttribute(Order=1)]
		public string quantity { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class RecurMan : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public long id { get; set; }

        [XmlElementAttribute(Order=1)]
		public string sec { get; set; }

		protected int _seccCode;

        [XmlElementAttribute(Order=2)]
		public int seccCode
		{
			get { return _seccCode; }
			set {
				_seccCode = value;
				seccCodeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool seccCodeSpecified { get; set; }

        [XmlElementAttribute("prodInfo", Order=3)]
		public ProdInfo[] prodInfo { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class RecurPmt : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public int pmtFreq { get; set; }

		protected int _initRecurPmtIdcr;

        [XmlElementAttribute(Order=1)]
		public int initRecurPmtIdcr
		{
			get { return _initRecurPmtIdcr; }
			set {
				_initRecurPmtIdcr = value;
				initRecurPmtIdcrSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool initRecurPmtIdcrSpecified { get; set; }

		protected int _pmtNr;

        [XmlElementAttribute(Order=2)]
		public int pmtNr
		{
			get { return _pmtNr; }
			set {
				_pmtNr = value;
				pmtNrSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool pmtNrSpecified { get; set; }

		protected int _nrOfPmt;

        [XmlElementAttribute(Order=3)]
		public int nrOfPmt
		{
			get { return _nrOfPmt; }
			set {
				_nrOfPmt = value;
				nrOfPmtSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool nrOfPmtSpecified { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Identity : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string type { get; set; }

        [XmlElementAttribute(Order=1)]
		public string nr { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class DriversLicense : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected DriversLicenseState _state;

        [XmlElementAttribute(Order=0)]
		public DriversLicenseState state
		{
			get { return _state; }
			set {
				_state = value;
				stateSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool stateSpecified { get; set; }

        [XmlElementAttribute(Order=1)]
		public string nr { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class AchEcheck : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string achId { get; set; }

        [XmlElementAttribute(Order=1)]
		public string achAcctInfo { get; set; }

        [XmlElementAttribute(Order=2)]
		public string bankRtNr { get; set; }

        [XmlElementAttribute(Order=3)]
		public string bankName { get; set; }

        [XmlElementAttribute(Order=4)]
		public string acctNr { get; set; }

        [XmlElementAttribute(Order=5)]
		public string acctNrEncrypt { get; set; }

		protected int _acctType;

        [XmlElementAttribute(Order=6)]
		public int acctType
		{
			get { return _acctType; }
			set {
				_acctType = value;
				acctTypeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool acctTypeSpecified { get; set; }

		protected int _seccCode;

        [XmlElementAttribute(Order=7)]
		public int seccCode
		{
			get { return _seccCode; }
			set {
				_seccCode = value;
				seccCodeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool seccCodeSpecified { get; set; }

		protected int _checkNr;

        [XmlElementAttribute(Order=8)]
		public int checkNr
		{
			get { return _checkNr; }
			set {
				_checkNr = value;
				checkNrSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool checkNrSpecified { get; set; }

		protected int _fraudChk;

        [XmlElementAttribute(Order=9)]
		public int fraudChk
		{
			get { return _fraudChk; }
			set {
				_fraudChk = value;
				fraudChkSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool fraudChkSpecified { get; set; }

        [XmlElementAttribute(Order=10)]
		public DriversLicense driversLicense { get; set; }

        [XmlElementAttribute(Order=11)]
		public Identity identity { get; set; }

        [XmlElementAttribute(Order=12)]
		public string dtBirth { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class TranData : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string swchKey { get; set; }

        [XmlElementAttribute(Order=1)]
		public string tranNr { get; set; }

		protected System.DateTime _dtTm;

        [XmlElementAttribute(Order=2)]
		public System.DateTime dtTm
		{
			get { return _dtTm; }
			set {
				_dtTm = value;
				dtTmSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool dtTmSpecified { get; set; }

        [XmlElementAttribute(Order=3)]
		public string amt { get; set; }

        [XmlElementAttribute(Order=4)]
		public string stan { get; set; }

        [XmlElementAttribute(Order=5)]
		public string auth { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class BillShip : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected int _type;

        [XmlElementAttribute(Order=0)]
		public int type
		{
			get { return _type; }
			set {
				_type = value;
				typeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool typeSpecified { get; set; }

        [XmlElementAttribute(Order=1)]
		public Contact contact { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Contact : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string id { get; set; }

        [XmlElementAttribute(Order=1)]
		public string firstName { get; set; }

        [XmlElementAttribute(Order=2)]
		public string lastName { get; set; }

        [XmlElementAttribute(Order=3)]
		public string fullName { get; set; }

        [XmlElementAttribute(Order=4)]
		public string coName { get; set; }

        [XmlElementAttribute(Order=5)]
		public string title { get; set; }

        [XmlElementAttribute("phone", Order=6)]
		public Phone[] phone { get; set; }

        [XmlElementAttribute(Order=7)]
		public string addrLn1 { get; set; }

        [XmlElementAttribute(Order=8)]
		public string addrLn2 { get; set; }

        [XmlElementAttribute(Order=9)]
		public string city { get; set; }

		protected ContactState _state;

        [XmlElementAttribute(Order=10)]
		public ContactState state
		{
			get { return _state; }
			set {
				_state = value;
				stateSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool stateSpecified { get; set; }

        [XmlElementAttribute(Order=11)]
		public string zipCode { get; set; }

        [XmlElementAttribute(Order=12)]
		public string ctry { get; set; }

        [XmlElementAttribute(Order=13)]
		public string email { get; set; }

		protected int _type;

        [XmlElementAttribute(Order=14)]
		public int type
		{
			get { return _type; }
			set {
				_type = value;
				typeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool typeSpecified { get; set; }

		protected int _stat;

        [XmlElementAttribute(Order=15)]
		public int stat
		{
			get { return _stat; }
			set {
				_stat = value;
				statSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool statSpecified { get; set; }

        [XmlElementAttribute(Order=16)]
		public string note { get; set; }

        [XmlElementAttribute(Order=17)]
		public Ship ship { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Phone : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public int type { get; set; }

        [XmlElementAttribute(Order=1)]
		public string nr { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Ship : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string fullName { get; set; }

        [XmlElementAttribute(Order=1)]
		public string addrLn1 { get; set; }

        [XmlElementAttribute(Order=2)]
		public string addrLn2 { get; set; }

        [XmlElementAttribute(Order=3)]
		public string city { get; set; }

		protected ShipState _state;

        [XmlElementAttribute(Order=4)]
		public ShipState state
		{
			get { return _state; }
			set {
				_state = value;
				stateSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool stateSpecified { get; set; }

        [XmlElementAttribute(Order=5)]
		public string zipCode { get; set; }

        [XmlElementAttribute(Order=6)]
		public string phone { get; set; }

        [XmlElementAttribute(Order=7)]
		public string email { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class PurcCardTax : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string type { get; set; }

        [XmlElementAttribute(Order=1)]
		public string desc { get; set; }

        [XmlElementAttribute(Order=2)]
		public string incld { get; set; }

        [XmlElementAttribute(Order=3)]
		public string amt { get; set; }

		protected int _rate;

        [XmlElementAttribute(Order=4)]
		public int rate
		{
			get { return _rate; }
			set {
				_rate = value;
				rateSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool rateSpecified { get; set; }

		protected int _rateExp;

        [XmlElementAttribute(Order=5)]
		public int rateExp
		{
			get { return _rateExp; }
			set {
				_rateExp = value;
				rateExpSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool rateExpSpecified { get; set; }

        [XmlElementAttribute(Order=6)]
		public string cardAcptrId { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class LineItem : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string itemNr { get; set; }

        [XmlElementAttribute(Order=1)]
		public string prodCode { get; set; }

        [XmlElementAttribute(Order=2)]
		public string custCode { get; set; }

        [XmlElementAttribute(Order=3)]
		public string cmdyCode { get; set; }

        [XmlElementAttribute(Order=4)]
		public string vatRefNr { get; set; }

        [XmlElementAttribute(Order=5)]
		public string desc { get; set; }

        [XmlElementAttribute(Order=6)]
		public string qty { get; set; }

		protected int _qtyExp;

        [XmlElementAttribute(Order=7)]
		public int qtyExp
		{
			get { return _qtyExp; }
			set {
				_qtyExp = value;
				qtyExpSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool qtyExpSpecified { get; set; }

        [XmlElementAttribute(Order=8)]
		public string unitOfMsr { get; set; }

        [XmlElementAttribute(Order=9)]
		public string unitPrc { get; set; }

		protected LineItemDcnt _dcnt;

        [XmlElementAttribute(Order=10)]
		public LineItemDcnt dcnt
		{
			get { return _dcnt; }
			set {
				_dcnt = value;
				dcntSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool dcntSpecified { get; set; }

        [XmlElementAttribute(Order=11)]
		public string dcntRt { get; set; }

        [XmlElementAttribute(Order=12)]
		public string dcntAmt { get; set; }

        [XmlElementAttribute(Order=13)]
		public string totAmt { get; set; }

		protected int _totAmtType;

        [XmlElementAttribute(Order=14)]
		public int totAmtType
		{
			get { return _totAmtType; }
			set {
				_totAmtType = value;
				totAmtTypeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool totAmtTypeSpecified { get; set; }

		protected int _supType;

        [XmlElementAttribute(Order=15)]
		public int supType
		{
			get { return _supType; }
			set {
				_supType = value;
				supTypeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool supTypeSpecified { get; set; }

		protected LineItemSign _sign;

        [XmlElementAttribute(Order=16)]
		public LineItemSign sign
		{
			get { return _sign; }
			set {
				_sign = value;
				signSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool signSpecified { get; set; }

        [XmlElementAttribute(Order=17)]
		public string privData { get; set; }

        [XmlElementAttribute("tax", Order=18)]
		public PurcCardTax[] tax { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class PurcCard : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string custId { get; set; }

        [XmlElementAttribute(Order=1)]
		public string cardAcptrTaxId { get; set; }

        [XmlElementAttribute(Order=2)]
		public string cardAcptrVatNr { get; set; }

        [XmlElementAttribute(Order=3)]
		public string cardAcptrRefNr { get; set; }

        [XmlElementAttribute(Order=4)]
		public string corpVatNr { get; set; }

        [XmlElementAttribute(Order=5)]
		public string custVatNr { get; set; }

        [XmlElementAttribute(Order=6)]
		public string mercOrdNr { get; set; }

        [XmlElementAttribute(Order=7)]
		public string invcNr { get; set; }

		protected System.DateTime _ordDt;

        [XmlElementAttribute(Order=8)]
		public System.DateTime ordDt
		{
			get { return _ordDt; }
			set {
				_ordDt = value;
				ordDtSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool ordDtSpecified { get; set; }

		protected System.DateTime _purcDt;

        [XmlElementAttribute(Order=9)]
		public System.DateTime purcDt
		{
			get { return _purcDt; }
			set {
				_purcDt = value;
				purcDtSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool purcDtSpecified { get; set; }

        [XmlElementAttribute(Order=10)]
		public string custBlngCode { get; set; }

        [XmlElementAttribute(Order=11)]
		public string custOrdNr { get; set; }

        [XmlElementAttribute(Order=12)]
		public string taxExmp { get; set; }

        [XmlElementAttribute(Order=13)]
		public string cmdyCode { get; set; }

        [XmlElementAttribute(Order=14)]
		public string desc { get; set; }

        [XmlElementAttribute(Order=15)]
		public string dcntAmt { get; set; }

        [XmlElementAttribute(Order=16)]
		public string shpAmt { get; set; }

        [XmlElementAttribute(Order=17)]
		public string dutyAmt { get; set; }

        [XmlElementAttribute(Order=18)]
		public string taxColld { get; set; }

        [XmlElementAttribute(Order=19)]
		public string totAmt { get; set; }

        [XmlElementAttribute(Order=20)]
		public string cmnt { get; set; }

        [XmlElementAttribute(Order=21)]
		public string privData { get; set; }

        [XmlElementAttribute("lineItem", Order=22)]
		public LineItem[] lineItem { get; set; }

        [XmlElementAttribute("tax", Order=23)]
		public PurcCardTax[] tax { get; set; }

        [XmlElementAttribute(Order=24)]
		public BillShip billShip { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class AuthReq : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string xid { get; set; }

        [XmlElementAttribute(Order=1)]
		public string cavv { get; set; }

		protected int _ucafIdcr;

        [XmlElementAttribute(Order=2)]
		public int ucafIdcr
		{
			get { return _ucafIdcr; }
			set {
				_ucafIdcr = value;
				ucafIdcrSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool ucafIdcrSpecified { get; set; }

        [XmlElementAttribute(Order=3)]
		public string ucaf { get; set; }

        [XmlElementAttribute(Order=4)]
		public PurcCard purcCard { get; set; }

        [XmlElementAttribute(Order=5)]
		public string eSign { get; set; }

        [XmlElementAttribute(Order=6)]
		public string voiceAuthCode { get; set; }

        [XmlElementAttribute(Order=7)]
		public string ordNr { get; set; }

        [XmlElementAttribute(Order=8)]
		public string vchrNr { get; set; }

        [XmlElementAttribute(Order=9)]
		public string pin { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class TranFlags : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected int _dupChkTmPrd;

        [XmlElementAttribute(Order=0)]
		public int dupChkTmPrd
		{
			get { return _dupChkTmPrd; }
			set {
				_dupChkTmPrd = value;
				dupChkTmPrdSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool dupChkTmPrdSpecified { get; set; }

        [XmlElementAttribute(Order=1)]
		public string rsbmt { get; set; }

        [XmlElementAttribute(Order=2)]
		public string mgdSettle { get; set; }

        [XmlElementAttribute(Order=3)]
		public string convFeeAcptd { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Pos : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string mcc { get; set; }

        [XmlElementAttribute(Order=1)]
		public string storeNr { get; set; }

        [XmlElementAttribute(Order=2)]
		public string termId { get; set; }

        [XmlElementAttribute(Order=3)]
		public string pmtDesc { get; set; }

        [XmlElementAttribute(Order=4)]
		public Phone custSvcPhNr { get; set; }

        [XmlElementAttribute(Order=5)]
		public string fiid { get; set; }

        [XmlElementAttribute(Order=6)]
		public string aba { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class NameVal : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string name { get; set; }

        [XmlElementAttribute(Order=1)]
		public string val { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Card : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected int _type;

        [XmlElementAttribute(Order=0)]
		public int type
		{
			get { return _type; }
			set {
				_type = value;
				typeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool typeSpecified { get; set; }

        [XmlElementAttribute(Order=1)]
		public string pan { get; set; }

        [XmlElementAttribute(Order=2)]
		public string sec { get; set; }

        [XmlElementAttribute(Order=3)]
		public string xprDt { get; set; }

        [XmlElementAttribute(Order=4)]
		public string sqncNr { get; set; }

        [XmlElementAttribute(Order=5)]
		public string trk1 { get; set; }

        [XmlElementAttribute(Order=6)]
		public string trk2 { get; set; }

		protected int _dbtOrCdt;

        [XmlElementAttribute(Order=7)]
		public int dbtOrCdt
		{
			get { return _dbtOrCdt; }
			set {
				_dbtOrCdt = value;
				dbtOrCdtSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool dbtOrCdtSpecified { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Merc : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string id { get; set; }

        [XmlElementAttribute(Order=1)]
		public string regKey { get; set; }

        [XmlElementAttribute(Order=2)]
		public string usrId { get; set; }

        [XmlElementAttribute(Order=3)]
		public string pwd { get; set; }

        [XmlElementAttribute(Order=4)]
		public int inType { get; set; }

		protected int _prodType;

        [XmlElementAttribute(Order=5)]
		public int prodType
		{
			get { return _prodType; }
			set {
				_prodType = value;
				prodTypeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool prodTypeSpecified { get; set; }
	}

    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName="SendTranRequest", WrapperNamespace="http://postilion/realtime/merchantframework/xsd/v1/", IsWrapped=true)]
	public class SendTranRequest 
	{

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=0)]
		public Brass9.Transfirst.TransactionCentral.Merc merc { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=1)]
		public int tranCode { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=2)]
		public Brass9.Transfirst.TransactionCentral.Card card { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=3)]
		public Brass9.Transfirst.TransactionCentral.Contact contact { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=4)]
		public string reqAmt { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=5)]
		public string prevSettleAmt { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=6)]
		public System.DateTime lclDtTm { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=7)]
        [XmlElementAttribute("usrDef")]
		public Brass9.Transfirst.TransactionCentral.NameVal[] usrDef { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=8)]
		public Brass9.Transfirst.TransactionCentral.Pos pos { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=9)]
		public int indCode { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=10)]
		public Brass9.Transfirst.TransactionCentral.TranFlags tranFlags { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=11)]
		public Brass9.Transfirst.TransactionCentral.AuthReq authReq { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=12)]
		public Brass9.Transfirst.TransactionCentral.TranData origTranData { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=13)]
		public Brass9.Transfirst.TransactionCentral.AchEcheck achEcheck { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=14)]
		public Brass9.Transfirst.TransactionCentral.RecurPmt recurPmt { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=15)]
		public Brass9.Transfirst.TransactionCentral.RecurMan recurMan { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=16)]
		public Brass9.Transfirst.TransactionCentral.Tax tax { get; set; }
	}

    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName="SendTranResponse", WrapperNamespace="http://postilion/realtime/merchantframework/xsd/v1/", IsWrapped=true)]
	public class SendTranResponse 
	{

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=0)]
		public string rspCode { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=1)]
		public string extRspCode { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=2)]
		public Brass9.Transfirst.TransactionCentral.AuthRsp authRsp { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=3)]
		public Brass9.Transfirst.TransactionCentral.TranData tranData { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=4)]
		public long invId { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=5)]
		public string cardType { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=6)]
		public string mapCaid { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=7)]
        [XmlElementAttribute("additionalAmount")]
		public Brass9.Transfirst.TransactionCentral.AdditionalAmount[] additionalAmount { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=8)]
		public Brass9.Transfirst.TransactionCentral.AchResponse achResponse { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class SettleData : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string tranNr { get; set; }

        [XmlElementAttribute(Order=1)]
		public string amt { get; set; }

        [XmlElementAttribute(Order=2)]
		public string mgdSettle { get; set; }
	}

    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName="SettleTranRequest", WrapperNamespace="http://postilion/realtime/merchantframework/xsd/v1/", IsWrapped=true)]
	public class SettleTranRequest 
	{

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=0)]
		public Brass9.Transfirst.TransactionCentral.Merc merc { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=1)]
        [XmlElementAttribute("settleData")]
		public Brass9.Transfirst.TransactionCentral.SettleData[] settleData { get; set; }
	}

    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName="SettleTranResponse", WrapperNamespace="http://postilion/realtime/merchantframework/xsd/v1/", IsWrapped=true)]
	public class SettleTranResponse 
	{

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=0)]
		public string rspCode { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Cust : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected int _type;

        [XmlElementAttribute(Order=0)]
		public int type
		{
			get { return _type; }
			set {
				_type = value;
				typeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool typeSpecified { get; set; }

        [XmlElementAttribute(Order=1)]
		public Contact contact { get; set; }

        [XmlElementAttribute("pmt", Order=2)]
		public Pmt[] pmt { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Pmt : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected long _id;

        [XmlElementAttribute(Order=0)]
		public long id
		{
			get { return _id; }
			set {
				_id = value;
				idSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool idSpecified { get; set; }

		protected int _type;

        [XmlElementAttribute(Order=1)]
		public int type
		{
			get { return _type; }
			set {
				_type = value;
				typeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool typeSpecified { get; set; }

        [XmlElementAttribute(Order=2)]
		public Card card { get; set; }

        [XmlElementAttribute(Order=3)]
		public string ordNr { get; set; }

        [XmlElementAttribute(Order=4)]
		public string amt { get; set; }

        [XmlElementAttribute(Order=5)]
		public Tax tax { get; set; }

        [XmlElementAttribute(Order=6)]
		public AchEcheck ach { get; set; }

        [XmlElementAttribute(Order=7)]
		public string desc { get; set; }

		protected int _indCode;

        [XmlElementAttribute(Order=8)]
		public int indCode
		{
			get { return _indCode; }
			set {
				_indCode = value;
				indCodeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool indCodeSpecified { get; set; }

		protected int _status;

        [XmlElementAttribute(Order=9)]
		public int status
		{
			get { return _status; }
			set {
				_status = value;
				statusSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool statusSpecified { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class RecurProf : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected long _recurProfId;

        [XmlElementAttribute(Order=0)]
		public long recurProfId
		{
			get { return _recurProfId; }
			set {
				_recurProfId = value;
				recurProfIdSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool recurProfIdSpecified { get; set; }

		protected int _type;

        [XmlElementAttribute(Order=1)]
		public int type
		{
			get { return _type; }
			set {
				_type = value;
				typeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool typeSpecified { get; set; }

        [XmlElementAttribute(Order=2)]
		public Recur recur { get; set; }

        [XmlElementAttribute("prodData", Order=3)]
		public ProdData[] prodData { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Recur : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public int recurProfStat { get; set; }

        [XmlElementAttribute(Order=1)]
		public int dbtOrCdt { get; set; }

        [XmlElementAttribute(Order=2)]
		public string amt { get; set; }

		protected int _nrOfPmt;

        [XmlElementAttribute(Order=3)]
		public int nrOfPmt
		{
			get { return _nrOfPmt; }
			set {
				_nrOfPmt = value;
				nrOfPmtSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool nrOfPmtSpecified { get; set; }

        [XmlElementAttribute(Order=4)]
		public System.DateTime startDt { get; set; }

        [XmlElementAttribute(Order=5)]
		public int blngCyc { get; set; }

        [XmlElementAttribute(Order=6)]
		public string desc { get; set; }

		protected long _custId;

        [XmlElementAttribute(Order=7)]
		public long custId
		{
			get { return _custId; }
			set {
				_custId = value;
				custIdSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool custIdSpecified { get; set; }

		protected long _pmtId;

        [XmlElementAttribute(Order=8)]
		public long pmtId
		{
			get { return _pmtId; }
			set {
				_pmtId = value;
				pmtIdSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool pmtIdSpecified { get; set; }

        [XmlElementAttribute("prodInfo", Order=9)]
		public ProdInfo[] prodInfo { get; set; }

		protected System.DateTime _nextProcDt;

        [XmlElementAttribute(Order=10)]
		public System.DateTime nextProcDt
		{
			get { return _nextProcDt; }
			set {
				_nextProcDt = value;
				nextProcDtSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool nextProcDtSpecified { get; set; }

		protected int _nrOfPmtRem;

        [XmlElementAttribute(Order=11)]
		public int nrOfPmtRem
		{
			get { return _nrOfPmtRem; }
			set {
				_nrOfPmtRem = value;
				nrOfPmtRemSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool nrOfPmtRemSpecified { get; set; }

		protected int _nrOfPmtProc;

        [XmlElementAttribute(Order=12)]
		public int nrOfPmtProc
		{
			get { return _nrOfPmtProc; }
			set {
				_nrOfPmtProc = value;
				nrOfPmtProcSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool nrOfPmtProcSpecified { get; set; }

		protected int _indCode;

        [XmlElementAttribute(Order=13)]
		public int indCode
		{
			get { return _indCode; }
			set {
				_indCode = value;
				indCodeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool indCodeSpecified { get; set; }

        [XmlElementAttribute(Order=14)]
		public string ordNr { get; set; }

        [XmlElementAttribute(Order=15)]
		public string purcOrdNr { get; set; }

        [XmlElementAttribute(Order=16)]
		public string shipToZipCode { get; set; }

        [XmlElementAttribute("usrDef", Order=17)]
		public NameVal[] usrDef { get; set; }

        [XmlElementAttribute(Order=18)]
		public Tax tax { get; set; }

		protected int _seccCode;

        [XmlElementAttribute(Order=19)]
		public int seccCode
		{
			get { return _seccCode; }
			set {
				_seccCode = value;
				seccCodeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool seccCodeSpecified { get; set; }

        [XmlElementAttribute(Order=20)]
		public string achAcctInfo { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class ProdData : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected long _id;

        [XmlElementAttribute(Order=0)]
		public long id
		{
			get { return _id; }
			set {
				_id = value;
				idSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool idSpecified { get; set; }

		protected int _type;

        [XmlElementAttribute(Order=1)]
		public int type
		{
			get { return _type; }
			set {
				_type = value;
				typeSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool typeSpecified { get; set; }

        [XmlElementAttribute(Order=2)]
		public Prod prod { get; set; }

        [XmlElementAttribute(Order=3)]
		public string quantity { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class Prod : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string prodName { get; set; }

        [XmlElementAttribute(Order=1)]
		public int stat { get; set; }

        [XmlElementAttribute(Order=2)]
		public int itemNr { get; set; }

        [XmlElementAttribute(Order=3)]
		public string desc { get; set; }

        [XmlElementAttribute(Order=4)]
		public string price { get; set; }

        [XmlElementAttribute(Order=5)]
		public string taxPctg { get; set; }

        [XmlElementAttribute(Order=6)]
		public string unitOfMsr { get; set; }

        [XmlElementAttribute(Order=7)]
		public string setupFee { get; set; }
	}

    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName="UpdtRecurrProfRequest", WrapperNamespace="http://postilion/realtime/merchantframework/xsd/v1/", IsWrapped=true)]
	public class UpdtRecurrProfRequest 
	{

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=0)]
		public Brass9.Transfirst.TransactionCentral.Merc merc { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=1)]
		public Brass9.Transfirst.TransactionCentral.Cust cust { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=2)]
		public Brass9.Transfirst.TransactionCentral.RecurProf recurProf { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=3)]
        [XmlElementAttribute("prodData")]
		public Brass9.Transfirst.TransactionCentral.ProdData[] prodData { get; set; }
	}

    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName="UpdtRecurrProfResponse", WrapperNamespace="http://postilion/realtime/merchantframework/xsd/v1/", IsWrapped=true)]
	public class UpdtRecurrProfResponse 
	{

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=0)]
		public long id { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=1)]
		public long custId { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=2)]
        [XmlElementAttribute("pmtId")]
		public long[] pmtId { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=3)]
        [XmlElementAttribute("prodId")]
		public long[] prodId { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=4)]
		public string rspCode { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class RecurProfCrta : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected long _id;

        [XmlElementAttribute(Order=0)]
		public long id
		{
			get { return _id; }
			set {
				_id = value;
				idSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool idSpecified { get; set; }

        [XmlElementAttribute(Order=1)]
		public string ordNr { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class CustCrta : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected long _id;

        [XmlElementAttribute(Order=0)]
		public long id
		{
			get { return _id; }
			set {
				_id = value;
				idSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool idSpecified { get; set; }

        [XmlElementAttribute(Order=1)]
		public string coName { get; set; }

        [XmlElementAttribute(Order=2)]
		public string firstName { get; set; }

        [XmlElementAttribute(Order=3)]
		public string lastName { get; set; }

        [XmlElementAttribute(Order=4)]
		public string fullName { get; set; }

		protected int _stat;

        [XmlElementAttribute(Order=5)]
		public int stat
		{
			get { return _stat; }
			set {
				_stat = value;
				statSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool statSpecified { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class ProdCrta : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

		protected long _id;

        [XmlElementAttribute(Order=0)]
		public long id
		{
			get { return _id; }
			set {
				_id = value;
				idSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool idSpecified { get; set; }

		protected int _stat;

        [XmlElementAttribute(Order=1)]
		public int stat
		{
			get { return _stat; }
			set {
				_stat = value;
				statSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool statSpecified { get; set; }

        [XmlElementAttribute(Order=2)]
		public string prodName { get; set; }
	}

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/")]
	public class PmtCrta : object, System.ComponentModel.INotifyPropertyChanged 
	{

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order=0)]
		public string pan { get; set; }

        [XmlElementAttribute(Order=1)]
		public string acctNr { get; set; }

		protected long _pmtId;

        [XmlElementAttribute(Order=2)]
		public long pmtId
		{
			get { return _pmtId; }
			set {
				_pmtId = value;
				pmtIdSpecified = true;
			}
		}

        [XmlIgnoreAttribute]
		public bool pmtIdSpecified { get; set; }

        [XmlElementAttribute(Order=3)]
		public string pmtDesc { get; set; }

        [XmlElementAttribute(Order=4)]
		public string ordNr { get; set; }
	}

    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName="FndRecurrProfRequest", WrapperNamespace="http://postilion/realtime/merchantframework/xsd/v1/", IsWrapped=true)]
	public class FndRecurrProfRequest 
	{

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=0)]
		public Brass9.Transfirst.TransactionCentral.Merc merc { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=1)]
		public int type { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=2)]
		public Brass9.Transfirst.TransactionCentral.RecurProfCrta recurProfCrta { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=3)]
		public Brass9.Transfirst.TransactionCentral.CustCrta custCrta { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=4)]
		public Brass9.Transfirst.TransactionCentral.ProdCrta prodCrta { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=5)]
		public Brass9.Transfirst.TransactionCentral.PmtCrta pmtCrta { get; set; }
	}

    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName="FndRecurrProfResponse", WrapperNamespace="http://postilion/realtime/merchantframework/xsd/v1/", IsWrapped=true)]
	public class FndRecurrProfResponse 
	{

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=0)]
		public int id { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=1)]
		public string mercId { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=2)]
        [XmlElementAttribute("cust")]
		public Brass9.Transfirst.TransactionCentral.Cust[] cust { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=3)]
        [XmlElementAttribute("recurProf")]
		public Brass9.Transfirst.TransactionCentral.RecurProf[] recurProf { get; set; }

        [MessageBodyMemberAttribute(Namespace="http://postilion/realtime/merchantframework/xsd/v1/", Order=4)]
        [XmlElementAttribute("prodData")]
		public Brass9.Transfirst.TransactionCentral.ProdData[] prodData { get; set; }
	}

    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public class MerchantWebServicesPortTypeClient : System.ServiceModel.ClientBase<Brass9.Transfirst.TransactionCentral.MerchantWebServicesPortType>, Brass9.Transfirst.TransactionCentral.MerchantWebServicesPortType 
	{

		public string SendTran(
                    Brass9.Transfirst.TransactionCentral.Merc merc, 
                    int tranCode, 
                    Brass9.Transfirst.TransactionCentral.Card card, 
                    Brass9.Transfirst.TransactionCentral.Contact contact, 
                    string reqAmt, 
                    string prevSettleAmt, 
                    System.DateTime lclDtTm, 
                    Brass9.Transfirst.TransactionCentral.NameVal[] usrDef, 
                    Brass9.Transfirst.TransactionCentral.Pos pos, 
                    int indCode, 
                    Brass9.Transfirst.TransactionCentral.TranFlags tranFlags, 
                    Brass9.Transfirst.TransactionCentral.AuthReq authReq, 
                    Brass9.Transfirst.TransactionCentral.TranData origTranData, 
                    Brass9.Transfirst.TransactionCentral.AchEcheck achEcheck, 
                    Brass9.Transfirst.TransactionCentral.RecurPmt recurPmt, 
                    Brass9.Transfirst.TransactionCentral.RecurMan recurMan, 
                    Brass9.Transfirst.TransactionCentral.Tax tax, 
                    out string extRspCode, 
                    out Brass9.Transfirst.TransactionCentral.AuthRsp authRsp, 
                    out Brass9.Transfirst.TransactionCentral.TranData tranData, 
                    out long invId, 
                    out string cardType, 
                    out string mapCaid, 
                    out Brass9.Transfirst.TransactionCentral.AdditionalAmount[] additionalAmount, 
                    out Brass9.Transfirst.TransactionCentral.AchResponse achResponse) {
            Brass9.Transfirst.TransactionCentral.SendTranRequest inValue = new Brass9.Transfirst.TransactionCentral.SendTranRequest();
            inValue.merc = merc;
            inValue.tranCode = tranCode;
            inValue.card = card;
            inValue.contact = contact;
            inValue.reqAmt = reqAmt;
            inValue.prevSettleAmt = prevSettleAmt;
            inValue.lclDtTm = lclDtTm;
            inValue.usrDef = usrDef;
            inValue.pos = pos;
            inValue.indCode = indCode;
            inValue.tranFlags = tranFlags;
            inValue.authReq = authReq;
            inValue.origTranData = origTranData;
            inValue.achEcheck = achEcheck;
            inValue.recurPmt = recurPmt;
            inValue.recurMan = recurMan;
            inValue.tax = tax;
            Brass9.Transfirst.TransactionCentral.SendTranResponse retVal = ((Brass9.Transfirst.TransactionCentral.MerchantWebServicesPortType)(this)).SendTran(inValue);
            extRspCode = retVal.extRspCode;
            authRsp = retVal.authRsp;
            tranData = retVal.tranData;
            invId = retVal.invId;
            cardType = retVal.cardType;
            mapCaid = retVal.mapCaid;
            additionalAmount = retVal.additionalAmount;
            achResponse = retVal.achResponse;
            return retVal.rspCode;
        }

		public string SettleTran(Brass9.Transfirst.TransactionCentral.Merc merc, Brass9.Transfirst.TransactionCentral.SettleData[] settleData) {
            Brass9.Transfirst.TransactionCentral.SettleTranRequest inValue = new Brass9.Transfirst.TransactionCentral.SettleTranRequest();
            inValue.merc = merc;
            inValue.settleData = settleData;
            Brass9.Transfirst.TransactionCentral.SettleTranResponse retVal = ((Brass9.Transfirst.TransactionCentral.MerchantWebServicesPortType)(this)).SettleTran(inValue);
            return retVal.rspCode;
        }

		public long UpdtRecurrProf(Brass9.Transfirst.TransactionCentral.Merc merc, Brass9.Transfirst.TransactionCentral.Cust cust, Brass9.Transfirst.TransactionCentral.RecurProf recurProf, Brass9.Transfirst.TransactionCentral.ProdData[] prodData, out long custId, out long[] pmtId, out long[] prodId, out string rspCode) {
            Brass9.Transfirst.TransactionCentral.UpdtRecurrProfRequest inValue = new Brass9.Transfirst.TransactionCentral.UpdtRecurrProfRequest();
            inValue.merc = merc;
            inValue.cust = cust;
            inValue.recurProf = recurProf;
            inValue.prodData = prodData;
            Brass9.Transfirst.TransactionCentral.UpdtRecurrProfResponse retVal = ((Brass9.Transfirst.TransactionCentral.MerchantWebServicesPortType)(this)).UpdtRecurrProf(inValue);
            custId = retVal.custId;
            pmtId = retVal.pmtId;
            prodId = retVal.prodId;
            rspCode = retVal.rspCode;
            return retVal.id;
        }

		public int FndRecurrProf(Brass9.Transfirst.TransactionCentral.Merc merc, int type, Brass9.Transfirst.TransactionCentral.RecurProfCrta recurProfCrta, Brass9.Transfirst.TransactionCentral.CustCrta custCrta, Brass9.Transfirst.TransactionCentral.ProdCrta prodCrta, Brass9.Transfirst.TransactionCentral.PmtCrta pmtCrta, out string mercId, out Brass9.Transfirst.TransactionCentral.Cust[] cust, out Brass9.Transfirst.TransactionCentral.RecurProf[] recurProf, out Brass9.Transfirst.TransactionCentral.ProdData[] prodData) {
            Brass9.Transfirst.TransactionCentral.FndRecurrProfRequest inValue = new Brass9.Transfirst.TransactionCentral.FndRecurrProfRequest();
            inValue.merc = merc;
            inValue.type = type;
            inValue.recurProfCrta = recurProfCrta;
            inValue.custCrta = custCrta;
            inValue.prodCrta = prodCrta;
            inValue.pmtCrta = pmtCrta;
            Brass9.Transfirst.TransactionCentral.FndRecurrProfResponse retVal = ((Brass9.Transfirst.TransactionCentral.MerchantWebServicesPortType)(this)).FndRecurrProf(inValue);
            mercId = retVal.mercId;
            cust = retVal.cust;
            recurProf = retVal.recurProf;
            prodData = retVal.prodData;
            return retVal.id;
        }
	}
}
