namespace Demo.HL7MessageParser.DTOs
{
	using System;
	using Demo.HL7MessageParser.DTOs.Data;

	[Serializable]
	public class VisitObj
	{
		private int _index;
		private VisitDataSet _ds;

		public VisitObj()
		{
			_index = 0;
			_ds = new VisitDataSet();
			_ds.V_VISIT.AddV_VISITRow(
				0,	//PatientVisitId
                0,  // PatientId
                0,  // CareUnitId
				DateTime.MinValue,	//AdmitDate
				DateTime.MinValue,	//DischargeDate
				"",	// Room
				"",	// Bed
				"",	// AccountNumber
                "", // Barcode
                ""  // HosptialService
            );
		}

		public VisitObj(VisitDataSet ds, int index)
		{
			_ds = ds;
			_index = index;
		}

        public VisitObj( PatientVisitObj pvo )
        {
            _index = 0;
            _ds = new VisitDataSet();
            _ds.V_VISIT.AddV_VISITRow(
				pvo.PatientVisitId,	//PatientVisitId
                pvo.PatientId,      // PatientId
                pvo.CareUnitId,     // CareUnitId
				pvo.AdmitDate,	    // AdmitDate
				pvo.DischargeDate,	// DischargeDate
				pvo.Room,	        // Room
				pvo.Bed,	        // Bed
				pvo.AccountNumber,	// AccountNumber
                 pvo.Barcode,        // Barcode
                pvo.HospitalService // HospitalService
            );
        }

		public int PatientID
		{
			get{return _ds.V_VISIT[_index].PatientID;}
			set{_ds.V_VISIT[_index].PatientID = value;}
		}
		public int PatientVisitId
		{
			get{return _ds.V_VISIT[_index].PatientVisitID;}
			set{_ds.V_VISIT[_index].PatientVisitID = value;}
		}
		public DateTime AdmitDate
		{
			get{return _ds.V_VISIT[_index].IsAdmitDateNull() ? DateTime.MinValue : _ds.V_VISIT[_index].AdmitDate;}
			set
            {
                if( value.Year < 1900)
				    value = DateTime.Now;
                _ds.V_VISIT[_index].AdmitDate = value;
            }
		}
		public DateTime DischargeDate
		{
			get{return _ds.V_VISIT[_index].IsDischargeDateNull() ? DateTime.MinValue : _ds.V_VISIT[_index].DischargeDate;}
			set
            {
                if( value.Year < 1900)
				    value = DateTime.MinValue;
                _ds.V_VISIT[_index].DischargeDate = value;
            }
		}
		public int CareUnitId
		{
			get{return _ds.V_VISIT[_index].CareUnitID;}
			set{_ds.V_VISIT[_index].CareUnitID = value;}
		}
		public string Room
		{
			get{return _ds.V_VISIT[_index].Room;}
			set{_ds.V_VISIT[_index].Room = value;}
		}
		public string Bed
		{
			get{return _ds.V_VISIT[_index].Bed;}
			set{_ds.V_VISIT[_index].Bed = value;}
		}
		public string AccountNumber
		{
			get{return _ds.V_VISIT[_index].AccountNumber;}
			set{_ds.V_VISIT[_index].AccountNumber = value;}
		}
        public string Barcode
		{
			get{return _ds.V_VISIT[_index].Barcode;}
			set{_ds.V_VISIT[_index].Barcode = value;}
		}
        public string HospitalService
        {
            get { return _ds.V_VISIT[_index].IsHospitalServiceNull() ? string.Empty : _ds.V_VISIT[_index].HospitalService; }
            set { _ds.V_VISIT[_index].HospitalService = value; }
        }
	}
}
